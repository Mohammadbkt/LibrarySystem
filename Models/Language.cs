using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_system.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Code { get; set; } = String.Empty;
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateOnly DeletedAt { get; set; }

        // public ICollection<Edition> Editions { get; set; }
    }
}