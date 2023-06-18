﻿namespace Persistence.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
    
    // public ICollection<Author> Authors { get; set; }
}