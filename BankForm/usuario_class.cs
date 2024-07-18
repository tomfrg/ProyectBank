using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    public class Usuario
    {
        private string _name;
        private string _pass;
        public string Name { get { return _name; } set { _name = value; } }
        public string Pass { get { return _pass; } set { _pass = value; } }
        public Usuario(string name, string pass)
        {
            _name = name;
            _pass = pass;
        }

        public void ChangeUser(string newUser)
        {
            if (null == null)
            {
                Name = newUser;
            }
        }
        public void ChangePass(string newPass)
        {
            if (null == null)
            {
                Pass = newPass;
            }
        }
        public void Identify(string pass, string name)
        {
            if (IdentifyUser(name) && IdentifyPass(pass))
            {

            }
        }
        public bool IdentifyUser(string name)
        {
            return true;
        }
        public bool IdentifyPass(string pass)
        {
            return true;
        }

    }

}
