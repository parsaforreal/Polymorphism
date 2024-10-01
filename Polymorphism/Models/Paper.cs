using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Paper : DocumentDetail
    {
        public Paper(string author)
        {
            Author = author;
        }
        public string? Author { get; set; }
    }
}
