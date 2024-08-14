using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // This class can be an inner class inside Notification class.
    public class NotificationBuilder
    {
        // We can disable overriding of fields by making them readonly.
        public string Content { get; private set; }

        public NotificationBuilder SetContent(string value)
        {
            Content = value;
            return this;
        }

        public string Sender { get; private set; }
        public NotificationBuilder SetSender(string value)
        {
            Sender = value;
            return this;
        }

        public string TimeStamp { get; private set; }
        public NotificationBuilder SetTimeStamp(string value)
        {
            TimeStamp = value;
            return this;
        }

        public bool HasBeenRead { get; private set; }
        public NotificationBuilder SetHasBeenRead(bool value)
        {
            HasBeenRead = value;
            return this;
        }

        public Notification Build()
        {
            // Validate the attributes.
            if (Content is null)
                throw new MissingFieldException();

            return new Notification(this);
        }
    }
}
