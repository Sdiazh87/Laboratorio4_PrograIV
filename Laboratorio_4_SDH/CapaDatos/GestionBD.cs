using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GestionBD
    {
        List<Facturas> listadoFacturas;

        public List<Facturas> listadoFacturero()
        {
            listadoFacturas = new List<Facturas>();
            Facturas objFactura = new Facturas();
            objFactura.IdFactura = 1;
            objFactura.numLinea = 2;
            objFactura.codProducto = "A101";
            objFactura.detProducto = "Camiseta";
            objFactura.cantProducto = 5;
            objFactura.costUnitario = 1500;
            objFactura.totalLinea = 7500.00;
            listadoFacturas.Add(objFactura);

            objFactura = new Facturas()
            {
                IdFactura = 2,
                numLinea = 6,
                codProducto = "A102",
                detProducto = "Pantalon",
                cantProducto = 3,
                costUnitario = 2465.65,
                totalLinea = 7396.95
            };
            listadoFacturas.Add(objFactura);

            objFactura = new Facturas()
            {
                IdFactura = 3,
                numLinea = 1,
                codProducto = "A103",
                detProducto = "Sueter",
                cantProducto = 1,
                costUnitario = 12550.50,
                totalLinea = 12550.50
            };
            listadoFacturas.Add(objFactura);

            objFactura = new Facturas()
            {
                IdFactura = 4,
                numLinea = 10,
                codProducto = "A104",
                detProducto = "Medias",
                cantProducto = 10,
                costUnitario = 835.60,
                totalLinea = 8356.00
            };
            listadoFacturas.Add(objFactura);

            return listadoFacturas;
        }

    }
}
