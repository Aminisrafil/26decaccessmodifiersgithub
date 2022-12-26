using System;
using System.Xml.Linq;

namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool check = true;
            string value="";
            User[] users = new User[0];

            
            
            do
            {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine("1.User elave et:");
                Console.WriteLine("2.Userlara bax:");
                Console.WriteLine("3.Userlar uzre axtaris et:");

                value = Console.ReadLine();

                if (value == "1")
                {
                    string name;
                    string password;
                    do
                    {
                        check = true;
                        Console.WriteLine("Username'ni daxil edin(minimum uzunlug 6, maximum uzunlug 25):");
                        name = Console.ReadLine();
                        Console.WriteLine("Passwordu daxil edin(minimum uzunlug 8, maximum uzunlug 25):");
                        password = Console.ReadLine();
                        if(name.Length < 6 || name.Length > 25 || password.Length < 8 || password.Length >25)
                        {
                            check= false;
                        }
                        if (!HasAll(password))
                        {
                            check = false;
                        }
                        if (!check)
                        {
                            Console.WriteLine("passwordu veya Usernameni duzgun daxil etmemisiniz");
                        }

                    } while (!check);
                    User user = new User(name, password);
                    AddUser(ref users, user);
                }
                else if(value == "2")
                {
                    Console.WriteLine(dateTime);
                    for (int i = 0; i < users.Length; i++)
                    {
                        Console.WriteLine(users[i].GetInfo());
                        Console.WriteLine(dateTime);
                    }
                }
                else if(value == "3")
                {
                    
                    Console.Write("Axtarmaq istediyiniz deyeri daxil edin:");
                    var search = Console.ReadLine();
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (users[i].Username.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(users[i].GetInfo());
                        }
                    }
                }

            } while (value != "0");
        }
        static void AddUser(ref User[] users, User user)
        {
            User[] makenewarr = new User[users.Length + 1];

            for (int i = 0; i < users.Length; i++)
            {
                makenewarr[i] = users[i];
            }
            makenewarr[makenewarr.Length - 1] = user;
            users = makenewarr;
        }
        static bool HasDigit(string word)
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
        static bool HasUpper(string word)
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
        static bool HasLower(string word)
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
        static bool HasAll(string word)
        {
            if (HasLower(word) && HasUpper(word) && HasDigit(word))
            {
                return true;
            }
            return false;
        }
    }
}
