using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateMyList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserList userList = new UserList();
            userList.Add(new User { UserName = "ali" });
            userList.Add(new User { UserName = "yasin" });
            userList.Add(new User { UserName = "doğan" });

            foreach (var item in userList)
            {
                Debug.WriteLine(item);
            }
        }
    }
}