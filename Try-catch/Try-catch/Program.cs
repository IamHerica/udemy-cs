using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //tratamento de erros

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException e) //esse e é passando a mensagem de erro que o terminal dá
            {
                Console.WriteLine("Error! " + e.Message); //imprimindo a msg de erro
            }
            catch (FormatException e) //esse e é passando a mensagem de erro que o terminal dá
            {
                Console.WriteLine("Format error! " + e.Message); //imprimindo a msg de erro

            }
        }
    }
}
