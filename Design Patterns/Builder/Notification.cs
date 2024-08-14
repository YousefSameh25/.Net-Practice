using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Notification
    {
        public string Content { get; set; }
        public string Sender { get; set; }
        public string TimeStamp { get; set; }
        public bool HasBeenRead { get; set; }


        public Notification(NotificationBuilder notificationBuilder)
        {
            Content = notificationBuilder.Content;
            Sender = notificationBuilder.Sender;
            TimeStamp = notificationBuilder.TimeStamp;
            HasBeenRead = true;
        }
    }
}
