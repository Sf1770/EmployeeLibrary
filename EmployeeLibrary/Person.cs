using System;
using System.IO; // => BCL
using System.Web; // => FCL

namespace EmployeeLibrary
{
    public class Person
    {


        //Predefined Namespace-logical separation of types
        //Types=> Class, interface, structs, enums, delegates'
        //Type members = fields, contants, variables, mmethod, events


        long ssn;
        string creditCardNum;
        //property
        public string ccn
        {
            get
            {
                if (age > 15)
                {
                    return creditCardNum;
                }
                else
                {
                    return "Not Allowed";
                }
            }
            set
            {
                creditCardNum = value;
            }
        }
        //autonomous property
        public int MyProperty { get; set; }
        public short age = 18;
        public string firstName, lastName;


        public Person()
        {
            ssn = 383747034;
            age = 97;
            firstName = "Beatrice";
            lastName = "Arthur";
            string info = GetPerson(firstName, lastName, age, ssn);
            Console.WriteLine(info);
            //Console.Read();
        }

        public Person(string firstName, string lastName, short age, long ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.ssn = ssn;
            string info = GetPerson(firstName, lastName, age, ssn);
            Console.WriteLine(info);

        }

        public string GetPassword(string firstName, string ssn)
        {
            string temp = "";
            for (int i = ssn.Length - 1; i > -1; i--)
            {
                temp += ssn[i];
            }

            for (int j = firstName.Length - 1; j > -1; j--)
            {
                temp += firstName[j];
            }

            //string password = "", temp

            return temp;

        }

        //public virtual string GetPerson(string firstName, string lastName, short age, long ssn) //Method speciication
        //{
        //    return firstName + " " + lastName + $" Age:{age}, ssn: {ssn}";
        //}

        //Method Overloading, no keyword required, choses the correct method to run at compile time based on the number of parameters, sequence of parameters, or the type of parameters

        public string GetPerson(string firstName) //Method speciication
        {
            return $"Name:{firstName}";
        }

        public string GetPerson(string firstName, string lastName) //Method speciication
        {
            return $"Name:{firstName} {lastName}";
        }

        public string GetPerson(string firstName, short age) //Method speciication
        {
            return $"Name:{firstName}, Age: {age}";
        }

        public string GetPerson(short age, string firstName) //Method speciication
        {
            return $"Name:{firstName}, Age: {age}";
        }

        public string GetPerson(string firstName, string lastName, short age) //Method speciication
        {
            return $"Name:{firstName} {lastName}, Age: {age}";
        }

        public string GetPerson(string firstName, string lastName, short age, long ssn) //Method speciication
        {
            return $"Name:{firstName}, Age: {age}, SSN: {ssn}";
        }

        public string GetPerson(string firstName, string lastName, short age, long ssn, string CCN) //Method speciication
        {
            return $"Name:{firstName}, Age: {age}, SSN: {ssn}, Credit Card Number: {CCN}";
        }

        public string GetPerson(params string[] data)
        //lets you pass any number of parameters as long as they are of type 
        {
            string info = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                info += data[i] + " ";
            }
            return info;
        }

        //Look over OOP


        //ref, indicates a value is being passed by reference
        /* ref can be used in method signature and in a method call
         * method signature: return a value to the caller by reference
         * method call: pass an argument by reference 
         * member body: indicates that a reference return value is stored locally as a reference that the caller intends to modify or in general, a local variable accesses another value by reference
         * Declare a ref struct; alwyas passing around the location
         */

        /* out, keyword can be used in 2 contexts
         * parameter modifier: lets you pass an argument to a method by reference rathern than by value
         * generic type parameter declarations for interfaces & delegates: specied that a type of parameter is covariant; enables you to use a more derived type than that specified by the generic parameter
           //only used to write that value

         /*Named arguments: Free you from having to put arguments in the order they are presented in; as long as you know the parameter names, you can put them in whatever order
          * Optional arguments: Defined at the end of the parameter list, after any required parameters, its assigned default values in case you don't pass in those values
          */

        /* Datatypes -> Value types and reference types
    Values stored - Stored on stack; E.g.: int, double, float, decimal, char DateTiime, structs, and enums 
    */
    }
}
