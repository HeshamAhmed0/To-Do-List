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

        #endregion

        #region Constructor
        public Reqired()
        {
            Console.WriteLine("          Hello In My App To Do Your Daily Recuremen");
            Console.WriteLine("What Do You Want To Do : \n1 Add Item\n2 Delete Item\n3 Dn Item");
            byte response =byte.Parse(Console.ReadLine());
            if (response == 1)
            {
                Additems();
            }
            else if (response == 2)
            {
                DeleteItem();
            }
            else if (response == 3) { DnItem(); }
        }
        #endregion
        public void newOption()
        {
            Console.WriteLine("Do You Want Another Option : ");
            Console.Write("Choose Y or N : ");
            string Choosen = Console.ReadLine();
            if (Choosen == "Y")
            {
                Console.Clear();
                Console.WriteLine("What Do You Want To Do : \n1 Add Item\n2 Delete Item\n3 Dn Item");
                byte response = byte.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Additems();
                }
                else if (response == 2)
                {
                    DeleteItem();
                }
                else if (response == 3) { DnItem(); }




            }
            else
            {
                Console.WriteLine("Your Day List : ");
                foreach (string I in Item)
                {
                    Console.WriteLine(I);
                }


            }
        }
        public void Additems() {
            Console.WriteLine("Enter To Do In This Day : ");
            Item.Add(Console.ReadLine());
           
           
            newOption();

        }
        
        // this BlockOf Code Return Dn After Succes Item 
        public void DnItem()
        {
            Console.Write("Enter Item You Are Dn : ");
            string Success=Console.ReadLine();
            foreach (string I in Item)
            {
                if (I ==Success)
                {
                    Console.WriteLine($"{I } Dn ");
                }
                Console.WriteLine(I);
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
