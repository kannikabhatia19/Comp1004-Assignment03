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
    }
}
