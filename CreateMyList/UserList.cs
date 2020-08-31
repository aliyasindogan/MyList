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
            Debug.WriteLine("Add method");
            users.Add(addedUser);
        }

        public IEnumerator GetEnumerator()
        {
            Debug.WriteLine("GetEnumerator Interface Method");
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
                Debug.WriteLine("UserIEnumerator constroctor");
                users = userList;
            }

            public bool MoveNext()
            {
                index++;
                Debug.WriteLine($"MoveNext method index:{index}");

                return (index < users.Count);
            }

            public object Current
            {
                get
                {
                    Debug.WriteLine($"Current method: {users[index]}");
                    return users[index];
                }
            }

            public void Reset()
            {
                Debug.WriteLine("Reset method");
                index = -1;
            }

            public object GetCurrent()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}