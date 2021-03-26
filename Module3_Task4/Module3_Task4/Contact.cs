namespace Module3_Task4
{
    public class Contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string FullName => $"{LastName} {FirstName}";
    }
}
