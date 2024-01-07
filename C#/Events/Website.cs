using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class AdditionalData : EventArgs // For standardization
    {
        public string Journalist { get; set; }
        public string Data { get; set; }
    }
    internal class Website
    {
        public event Action<object, EventArgs> users;

        // Fire event.
        public void AddNews(string data)
        {
            if (users != null)
                users.Invoke(this, new AdditionalData { Journalist = "Yousef", Data = data });
        }

        // Will use event instead
        //public void Subscribe(Action<string> user)
        //{
        //    users += user;
        //}

    }
}
