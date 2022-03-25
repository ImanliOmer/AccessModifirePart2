using System;

namespace AccesModifirePart2.Class
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private int _age;


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }





        public string Name
        {

            get { return _name; }

            set
            {
                if (String.IsNullOrEmpty(value) == false && value.Length >= 3 && value.Length <= 30 && DifferentCase(value, value))
                {
                    _name = value;
                    return;
                }
                Console.WriteLine("\n name invalid try again: ");
                return;

            }
        }

        public int Age
        {
            get { return _age; }


            set { _age = value; }

        }




        public string Surname
        {

            get { return _surname; }

            set
            {
                if (String.IsNullOrEmpty(value) == false && value.Length > 3 && value.Length <= 35 == true && DifferentCase(value, value))
                {
                    _surname = value;
                    return;
                }
                Console.WriteLine("\n Surname invalid try again: ");
                
                return;

            }
        }



        public bool DifferentCase(string name, string surname)
        {

            bool result = false;


            bool result1 = Char.IsUpper(name[0]);
            bool result2 = Char.IsUpper(surname[0]);
            if (result1 == true && result2 == true)
                result = true;


            return result;


        }

    }
}

