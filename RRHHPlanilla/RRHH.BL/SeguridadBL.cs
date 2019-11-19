using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class SeguridadBL
    {
        #region Inicializar Lista
        Contexto _contexto;
        public BindingList<Usuario> ListaSeguridad { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaSeguridad = new BindingList<Usuario>();
        }
        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexto.Trabajadores.Load();

            ListaSeguridad = _contexto.Usuarios.Local.ToBindingList();
            return ListaSeguridad;
        }

        #endregion

        // GUARDAD
        public Resultado3 GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        //CANCELAR CAMBIOS
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        //AGREGAR
        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            ListaSeguridad.Add(nuevoUsuario);
        }

        //ELIMINAR
        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaSeguridad)
            {
                if (usuario.Id == id)
                {
                    ListaSeguridad.Remove(usuario);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        //VALIDACION
        private Resultado3 Validar(Usuario usuario )
        {
            var resultado = new Resultado3();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(usuario.NombUsuario) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese una contraseña";
            }

            return resultado;
        }


        #region Autorizacion

        public bool Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.NombUsuario && contrasena == usuarioDB.Contrasena)
                {
                    return true;
                }
            }

            return false;
        }
    }

    #endregion

    public class Usuario
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int edad { get; set; }
        public string FechaInicio { get; set; }
        public int Cedula { get; set; }

        //SEGURIDAD
        public string NombUsuario { get; set; }
        public string Contrasena { get; set; }
        public Privilegios TipoUsuario { get; set; }

        public string contrasena1 { get; set; }
        public string contrasena2 { get; set; }
    }

    public class Resultado3
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

    public class Privilegios
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
    }
}