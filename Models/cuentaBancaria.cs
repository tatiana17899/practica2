using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace practica2.Models
{
    [Table("t_cuenta_bancaria")]
    public class cuentaBancaria
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long Id { get; set; }
      public string? Titular { get; set; }
      public string? TipoCuenta { get; set; }
      public decimal SaldoInicial { get; set; }
      public string? Correo { get; set; }  
    }
}