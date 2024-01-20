﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProyectoFinal_.Migrations
{
    [DbContext(typeof(ProyectoFinal_Context))]
    [Migration("20240120011130_ProyectoFinal")]
    partial class ProyectoFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoFinal_.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoID"), 1L, 1);

                    b.Property<string>("CargoEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EdadEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SedeID")
                        .HasColumnType("int");

                    b.Property<decimal>("SueldoEmpleado")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmpleadoID");

                    b.HasIndex("SedeID");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("ProyectoFinal_.Models.Sede", b =>
                {
                    b.Property<int>("SedeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SedeID"), 1L, 1);

                    b.Property<string>("NombreCiudad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SedeID");

                    b.ToTable("Sede");
                });

            modelBuilder.Entity("ProyectoFinal_.Models.Empleado", b =>
                {
                    b.HasOne("ProyectoFinal_.Models.Sede", "sede")
                        .WithMany("Empleados")
                        .HasForeignKey("SedeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sede");
                });

            modelBuilder.Entity("ProyectoFinal_.Models.Sede", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}