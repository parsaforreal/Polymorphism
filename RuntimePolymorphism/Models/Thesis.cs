using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Thesis : Document
    {
        public Thesis(int id, string title, string aBstract, string Text) : base(id, title, aBstract)
        {
            this.Text = Text;
        }

        public string? Text { get; set; }
    }
}
