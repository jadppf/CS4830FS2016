﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContactsService
    {
        [OperationContract]
        List<SVCPerson> ListPeople();

        [OperationContract]
        bool AddPerson(SVCPerson person);

        [OperationContract]
        bool DeletePerson(int idPerson);
    }


    [DataContract]
    public partial class SVCPerson
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
 
}
