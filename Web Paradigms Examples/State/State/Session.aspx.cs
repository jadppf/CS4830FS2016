using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Page"] = 0;
            }
        }

        protected void buttonPrevious_Click(object sender, EventArgs e)
        {
            int iPage = Convert.ToInt32(Session["Page"]);

            iPage--;
            Session["Page"] = iPage;
            labelPage.Text = "Page " + iPage;

            if (iPage<1)
            {
                buttonPrevious.Visible = false;
            }
        }

        protected void buttonNext_Click(object sender, EventArgs e)
        {
            int iPage = Convert.ToInt32(Session["Page"]);

            iPage++;
            Session["Page"] = iPage;
            labelPage.Text = "Page " + iPage;

            buttonPrevious.Visible = true;
        }
    }
}