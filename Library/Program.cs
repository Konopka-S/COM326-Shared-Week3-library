using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book { Title = "C# for beginners", Author = "BillGates", ISBN = "12345678" });
books.Add(new Book { Title = "Ultimate C#", Author = "Microsoft", ISBN = "2233445" });

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));


foreach (Book book in books)
{
    Console.WriteLine($"Book Title: {book.Title}");
    Console.WriteLine($"Book Author: {book.Author}");
    Console.WriteLine($"Book ISBN: {book.ISBN}");
}

foreach (Member member in members)
{
    Console.WriteLine($"Member Name: {member.Name}");
    Console.WriteLine($"Member Address: {member.Address}");
    Console.WriteLine($"Member Phone: {member.Phone}");
    Console.WriteLine($"Member ID: {member.MemberId}");
}
