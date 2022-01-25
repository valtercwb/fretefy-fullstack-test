﻿// <auto-generated />
using System;
using Fretefy.Test.Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20220125062727_create_regiao_regiaocidade")]
    partial class create_regiao_regiaocidade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75ddcc89-6034-45d8-814f-261d6f65f93e"),
                            Nome = "Rio Branco",
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("0c35fe01-748b-473d-bb99-ad49512dfc8c"),
                            Nome = "Maceió",
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("6f72443f-5422-479c-8ea2-cbd7cbef01c2"),
                            Nome = "Macapá",
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("6df285fc-1773-4de4-9acc-fbe865cc384b"),
                            Nome = "Manaus",
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("2923ff5e-9ba2-4c80-a779-d55d59f5f812"),
                            Nome = "Salvador",
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("1c93edd0-8f7b-4923-af0e-59f13274c1cf"),
                            Nome = "Fortaleza",
                            UF = " CE"
                        },
                        new
                        {
                            Id = new Guid("a76f276e-8985-4038-b3cc-4e362691465d"),
                            Nome = "Brasília",
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("4c7f58de-064c-426f-832b-1c50740f9754"),
                            Nome = "Vitória",
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("26e1b6f8-64ea-4992-8684-e65daf7ca77b"),
                            Nome = "Goiânia",
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("737cb14d-6142-4555-8d79-e1c1a4e9f0a7"),
                            Nome = "São Luís",
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("30619f40-fcb9-41ca-82b8-416f82846610"),
                            Nome = "Cuiabá",
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("15023a90-82dc-44f9-a004-b368e54fc10f"),
                            Nome = "Campo Grande",
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("5d90932f-9012-4e5f-bcb3-9feef2b3e475"),
                            Nome = "Belo Horizonte",
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("b20ba361-d62c-4fc0-acd8-8759d6804f9d"),
                            Nome = "Belém",
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("78147108-26cc-4699-8e0e-00cc2110de77"),
                            Nome = "João Pessoa",
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("756f1a95-f21f-465d-abe7-d15c2f8881ea"),
                            Nome = "Curitiba",
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("d5630038-54e9-4d98-8be5-7f45ec4650f7"),
                            Nome = "Recife",
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("cfefc1bc-89ff-4cf7-84f2-91281cf63360"),
                            Nome = "Teresina",
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("4013f3ab-24a0-4cba-9b9d-245f188d370b"),
                            Nome = "Rio de Janeiro",
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("36533ef1-fc47-479d-ba7c-a65ddda08eb9"),
                            Nome = "Natal",
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("509e6eb1-1de6-4055-9035-7f6816666535"),
                            Nome = "Porto Alegre",
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("184ee1d3-3620-487b-8436-7c26b7927190"),
                            Nome = "Porto Velho",
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("48a518d2-e848-420c-8dec-8defe48dd140"),
                            Nome = "Boa Vista",
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("8f27362b-495d-45c7-9fdd-c0de5bdd2f31"),
                            Nome = "Florianópolis",
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("50474484-9a31-4e54-9075-4d13299c4ad1"),
                            Nome = "São Paulo",
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("eddfac12-c833-49ff-8206-bf2bf32ffc4f"),
                            Nome = "Aracaju",
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("b3c80a8c-58a7-4a59-8c4c-0619c5a29e9f"),
                            Nome = "Palmas",
                            UF = "TO"
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Regiao");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.RegiaoCidade", b =>
                {
                    b.Property<Guid>("RegiaoId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CidadeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("RegiaoId", "CidadeId");

                    b.HasIndex("CidadeId");

                    b.ToTable("RegiaoCidade");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.RegiaoCidade", b =>
                {
                    b.HasOne("Fretefy.Test.Domain.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fretefy.Test.Domain.Entities.Regiao", "Regiao")
                        .WithMany("Cidades")
                        .HasForeignKey("RegiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Regiao");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}