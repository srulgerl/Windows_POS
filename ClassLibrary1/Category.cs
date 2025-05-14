using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posLibrary
{
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public Category(int id, string name) {
            categoryId = id;
            categoryName = name;
        }
    }
}
