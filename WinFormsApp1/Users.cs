using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    [Serializable]
    public class Users
    {
       public List<User> UserList { get; set; } = new List<User>();
    }
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public User  () { }
        public User (string name, int sex, int age) 
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

    }
}
