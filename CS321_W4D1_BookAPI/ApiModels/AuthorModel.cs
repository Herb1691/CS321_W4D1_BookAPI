using System;
using System.Collections.Generic;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public class AuthorModel
    {
        // TODO: fill in AuthorModel properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<BookModel> Books { get; set; }
    }
}

