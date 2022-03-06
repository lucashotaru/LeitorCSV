using System;

namespace LeitorCBF.LeitorCSV.Models
{
    public class DadosModel
    {
        public string NomeTimeCasa { get; set; }
        public int PlacarTimeCasa { get; set; }
        public string NomeTimeVisitante { get; set; }
        public int PlacarTimeVisitante { get; set; }
        public int Rodada { get; set; }
        public DateTime DataHoraJogo { get; set; }
    }
}