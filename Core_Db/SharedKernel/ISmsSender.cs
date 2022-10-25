using System.Collections.Generic;
using System.Threading.Tasks;
namespace PSafe.Core.SharedKernel
{
    public interface ISmsSender
    {
        Task SendSmsAsync(List<string> phoneNumbers, string message);
        Task SendSmsAsync(List<string> phoneNumbers, string title, string message);
    }
}
