using Microsoft.AspNetCore.Components.Web;

namespace Xplor_Excercise.Data
{
    public class Customer
    {
        public string Id { get; set; }
        public string Salutation { get; set; }
        public string Initials { get; set; }
        public string FirstName { get; set; }
        public string FirstName_Ascii { get; set; }
        public string Gender { get; set; }
        public string FirstName_Country_Rank { get; set; }
        public string FirstName_Country_Frequency { get; set; }
        public string LastName { get; set; }
        public string LastName_Ascii { get; set; }
        public string LastName_Country_Rank { get; set; }
        public string LastName_Country_Frequency { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country_Code { get; set; }
        public string Country_Code_Alpha { get; set; }
        public string Country_Name { get; set; }
        public string Primary_Language_Code { get; set; }
        public string Primary_Language { get; set; }
        public decimal Balance { get; set; }
        public string Phone_Number { get; set; }
        public string Currency { get; set; }

    }
}
