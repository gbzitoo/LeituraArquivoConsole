using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader(@"\\10.75.0.90\publico$\ArquivoCsv\ListaDeRamais.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    string id = "";
                    string nome = "";
                    string ramal = "";

                    String linha = streamReader.ReadLine();

                    var array = linha.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    id = array[0];
                    nome = array[1];
                    ramal = array[2];

                    Console.WriteLine("ID: "+id + " Nome: " + nome + ", Ramal: " + ramal);
                }

            }

            Console.ReadKey();
        }
    }
}
