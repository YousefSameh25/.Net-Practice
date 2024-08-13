namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Suppose we have a stream provider and many quality
            // and we want to construct an stream provider object with specific quality.
            // Simply we can add a reference of the interface inside stream provider class -> bridge.
            // this will make us to extend the required class from 2 independent classes (stream provider - Quality).
            // without bridge design pattern -> we will create all possible combinations of the 2 classes
            // ex) stream provider + Quality1, stream provider + Quality2.
            // So there will be an extensibility problem.


            // We can easily now make a different combinations without creating all combinations.
            StreamProvider1 streamProvider = new StreamProvider1(new Quality1());

            StreamProvider1 streamProvider2 = new StreamProvider1(new Quality2());

        }
    }
}
