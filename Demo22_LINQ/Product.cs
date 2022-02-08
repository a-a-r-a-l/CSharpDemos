using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo22_LINQ
{
    class Product
        : IComparable
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set;  }

        #region IComparable interface members

        public int CompareTo(object obj)
        {
            return this.ProductID.CompareTo((obj as Product).ProductID);
        }

        #endregion
    }
}
