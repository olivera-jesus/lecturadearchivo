using System;
using System.IO;

namespace lecturadearchivo
{
    class Program
    {
      
        static void Main(string[] args)

        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\k020xd.txt");
                line = sr.ReadLine();
                while( line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                }
                sr.Close();
                Console.ReadLine();
            }
             catch(Exception e)
            {
                Console.WriteLine("excepcion : " + e.Message);
            }
            finally
            {
                Console.WriteLine("ejecutando bloque final");
            }
        }
    }
}
