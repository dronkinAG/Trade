namespace TradeApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public int Category { get; set; }
        public byte State { get; set; }
        public byte Order { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Passport { get; set; }
        public string Comment { get; set; }
        public User()
        {

        }
    }
}
