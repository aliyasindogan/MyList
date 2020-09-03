namespace CreateMyList
{
    public class Category
    {
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}