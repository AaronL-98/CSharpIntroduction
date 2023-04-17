namespace ExceptionsApp
{
    internal class Exceptions
    {
        static void Main(string[] args)
        {
            
            string fileName = "";
            string text;
            try
            {
                //string? text = File.Exists(fileName) ? File.ReadAllText("HelloWorld.txt") : throw new FileNotFoundException();
                text = File.ReadAllText("HelloWorld.txt");
                
                text = File.ReadAllText("");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Sorry I Can't find " + fileName);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Empty file name!");
            }
            finally
            {
                Console.WriteLine("We made it here!");
            }
        }
    }
}