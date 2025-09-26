using DIExample.Services;

namespace DIExample.Core;

public class Notification
{
    private readonly IMessageService _messageService;

    // dependency is injected via constructor
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Alert(string message)
    {
        _messageService.SendMessage(message);
    }
}
