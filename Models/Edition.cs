using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Edition
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; } = String.Empty;
        public EditionFormat Format { get; set; }
        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        public string ISBN { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public int PageCount { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        public Book? Book { get; set; }
        public Publisher? Publisher { get; set; }
        public Language? Language { get; set; }
        

    }

    public enum EditionFormat
    {
        Hardcover = 1,
        Paperback = 2,
        Ebook = 3,
        Audio = 4,
        LargePrint = 5
    }
}