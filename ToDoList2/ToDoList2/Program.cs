namespace ToDoList2
{
    internal class Program
    {
        private static List<Item> Listt = new List<Item>();

       
        private static void NewOption()
        {
            Console.WriteLine("Do You Want Another Option ");
            Console.WriteLine("1. Yes\n2. No");
            Console.Write("Enter Choosen : ");
            int choosen =int.Parse(Console.ReadLine());
            if (choosen==1) 
            {
                Start();
            }
            else if (choosen==2) 
            {
                Console.WriteLine("Your List is : ");
                ViewItem();
            }else
            {
                Console.WriteLine("Your Choosen Is Not Correct");
                Console.WriteLine("Please Enter Valid Choosen ");
                NewOption();
            }
        }
        static void Main(string[] args)
        {
            Start();

        }
        private static void Start()
        {
            Console.WriteLine("What Do You Want to Do ");
            Console.WriteLine("1. Add    Item ");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. View   Item ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1) { AddItem(); }
            else if (input == 2) { RemoveItem(); }
            else if (input == 3) { ViewItem(); }
        }

       
        private static void AddItem()
        {

            Console.Write("Enter Item You Need To Add : ");
            string input = Console.ReadLine();
            Console.WriteLine("Is this Item Is Done :");
            Console.WriteLine("1. IsDone");
            Console.WriteLine("2. NoDone");
            int Choosen = int.Parse(Console.ReadLine());
            if (Choosen == 1)
            {
                Item i = new Item(input, true);
                Listt.Add(i);
                NewOption();
            }
            else if (Choosen == 2)
            {
                Item i = new Item(input, false);
                Listt.Add(i);
                NewOption();
            }
            else
            {
                Console.WriteLine("This Choosen  Is Not Correct\nPlease Enter Correct Choose");
                AddItem();
            }

        }

        private  static void RemoveItem()
        { 
            Console.WriteLine("Choose Item You Need TO Remove It : ");
            ViewItem();
            Console.Write("What Is Your Choosen : ");
            int Choosen =int.Parse(Console.ReadLine());
            if (Choosen >= Listt.Count || Choosen < 0)
            {
                Console.WriteLine("InValid Choosen ");
                Console.Write("Please Enter Valid Choosen");
                RemoveItem();
            }
            else if (Choosen > 0||Choosen<Listt.Count) 
            {
                Listt.Remove(Listt[Choosen]);
                Console.WriteLine("New Item Is : ");
                ViewItem();
            }
            
        }

        private static void ViewItem()
        {
            for (int i=0;i<Listt.Count;i++)
            {
                Console.WriteLine($"{i+1}. {Listt[i]}");
            }
            NewOption();
        }
    }
}