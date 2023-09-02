// looking at files. store and save data while app is running read/write data to file
// console = stream
//check out solid principles
//dependancy = new keyword, something program depends on, reduce these
//THESE NOTES COVER MOD 2 primarily - Files
namespace FilesNotes
{
    public class Program
    {
        public static void Main(string[] args) // dont need string[] args necessarily
        {
            FileManager dataManager = new FileManager(); // creating instance of class assign variable fileManager = object

            string filename = "grades.txt";
            string menu;
            do
            {
                // menu
                Console.WriteLine("1. Write data to file");
                Console.WriteLine("2. Read data from file");
                Console.WriteLine("3. Exit");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    dataManager.Write(filename);

                }

                else if (menu == "2")
                {
                    dataManager.Read(filename);
                }
            } while (menu != "3");
        }
    }
}


//Assignment1 NOTES ---------------------------

//most covers the assignment except -- built point 2 in section 1 need header. define the "columns". 
//header - 
// writing - pipes = comma ticket, summary, watching ----- ask user for watching in Loop --- 
// reading -watching value - pipes in last column pipes 
//git -- push to github 

// looking at files. store and save data while app is running read/write data to file
// console = stream
namespace FilesNotes
{
}

