namespace Persistence.Entities;

public class Author
{
    public int Id { get; set; }

    // public string FullName { get; set; }

    // public string FirstName { get; set; }
    // public string LastName { get; set; }

    public ICollection<Book> Books { get; set; }
}