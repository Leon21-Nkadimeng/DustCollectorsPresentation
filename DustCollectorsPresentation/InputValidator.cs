using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
namespace DustCollectorsPresentation
{
    public class InputValidator
    {
        // patterns for regular expressions
        public const string PHONE_NUMBER_PATTERN = "(0[12345678]\\d{8})|(0[12345678]\\d(\\s\\d{3}){2})";
        public const string UNQUOTED_EMAIL_ADDRESS_PATTERN = "([!#$%&'*+-/=?^_`{|}~.]?\\w+[!#$%&'*+-/=?^_`{|}~.]?)+@([a-zA-Z]+)(.[a-zA-Z])*";

        // uses matcher to check if an email is valid
        public static bool isValidEmail(string emailAddress)
        {
            Regex emailRegex = new Regex(UNQUOTED_EMAIL_ADDRESS_PATTERN);
            return emailRegex.IsMatch(emailAddress);
        }
        // checks if phone number is valid
        public static bool isValidPhoneNumber(string phoneNumber)
        {
            Regex phoneNumberRegex = new Regex(PHONE_NUMBER_PATTERN);
            return phoneNumberRegex.IsMatch(phoneNumber);
        }

    }
}