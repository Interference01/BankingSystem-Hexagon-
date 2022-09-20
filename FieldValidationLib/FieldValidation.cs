using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FieldValidationLib {
    public static class FieldValidation {
        public static void LengthValidate(string fieldName, string value, int maxLength) {
            if (value.Length >= maxLength) {
                throw new ValidationException($"Max length for field {fieldName} 20");
            }
        }

        public static void PasswordValidate(string password) {
            if (password.Length < 8 && password.Any(char.IsUpper) && password.Any(char.IsSymbol)) {
                throw new ValidationException("Password must be no more 8 lenght, one upper letter and one any symbol");
            }
        }

        public static void EmailValidate(string email) {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            if (!Regex.IsMatch(email, regex, RegexOptions.IgnoreCase)) {
                throw new ValidationException("Email not validate");
            }
        }
    }
}