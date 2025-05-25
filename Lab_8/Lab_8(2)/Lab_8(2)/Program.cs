namespace Lab_8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Items item1 = Create.CreateItems();
            Items item2 = Create.CreateItems();
            Items item3 = Create.CreateItems();
            Items[] items = { item1, item2, item3 };
            Case myCase = Create.CreateCase();
            Console.WriteLine("Case and items:");
            Console.WriteLine(myCase.ToString());
            Console.WriteLine(item1.ToString());
            Console.WriteLine(item2.ToString());
            Console.WriteLine(item3.ToString());
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            myCase.ItemAdd += handler1.ItemsAddHandler;
            myCase.ItemAdd += handler2.ItemDeleteHandler;
            Console.WriteLine("Case after changing:");
            myCase.AddItems(item1);
            Console.WriteLine(myCase.ToString());
            myCase.DeleteItems(item1);
            Console.WriteLine(myCase.ToString());
        }
            
    }
}
