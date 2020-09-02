using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace mail_Gonderme
{
    class MailAdresiKontrolu
    {
        
        public bool MailAdresKontrolu(List<string> emailAdresleri)
        {
            try
            {
                foreach (string emailAdresi in emailAdresleri)
                {
                    MailAddress m = new MailAddress(emailAdresi);
                    return true;
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
