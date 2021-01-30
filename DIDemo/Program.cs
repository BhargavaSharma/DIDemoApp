namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var _queueService = (QueueService)Activator.CreateInstance(typeof(QueueService));
            //var _queueConsumer = (QueueConsumer)Activator.CreateInstance(typeof(QueueConsumer),_queueService);
            //_queueConsumer.print();

            var container = new DependencyContainer();
            container.AddDependencies<QueueService>();
            container.AddDependencies<QueueConsumer>();


            var resolver = new DependencyResolver(container);
            var consumer = resolver.GetService<QueueConsumer>();
            consumer.print();
        }
    }
}
