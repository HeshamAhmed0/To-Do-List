using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Items
    { 
        #region MyRegion
            private string item;
            #endregion
        public  void IsItem(string Item , bool Done)
        {
            if (Done== true)
            {
                item = Item + "Dn";
            }
            else if (Done == false) 
            {
                item = Item;
            }
        }



    }
}
