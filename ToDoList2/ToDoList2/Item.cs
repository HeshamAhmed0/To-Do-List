using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList2
{
    internal class Item
    {
        #region Attributes
        private string item;
        private bool IsDone; 
        #endregion
        
        public  Item(string item,bool done)
        {
            this.item = item;
            this.IsDone = done;
        }
        //public void SetItem(string item, bool done)
        //{
        //    this.item = item;
        //    this.IsDone = done;
        //}
        public string GetItem()
        {
            return this.item;
        }
        public bool GetDone() {

            return IsDone;
        }
        public override string ToString()
        {
            if (IsDone==true)
            {

            return $"{item} Done";

            }
            else
            {
                return $"{item} NoDone";

            }
        }
    }
}
