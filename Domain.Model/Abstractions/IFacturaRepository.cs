﻿using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface IFacturaRepository
    {
        int GenerarFactura(Factura OBJfactura);
    }
}
