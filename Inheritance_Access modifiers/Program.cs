using System;

namespace Inheritance_Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
        }
        class Admin:User
        {
            
            public bool issuperadmin;
            public string section;
            public Admin(string username, int pasword, bool Issuperadmin, string Secton):base(username,pasword)
            {

                issuperadmin = Issuperadmin;
                section = Secton;
            }








        }

        class User
        {

            private string _Username;
            private int _Pasword;
            public User(string username, int pasword)
            {
                _Username = username;
                _Pasword = pasword;

            }
            public string Username_pasword
            {

                get
                {

                    return _Username;


                }
                set
                {

                }




            }






        }

    }
}
