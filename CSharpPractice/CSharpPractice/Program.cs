using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Welcome welcome = new Welcome();
            welcome.Display();
            Declarationvar dc = new Declarationvar();
            dc.Declaration();
            Console.ReadLine();
        }
    }
}
