namespace HackerWe.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public Guid ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public short NumberOfCopies { get; set; }
        public short NumberOfBorrowedOut { get; set; }
        public DateTime DatePublished { get; set; }

        public string ToCSV()
        {
            string str;
            str = string.Format("{0},{1},{2},{3},{4}", Id, ISBN, Author, Name, DatePublished);
            return str;
        }

        public string ToJson()
        {
            string str;
            str = string.Format("Id: {0},ISBN: {1},Aouthor: {2},Name: {3},Date[ublished: {4}", Id, ISBN, Author, Name, DatePublished);
            return str;
        }

        public bool IsNewBindingNeeded()
        {
            return DatePublished.Year < DateTime.Now.AddYears(20).Year;
        }
        public Book FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Book dailyValues = new Book();
            Id = int.Parse(values[0]);
            ISBN = Guid.Parse(values[1]);
            Author =(values[2]);
            Name = (values[3]);
            DatePublished = DateTime.Parse(values[4]);
            return dailyValues;
        }
    }
}