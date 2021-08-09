using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ChecaVacina.Entity;

namespace ChecaVacina
{
    public static class Email
    {

        public static void EnviarEmail(Agendamento mensagem, string remetente)
        {
            //lendo arquivo json e convertendo em obj
            JObject json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText("Appsettings.json"));
            //convertendo o nó "configuration" para navegar no seu objeto
            Configuration config = ((JObject)json["Configuration"]).ToObject<Configuration>();
            //Console.WriteLine($"Teste Password: {config.Password}");

            //variáveis
            string password = config.Password;
            string from = "aviso@fomedeescrever.com.br";
            string smtp = config.Smtp;
            int port = config.Port;

            string to = remetente;
            string fromName = "Aviso Vacina";
            string subject = "Sua Vacina está marcada!";

            string body =
                "<h1>Sua vacina foi marcada! Segue Dados: </h1>"  +
                $"{mensagem.Nome}, sua vacina está marcada para:<br/>" +
                $"{mensagem.Data:dd/MM/yyyy} às {mensagem.Hora:HH:mm} <br/>" +
                $"Local:  {mensagem.Local} <br/>" +
                "<h2> viva o SUS  </h2> <br/>" +
                "<a href='http://fomedeescrever.com.br/'>Fome de Escrever</a>";
                

            //configurações do e-mail
            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(from, fromName);
            message.To.Add(new MailAddress(to));
            message.Subject = subject;
            message.Body = body;


            using (var client = new System.Net.Mail.SmtpClient(smtp, port))
            {
                //credenciais
                client.Credentials = new NetworkCredential(from, password);

                //encriptação
                client.EnableSsl = false;

                //enviando mensagem
                try
                {
                    client.Send(message);
                    Console.WriteLine("Email enviado!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("The email was not sent.");
                    Console.WriteLine("Error message: " + e.Message);
                }
            }


        }
    }
}

