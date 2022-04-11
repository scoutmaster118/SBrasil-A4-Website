using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AS1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnGreen.Click += new EventHandler(this.btnGreenClick);
            btnReversed.Click += new EventHandler(this.btnReversedClick);
            btnBold.Click += new EventHandler(this.btnBoldClick);
            btnItal.Click += new EventHandler(this.btnItalClick);
            btnTexSubmit.Click += new EventHandler(this.btnSubmitClick);
            btnB2D.Click += new EventHandler(this.btnB2DClick);
            btnD2B.Click += new EventHandler(this.btnD2BClick);
        }

        public string getInput()
        {
            return txtInput.Text;
        }

        public void btnSubmitClick(object sender, EventArgs e)
        {
            int inputInt = 0;
            bool error = false;
            string input = getInput();
            txtOutput.CssClass = "";
            lblsubmit.Text = "";

            if (string.IsNullOrEmpty(input))
            {
                lblsubmit.Text = "your input is blank";
            }
            else
            {
                try
                {
                    inputInt = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    error = true;
                }
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
                lblsubmit.Text = "you submitted the text: " + input;
            }

        }

        private void btnItalClick(object sender, EventArgs e)
        {
            txtOutput.CssClass = "textitali";

            txtOutput.Text = getInput();
        }

        private void btnBoldClick(object sender, EventArgs e)
        {

            txtOutput.CssClass = "textbold";
            txtOutput.Text = getInput();
        }

        void btnGreenClick(Object sender, EventArgs e)
        {
            txtOutput.CssClass = "GreenText";
            txtOutput.Text = getInput();
        }

        void btnReversedClick(Object sender, EventArgs e)
        {
            string[] input = getInput().Split(' ');
            string reversed = "";
            txtOutput.CssClass = "";

            foreach (var word in input)
            {
                string temp = "";
                for (int i = word.Length; i > 0; i--)
                {
                    temp += word[i - 1];
                }
                reversed +=" " + temp;
            }
            txtOutput.Text = reversed;

            //lblReversed.Text = reversed;
        }
        private void DisableButtons()
        {
            btnB2D.Enabled = false;
            btnD2B.Enabled = false;
        }


        private void btnB2DClick(object sender, EventArgs e)
        {
            int binaryNumber = Convert.ToInt32(getInput(), 2);
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
    }
}