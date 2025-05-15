using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posLibrary
{
    public abstract class User
    {
        public int userId { get; set; }
        public string userName { get; set; }

        public string role { get; set; }

        public User(int id)
        {
            userId = id;
        }

        public abstract bool hasPermission(string action);
    }

    public class Manager : User
    {
        public Manager(int id, string name) : base(id)
        {
        
            userName = name;
            role = "Manager";
        }

        public override bool hasPermission(string action)
        {
            return true;
        }
    }

    public class Cashier : User
    {
        public Cashier(int id, string name) : base(id)
        {
        
            userName = name;
            role = "Cashier";
        }
        public override bool hasPermission(string action)
        {
            return action == "viewProducts";
        }
    }
}