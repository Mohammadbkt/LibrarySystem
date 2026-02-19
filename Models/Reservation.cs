using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public DateTime RequestedAt { get; set; }
        public ReservationStatus Status { get; set; }
        public DateTime? FulfilledAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
    }

    public enum ReservationStatus
    {
        Waiting = 1,
        Notified = 2,
        Fulfilled = 3,
        Cancelled = 4
    }
}