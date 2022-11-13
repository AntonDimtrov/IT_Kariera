namespace Program
{
    public class Book
    {
        private string title;
        private double rating;
        public Book(string title, double rating)
        {
            this.title = title;
            this.rating = rating;
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public double Rating
        {
            get { return this.rating; }
            set { this.rating = value; }
        }
        public override string ToString()
        {
            return $"Book {title} is with {rating:f1} rating.";
        }
    }
}