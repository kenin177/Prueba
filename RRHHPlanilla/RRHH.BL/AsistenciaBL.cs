using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class AsistenciaBL
    {
        Contexto _contexto;
        public BindingList<Asistencia2> ListaAsistencia { get; set; }

        public AsistenciaBL()
        {
            _contexto = new Contexto();
            ListaAsistencia = new BindingList<Asistencia2>();
        }


        public BindingList<Asistencia2> ObtenerAsistencia()
        {
            _contexto.Asistencias.Load();

            ListaAsistencia = _contexto.Asistencias.Local.ToBindingList();
            return ListaAsistencia;
        }

        public Asistencia2 ObtenerAsistencia(int asistenciaid)
        {
            return _contexto.Asistencias.FirstOrDefault(r => r.Id == asistenciaid);
        }

        public Resultado GuardaAsistencias(Asistencia2 Asistencia)
        {
            var resultado = Validar(Asistencia);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public BindingList<Asistencia2> ObtenerAsistencia2(string buscar1)
        {
            var query = _contexto.Asistencias.

                Where(p => p.Nombre.ToLower().Contains(buscar1.ToLower()) == true 
                || p.FechaEntrada.ToString().Contains(null) == true
                ).ToList();


            var resultado = new BindingList<Asistencia2>(query);

            return resultado;

        }

        public void AgregarAsistencia()
        {
            var nuevaAsistencia = new Asistencia2();
            ListaAsistencia.Add(nuevaAsistencia);
        }


        public bool EliminarAsistencia(int id)
        {
            foreach (var asistencia in ListaAsistencia)
            {
                if (asistencia.Id == id)
                {
                    ListaAsistencia.Remove(asistencia);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;

        }
        private Resultado Validar(Asistencia2 asistencia)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (asistencia == null)
            {
                resultado.Mensaje = "Agregar una Asistencia";
                resultado.Exitoso = false;
            }

            //if (asistencia.FechaEntrada == null)
            //{
            //    //resultado.Mensaje = "Ingrese vacaciones disponibles";
            //    resultado.Exitoso = false;
            //}

            return resultado;
        }
    }

    public class Asistencia2
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public string Jornada { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
