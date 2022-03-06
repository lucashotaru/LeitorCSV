using System.Collections.Generic;
using LeitorCBF.LeitorCSV.Repository;

namespace LeitorCBF.LeitorCSV.CBFDataService
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly ICBFRepository cbfRepository;

        public DataService(ApplicationContext contexto, ICBFRepository cbfRepository)
        {
            this.contexto = contexto;
            this.cbfRepository = cbfRepository;
        }

        public void IncicializaDB()
        {
            contexto.Database.EnsureCreated();
            List<Models.DadosModel> dados = GetDadosCSV();
            cbfRepository.SaveBancoCSV(dados);
        }

        private static List<Models.DadosModel> GetDadosCSV()
        {
            var dadosJogos = new LeitorCSVModel();
            var dados = dadosJogos.GETDadosJogo();
            return dados;
        }
    }
}
