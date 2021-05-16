using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityDorms.models
{
    public partial class UserList
    {
        public List<User> Users { get; set; }

        public static User getUserByAccount(string email, string password)
        {
            foreach (User User in App.Users)
            {
                if (User.Email == email && User.Password == password)
                {
                    return User;
                }
            }

            return null;
        }
    }
}
