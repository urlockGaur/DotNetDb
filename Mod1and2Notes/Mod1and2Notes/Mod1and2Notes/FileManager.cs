// looking at files. store and save data while app is running read/write data to file
// console = stream
//check out solid principles
//dependancy = new keyword, something program depends on, reduce these


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
    public class FileManager
    {
        // need Read method
        public void Write(string filename)
        {
            // new stream
            StreamWriter sw = new StreamWriter(filename, true); // new instance of a class class = type writing out to grades.txt. true = appends to grades.txt, doesn't make new file
                                                                // create new stream for a courses file if you wanted to create totally new file


            //writing to a file, ask user to enter data
            Console.WriteLine("Enter a course: ");
            var course = Console.ReadLine();

            Console.WriteLine("Enter a grade: ");
            var grade = Console.ReadLine();

            //output the data to file (csv?) comma separated values
            // writing out the data --------------------

            //Console.WriteLine(course + "|" + grade); // using pipe | to deliminate or separate the values can use comma
            //Console.WriteLine("{0}{1}", course, grade); // intermediate method

            sw.WriteLine($"{course}|{grade}"); // best practice use $ - string interpolation ---- use in assignment ----replace console with sw-----. file saved in bin folder*****
                                               // the above writes to the Stream above --- put comma in place of |

            // need to save file 

            sw.Close(); // automatically flushes or saves data. by default it will overwrite
        }

        public void Read(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename); // reads in 1 line at a time

                sr.ReadLine(); // skips the header ---- ASSINGMENT NOTES ON HEADER

                while (sr.EndOfStream != true) // while not at end of stream....
                {
                    var line = sr.ReadLine();

                    Console.WriteLine($"Your line is {line}"); // need to tell it to continue. the above readline only reads 1 line

                    // parse line to retrieve the grade

                    var lineArray = line.Split('|'); // each element splits by the comma

                    Console.WriteLine($"Course: {lineArray[0]}, Grade: {lineArray[1]}");
                }
            }
        }
    }
}

