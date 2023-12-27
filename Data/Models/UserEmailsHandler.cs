using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tescatlipoca.Data.Models
{
    public class EmailManager
    {
        public List<EmailAccount> EmailAccounts { get; private set; } = new List<EmailAccount>();

        public void AddEmailAccount(string email, string password)
        {
            if (EmailAccounts.Count < 3)
            {
                EmailAccounts.Add(new EmailAccount { Email = email, Password = password });
            }
        }

        public void RemoveEmailAccount(EmailAccount account)
        {
            EmailAccounts.Remove(account);
        }
    }
    
      
    public class EmailAccount
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

}
