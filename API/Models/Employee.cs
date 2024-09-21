namespace Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName {  get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string TitleOfCourtesy { get; set; } = string.Empty;

        public DateTime DateBirth {  get; set; }

        public DateTime DateHire { get; set; }

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int MgrId { get; set; }
    }
}
