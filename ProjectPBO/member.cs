using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    class Member
    {
        string username;
        string email; 


        public Member(string username, string email)
        {
            this.username= username;
            this.email = email;
        }

        public void ShowMemberInformation()
        {
            Console.WriteLine("Username\t: {0} ", username);
            Console.WriteLine("Email\t\t: {0}", email);
        }
        
    }
}
