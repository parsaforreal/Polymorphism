namespace Polymorphism.Models
{
    public class Paper
    {
        public Paper(string Author)
        {
            this.Author = Author;
        }

        public string? Author { get; set; }
    }
}
