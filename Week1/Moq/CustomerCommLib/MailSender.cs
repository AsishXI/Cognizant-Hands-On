using System;

namespace CustomerCommLib
{
    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            Console.WriteLine($"Mail sent to {toAddress}");

            return true;
        }
    }
}