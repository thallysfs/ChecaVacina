using System;
using System.Collections.Generic;
using System.Text;

namespace ChecaVacina
{
    public class Agendamento
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string Dose { get; set; }


        public override string ToString()
        {
            return $"Nome:{Nome } \n Data de Nascimento: {DataNascimento:dd/MM/yyyy} \n Local: {Local} \n Data: {Data:dd/MM/yyyy} \n Hora: {Hora:HH:mm} Dose: {Dose}";
        }
    }
}
