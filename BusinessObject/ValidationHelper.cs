using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ValidationHelper
    {
        public static string ValidateFullName(string fullName)
        {
            int minLength = 3;
            int maxLength = 50;

            if (string.IsNullOrWhiteSpace(fullName)) return "Name cannot be blank.";

            if (fullName.Length < minLength || fullName.Length > maxLength)
                return $"The name must be between {minLength} and {maxLength} characters in length.";

            foreach (char c in fullName)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return "Names can only contain letters and spaces.";
                }
            }

            if (fullName.Contains("  "))
                return "The name cannot contain two consecutive spaces.";
            return null;
        }

        public static string ValidateEmail(string email)
        {

            const string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            if (string.IsNullOrWhiteSpace(email)) return "Email cannot be blank.";

            if (!Regex.IsMatch(email, pattern)) return "Invalid email.";

            return null;
        }

        public static string ValidatePassword(string password)
        {
            // Biểu thức chính quy kiểm tra mật khẩu có ít nhất 8 ký tự,
            // ít nhất 1 ký tự chữ thường, 1 ký tự chữ in hoa và 1 chữ số.
            const string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";

            if (!Regex.IsMatch(password, pattern))
            {
                return "Password must contain at least 8 characters, including at least one lowercase letter, one uppercase letter, and one number.";
            }

            return null;
        }
        public static string ValidateID(string id)
        {
            const string pattern = @"^SE\d{3}$";
            if (string.IsNullOrWhiteSpace(id)) return "StudentID cannot be blank";
            return Regex.IsMatch(id, pattern) ? null : "StudentID must SExxx !!!";
        }
    }
}
