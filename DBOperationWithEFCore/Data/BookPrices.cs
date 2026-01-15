namespace DBOperationWithEFCore.Data
{
    public class BookPrices
    {
        public int id { get; set; }
        public int bookid { get; set; }
        public int currencyid { get; set; }
        public double Amount { get; set; }
        public Book Books { get; set; }
        public Currencies Currencies { get; set; }
    }
}
