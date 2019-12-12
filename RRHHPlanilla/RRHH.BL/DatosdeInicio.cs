﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace RRHH.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            //RUTA
            string ruta = @"C:\Users\Kenin\Desktop\Prueba Proyecto L3\RRHHPlanilla\CODIGO DE BARRAS\";


            #region SEXO

            var sexo1 = new Sexo();
            sexo1.Descripcion = "Masculino";
            contexto.Sexos.Add(sexo1);

            var sexo2 = new Sexo();
            sexo2.Descripcion = "Femenino";
            contexto.Sexos.Add(sexo2);


            var sexo3 = new Sexo();
            sexo3.Descripcion = "Otro..";
            contexto.Sexos.Add(sexo3);


            #endregion

            #region PRIVILEGIO
            var privi = new Privilegio();
            privi.Descripcion = "Administrador";
            contexto.Privilegios.Add(privi);

            var privi1 = new Privilegio();
            privi1.Descripcion = "Gerente";
            contexto.Privilegios.Add(privi1);

            var privi2 = new Privilegio();
            privi2.Descripcion = "Supervisor";
            contexto.Privilegios.Add(privi2);
            #endregion

            #region USUARIO
            var usuario1 = new Usuario();

            //SEGURIDAD
            usuario1.NombUsuario = "admin";
            usuario1.Contrasena = "123";
            usuario1.Nombre = "Kevin";
            usuario1.Apellido = "Rivera";
            usuario1.Correo = "prueba1234@gmail.com";
            usuario1.edad = 22;
            usuario1.Foto = null;
            usuario1.FechaInicio = new DateTime(1997, 4, 29);
            usuario1.Cedula = 0512199700879;
            usuario1.PrivilegioId = 1;
            contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();

            //SEGURIDAD
            usuario2.NombUsuario = "gerente";
            usuario2.Contrasena = "123";
            usuario2.Nombre = "German";
            usuario2.Apellido = "No me Acuerdo";
            usuario2.Correo = "prueba1234@gmail.com";
            usuario2.edad = 21;
            usuario2.Foto = null;
            usuario2.FechaInicio = new DateTime(1998, 10, 18);
            usuario2.Cedula = 0512199700666;
            usuario2.PrivilegioId = 2;
            contexto.Usuarios.Add(usuario2);


            var usuario3 = new Usuario();

            //SEGURIDAD
            usuario3.NombUsuario = "super";
            usuario3.Contrasena = "123";
            usuario3.Nombre = "Juan";
            usuario3.Apellido = "Lo mismo";
            usuario3.Correo = "prueba1234@gmail.com";
            usuario3.edad = 22;
            usuario3.Foto = null;
            usuario3.FechaInicio = new DateTime(2002, 12, 9);
            usuario3.Cedula = 0512199700999;
            usuario3.PrivilegioId = 3;
            contexto.Usuarios.Add(usuario3);
            #endregion

            #region CARGO
            var cargo1 = new Cargo();
            cargo1.Descripcion = "Gerente";
            contexto.Cargos.Add(cargo1);

            var cargo2 = new Cargo();
            cargo2.Descripcion = "Supervisor";
            contexto.Cargos.Add(cargo2);

            var cargo3 = new Cargo();
            cargo3.Descripcion = "Operario";
            contexto.Cargos.Add(cargo3);

            var cargo4 = new Cargo();
            cargo4.Descripcion = "Mantenimiento";
            contexto.Cargos.Add(cargo4);
            #endregion

            #region METODO PAGO

            var metodopago1 = new MetodoPago();
            metodopago1.Descripcion = "Mensual";
            contexto.MetodoPagos.Add(metodopago1);

            var metodopago2 = new MetodoPago();
            metodopago2.Descripcion = "Quincenal";
            contexto.MetodoPagos.Add(metodopago2);

            var metodopago3 = new MetodoPago();
            metodopago3.Descripcion = "Semanal";
            contexto.MetodoPagos.Add(metodopago3);

            var metodopago4 = new MetodoPago();
            metodopago4.Descripcion = "Diario";
            contexto.MetodoPagos.Add(metodopago4);
            #endregion

            #region EGRESOS E INGRESOS

            var egresos1 = new Egreso();
            egresos1.Descripcion = "IHSS";
            contexto.Egresos.Add(egresos1);

            var egresos2 = new Egreso();
            egresos2.Descripcion = "RAP";
            contexto.Egresos.Add(egresos2);

            var egresos3 = new Egreso();
            egresos3.Descripcion = "ISR";
            contexto.Egresos.Add(egresos3);

            var egresos4 = new Egreso();
            egresos4.Descripcion = "ADELANTO";
            contexto.Egresos.Add(egresos4);

            var egresos5 = new Egreso();
            egresos5.Descripcion = "PRESTAMO";
            contexto.Egresos.Add(egresos5);

            var egresos6 = new Egreso();
            egresos6.Descripcion = "COOPERATIVA";
            contexto.Egresos.Add(egresos6);

            var egresos7 = new Egreso();
            egresos7.Descripcion = "FONDO DE PENSIONES";
            contexto.Egresos.Add(egresos7);

            var Ingresos1 = new Ingreso();
            Ingresos1.Descripcion = "Bonos";
            contexto.Ingresos.Add(Ingresos1);

            var Ingresos2 = new Ingreso();
            Ingresos2.Descripcion = "Horas Extras";
            contexto.Ingresos.Add(Ingresos2);

            #endregion

            #region JORNADA

            var jornada1 = new Jornada();
            jornada1.Descripcion = "Diurno";
            contexto.Jornadas.Add(jornada1);

            var jornada2 = new Jornada();
            jornada2.Descripcion = "Nocturno";
            contexto.Jornadas.Add(jornada2);

            var jornada3 = new Jornada();
            jornada3.Descripcion = "Mixto";
            contexto.Jornadas.Add(jornada3);
            #endregion

            #region ESTADO CIVIL
            var estado1 = new EstadoCivil();
            estado1.Descripcion = "Soltero";
            contexto.EstadoCiviles.Add(estado1);

            var estado2 = new EstadoCivil();
            estado2.Descripcion = "Casado";
            contexto.EstadoCiviles.Add(estado2);

            var estado3 = new EstadoCivil();
            estado3.Descripcion = "Divorciado";
            contexto.EstadoCiviles.Add(estado3);

            var estado4 = new EstadoCivil();
            estado4.Descripcion = "Viudo";
            contexto.EstadoCiviles.Add(estado4);
            #endregion

            #region EMPLEADOS
            var trabajador1 = new Trabajador();
            trabajador1.Nombre = "Kevin";
            trabajador1.Apellido = "Amaya";
            trabajador1.Edad = 21;
            trabajador1.Sexo = sexo1;
            trabajador1.Sueldo = 25000;
            trabajador1.Direccion = "Unah vs";
            trabajador1.EstadoCivilId = 2;
            trabajador1.CargoId = 1;
            trabajador1.MetodoPagoId = 1;
            trabajador1.JornadaId = 1;
            trabajador1.FechaInicio = new DateTime(2002, 4, 21) ;
            trabajador1.Cedula = 0512199700999;
            trabajador1.DisponibleDia = 20;

            var imagen1 = Image.FromFile(ruta + "1.png");
            trabajador1.CodigoBarras = imageToByteArray(imagen1);

            contexto.Trabajadores.Add(trabajador1);


            var trabajador2 = new Trabajador();
            trabajador2.Nombre = "German";
            trabajador2.Apellido = "Mendoza";
            trabajador2.Edad = 21;
            trabajador2.Sexo = sexo1;
            trabajador2.Sueldo = 25000;
            trabajador2.Direccion = "Unah vs";
            trabajador2.EstadoCivilId = 1;
            trabajador2.CargoId = 1;
            trabajador2.MetodoPagoId = 1;
            trabajador2.JornadaId = 1;
            trabajador2.FechaInicio = new DateTime(2002, 8, 20);
            trabajador2.Cedula = 0512199754885;
            trabajador2.DisponibleDia = 20;

            var imagen2 = Image.FromFile(ruta + "2.png");
            trabajador2.CodigoBarras = imageToByteArray(imagen2);

            contexto.Trabajadores.Add(trabajador2);

            var trabajador3 = new Trabajador();
            trabajador3.Nombre = "Juan";
            trabajador3.Apellido = "Alvarado";
            trabajador3.Edad = 24;
            trabajador3.Sexo = sexo1;
            trabajador3.Sueldo = 25000;
            trabajador3.Direccion = "Unah vs";
            trabajador3.EstadoCivilId = 1;
            trabajador3.CargoId = 1;
            trabajador3.MetodoPagoId = 1;
            trabajador3.JornadaId = 1;
            trabajador3.FechaInicio = new DateTime(2007, 1, 14);
            trabajador3.Cedula = 0512199778999;
            trabajador3.DisponibleDia = 20;

            var imagen3 = Image.FromFile(ruta + "3.png");
            trabajador3.CodigoBarras = imageToByteArray(imagen3);

            contexto.Trabajadores.Add(trabajador3);

            var trabajador4 = new Trabajador();
            trabajador4.Nombre = "Luis";
            trabajador4.Apellido = "Lopez";
            trabajador4.Edad = 45;
            trabajador4.Sexo = sexo1;
            trabajador4.Sueldo = 25000;
            trabajador4.Direccion = "Unah vs";
            trabajador4.EstadoCivilId = 1;
            trabajador4.CargoId = 1;
            trabajador4.MetodoPagoId = 1;
            trabajador4.JornadaId = 1;
            trabajador4.FechaInicio = new DateTime(2010, 11, 11);
            trabajador4.Cedula = 0512199707899;
            trabajador4.DisponibleDia = 20;

            var imagen4 = Image.FromFile(ruta + "4.png");
            trabajador4.CodigoBarras = imageToByteArray(imagen4);

            contexto.Trabajadores.Add(trabajador4);

            var trabajador5 = new Trabajador();
            trabajador5.Nombre = "Ariana";
            trabajador5.Apellido = "Mendoza";
            trabajador5.Edad = 26;
            trabajador5.Sexo = sexo2;
            trabajador5.Sueldo = 15000;
            trabajador5.Direccion = "Unah vs";
            trabajador5.EstadoCivilId = 1;
            trabajador5.CargoId = 2;
            trabajador5.MetodoPagoId = 1;
            trabajador5.JornadaId = 1;
            trabajador5.FechaInicio = new DateTime(1999, 6, 16);
            trabajador5.Cedula = 0512199499999;
            trabajador5.DisponibleDia = 20;

            var imagen5 = Image.FromFile(ruta + "5.png");
            trabajador5.CodigoBarras = imageToByteArray(imagen5);

            contexto.Trabajadores.Add(trabajador5);

            var trabajador6 = new Trabajador();
            trabajador6.Nombre = "Maria";
            trabajador6.Apellido = "Alvarez";
            trabajador6.Edad = 27;
            trabajador6.Sexo = sexo2;
            trabajador6.Sueldo = 12000;
            trabajador6.Direccion = "Unah vs";
            trabajador6.EstadoCivilId = 1;
            trabajador6.CargoId = 3;
            trabajador6.MetodoPagoId = 1;
            trabajador6.JornadaId = 2;
            trabajador6.FechaInicio = new DateTime(2018, 2, 14);
            trabajador6.Cedula = 0812199714999;
            trabajador6.DisponibleDia = 10;

            var imagen6 = Image.FromFile(ruta + "6.png");
            trabajador6.CodigoBarras = imageToByteArray(imagen6);

            contexto.Trabajadores.Add(trabajador6);


            var trabajador7 = new Trabajador();
            trabajador7.Nombre = "Doris";
            trabajador7.Apellido = "Perez";
            trabajador7.Edad = 26;
            trabajador7.Sexo = sexo3;
            trabajador7.Sueldo = 9800;
            trabajador7.Direccion = "Unah vs";
            trabajador7.EstadoCivilId = 1;
            trabajador7.CargoId = 4;
            trabajador7.MetodoPagoId = 1;
            trabajador7.JornadaId = 2;
            trabajador7.FechaInicio = new DateTime(2012, 7, 30);
            trabajador7.Cedula = 0912199712989;
            trabajador7.DisponibleDia = 20;

            var imagen7 = Image.FromFile(ruta + "7.png");
            trabajador7.CodigoBarras = imageToByteArray(imagen7);

            contexto.Trabajadores.Add(trabajador7);



            #endregion

            #region CAPACITACION
            var capacitacion1 = new Capacitacion();
            capacitacion1.Tema = "Manejo de Conflictos";
            capacitacion1.Horas = "12";
            capacitacion1.Poblacion = "San Pedro Sula";
            capacitacion1.Personal = "German Mendoza y Kevin Amaya";
            capacitacion1.Fecha = "10-Noviembre";
            capacitacion1.Horario = "1:30 Pm a 5:00Pm";
            capacitacion1.Modalidad = "Presencial";
            capacitacion1.Proveedor = "CCIC";
            capacitacion1.Lugar = "CCIC";
            capacitacion1.Presupuesto = "Membresia";
            capacitacion1.Status = "Impartido";
            contexto.Capacitaciones.Add(capacitacion1);

            var capacitacion2 = new Capacitacion();
            capacitacion2.Tema = "Manejo del Personal";
            capacitacion2.Horas = "8";
            capacitacion2.Poblacion = "San Pedro Sula";
            capacitacion2.Personal = "Ariana Mendoza";
            capacitacion2.Fecha = "20-Noviembre";
            capacitacion2.Horario = "1:30 Pm a 5:00Pm";
            capacitacion2.Modalidad = "Presencial";
            capacitacion2.Proveedor = "CCIC";
            capacitacion2.Lugar = "CCIC";
            capacitacion2.Presupuesto = "Membresia";
            capacitacion2.Status = "En Proceso";
            contexto.Capacitaciones.Add(capacitacion2);

            var capacitacion3 = new Capacitacion();
            capacitacion3.Tema = "Manejo del Personal";
            capacitacion3.Horas = "12";
            capacitacion3.Poblacion = "San Pedro Sula";
            capacitacion3.Personal = "Luis Lopez";
            capacitacion3.Fecha = "20-Noviembre";
            capacitacion3.Horario = "1:30 Pm a 5:00Pm";
            capacitacion3.Modalidad = "Presencial";
            capacitacion3.Proveedor = "FUNDAHRSE";
            capacitacion3.Lugar = "Hotel Honduras";
            capacitacion3.Presupuesto = "Membresia";
            capacitacion3.Status = "En Proceso";
            contexto.Capacitaciones.Add(capacitacion3);

            #endregion

            #region ExEmpleados

            //var Extrabajador1 = new ExTrabajador();
            //Extrabajador1.Nombre = "Hector";
            //Extrabajador1.Apellido = "Acosta";
            ////Extrabajador1.Edad = 39;
            ////Extrabajador1.Sexo = sexo1;
            //Extrabajador1.Sueldo = 15000;
            ////Extrabajador1.Direccion = "Unah vs";
            ////Extrabajador1.EstadoCivilId = 2;
            //Extrabajador1.CargoId = 3;
            //Extrabajador1.MetodoPagoId = 1;
            //Extrabajador1.JornadaId = 1;
            //Extrabajador1.FechaInicio = new DateTime(2005, 4, 21);
            //Extrabajador1.Cedula = 0512199700999;
            //Extrabajador1.FechaFinal = new DateTime(2018, 4, 21);
            //Extrabajador1.Motivo = "Restructuracion";
            //Extrabajador1.SueldoMensual = 17500;
            //Extrabajador1.SueldoDiario = 583;
            //Extrabajador1.Preaviso = 1166;
            //Extrabajador1.Cesantia = 227500;
            //Extrabajador1.CesantiaPro = 0;
            //Extrabajador1.Vacaciones = 0;
            //Extrabajador1.TotalPrestaciones = 228666;
            //contexto.ExTrabajadores.Add(Extrabajador1);

            //var Extrabajador2 = new ExTrabajador();
            //Extrabajador2.Nombre = "Roberto";
            //Extrabajador2.Apellido = "Mendez";
            ////Extrabajador2.Edad = 37;
            ////Extrabajador2.Sexo = sexo1;
            //Extrabajador2.Sueldo = 15000;
            ////Extrabajador2.Direccion = "Unah vs";
            ////Extrabajador2.EstadoCivilId = 1;
            //Extrabajador2.CargoId = 3;
            //Extrabajador2.MetodoPagoId = 1;
            //Extrabajador2.JornadaId = 1;
            //Extrabajador2.FechaInicio = new DateTime(2005, 4, 21);
            //Extrabajador2.Cedula = 0512199700997;
            //Extrabajador2.FechaFinal = new DateTime(2018, 4, 21);
            //Extrabajador2.Motivo = "Restructuracion";
            //Extrabajador2.SueldoMensual = 17500;
            //Extrabajador2.SueldoDiario = 583;
            //Extrabajador2.Preaviso = 1166;
            //Extrabajador2.Cesantia = 227500;
            //Extrabajador2.CesantiaPro = 0;
            //Extrabajador2.Vacaciones = 0;
            //Extrabajador2.TotalPrestaciones = 228666;
            //contexto.ExTrabajadores.Add(Extrabajador2);

            //var Extrabajador3 = new ExTrabajador();
            //Extrabajador3.Nombre = "Christiano";
            //Extrabajador3.Apellido = "Ronaldo";
            ////Extrabajador3.Edad = 35;
            ////Extrabajador3.Sexo = sexo1;
            //Extrabajador3.Sueldo = 15000;
            ////Extrabajador3.Direccion = "Unah vs";
            ////Extrabajador3.EstadoCivilId = 2;
            //Extrabajador3.CargoId = 3;
            //Extrabajador3.MetodoPagoId = 1;
            //Extrabajador3.JornadaId = 1;
            //Extrabajador3.FechaInicio = new DateTime(2005, 4, 21);
            //Extrabajador3.Cedula = 0512199700997;
            //Extrabajador3.FechaFinal = new DateTime(2018, 4, 21);
            //Extrabajador3.Motivo = "Restructuracion";
            //Extrabajador3.SueldoMensual = 17500;
            //Extrabajador3.SueldoDiario = 583;
            //Extrabajador3.Preaviso = 1166;
            //Extrabajador3.Cesantia = 227500;
            //Extrabajador3.CesantiaPro = 0;
            //Extrabajador3.Vacaciones = 0;
            //Extrabajador3.TotalPrestaciones = 228666;
            //contexto.ExTrabajadores.Add(Extrabajador3);




            #endregion

            #region Vacaciones

            var Vacacion1 = new Vacacion();
                 Vacacion1.Nombre = "Juanito";
                 Vacacion1.Disponible = 15;
                 Vacacion1.Obtenido = 5;
                 Vacacion1.Iniciavacacion = new DateTime(2019, 4, 11);
                 Vacacion1.Finalizavacacion = new DateTime(2019, 4, 15);
                 Vacacion1.Pago = 4860;
                 Vacacion1.TrabajadorId = 2;
                 contexto.Vacaciones.Add(Vacacion1);

                 var Vacacion2 = new Vacacion();
                 Vacacion2.Nombre = "German";
                 Vacacion2.Disponible = 15;
                 Vacacion2.Obtenido = 5;
                 Vacacion2.Iniciavacacion = new DateTime(2019, 5, 23);
                 Vacacion2.Finalizavacacion = new DateTime(2019, 5, 27);
                 Vacacion2.Pago = 4860;
                 Vacacion2.TrabajadorId = 1;
                 contexto.Vacaciones.Add(Vacacion2);

                 var Vacacion3 = new Vacacion();
                 Vacacion3.Nombre = "Luisito";
                 Vacacion3.Disponible = 10;
                 Vacacion3.Obtenido = 5;
                 Vacacion3.Iniciavacacion = new DateTime(2019, 6, 3);
                 Vacacion3.Finalizavacacion = new DateTime(2019, 6, 7);
                 Vacacion3.Pago = 4860;
                 Vacacion3.TrabajadorId = 3;
                 contexto.Vacaciones.Add(Vacacion3);


                 //var Vacacion4 = new Vacacion();
                 //Vacacion4.Disponible = 5;
                 //Vacacion4.Obtenido = 5;
                 //Vacacion4.Iniciavacacion = new DateTime(2019, 5, 23);
                 //Vacacion4.Finalizavacacion = new DateTime(2019, 5, 27);
                 //Vacacion4.Pago = 4860;
                 //Vacacion4.TrabajadorId = 4;
                 //contexto.Vacaciones.Add(Vacacion4);

                 //var Vacacion5 = new Vacacion();
                 //Vacacion5.Disponible = 15;
                 //Vacacion5.Obtenido = 5;
                 //Vacacion5.Iniciavacacion = new DateTime(2019, 8, 23);
                 //Vacacion5.Finalizavacacion = new DateTime(2019, 8, 27);
                 //Vacacion5.Pago = 2915;
                 //Vacacion5.TrabajadorId = 5;
                 //contexto.Vacaciones.Add(Vacacion5);

                 //var Vacacion6 = new Vacacion();
                 //Vacacion6.Disponible = 5;
                 //Vacacion6.Obtenido = 5;
                 //Vacacion6.Iniciavacacion = new DateTime(2019, 8, 23);
                 //Vacacion6.Finalizavacacion = new DateTime(2019, 8, 27);
                 //Vacacion6.Pago = 2330;
                 //Vacacion6.TrabajadorId = 6;
                 //contexto.Vacaciones.Add(Vacacion6);

                 //var Vacacion7 = new Vacacion();
                 //Vacacion7.Disponible = 5;
                 //Vacacion7.Obtenido = 5;
                 //Vacacion7.Iniciavacacion = new DateTime(2019, 11, 18);
                 //Vacacion7.Finalizavacacion = new DateTime(2019, 11, 22);
                 //Vacacion7.Pago = 1905;
                 //Vacacion7.TrabajadorId = 7;
                 //contexto.Vacaciones.Add(Vacacion7);


            #endregion
            
          
    
            base.Seed(contexto);
        }

        public byte[] imageToByteArray(Image ImageIn)
        {
            MemoryStream ms = new MemoryStream();
            ImageIn.Save(ms, ImageIn.RawFormat);

            return ms.ToArray();
        }
    }
}
