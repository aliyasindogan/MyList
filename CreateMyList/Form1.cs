using System;
using System.Diagnostics;
using System.Text;
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
            StringBuilder sb = new StringBuilder();
            foreach (var item in userList)
            {
                richTextBox1.AppendText(item.ToString() + Environment.NewLine);
                Debug.WriteLine(item);
            }
        }
    }
}