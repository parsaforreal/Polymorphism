using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicRelations.Models
{
    public class Thesis : DocumentType
    {
        private string? text;
        public string Text
        {
            get => text ?? string.Empty;
            set => text = value;
        }

        public override string Get()
        {
            string result = $"The text of the thesis is : {text}";
            Console.WriteLine(result);
            return result;
        }
    }
}
