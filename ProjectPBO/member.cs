using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    class Member
    {

        // attribute, field, variables
        string username;
        string email; 


        // constructor
        public Member(string username, string email)
        {
            this.username= username;
            this.email = email;
        }

        // ini procedure
        public void ShowMemberInformation()
        {
            Console.WriteLine("Username\t: {0} ", username);
            Console.WriteLine("Email\t\t: {0}", email);
        }
        
    }
}