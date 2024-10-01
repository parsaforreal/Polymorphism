using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Article : DocumentDetail
    {
        public DateOnly Date { get; set; }
    }
}
