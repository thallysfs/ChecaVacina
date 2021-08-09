using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ChecaVacina
{
    public static class DetalhesVacina
    {
        // this extende o método a classe IWebElement
        public static Agendamento TrataDetalhes(this List<IWebElement> detalhes)
        {
            Agendamento result = new Agendamento() {
                Nome = detalhes[0].Text,
                DataNascimento = Convert.ToDateTime(detalhes[1].Text, new CultureInfo("pt-BR")),
                Local = detalhes[2].Text,
                Data = Convert.ToDateTime(detalhes[3].Text, new CultureInfo("pt-BR")),
                Hora = Convert.ToDateTime(detalhes[4].Text, new CultureInfo("pt-BR")),
                Dose = detalhes[5].Text

             };

            return result;

        }
    }
}
