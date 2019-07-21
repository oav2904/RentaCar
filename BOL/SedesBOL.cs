﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BOL
{
    public class SedesBOL
    {
        private SedesDAL sedal = new SedesDAL();
        public void Guardar(Sedes sedes)
        {

            Validar(sedes);

            if (sedes.ID > 0)
            {
                //sedal.Actualizar(sedes);
            }
            else
            {
                //sedal.Insertar(sedes);

            }

        }


        public void Eliminar(Cliente sedes)
        {
            if (sedes.ID <= 0 || sedes == null)
            {
                throw new Exception("Seleccione una sedes");
            }
           // sedal.Eliminar(sedes);
        }

        public void Validar(Sedes sedes)
        {
            if (sedes == null)
            {
                throw new Exception("Seleccione una sede");
            }

            if (string.IsNullOrWhiteSpace(sedes.Nombre))
            {
                throw new Exception("Ingrese un nombre para la sede");
            }
            if (string.IsNullOrWhiteSpace(sedes.Ciudad))
            {
                throw new Exception("Ingrese una ciudad para la sede");
            }
            if (string.IsNullOrWhiteSpace(sedes.Canton))
            {
                throw new Exception("Ingrese un canton para la sede");
            }
            if (string.IsNullOrWhiteSpace(sedes.Provincia))
            {
                throw new Exception("Ingrese una provincia para la sede");
            }
            if (string.IsNullOrWhiteSpace(sedes.Pais))
            {
                throw new Exception("Ingrese un país para la sede");
            }
            if (string.IsNullOrWhiteSpace(sedes.Nombre))
            {
                throw new Exception("Ingrese un nombre para la sede");
            }
        }
    }
}
