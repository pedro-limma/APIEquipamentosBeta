using FirstApi.Data;
using FirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.ToDoData
{
    public class MockEquipamentoData : IEquipamentoData
    {

        private List<Equipamento> equipamentos = new List<Equipamento>()
        {
            new Equipamento()
            {
                Id = Guid.NewGuid(),
                Nome = "Caixa_Eletrônico_1",
                Tipo = "Caixa Eletrônico"
            },
            new Equipamento()
            {
                Id = Guid.NewGuid(),
                Nome = "Caixa_Eletrônico_2",
                Tipo = "Caixa Eletrônico"
            },
            new Equipamento()
            {
                Id = Guid.NewGuid(),
                Nome = "Caixa_Eletrônico_3",
                Tipo = "Caixa Eletrônico"
            },
        };

        public Equipamento AddEquipamento(Equipamento equipamento)
        {
            equipamento.Id = Guid.NewGuid();
            equipamentos.Add(equipamento);

            return GetEquipamento(equipamento.Id);
        }

        public void DeleteEquipamento(Equipamento equipamento)
        {
            equipamentos.Remove(equipamento);
        }

        public Equipamento EditEquipamento(Equipamento equipamento)
        {
            var equipamentoExistente = GetEquipamento(equipamento.Id);
            equipamentoExistente.Nome = equipamento.Nome;
            equipamentoExistente.Tipo = equipamento.Tipo;
            return equipamentoExistente;
        }

        public Equipamento GetEquipamento(Guid id)
        {
            return equipamentos.SingleOrDefault(x => x.Id == id);
        }

        public List<Equipamento> GetEquipamentos()
        {
            return equipamentos;
        }
    }
}
