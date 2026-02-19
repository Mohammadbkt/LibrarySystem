using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Fine
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BorrowingId { get; set; }
        public decimal Amount { get; set; }
        public int DaysLate { get; set; }
        public decimal FeePerDay { get; set; }
        public string Reason { get; set; } = String.Empty;
        public FineStatus Status { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime? PaidAt { get; set; }
        public bool IsPaid { get; set; } = false;

        public Borrowing Borrowing { get; set; }
        public User User { get; set; }

    }

    public enum FineStatus
    {
        Pending = 1,
        Paid = 2,
        Waived = 3
    }
}