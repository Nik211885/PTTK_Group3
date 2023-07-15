using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Win32.SafeHandles;
using MimeKit;
using Org.BouncyCastle.Bcpg.Sig;

namespace Group3.Method
{
    public static class MailServer
    {
        public static async Task SendEmail(string name,string formEmail,string code)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("MyCafe", "khacninh2020@gmail.com"));
            message.To.Add(new MailboxAddress($"{name}", $"{formEmail}"));
            message.Subject = "Xác thực tài khoản của bạn";
                message.Body = new TextPart("plain")
                {
                    Text = $@"Xin chào {name}
                        Chúng tôi đã nhận được yêu cầu của bạn hãy nhập mã này để hoàn tất quá trình
                        Mã xác minh:{code}

                        Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi 
                        Mycafe"
                };
            await Task.Run(() => {

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {

                    client.Connect("smtp.gmail.com", 587);

                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    client.Authenticate("klnta2318@gmail.com", "jdyhldnpbhjzroaq");

                    client.Send(message);

                    client.Disconnect(true);
                }
            });

        }
    }
}
