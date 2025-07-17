using Dependancy_Injection.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
 
namespace Dependancy_Injection.Services
{
    public class EmailNotification:INotification
    {
        public string send(string to,string message)
        {
            return($"{message} send successfully to {to}");
        }
    }
}
