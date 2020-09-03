using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CreateMyList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region My List

            UserList userList = new UserList();
            userList.Add(new User { UserName = "ali" });
            userList.Add(new User { UserName = "yasin" });
            userList.Add(new User { UserName = "doğan" });
            foreach (var item in userList)
            {
                richTextBox1.AppendText(item.ToString() + Environment.NewLine);
                Debug.WriteLine(item);
            }
            richTextBox1.AppendText("***************" + Environment.NewLine);

            #endregion My List

            #region My Generic List

            MyEntityList<User> _users = new MyEntityList<User>();
            _users.Add(new User { UserName = "recep" });
            _users.Add(new User { UserName = "ali" });
            _users.Add(new User { UserName = "mert" });
            foreach (var item2 in _users)
            {
                richTextBox1.AppendText(item2.ToString() + Environment.NewLine);
                Debug.WriteLine(item2);
            }
            richTextBox1.AppendText("***************" + Environment.NewLine);

            MyEntityList<Category> _categories = new MyEntityList<Category>();
            _categories.Add(new Category { CategoryName = "AnaSayfa" });
            _categories.Add(new Category { CategoryName = "Hakkımızda" });
            _categories.Add(new Category { CategoryName = "İletişim" });
            foreach (var item3 in _categories)
            {
                richTextBox1.AppendText(item3.ToString() + Environment.NewLine);
                Debug.WriteLine(item3);
            }
            richTextBox1.AppendText("***************" + Environment.NewLine);

            #endregion My Generic List
        }
    }
}