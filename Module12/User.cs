using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User(string login, string name, bool ispremium) // Конструктор
        { 
            Login = login;
            Name = name;
            IsPremium = ispremium;        
        }
    }
}
