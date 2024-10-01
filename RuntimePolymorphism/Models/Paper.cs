using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Paper : Document
    {
        public Paper(int id, string title, string aBstract, string Author) : base(id, title, aBstract)
        {
            this.Author = Author;
        }

        public string? Author { get; set; }
    }
}
