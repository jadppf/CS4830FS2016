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
        private static List<ContactsService.SVCPerson> m_listPeople;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_listPeople = new List<ContactsService.SVCPerson>();
                ShowContactList();
            }
        }

        void HideAll()
        {
            divAddContact.Visible = false;
            divContactsList.Visible = false;
        }

        void ShowContactList()
        {
            HideAll();
            divContactsList.Visible = true;

            var client = new ContactsService.ContactsServiceClient();
            var people = client.ListPeople();

            listContacts.Items.Clear();
            foreach (var person in people)
            {
                listContacts.Items.Add(person.FirstName + " " + person.LastName + " (" + person.Email + ")");
                m_listPeople.Add(person);
            }

            client.Close();

        }
        void ShowAddContact()
        {
            HideAll();
            divAddContact.Visible = true;

        }


        protected void buttonAddContacts_Click(object sender, EventArgs e)
        {
            HideAll();
            divAddContact.Visible = true;

        }

        void AddPerson()
        {
            var client = new ContactsService.ContactsServiceClient();
            ContactsService.SVCPerson person = new ContactsService.SVCPerson();
            person.Email = textEmail.Text;
            person.FirstName = textFirstName.Text;
            person.LastName = textLastName.Text;
            person.Phone = textPhone.Text;
            client.AddPerson(person);
            client.Close();

        }

        protected void buttonDoAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
            ShowContactList();
        }

        protected void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            int i = listContacts.SelectedIndex;
            if (0<=i)
            {
                DeleteContact(i);
            }
            ShowContactList();
        }

        private void DeleteContact(int index)
        {
            var client = new ContactsService.ContactsServiceClient();
            ContactsService.SVCPerson person = m_listPeople[index];
            client.DeletePerson(person.ID);
            client.Close();

        }
    }
}