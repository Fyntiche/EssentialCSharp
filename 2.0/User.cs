using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0
{
    class User
    {
        string login;

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string surname;
        public string Surname { get => surname; set => surname = value; }



        int age;
        public int Age { get => age; set => age = value; }

        readonly DateTime date;



        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string name, string surname, int age)
        {
            date = DateTime.Now;
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine($"Имя = {name}, фамилия = {Surname}, возраст = {Age}");
        }

    }
}
