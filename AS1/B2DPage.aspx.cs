using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AS1
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnB2D.Click += new EventHandler(this.btnB2DClick);
            btnD2B.Click += new EventHandler(this.btnD2BClick);
            btnNumSubmit.Click += new EventHandler(this.btnSubmitClick);
        }

        private void DisableButtons()
        {
            btnB2D.Enabled = false;
            btnD2B.Enabled = false;
        }
        

        private void btnB2DClick(object sender, EventArgs e)
        {
            int binaryNumber = Convert.ToInt32(getInput(),2);
            txtOutput.Text = binaryNumber.ToString(); ;
            DisableButtons();
        }

        private void btnD2BClick(object sender, EventArgs e)
        {
           
            string result;
            int num = Convert.ToInt32(getInput());
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            txtOutput.Text = result;
            DisableButtons();
        }

        public string getInput()
        {
            return txtInput.Text;
        }

        private void btnSubmitClick(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            int input = 0;
            bool error = false;
            try
            {
                 input = Convert.ToInt32(getInput());
            }
            catch (Exception)
            {
                lblsubmit.Text = "your input is needs to be a numaric value";
                error = true;
            }
            if (!error)
            {
                txtOutput.CssClass = "";
                lblsubmit.Text = "you submitted the number: " + input;
                btnB2D.Enabled = true;
                btnD2B.Enabled = true;

            }
            else
            {
                DisableButtons();
            }
            

           
            
        }
    }
}