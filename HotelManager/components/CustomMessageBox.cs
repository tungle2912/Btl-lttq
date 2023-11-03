using FontAwesome.Sharp;
using HotelManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class CustomMessageBox : Form
    {
        public string title;
        public string message;
        public string agreeButton;
        public string disagreeButton;

        public event EventHandler YesClicked;
        public event EventHandler NoClicked;
        // 147, 133
        public CustomMessageBox(string title, string message)
        {
            this.title = title;
            this.message = message;
            this.agreeButton = "Ok";
            this.disagreeButton = "";
            InitializeComponent();
        }

        public CustomMessageBox(string title, string message,string agreeButton, string disagreeButton)
        {
            this.title = title;
            this.message = message;
            this.agreeButton = agreeButton;
            this.disagreeButton = disagreeButton;
            InitializeComponent();

            // 

            agreeMessageBoxBtn.Click += (sender, e) =>
            {
                OnYesClicked();
                this.Hide();
            };
            disagreeMessageBoxBtn.Click += (sender, e) =>
            {
                OnNoClicked();
                this.Hide();
            };
        }


        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            customMessageBoxTitle.Text = title;
            customMessageBoxContent.Text = message;
            agreeMessageBoxBtn.Text = agreeButton;


            // Set position for label to center of the form
            customMessageBoxTitle.Left = (this.ClientSize.Width - customMessageBoxTitle.Size.Width) / 2;
            customMessageBoxContent.Left = (this.ClientSize.Width - customMessageBoxContent.Size.Width) / 2;
            // 
            if (disagreeButton == "")
            {
                agreeMessageBoxBtn.Location = new Point(193, 164);
                disagreeMessageBoxBtn.Visible = false;
            }
            else
            {
                disagreeMessageBoxBtn.Visible = true;
                disagreeMessageBoxBtn.Text = disagreeButton;
            }
        }

        public void agreeMessageBoxBtn_Click(object sender, EventArgs e)
        {
            if (agreeButton == "Ok")
            {
                this.Close();
            }
        }

 

        protected virtual void OnYesClicked()
        {
            YesClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnNoClicked()
        {
            NoClicked?.Invoke(this, EventArgs.Empty);
        }

 

    
    }
}



