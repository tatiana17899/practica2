using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica2.Models;

namespace practica2.ViewModel
{
    public class CuentaBancariaViewModel
    {
        public cuentaBancaria? FormCuentaBancaria { get; set; }
        public List<cuentaBancaria>? ListarCuentaBancaria { get; set; }
    }
}