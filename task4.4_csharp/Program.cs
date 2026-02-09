// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System;

//class User
//{
//    public string Name;
//}

//struct UserSnapshot
//{
//    public string Name;
//}

//class Program
//{
//    static void Modify(User user, UserSnapshot snapshot)
//    {
//        user.Name = "Ali";
//        snapshot.Name = "Ali";
//    }

//    static void ModifyRef(ref User user, ref UserSnapshot snapshot)
//    {
//        user.Name = "Omar";
//        snapshot.Name = "Omar";
//    }

//    static void Main()
//    {User u = new User();
//     u.Name = "Ahmed";

//    UserSnapshot s = new UserSnapshot();
//    s.Name = "Ahmed";

//    Modify(u, s);
//    Console.WriteLine("After normal call:");
//    Console.WriteLine(u.Name);   
//    Console.WriteLine(s.Name);   

//    ModifyRef(ref u, ref s);
//    Console.WriteLine("After ref call:");
//    Console.WriteLine(u.Name);   
//     Console.WriteLine(s.Name);   
//    }
//}
using System;

class Item
{
    public string Title { get; set; }
    public string ItemId { get; set; }

    public Item(string title, string itemId)
    {
        Title = title;
        ItemId = itemId;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Item ID: " + ItemId);
    }
}

class Book : Item
{
    public string Author { get; set; }
    public int Pages { get; set; }

    public Book(string title, string itemId, string author, int pages)
        : base(title, itemId)
    {
        Author = author;
        Pages = pages;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Pages: " + Pages);
    }
}

class Magazine : Item
{
    public int IssueNumber { get; set; }
    public string Publisher { get; set; }

    public Magazine(string title, string itemId, int issueNumber, string publisher)
        : base(title, itemId)
    {
        IssueNumber = issueNumber;
        Publisher = publisher;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Issue Number: " + IssueNumber);
        Console.WriteLine("Publisher: " + Publisher);
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("C# Basics", "B101", "Ahmed Ali", 350);
        Magazine magazine = new Magazine("Tech Monthly", "M202", 45, "Tech Press");

        Console.WriteLine("Book Info:");
        book.DisplayInfo();

        Console.WriteLine("\nMagazine Info:");
        magazine.DisplayInfo();
    }
}
