using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Declarationvar
    {
        string name;
        int age;
        float salary;
        bool result;
        char word;
        public void Declaration()
        {
            //User input string value
            Console.WriteLine("Enter the Name");
            name =Console.ReadLine();
            Console.WriteLine("Name is:"+name);
            //User input int value
            Console.WriteLine("Enter the Integer Value");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is:"+age);
            //User Input float value
            Console.WriteLine("Enter the float value");
            salary = (float)Convert.ToDouble(Console.ReadLine());

            //User bool value
            result= true;
            Console.WriteLine(result);

            //User char value
            Console.WriteLine("Enter the char value");
            word = 'A';
            Console.WriteLine(word);
        }

    }
}
