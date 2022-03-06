using System.Collections.Generic;
using LeitorCBF.LeitorCSV.Models;

namespace LeitorCBF.LeitorCSV.Repository
{
    public class CBFRepository : ICBFRepository
    {
        private readonly ApplicationContext contexto;

        public CBFRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void SaveBancoCSV(List<Models.DadosModel> dados)
        {
            foreach (var dado in dados)
            {
                contexto.Set<Rodadas>().Add(new Rodadas(dado.NomeTimeCasa,
                                                        dado.PlacarTimeCasa,
                                                        dado.NomeTimeVisitante,
                                                        dado.PlacarTimeVisitante,
                                                        dado.Rodada,
                                                        dado.DataHoraJogo));
            }
            contexto.SaveChanges();
        }
    }
}