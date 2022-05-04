using authbookbll.Model;
using System;
using System.Collections.Generic;

namespace authbookbll
{
        public interface IAuthorService
        {
            public List<Author> getAllAuthors();
        }
    public class AuthorService : IAuthorService //inherentens
    {
        public List<Author> getAllAuthors()
        {
            return new List<Author>
            {
                new Author(){AuthorID=1,age=12,isAlive=true,name="Castle", password="1234"},
                new Author(){AuthorID=2,age=85,isAlive=true,name="Line", password="12345"}

            };
            throw new NotImplementedException();
        }
    }

}
