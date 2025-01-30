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
        private static int Size=1;
        private string[] item;
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
                foreach (string Item in item)
                {
                    Console.WriteLine(Item);
                }


            }
        }
        public void Additems() {
            Console.WriteLine("Enter To Do In This Day : ");
             item = new string[Size];
            item[i] = Console.ReadLine();
            i++;
           
            newOption();

        }
        
        // this BlockOf Code Return Dn After Succes Item 
        public void DnItem()
        {
            Console.Write("Enter Item You Are Dn : ");
            string Success=Console.ReadLine();
            int index = Array.IndexOf(item, Success);
            foreach (string Item in item)
            {
                if (Item ==Success)
                {
                    Console.WriteLine($"{Item } Dn ");
                }
                Console.WriteLine(Item);
            }

            newOption();
        }

        public void DeleteItem()
        {
            Console.Write("Enter Item You Want To Delete It : ");
            string DeleteItem = Console.ReadLine();
            string[] newItems =new string[item.Length];
            foreach (string CurrentItem in item)
            {
                if (CurrentItem==DeleteItem) 
                {
                    break;
                }
                else
                {
                    for (int i=0; i<newItems.Length;i++)
                    {
                        newItems[i] = CurrentItem;

                    }
                    Array.Clear(item);
                    Array.Copy(newItems,item,newItems.Length);
                }
            }
            newOption();
        }
    }
}
