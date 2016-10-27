using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Cookies["Page"].Value = "0";
            }
        }

        protected void buttonPrevious_Click(object sender, EventArgs e)
        {
            int iPage = Convert.ToInt32(Request.Cookies["Page"].Value);

            iPage--;
            Response.Cookies["Page"].Value = iPage.ToString();
            labelPage.Text = "Page " + iPage;

            if (iPage < 1)
            {
                buttonPrevious.Visible = false;
            }
        }

        protected void buttonNext_Click(object sender, EventArgs e)
        {
            int iPage = Convert.ToInt32(Request.Cookies["Page"].Value);

            iPage++;
            Response.Cookies["Page"].Value = iPage.ToString();
            labelPage.Text = "Page " + iPage;

            buttonPrevious.Visible = true;
        }
    }
}