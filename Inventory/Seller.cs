using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Seller
    {
        #region Private Fields
        private string name;
        private int casesSold;
        #endregion

        #region Constructor
        public Seller()
        {
            name = "No name given";
            casesSold = 0;
        }
        #endregion

        #region Methods
        public string getName()
        {
            return name;
        }
            
        #endregion


    }
}
