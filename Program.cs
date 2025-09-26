using DIExample.Core;
using DIExample.Services;

class Program
{
    static void Main(string[] args)
    {
        // Choose which service to inject
        IMessageService service = new SmsService(); // or new SmsService()
        Notification notify = new Notification(service);

        notify.Alert("Hello Dependency Injection!");
    }
}
