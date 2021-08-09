using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ChecaVacina.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ChecaVacina
{
    class Program
    {

        static void Main(string[] args)
        {
            JObject json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText("Appsettings.json"));
            //convertendo o nó "configuration" para navegar no seu objeto
            Pessoa[] config = ((JArray)json["Pessoas"]).ToObject<Pessoa[]>();

            List<Pessoa> pessoas = config.ToList();


            var options = new FirefoxOptions();
            options.PageLoadStrategy = PageLoadStrategy.Normal;
            options.AddArguments("--headless");

            IWebDriver driver = new FirefoxDriver(options);

            driver.Navigate().GoToUrl(@"https://vacinacao.sms.fortaleza.ce.gov.br/pesquisa/agendados");

            pessoas.ForEach(f =>
            {
                var iptNome = driver.FindElement(By.Id("nome"));
                iptNome.Clear();
                iptNome.SendKeys(f.Nome + Keys.Enter);

                //var nome = driver.FindElement(By.CssSelector("#tableGrid tbody tr td")).Text;
                var detalhes = driver.FindElement(By.CssSelector("#tableGrid tbody tr"));

                // transformando objetos em uma lista
                var obj = detalhes.FindElements(By.CssSelector("td")).ToList();


                if (obj.Count == 1)
                {
                    Console.WriteLine(obj[0].Text);
                }
                else
                {
                    var result = obj.TrataDetalhes();
                    Console.WriteLine(result);


                    if (result.Nome == f.Nome)
                    {
                        //ENVIAR E-MAIL
                        Email.EnviarEmail(result, f.Email);
                    }

                }




                //Email.EnviarEmail(Detalhes, "thallys@hotmail.com");
            });


        }
    }
}
