namespace MobilePhoneRegistrationMVC.Models
{
    public class PhoneRegistration
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public string InsuranceProvider { get; set; }
    }
}
