﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Voucher
    {
        public string CodigoVoucher { get; set; }
        public int IdCliente { get; set; }
        public DateTime Date { get; set; }
        public int IdArticulo { get; set; }

    }
}
