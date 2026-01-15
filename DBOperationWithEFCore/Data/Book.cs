namespace DBOperationWithEFCore.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string tittle { get; set; }
        public string Description { get; set; }
        public int NoOfpages { get; set; }
        public bool IsActive { get; set; }
        public int languageId { get; set; }
        public Language Languages { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
