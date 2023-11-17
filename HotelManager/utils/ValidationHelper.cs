
using System.Windows.Forms;

namespace HotelManager.utils
{
    public class ValidationHelper
    {
         public bool isEmpty(string text)
        {
            return text.Trim() == "";
        }

        public bool isNotMatched(string password, string confirmPassword)
        {
            return password != confirmPassword;
        }

        

        public bool isInvalidLength(string text, int minLength, int maxLength)
        {
            return text.Length < minLength || text.Length > maxLength;
        }

        public void showError(Label tag, string message)
        {
            tag.Text = message;
        }
    }
}

/*
     "Please fill out all required fields." (Vui lòng điền đầy đủ các trường bắt buộc.)

    "Invalid email address format." (Định dạng địa chỉ email không hợp lệ.)

    "Password must be at least 8 characters long." (Mật khẩu phải có ít nhất 8 ký tự.)

    "Password and confirm password do not match." (Mật khẩu và xác nhận mật khẩu không khớp nhau.)

    "Please select a valid option." (Vui lòng chọn một tùy chọn hợp lệ.)
 
 */