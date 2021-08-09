using System;
using System.Collections.Generic;
using System.Text;

namespace ChecaVacina.Entity
{
    class Configuration
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Smtp { get; set; }
        public int Port { get; set; }
    }
}
