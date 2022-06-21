private static string FormatPhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber.Length == 10 && PhoneNumber.StartsWith("5"))
                return PhoneNumber;
            else
                PhoneNumber = Regex.Replace(PhoneNumber, @"^(00|\+)(1|2[078]|2[1234569][0-9]|3[0123469]|3[578][0-9]|4[013456789]|42[0-9]|5[09][0-9]|5[12345678]|6[0123456]|6[789][0-9]|7|8[0578][0-9]|8[123469]|9[0123458]|9[679][0-9])", "")
                                        .Replace("(", "")
                                        .Replace(")", "")
                                        .Replace(" ", "");

            return PhoneNumber;
        }