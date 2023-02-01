using System;

namespace Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {

            var arry = new int[6];

            try{
                for(var cont = 0; cont < 10; cont++){
                    Console.WriteLine(arry[cont]);
                }
            }catch (Exception e){
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
