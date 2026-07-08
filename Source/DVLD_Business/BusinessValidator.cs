using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business {
    public static class BusinessValidator {
        public enum NationalNumValidationResults : byte {
            InvalidLength, AlreadyExists, NoErrors
        }

        public static NationalNumValidationResults ValidateNationalNum(string nationalNum) {
            if (nationalNum.Length != 14)
                return NationalNumValidationResults.InvalidLength;

            if (Person.DoesExist(nationalNum))
                return NationalNumValidationResults.AlreadyExists;

            return NationalNumValidationResults.NoErrors;
        }

        public static bool ValidateEmail(string email) {
            int p = email.IndexOf('@');

            //Checking the number of '@' characters:
            if (p == -1 || p != email.LastIndexOf('@'))
                return false;

            //Checking the lengths of the sections before and after the '@' character:
            if (email.Substring(0, p).Length == 0 || email.Substring(p + 1).Length == 0)
                return false;

            //Checking the '.' after the '@' character:
            p = email.IndexOf('.', p + 1);
            return p != -1 && p != email.Length - 1;
        }

        public static bool IsImageFormat(string filePath) {
            string _ext = Path.GetExtension(filePath).ToLower();

            return _ext == ".jpg" || _ext == ".jpeg" || _ext == ".png" || _ext == ".bmp" || _ext == ".gif";
        }

        public static bool IsNumber(string text) => text != string.Empty && decimal.TryParse(text, out _);

        public static bool IsValidAge(string text) => byte.TryParse(text, out byte result) && result <= 100;
    }
}
