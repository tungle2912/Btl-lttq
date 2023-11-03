using HotelManager.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class Register : Form
    {
        private bool isValidated;
        ValidationHelper validate = new ValidationHelper();

        public Register()
        {
            InitializeComponent();
            registerPasswordInput.PasswordChar = '*'; // Hide
            registerConfirmPasswordInput.PasswordChar = '*'; // Hide

        }


        private void handleMouseEnter(object sender, EventArgs e)
        {
            signupBtn.BackColor = Color.Green;
        }

        private void handleMouseLeave(object sender, EventArgs e)
        {
            signupBtn.BackColor = Color.Transparent;


        }

        private void closeRegisterPageBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void directToLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

            isValidated = true;
            foreach(Control control in RegisterFormControl.Controls)
            {
               if(control.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)control;
                    Label l = t.Name == "registerUsernameInput" ? registerUsernameWarningText : (t.Name == "registerPasswordInput" ? registerPasswordWarningText : registerComfirmPasswordWarningText);
                    string field = t.Name == "registerUsernameInput" ? "Username" : (t.Name == "registerPasswordInput" ? "Password" : "Confirm password");

                    if (validate.isEmpty(t.Text))
                    {
                        t.Focus();
                        validate.showError(l, "This field is required!");
                        isValidated = false;
                    }
                    else
                    {
                        validate.showError(l, "");
                        if (validate.isInvalidLength(t.Text, 8, 16))
                        {
                            t.Focus();
                            validate.showError(l, $"{field} must be between 8 and 16 characters long");
                            isValidated = false;
                        }
                        else
                        {
                            validate.showError(l, "");
                            if (t.Name == "registerConfirmPasswordInput" && validate.isNotMatched(t.Text, registerPasswordInput.Text))
                            {
                                t.Focus();
                                validate.showError(l, "Password and confirm password do not match");
                                isValidated = false;
                            }
                            else
                            {
                                validate.showError(l, "");

                            }
                        }
                    }
                }
            }


            if (isValidated)
            {
                try
                {   
                    DBQuery db = new DBQuery();
                    DataTable dt = new DataTable();

                    dt = db.GetData("SELECT * UserAccount WHERE username = '" + registerUsernameInput.Text + "'");
                    if(dt.Rows.Count > 0)
                    {
                        (new CustomMessageBox("Xác nhận", "Tài khoản đã tồn tại!")).Show();
                    }
                    else
                    {
                        string username = registerUsernameInput.Text;
                        string password = registerPasswordInput.Text;

                        CustomMessageBox c = new CustomMessageBox("Xác nhận", "Đăng ký thành công, vui lòng đăng nhập!");
                        this.Close();
                        Login login = new Login(username, password);
                        login.Show();
                        c.Show();
                    }

                }catch(Exception ex)
                {
                    (new CustomMessageBox("Xác nhận", "Đăng kí thất bại!")).Show();
                }
            }


        }

        private void handleHideShowPassword(object sender, EventArgs e)
        {
            
                if (eyeRegisterPassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
                {
                    registerPasswordInput.PasswordChar = '\0'; // Show 
                    eyeRegisterPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

                }
                else
                {
                    registerPasswordInput.PasswordChar = '*'; // Hide
                    eyeRegisterPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
            

        }

        private void handleHideShowConfirmPassword(object sender, EventArgs e)
        {

            if (eyeRegisterConfirmPassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                registerConfirmPasswordInput.PasswordChar = '\0'; // Show 
                eyeRegisterConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

            }
            else
            {
                registerConfirmPasswordInput.PasswordChar = '*'; // Hide
                eyeRegisterConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }


        }
    }
    



}
