﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("RRHHDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Asistencia2> Asistencias { get; set; }
        public DbSet<Planilla> Planillas { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<Privilegio> Privilegios { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<Egreso> Egresos { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Jornada> Jornadas { get; set; }
        public DbSet<EstadoCivil> EstadoCiviles { get; set; }
        public DbSet<Capacitacion> Capacitaciones { get; set; }
        public DbSet<ExTrabajador> ExTrabajadores { get; set; }
        public DbSet<Vacacion> Vacaciones { get; set; }
        public DbSet<Anticipo> Anticipos { get; set; }
        public DbSet<HoraExtra> HoraExtras { get; set; }

       }
}
