using System;
using MyLibrary.Application.DTOs;
using MyLibrary.Domain.Entities;

namespace MyLibrary.Application.Services.Interfaces;

public interface IBooksService
{
    Book AddBook(BookDTO bookDto);
    List<Book> GetBooks();
    
}