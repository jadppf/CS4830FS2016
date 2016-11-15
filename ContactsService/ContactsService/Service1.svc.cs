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
    }
}
