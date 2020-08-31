namespace CreateMyList
{
    public class User
    {
        public string UserName { get; set; }

        public override string ToString()
        {
            return this.UserName;
        }
    }
}