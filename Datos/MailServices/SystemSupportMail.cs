using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.MailServices
{
    public class SystemSupportMail: MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "emailpruebasp@gmail.com";
            password = "pruebas de programacion";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
