using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BOL
{
    public class FacturaBOL
    {
        private FacturaDAL fadao = new FacturaDAL();

        public void Guardar(Factura factura)
        {

            Validar(factura);

            if (factura.ID > 0)
            {
               // fadao.Actualizar(factura);
            }
            else
            {
                //fadao.Insertar(factura);

            }

        }


        public void Eliminar(Cliente factura)
        {
            if (factura.ID <= 0 || factura == null)
            {
                throw new Exception("Seleccione una factura");
            }
            //fadao.Eliminar(factura);
        }

        public void Validar( Factura factura)
        {
            if(factura == null)
            {
                throw new Exception("Seleccione una factura");
            }

            if (factura.Cliente == 0)
            {
                throw new Exception("Seleccione un cliente");
            }

            if (factura.Vehiculo == 0)
            {
                throw new Exception("Seleccione un vehiculo");
            }

            if (factura.Costo == 0)
            {
                throw new Exception("El costo de la factura no puede ser menor o igual a 0");
            }

        }

    }
}
