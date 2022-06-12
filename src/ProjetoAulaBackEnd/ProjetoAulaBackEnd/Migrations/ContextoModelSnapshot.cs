﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAulaBackEnd.Models;

#nullable disable

namespace ProjetoAulaBackEnd.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Hospede", b =>
                {
                    b.Property<int>("IdHospede")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHospede"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdHospede");

                    b.ToTable("Hospede", (string)null);
                });

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Imovel", b =>
                {
                    b.Property<int>("IdImovel")
                        .HasColumnType("int");

                    b.Property<bool>("Academia")
                        .HasColumnType("bit");

                    b.Property<bool>("ArCondicionado")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CheckIn")
                        .HasColumnType("int");

                    b.Property<int>("CheckOut")
                        .HasColumnType("int");

                    b.Property<bool>("Churrasqueira")
                        .HasColumnType("bit");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cozinha")
                        .HasColumnType("bit");

                    b.Property<int>("DesativarImovel")
                        .HasColumnType("int");

                    b.Property<int>("DispImovel")
                        .HasColumnType("int");

                    b.Property<int>("DistanciaPraia")
                        .HasColumnType("int");

                    b.Property<bool>("DuchaExterna")
                        .HasColumnType("bit");

                    b.Property<bool>("Elevador")
                        .HasColumnType("bit");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estacionamento")
                        .HasColumnType("bit");

                    b.Property<string>("Foto1")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Foto2")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Foto3")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Foto4")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("Jogos")
                        .HasColumnType("bit");

                    b.Property<bool>("Lareira")
                        .HasColumnType("bit");

                    b.Property<bool>("MaquinaLavar")
                        .HasColumnType("bit");

                    b.Property<bool>("PET")
                        .HasColumnType("bit");

                    b.Property<bool>("Patio")
                        .HasColumnType("bit");

                    b.Property<bool>("Piscina")
                        .HasColumnType("bit");

                    b.Property<int>("QtdeBanheiros")
                        .HasColumnType("int");

                    b.Property<int>("QtdeCamas")
                        .HasColumnType("int");

                    b.Property<int>("QtdeHospedes")
                        .HasColumnType("int");

                    b.Property<int>("QtdeQuartos")
                        .HasColumnType("int");

                    b.Property<bool>("Rampa")
                        .HasColumnType("bit");

                    b.Property<bool>("Sauna")
                        .HasColumnType("bit");

                    b.Property<bool>("Suite")
                        .HasColumnType("bit");

                    b.Property<int>("TipoAc")
                        .HasColumnType("int");

                    b.Property<int>("TipoEsp")
                        .HasColumnType("int");

                    b.Property<int>("ValorDiaria")
                        .HasColumnType("int");

                    b.Property<bool>("VistaMar")
                        .HasColumnType("bit");

                    b.Property<bool>("WiFi")
                        .HasColumnType("bit");

                    b.HasKey("IdImovel");

                    b.ToTable("Imovel", (string)null);
                });

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Imovel", b =>
                {
                    b.HasOne("ProjetoAulaBackEnd.Models.Hospede", "IdHospede")
                        .WithMany("Imoveis")
                        .HasForeignKey("IdImovel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdHospede");
                });

            modelBuilder.Entity("ProjetoAulaBackEnd.Models.Hospede", b =>
                {
                    b.Navigation("Imoveis");
                });
#pragma warning restore 612, 618
        }
    }
}
