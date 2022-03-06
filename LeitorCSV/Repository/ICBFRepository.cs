using System.Collections.Generic;
using LeitorCBF.LeitorCSV.Models;

namespace LeitorCBF.LeitorCSV.Repository
{
    public interface ICBFRepository
    {
        void SaveBancoCSV(List<DadosModel> dados);
    }
}