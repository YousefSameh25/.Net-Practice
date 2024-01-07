namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Publisher.
            Website ws = new Website();

            // Subscriber.
            Person p1 = new Person { Name = "Yousef" };
            Person p2 = new Person { Name = "Amona" };
            Magazine m1 = new Magazine { Name = "Al7or" };
            Magazine m2 = new Magazine { Name = "Egypt" };

            // That means p1, p2, m1, m2 have been subscribed.
            ws.users += p1.GetNotification;
            ws.users += p2.GetNotification;

            ws.users += m1.GetNotificationForMagazine;
            ws.users += m2.GetNotificationForMagazine;

            // ws.users = m1; event will disable this operation.
            // ws.users = null; event will disable this operation.

            ws.AddNews("I really miss competitive programming.");
        }
    }
}
