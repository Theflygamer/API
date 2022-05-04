using authbookbll;
using authbookbll.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace auth_book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public List<Author> Get()
        {
            return new AuthorService().getAllAuthors();
        }
    }
}
