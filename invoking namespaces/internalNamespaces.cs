namespace invoking_namespaces
{
    public class innerBankAccount
    {
        public innerBankAccount() { Console.WriteLine("inner Bank acc is created"); }
        int Id { get; set; }
        public int AccountNumber { get; set; }
    }

}
