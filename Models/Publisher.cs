using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        //public ICollection<Book> Books { get; set; }
        
        // public ICollection<Edition> Editions { get; set; }
    }
}