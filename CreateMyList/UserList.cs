using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CreateMyList
{
    public class UserList : IEnumerable
    {
        private List<User> users;

        public UserList()
        {
            users = new List<User>();
            Debug.WriteLine("UserList contractor");
        }

        public void Add(User addedUser)
        {
            Debug.WriteLine("Add metodu");
            users.Add(addedUser);
        }

        public IEnumerator GetEnumerator()
        {
            Debug.WriteLine("GetEnumerator metodu");

            return new UserIEnumerator(users);
        }

        public class UserIEnumerator : IEnumerator
        {
            private List<User> users;
            private int index = -1;

            public UserIEnumerator()
            {
            }

            public UserIEnumerator(List<User> userList)
            {
                Debug.WriteLine("UserIEnumerator metodu");
                users = userList;
            }

            public object Current
            {
                get
                {
                    Debug.WriteLine("Current metodu");
                    return users[index];
                }
            }

            public object GetCurrent()
            {
                throw new System.NotImplementedException();
            }

            public bool MoveNext()
            {
                index++;
                Debug.WriteLine($"MoveNext metodu index:{index}");

                return (index < users.Count);
            }

            public void Reset()
            {
                Debug.WriteLine("Reset metodu");
                index = -1;
            }
        }
    }
}