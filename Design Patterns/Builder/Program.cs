namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new NotificationBuilder()
                .SetContent("Hello") // If we miss this parameter we will get an exception!
                .SetTimeStamp("21/7")
                .SetSender("Yousef")
                .SetHasBeenRead(false)
                .Build();

            // Builder pros:
            // 1- Many attributes for a class.
            // 2- Make setting operation more readable.
            // 3- Allow us to validate the attributes before creating the object.
            // 4- Get rid of constructor overloading.
        }
    }
}
