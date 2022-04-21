using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_7_File_IO
{
    class FileIOProgram
    {
        static void Main(string[] args)
        {
            string data; //like placeholder
            StreamReader reader = null;
           StreamWriter writer = null;
            try
            {
                reader = new StreamReader("C:\\Users\\hp\\Documents\\info.txt");
                
                data = reader.ReadLine();

                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }
                reader.Close();
                writer = new StreamWriter("C:\\Users\\hp\\Documents\\info2.txt");
                writer.WriteLine("Employee : Johnny" +"\n"+
                    "Location: USA" +"\n"+
                    "Company Name: Capgemini");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                writer.Close();
                Console.ReadKey();
            }
        }
    }
}
