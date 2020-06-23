using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    
    class User : IAdminintrated
    {
        public int UserId;
        string username;
        string password;
        string sex;
        string user_email;
        int type;

        public User(string username, string password, string sex, string user_email, int type, int id) { }

        public User(int UserId,string username, string password, string sex, string user_email, int type)

        {
            
            this.username = username;
            this.password = password;
            this.sex = sex;
            this.user_email = user_email;
            this.type = type;
            this.UserId= UserId;
        }
        public User(){}

        public string Changeusername(string newusername)
        {
            this.username = newusername;
            return newusername;
        }
        public string changepassword(string newpass)
        {
            this.password = newpass;
            return newpass;
        }
        public void changetoadmin()
        {
            this.type = 2;
        }
    }
}
