using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Authtor { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
