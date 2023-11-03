using HotelManager.utils;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class Login : Form
    {
        public static string username = "";
        public static string MaNV = "";
        private string registerUsername, registerPassword;
        private bool isValidated;
        ValidationHelper validate = new ValidationHelper();
        public Login()
        {
            InitializeComponent();
            loginPasswordInput.PasswordChar = '*'; // Hide

        }

        public Login(string username, string password)
        {
            registerUsername = username;
            registerPassword = password;
            InitializeComponent();
            loginPasswordInput.PasswordChar = '*'; // Hide

        }
        private void handleMouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.Green;
        }

        private void handleMouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.Transparent;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            isValidated = true;

            foreach (Control control in LoginFormControl.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)control;

                    Label l = t.Name == "loginUsernameInput" ? usernameWarningText : passwordWarningText;
                    string k = t.Name == "loginUsernameInput" ? "Username" : "Password";


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
                            validate.showError(l, $"{k} must be between 8 and 12 characters long");
                            isValidated = false;
                        }
                        else
                        {
                            validate.showError(l, "");
                        }
                    }
                }
            }

            // Login here
            if (isValidated)
            {
                try
                {   
                    DataTable dt = new DataTable();
                    DBQuery db = new DBQuery();
                    dt = db.GetData("SELECT * FROM USERS WHERE userName = '" + loginUsernameInput.Text + "' and passWord = '" + loginPasswordInput.Text + "'");
                    
                    if (dt.Rows.Count > 0)
                    {
                        username = loginUsernameInput.Text;
                        MaNV = dt.Rows[0].Field<string>("MaNV");
                        this.Hide();
                        App app = new App();
                        app.Show();
                      
                        (new CustomMessageBox("Xác nhận", "Đăng nhập thành công!")).Show();
                    }
                    else
                    {
                        (new CustomMessageBox("Xác nhận", "Đăng nhập thấy bại! Tài khoản hoặc mật khẩu không chính xác")).Show();
                    }
                    
                }
                
                catch(Exception ex)
                {
                    (new CustomMessageBox("Thông báo", "Kết nối đến database thất bại!")).ShowDialog();
                }
            }
        }

        private void directToRegisterPage_Click(object sender, EventArgs e)
        {
           // Close login form
           this.Hide();
           Register register = new Register();
           register.Show();
        }

        private void closeLoginPageBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forgetPassword_Click(object sender, EventArgs e)
        {
            CustomMessageBox cm = new CustomMessageBox("Xác nhận", "Có cái mật khẩu cũng quên. Nói yêu anh thì anh lấy lại cho?");
            cm.Show();
        }

        private void eyePassword_Click(object sender, EventArgs e)
        {
           if(eyePassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                loginPasswordInput.PasswordChar = '\0'; // Show 
                eyePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

            }
            else
            {
                loginPasswordInput.PasswordChar = '*'; // Hide
                eyePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginUsernameInput.Text = registerUsername;
            loginPasswordInput.Text = registerPassword;

        }
    }
}

