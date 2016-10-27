using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int iPage = 0;
            try
            {
                iPage = Convert.ToInt32(Request.QueryString["Page"]);
            }
            catch (Exception)
            {
            }

            if (iPage>0)
            {
                buttonPrevious.Visible = true;
            }
            else
            {
                buttonPrevious.Visible = false;
            }

            buttonPrevious.NavigateUrl = "QueryString.aspx?Page=" + (iPage - 1);
            buttonNext.NavigateUrl = "QueryString.aspx?Page=" + (iPage + 1);

            labelState.Text = "Page " + iPage;
        }
    }
}