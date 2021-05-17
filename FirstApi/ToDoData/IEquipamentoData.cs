using FirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Data
{
    public interface IEquipamentoData
    {
        List<Equipamento> GetEquipamentos();

        Equipamento GetEquipamento(Guid id);

        Equipamento AddEquipamento(Equipamento equipamento);

        void DeleteEquipamento(Equipamento equipamento);

        Equipamento EditEquipamento(Equipamento equipamento);

    }
}
