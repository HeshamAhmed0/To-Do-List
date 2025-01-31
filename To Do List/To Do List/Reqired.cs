using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Reqired
    {
        #region Attributes
        private static List<string> Item=new List<string>();
        private int i = 0;
        string Success;

        #endregion

        #region Constructor
        public Reqired()
        {
            Console.WriteLine("          Hello In My App To Do Your Daily Recuremen");
            Console.WriteLine("What Do You Want To Do : \n1 Add Item\n2 Delete Item\n3 Dn Item\n4 View Item");
            byte response =byte.Parse(Console.ReadLine());
            if (response == 1)
            {
                Additems();
            }
            else if (response == 2)
            {
                DeleteItem();
            }
            else if (response == 3) { DnItem(); } else if (response == 4) { ViewItems(); }
        }
        #endregion
        public void newOption()
        {
            Console.WriteLine("Do You Want Another Option : ");
            Console.Write("Choose Y or N : ");
            string Choosen = Console.ReadLine();
            Console.Clear();

            if (Choosen == "Y")
            {
                Console.WriteLine("What Do You Want To Do : \n1 Add Item\n2 Delete Item\n3 Dn Item\n4 View Items");
                byte response = byte.Parse(Console.ReadLine());
                Console.Clear();

                if (response == 1)
                {
                    Additems();
                }
                else if (response == 2)
                {
                    DeleteItem();
                }
                else if (response == 3) { DnItem(); }
                else if (response == 4) { ViewItems(); };




            }
            else
            {
                Console.WriteLine("You Are Hero \n Continue . ");

            }
        }

        public void ViewItems()
        {
            for (int i=0;i<Item.Count;i++)
            {
                Console.WriteLine(Item[i]);
            }
            newOption();
        }

        public void Additems() {
            Console.Clear();
            Console.WriteLine("Enter To Do In This Day : ");
            Item.Add(Console.ReadLine());
            Console.Clear();


            newOption();

        }
        
        // this BlockOf Code Return Dn After Succes Item 
        public void DnItem()
        {
            Console.Clear();

            Console.Write("Enter Item You Are Dn : ");
             Success=Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < Item.Count ; i++)
            {
                if (Item[i] == Success)
                {

                    Item[i] = Success + " Dn";
                    Console.WriteLine(Item[i]);

                }
                else {             
                    Console.WriteLine(Item[i]);
                      }
               

                
            }
            newOption();
        }

        public void DeleteItem()
        {
            Console.Write("Enter Item You Want To Delete It : ");
            string DeleteItem = Console.ReadLine();
            Item.Remove(DeleteItem);
               
            newOption();
        }
    }
}
