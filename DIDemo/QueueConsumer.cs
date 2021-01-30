namespace DIDemo
{
    public class QueueConsumer
    {
        private QueueService _queueService;
        public QueueConsumer(QueueService queueService)
        {
            _queueService = queueService;
        }

        public void print()
        {
            _queueService.print();
        }
    }
}
