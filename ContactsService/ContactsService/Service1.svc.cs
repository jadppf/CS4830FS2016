//#define INSANE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IContactsService
    {
        public List<SVCPerson> ListPeople()
        {
            List<SVCPerson> people = new List<SVCPerson>();

            using (var db = new ContactEntities())
            {
                var query = from persons in db.People
                            select persons;


                foreach (var person in query)
                {

                    SVCPerson svcperson = new ContactsService.SVCPerson();
                    svcperson.ID = person.ID;
                    svcperson.FirstName = person.FirstName;
                    svcperson.LastName = person.LastName;
                    if (null != person.Phone)
                    {
                        svcperson.Phone = person.Phone.Number;
                    }
                    if (null != person.Email)
                    {
                        svcperson.Email = person.Email.EmailAddress;
                    }
                    people.Add(svcperson);

                }
            }

            return (people);
        }

        public bool AddPerson(SVCPerson svcperson)
        {
            bool fResult = false;

            Person person = new ContactsService.Person();
            person.FirstName = svcperson.FirstName;
            person.LastName = svcperson.LastName;
            person.Email = new ContactsService.Email();
            person.Email.EmailAddress = svcperson.Email;
            person.Phone = new ContactsService.Phone();
            person.Phone.Number = svcperson.Phone;

            try
            {
                using (var db = new ContactEntities())
                {
                    db.People.Add(person);
                    db.SaveChanges();
                    fResult = true;
                }
            }
            catch (Exception err)
            {
                // PROBLEM! - log this error
            }

            return (fResult);
        }

        public bool DeletePerson(int idPerson)
        {
            bool fResult = false;
            try
            {
                using (var db = new ContactEntities())
                {
#if INSANE
                Person dummy = new Person();
                dummy.ID = idPerson;
                db.People.Remove(dummy);
#else
                    var query = from persons in db.People
                                where persons.ID.Equals(idPerson)
                                select persons;
                    db.People.Remove(query.FirstOrDefault());
#endif
                    db.SaveChanges();
                    fResult = true;
                }
            }
            catch (Exception err)
            {
                // PROBLEM! - log this error

            }

            return (fResult);
        }
    }
}
