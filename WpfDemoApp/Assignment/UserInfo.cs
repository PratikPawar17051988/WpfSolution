using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoApp.Assignment
{

    public class UserInfo
    {
        string _username;
        int _age;
        string _favcolor;

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public string Favcolor
        {
            get
            {
                return _favcolor;
            }

            set
            {
                _favcolor = value;
            }
        }
    }
}
