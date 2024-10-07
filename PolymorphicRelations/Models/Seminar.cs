using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PolymorphicRelations.Models
{
    public class Seminar : DocumentType
    {
        private string? subject;
        public string Subject
        {
            get => subject ?? string.Empty;
            set => subject = value;
        }
        public override string Get()
        {
            string result = $"The Subject of the Seminar is : {Subject}";
            Console.WriteLine(result);
            return result;
        }
    }
}
