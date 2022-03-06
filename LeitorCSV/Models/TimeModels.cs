using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LeitorCBF.LeitorCSV.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Rodadas : BaseModel
    {
        [Required]
        public string NomeTimeCasa { get; private set; }
        [Required]
        public int PlacarTimeCasa { get; private set; }
        [Required]
        public string NomeTimeVisitante { get; private set; }
        [Required]
        public int PlacarTimeVisitante { get; private set; }
        [Required]
        public int Rodada { get; set; }
        [Required]
        public DateTime DataHoraJogo { get; set; }
        
        public Rodadas()
        {

        }

        public Rodadas(string nomeTimeCasa, int placarTimeCasa, string nomeTimeVisitante, int placarTimeVisitante, int rodada, DateTime dataHoraJogo)
        {
            this.NomeTimeCasa = nomeTimeCasa;
            this.PlacarTimeCasa = placarTimeCasa;
            this.NomeTimeVisitante = nomeTimeVisitante;
            this.PlacarTimeVisitante = placarTimeVisitante;
            this.Rodada = rodada;
            this.DataHoraJogo = dataHoraJogo;
        }
    }
}