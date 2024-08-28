using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PasswordStorage
    {
        public List<string> Passwords { get; set; }
        //public string Key { get; set; }
        public PasswordStorage(List<string> Passwords /*string key*/)
        {
            //Key = key;
            Passwords = new List<string>(); 
        }

        //modifies list if password passes bool - returns bool
        public static bool AddPassword(string password, List<string> Passwords)
        {
            //string of capital vowels for password criteria
            string upperVowel = "AEIOUY";

            //checks if password is in list
            if (Passwords.ToString().Contains(password))
            {
                //if on list, doesn't add, returns false
                return false;
            }
            //if password is not in list
            else if (!Passwords.ToString().Contains(password))
            {
                //checks password against required criteria
                if (password.Length >= 7 && password.Length <= 12
                    && password.Any(char.IsDigit) && !password.Contains("6") && !password.Contains(" ")
                    && password.Contains(upperVowel) && password.Contains(upperVowel))
                {
                    //adds password to list and returns true
                    Passwords.Add(password);
                    return true;
                }
                //checks non-criteria password against special passwords
                else if (password.Equals("mod") || password.Equals("admin"))
                {
                    //special password match adds special password to list and returns true
                    Passwords.Add(password);
                    return true;
                }
        //Both ELSE statements catch exceptions
                else
                {
                    return false;
                }

            }
            else 
            { 
                return false; 
            }
        }
        
    }
}
