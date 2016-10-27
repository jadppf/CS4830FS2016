using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonPrevious_Click(object sender, EventArgs e)
        {
            int iPage = GetPageNumber();

            iPage--;

            SetPageState(iPage);
        }
        protected void buttonNext_Click(object sender, EventArgs e)
        {
            int iPage = GetPageNumber();

            iPage++;

            SetPageState(iPage);
        }


        private int GetPageNumber()
        {
            int iPage = 0;
            try
            {
                iPage = Convert.ToInt32(hiddenPage.Value);
            }
            catch (Exception)
            {
            }

            return (iPage);
        }

        private void SetPageState(int iPage)
        {
            if (iPage > 0)
            {
                buttonPrevious.Visible = true;
            }
            else
            {
                buttonPrevious.Visible = false;
            }
            labelPage.Text = "Page " + iPage;
            hiddenPage.Value = iPage.ToString();
        }
    }
}