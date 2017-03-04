using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp1004_Assignment03
{
    class Movie
    {
        private static string _title;
        private static string _category;
        private static double _cost;
        private static double _grandTotal;
        private static double _subTotal;
        private static double _salesTax;

        public static string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public static string Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }

        public static double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }

        public static double GrandTotal
        {
            get
            {
                return _grandTotal;
            }

            set
            {
                _grandTotal = value;
            }
        }

        public static double SubTotal
        {
            get
            {
                return _subTotal;
            }

            set
            {
                _subTotal = value;
            }
        }

        public static double SalesTax
        {
            get
            {
                return _salesTax;
            }

            set
            {
                _salesTax = value;
            }
        }
    }
}
