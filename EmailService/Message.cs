using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace EmailService
{
    public class Message(IEnumerable<string> to, string subject, string content)
    {
        public List<MailboxAddress> To { get; set; } = [.. to.Select(x => new MailboxAddress(string.Empty, x))];
        public string Subject { get; set; } = subject;
        public string Content { get; set; } = content;
    }
}
