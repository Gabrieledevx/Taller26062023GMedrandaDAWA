using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller26062023GMedrandaDAWA.Models;

namespace Taller26062023GMedrandaDAWA.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("app1_Migrations.Modelos.Usuario", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<string>("Apellido")
                    .IsRequired()
                    .HasColumnType("VARCHAR(20)");

                b.Property<string>("Dirección")
                    .IsRequired()
                    .HasColumnType("VARCHAR(20)");

                b.Property<string>("Nombre")
                    .IsRequired()
                    .HasColumnType("VARCHAR(20)");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("VARCHAR(10)");

                b.Property<string>("Telefono")
                    .IsRequired()
                    .HasColumnType("VARCHAR(40)");

                b.Property<string>("fechaDeNacimiento")
                    .IsRequired()
                    .HasColumnType("VARCHAR(10)");

                b.HasKey("Id");

                b.ToTable("Usuarios");
            });
#pragma warning restore 612, 618
        }
    }
}