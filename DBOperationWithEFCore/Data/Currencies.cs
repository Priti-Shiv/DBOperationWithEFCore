namespace DBOperationWithEFCore.Data
{
    public class Currencies
    {

        public int Id { get; set; }
        public string tittle { get; set; }
        public string Description { get; set; }

        public ICollection<BookPrices> bookPrices { get; set; }
    }
}
