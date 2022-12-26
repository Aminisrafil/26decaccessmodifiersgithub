using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers
{
    internal class User
    {
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    value = _username;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 25)
                {
                    if (HasAll(value))
                    {
                        value = _password;
                    }
                }
            }
        }
        public bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsUpper(word[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLower(word[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasAll(string word)
        {
            if (HasLower(word) && HasUpper(word) && HasDigit(word))
            {
                return true;
            }
            return false;
        }
        public string GetInfo()
        {
            return$"Username:{Username}";
        }
    }
}
