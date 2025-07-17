using Dependancy_Injection.Interfaces;

namespace Dependancy_Injection.Services
{
    public class SmsNotification:INotification
    {
        public string send(string to, string message)
        {
            return $"sms {message} has been sent to {to}";
        }
    }
}
