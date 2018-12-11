using FarmaBot.DomainModel.Medicamentos;
using FarmaBot.DomainModel.Sintomas;
using System.Collections.Generic;

namespace FarmaBot.DomainModel
{
    public class InMemoryDatabase
    {
        public static List<Medicamento> Medicamentos;

        public static List<Sintoma> Sintomas;

        public static void InitData()
        {
            Medicamentos = new List<Medicamento>
            {
                new Medicamento
                {
                    Id = 1,
                    Nome = "Advil",
                    Preco = 10.90m,
                    Tags = new List<string>
                    {
                        "dor de cabeca",
                        "febre",
                        "exanqueca",
                        "cefaleia"
                    }
                },
                new Medicamento
                {
                    Id = 2,
                    Nome = "Tylenol",
                    Preco = 11.00m,
                    Tags = new List<string>
                    {
                        "dor de cabeca",
                        "febre",
                        "exanqueca",
                        "dor no corpo",
                        "resfriado",
                        "cefaleia"
                    }
                },
                new Medicamento
                {
                    Id = 3,
                    Nome = "Neosaldina",
                    Preco = 9.80m,
                    Tags = new List<string>
                    {
                        "dor de cabeca",
                        "exanqueca",
                        "colica",
                        "dor de barriga",
                        "cefaleia",
                        "gases"
                    }
                },
                new Medicamento
                {
                    Id = 4,
                    Nome = "Paracetamol",
                    Preco = 10.90m,
                    Tags = new List<string>
                    {
                        "dor de dente",
                        "dor nas costas",
                        "dores musculares",
                        "dor no corpo",
                        "artrite"
                    }
                },
                new Medicamento
                {
                    Id = 5,
                    Nome = "Dipirona",
                    Preco = 10.90m,
                    Tags = new List<string>
                    {
                        "dores musculares",
                        "dor no corpo",
                        "febre"
                    }
                },
                new Medicamento
                {
                    Id = 6,
                    Nome = "Buscopan",
                    Preco = 10.90m,
                    Tags = new List<string>
                    {
                        "colica",
                        "dor de barriga",
                        "febre",
                        "gases"
                    }
                },
                new Medicamento
                {
                    Id = 7,
                    Nome = "Diazepam",
                    Preco = 8.89m,
                    Tags = new List<string>
                    {
                        "ansiedade"
                    }
                },
                new Medicamento
                {
                    Id = 8,
                    Nome = "Hixizine",
                    Preco = 20.10m,
                    Tags = new List<string>
                    {
                        "coceira",
                        "alergia",
                        "urticaria"
                    }
                },
                new Medicamento
                {
                    Id = 9,
                    Nome = "Lorazepam",
                    Preco = 15.90m,
                    Tags = new List<string>
                    {
                        "coceira",
                        "alergia",
                        "urticaria"
                    }
                },
                new Medicamento
                {
                    Id = 10,
                    Nome = "Benalet",
                    Preco = 5.20m,
                    Tags = new List<string>
                    {
                        "tosse",
                        "dor de garganta"
                    }
                },
                new Medicamento
                {
                    Id = 11,
                    Nome = "Flogoral",
                    Preco = 4.42m,
                    Tags = new List<string>
                    {
                        "tosse",
                        "dor de garganta"
                    }
                }
            };

            /*Sintomas = new List<Sintoma>
            {
                new Sintoma
                {
                    Id = 1,
                    Descricao = "Dor de cabeça",
                    Medicamentos = new List<Medicamento>
                    {
                        new Medicamento
                        {
                            Id = 1,
                            Nome = "Advil",
                            Preco = 10_90
                        },
                        new Medicamento
                        {
                            Id = 2,
                            Nome = "Tylenol",
                            Preco = 11_00
                        },
                        new Medicamento
                        {
                            Id = 3,
                            Nome = "Neosaldina",
                            Preco = 9_80
                        }
                    }
                },

                new Sintoma
                {
                    Id = 2,
                    Descricao = "Dor de dente",
                    Medicamentos = new List<Medicamento>
                    {
                        new Medicamento
                        {
                            Id = 4,
                            Nome = "Paracetamol",
                            Preco = 10_90
                        },
                        new Medicamento
                        {
                            Id = 5,
                            Nome = "Dipirona",
                            Preco = 10_90
                        },
                        new Medicamento
                        {
                            Id = 6,
                            Nome = "Nimesulida",
                            Preco = 10_90
                        }
                    }
                },

                new Sintoma
                {
                    Id = 3,
                    Descricao = "Ansiedade",
                    Medicamentos = new List<Medicamento>
                    {
                        new Medicamento
                        {
                            Id = 6,
                            Nome = "Diazepam",
                            Preco = 30_20
                        },
                        new Medicamento
                        {
                            Id = 8,
                            Nome = "Hixizine",
                            Preco = 20_10
                        },
                        new Medicamento
                        {
                            Id = 9,
                            Nome = "Lorazepam",
                            Preco = 15_90
                        }
                    }
                },
            };*/
        }
    }
}
