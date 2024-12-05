using AutoMapper;
using EFCoreManyToMany.Database;
using EFCoreManyToMany.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCoreManyToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        public BookDbContext _context;
        private readonly IMapper _mapper;
        public BooksController(BookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //GET:api/Books
        [HttpGet]
        public IActionResult Get()
        {
            List<BookDto> bookDtos = new List<BookDto>();
            //using (var context = new BookDbContext())
            //{
            //    var books = context.Books.ToList();
            //    return Ok(books);
            //}
            var books = _context.Books.Include(x => x.Author).ToList();
            _mapper.Map(books, bookDtos);
            //foreach(var book in books)
            //{
            //    bookDtos.Add(new BookDto
            //    {
            //        BookId = book.BookId,
            //        Title = book.Title,
            //        AuthorName = book.Author.AuthorName
            //    });
            //}
            return Ok(bookDtos);
            // return Ok();

        }
        //Post:api/Books
        [HttpPost]
        public IActionResult Post([FromBody] BookDto bookDto)
        {
            var book = _mapper.Map<Book>(bookDto);
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}
