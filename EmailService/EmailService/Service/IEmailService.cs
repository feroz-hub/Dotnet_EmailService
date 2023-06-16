using System;
using Email.Models;

namespace Email.Service
{
    public interface IEmailService
    {
        void SendEmail(EmailModel request);
    }
}

