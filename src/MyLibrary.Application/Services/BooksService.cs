using System;
using MyLibrary.Application.DTOs;
using MyLibrary.Application.Services.Interfaces;
using MyLibrary.Domain.Entities;

namespace MyLibrary.Application.Services;

public class BooksService : IBooksService
{
   private List<Book> _books;

    public BooksService()
    {
         _books = new List<Book>();
    }

    public Book AddBook(BookDTO bookDto)
    {
        var book = new Book
        {
            Id = Guid.NewGuid(),
            Title = bookDto.Title,
            Author = bookDto.Author
        };

        _books.Add(book);
        return book;
    }

    public List<Book> GetBooks()
    {
        return _books;
    }
}
