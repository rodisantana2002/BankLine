using System;
using System.Collections;
using System.Collections.Generic;


namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {        
            ICollection<String> lst =  new List<String>();
            ICollection<String> lst2 = new LinkedList<String>();

            lst.Add("Rodolfo");
            lst.Add("Ines");

            foreach (String str in lst){
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
