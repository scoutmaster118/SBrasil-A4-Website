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
            btnIni.Click += new EventHandler(this.btnItalClick);
            btnB2D.Click += new EventHandler(this.btnB2DClick);
            btnD2B.Click += new EventHandler(this.btnD2BClick);

            btnSubmit.Click += new EventHandler(this.btnSubmitClick);
            //txtInput.TextChanged += new EventHandler(this.btnSubmitClick);
            
        }

        public string getInput()
        {
            return txtInput.Text;
        }

        public void btnSubmitClick(object sender, EventArgs e)
        {
            int inputInt = 0;
            bool error = false;
            bool nullValue = false;
            string input = getInput();
            txtOutput.CssClass = "";
            txtOutput.Text = "";

            if (string.IsNullOrEmpty(input))
            {
                lblsubmit.Text = "your input is blank";
                nullValue = true;
                txtOutput.Text = "";
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
            
            if (!error && !nullValue)
            {
                txtOutput.CssClass = "";
                lblsubmit.Text = "you submitted the number: " + input;
                btnB2D.Enabled = true;
                btnD2B.Enabled = true;

            }
            else if (error && !nullValue)
            {
                DisableB2DButtons();
                txtOutput.CssClass = "";
                lblsubmit.Text = "you submitted the text: " + input;
                EnableTextButtons();
            }
            else
            {
                DisableTextButtons();
                txtOutput.Text = "";
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
        private void DisableB2DButtons()
        {
            btnB2D.Enabled = false;
            btnD2B.Enabled = false;
        }

        private void DisableTextButtons()
        {
            btnGreen.Enabled = false;
            btnReversed.Enabled = false;
            btnBold.Enabled = false;
            btnIni.Enabled = false;
        }
        private void EnableTextButtons()
        {
            btnGreen.Enabled = true;
            btnReversed.Enabled = true;
            btnBold.Enabled = true;
            btnIni.Enabled = true;
        }



        private void btnB2DClick(object sender, EventArgs e)
        {
            txtOutput.CssClass = "";
            int binaryNumber = Convert.ToInt32(getInput(), 2);
            txtOutput.Text = binaryNumber.ToString(); ;
            DisableB2DButtons();
        }

        private void btnD2BClick(object sender, EventArgs e)
        {
            txtOutput.CssClass = "";
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
            DisableB2DButtons();
        }
    }
}