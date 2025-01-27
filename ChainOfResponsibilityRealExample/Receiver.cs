﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealExample
{
    /// <summary>
    /// получаетель уведомлений
    /// </summary>
    class Receiver
    {
        //банковские переводы
        public bool EmailNotification { get; set; }

        //денежные переводы-WesternUnion? Unistream
        public bool SmsNotification { get; set; }

        //перевод через PayPal
        public bool VoiceNotification { get; set; }
        public Receiver(bool emailNotification, bool smsNotification, bool voiceNotification)
        {
            EmailNotification = emailNotification;
            SmsNotification = smsNotification;
            VoiceNotification = voiceNotification;
        }
    }
}
