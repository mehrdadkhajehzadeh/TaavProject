class Category
{
    public string CategoryName { get; set; }
    public List<CategoryItem> Items { get; set;}
    public Category(string categoryName, int capacity)
    {
        CategoryName = categoryName;
        Items = new ();
        for (int i = 1; i <= capacity; i++)
        {
            Items.Add(new CategoryItem(i));
        }
    }
}
