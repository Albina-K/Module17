namespace FactoryMethodRealExample
{
    class Program
    {
        static void Main(string[] args) 
        {
            string messageText = "Ваш номер заказа - 83456";

            //отправляем заказ по смс
            MessageSender sender = new SmsMessageSender("5747839364");
            Message smsMessage = sender.Send(messageText);

            //отправляем заказ по емаил
            sender = new EmailMessageSender("fhgjf@vfjrfjr.com");
            Message message = sender.Send(messageText);
    }
}
