namespace Entities.Concrete.Dtos
{
    public class CustomerDto
    {

        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyWebAddress { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerEMail { get; set; }
        public string CompanyWorkSpace { get; set; }
        public int ProductId { get; set; }
        public DateTime BuyProductDate { get; set; }
        public int LicenseTime { get; set; }
        public DateTime EndProductDate { get; set; }
        public int Price { get; set; }
        public string Note { get; set; }
        public string Version { get; set; }

    }
}
