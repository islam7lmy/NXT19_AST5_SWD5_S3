using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    internal struct PhoneBook
    {
        string[] names;
        string[] numbers;


        /// <summary>
        /// Capacity of PhoneBook [max number of elements can be saved in phonebook]
        /// </summary>
        int _size;
        public int Size
        {
            get { return _size; }
            private set { _size = value < 2 ? 2 : value; }
        }

        /// <summary>
        /// number of current elements in phonebook
        /// </summary>
        //int count;
        public int Count
        {
            get
            {
                int counter = 0;
                foreach (string name in names)
                {
                    if(name is not null)
                        counter++;
                }
                return counter;
            }
        }

        ///constructor chanining :
        ///calling one constructor from another constructor in the same Struct or Class

        //clr => default constructor 
        public PhoneBook() : this(0) // refer to anthor constructor that has one parameter
        {
            //Size = default;
            //numbers = new string[0];
            //names = new string[0];
        }

        public PhoneBook(int _size)
        {
            Size = _size; //_size < 2 ? 2 : _size;
            numbers = new string[Size];
            names = new string[Size];
        }


        //addcontact(name,number);
        public void AddContact(string name, string number ,int _postion)
        {
            if(_postion < 0 || _postion >= Size)
            {
                Console.WriteLine("the postion you select is out of range");
                return;
            }

            names[_postion] = name;
            numbers[_postion] = number;
        }
        //removecontact(name); //if find contact remove from name arr and number arr
        public void RemoveContact(string name)
        {
            int index = Array.IndexOf(names, name);
            if(index == -1)
            {
                Console.WriteLine("contact not found");
                return;
            }
            names[index] = null;
            numbers[index] = null;
        }

        ///getter & setter

        //getcontact(name); //=> number
        public string  GetContact(string name)
        {
            int index = Array.IndexOf(names, name);
            if (index == -1)
            {
                return "contact not found";
            }
            return numbers[index];
        }
        //setcontact(name,number); //if find contact update number
        public void SetContact(string name,string number)
        {
            int index = Array.IndexOf(names, name);
            if (index == -1)
            {
                Console.WriteLine("contact not found");
                return;
            }
            numbers[index] = number;
        }

        /// indexer for number  by name
        /// indexer is a special type of property 
        /// that allows you to access elements in a collection 
        public string this[string name]
        {
            get
            {
                int index = Array.IndexOf(names, name);
                if (index == -1)
                {
                    return "contact not found";
                }
                return numbers[index];
            }
            set
            {
                int index = Array.IndexOf(names, name);
                if (index == -1)
                {
                    Console.WriteLine("contact not found");
                    return;
                }
                numbers[index] = value;
            }
        }


        //resize => [quiz] => duplicate capacity
    }
}
