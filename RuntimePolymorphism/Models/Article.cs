using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Article : Document
    {
        public Article(int id, string title, string aBstract, DateTime Date) : base(id, title, aBstract)
        {
            this.Date = Date;
        }

        public DateTime Date { get; set; }
    }
}
