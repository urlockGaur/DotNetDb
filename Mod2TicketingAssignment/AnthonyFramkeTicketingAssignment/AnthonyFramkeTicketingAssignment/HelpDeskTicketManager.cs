namespace FramkeTicketingAssignment
{
    public class TicketManager
    {
        public void Write(string filename)
        {

            var header = ("TicketID, Summary, Status, Priority, Submitter, Assigned, Watching");

            //need new stream
            StreamWriter sw = new StreamWriter(filename, true); // appends to our help desk ticket file


            //writing to file -- 

            //need header written

            sw.WriteLine(header);

            //writing to file -- ask user to enter data
            Console.WriteLine("Enter the Ticket ID: ");
            var ticketID = Console.ReadLine();

            Console.WriteLine("Enter a Ticket Summary: ");
            var summary = Console.ReadLine();

            Console.WriteLine("Enter the Ticket Status:  ");
            var status = Console.ReadLine();

            Console.WriteLine("Enter the Ticket Priority: ");
            var priority = Console.ReadLine();

            Console.WriteLine("Enter the Ticket Submitter: ");
            var submitter = Console.ReadLine();

            Console.WriteLine("Enter who the Ticket is Assigned to: ");
            var assigned = Console.ReadLine();


            //watching section

            Console.WriteLine("***Enter the team member(s) Watching the ticket (one per line)***");

            int maxWatchers = 5; // defining watchingArray size
            string[] watchingArray = new string[maxWatchers]; //putting watchers into array
            int currentIndex = 0;

            while (true)
            {
                Console.WriteLine("Enter a team member (or type 'exit') :  ");
                string inputWatcher = Console.ReadLine();

                if (inputWatcher.ToLower() == "exit") // need to offer option to exit loop
                {
                    break;

                }
                if (currentIndex < maxWatchers)

                {
                    watchingArray[currentIndex] = inputWatcher;
                    currentIndex++;

                }
                else

                {
                    Console.WriteLine("The max number of Watchers has been added."); // set limit of 5 indexes for the array to provide a user input limit
                    break;
                }

            }
  
            // using take method to join names entered into watching array onto 1 line. previous solution was creating entries based on number of watchers entered, delimits via pipes per assignment
                
                string watchers = string.Join("|", watchingArray.Take(currentIndex));
                
                sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watchers}");
            

            // saving csv file "flushing"
            sw.Close();
        }


        public void Read(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename); //reads lines 1 at a time

                sr.ReadLine(); //skipping header line (1st line)

                while (sr.EndOfStream != true) // while not at the end of stream....
                {
                

                    var ticket = sr.ReadLine();

                    var ticketArray = ticket.Split(',');
                    Console.WriteLine($"{ticketArray[0]}, {ticketArray[1]}, {ticketArray[2]}, {ticketArray[3]}, {ticketArray[4]}, {ticketArray[5]}, {ticketArray[6]}");
                }
            }
        }
    }
}
    
