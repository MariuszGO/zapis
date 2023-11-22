using System.Text;

namespace zapis
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            Int64 x;
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("C:\\pliki\\nowy.txt", true, Encoding.ASCII);

                //Write out the numbers 1 to 10 on the same line.
                for (x = 0; x < 10; x++)
                {
                    sw.Write(x + ";");
                }

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }




        }
    }
}


