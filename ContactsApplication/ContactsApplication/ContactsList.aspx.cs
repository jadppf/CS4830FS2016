using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContactsApplication
{
    public partial class ContactsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new ContactsService.ContactsServiceClient();
            var people = client.ListPeople();

            listContacts.Items.Clear();
            foreach (var person in people)
            {
                listContacts.Items.Add(person.FirstName + " " + person.LastName + "(" + person.Email + ")");
            }
        }
    }
}