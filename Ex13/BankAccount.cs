
namespace Ex13 {
    public class BankAccount {
        public string Name {get; set;}
        public long AccountNumber {get; set;}
        public double TotalBalance {get; set;}

        public BankAccount(string name, long accountNumber, double totalBalance) {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.TotalBalance = totalBalance;
        }

        public string AccountAsString() {
            return $"Account: [{this.Name},{this.AccountNumber},{this.TotalBalance}]";
        }
    }
}