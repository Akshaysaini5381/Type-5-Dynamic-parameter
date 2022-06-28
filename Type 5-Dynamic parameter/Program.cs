using System;

namespace Type_5_Dynamic_parameter
{
    class Program
    {
       static void show(dynamic num)
        {
            Console.WriteLine("All "+num);
        }
        static void Main(string[] args)
        {
            show(12);
            show("alshay");
            show(12.4);
            show(true);


            
        }
    }
}
