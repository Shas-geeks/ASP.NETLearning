namespace IActionEX.Models
{
    public class Book
    {
        public int? BookID { get; set; }
        public string? Author { get; set; }
        public override string ToString()
        {
            return $"BookID: {BookID},Author: {Author}";
        }
    }
}
