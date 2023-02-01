using System;

namespace Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {

            var arry = new int[6];

            try{
                for(var cont = 0; cont < 6; cont++){
                    Console.WriteLine(arry[cont]);
                }
                Salvar("");

            }catch (Exception e){
                System.Console.WriteLine(e.InnerException);
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Algo deu errado!");
            }

        }

        static void Salvar(string text){
            if(string.IsNullOrEmpty(text)){
                throw new Exception("O texto não pode ser nulo ou vazio!");
            }
        }
    }
}
