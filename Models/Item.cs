using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int EditionId { get; set; }
        public ItemStatus Status { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        public Edition Edition { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
        

    }

    

public enum ItemStatus
{
    Available = 1,
    Borrowed = 2,
    Reserved = 3,
}

}