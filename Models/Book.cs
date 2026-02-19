using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public DateTime PublicationDate { get; set; }
        public string Summary { get; set; } = String.Empty;
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int LanguageId { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // public Author Author { get; set; }
        // public Language Language { get; set; }
        // public Publisher Publisher { get; set; }
        // public Category Category { get; set; }
        // public ICollection<Feedback> Feedback { get; set; }
        // public ICollection<Wishlist> Wishlists { get; set; }
        // public ICollection<Edition> Editions { get; set; }

    }
}