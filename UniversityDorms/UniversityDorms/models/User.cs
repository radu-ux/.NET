using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityDorms.models
{
    public partial class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> ReservedDorms { get; set; }
        public bool hasUserReservedTheDorm(User user, string dormName)
        {
            foreach (string dorm in user.ReservedDorms)
            {
                if (dorm == dormName)
                {
                    return true;
                }
            }
            return false;
        }

        public void reserveDorm(string dormName)
        {
            ReservedDorms.Add(dormName);
        }
    }

}
