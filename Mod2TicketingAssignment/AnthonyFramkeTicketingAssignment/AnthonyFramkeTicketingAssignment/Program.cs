namespace FramkeTicketingAssignment
{
    public class Program
    {
        public static void Main(string[] args) {

            TicketManager helpDeskTicketManager = new TicketManager(); // creating instance of systemTicketManager(object)

            string filename = "ticket.csv";
            string ticketMenu;

            do
            {
                //ticket menu
                Console.WriteLine("Welcome to the Help Desk Ticket Manager");
                Console.WriteLine("---------------------------------------------------");
                
                Console.WriteLine();// creating blank line

                Console.WriteLine("1. Write a Help Desk Ticket");
                Console.WriteLine("2. Read Help Desk Ticket data from file");
                Console.WriteLine("3. Exit Help Desk Ticket Manager");
                ticketMenu = Console.ReadLine();

                if (ticketMenu == "1") // enter 1 if user wants to write help desk ticket
                {
                    helpDeskTicketManager.Write(filename);
                }

                else if (ticketMenu == "2") // enter 2 if user wants to read help desk ticket
                {
                    helpDeskTicketManager.Read(filename);
                }
            } while (ticketMenu != "3"); // enter 3 if user wants to exit
        
        }
    }
}