using System;
using System.Collections.Generic;
using System.IO;
using LeitorCBF.LeitorCSV.Models;

namespace LeitorCBF.LeitorCSV.Repository
{

    public class LeitorCSVModelRepository : ILeitorCSVModelRepository
    {
        public LeitorCSVModelRepository()
        {
        }

        public static (int, int, int, int, int, int) SetColumnsIndex(string[] Columns)
        {
            int indexNomeTimeCasa = 0;
            int indexPlacarTimeCasa = 0;
            int indexNomeTimeVisitante = 0;
            int indexPlacarTimeVisitante = 0;
            int indexRodada = 0;
            int indexDataHoraJogo = 0;
            for (int i = 0; i < Columns.Length; i++)
            {
                if (string.IsNullOrEmpty(Columns[i]))
                    continue;
                if (Columns[i].ToLower() == "nometimecasa")
                    indexPlacarTimeCasa = i;
                if (Columns[i].ToLower() == "placartimecasa")
                    indexPlacarTimeCasa = i;
                if (Columns[i].ToLower() == "nometimevisitante")
                    indexNomeTimeVisitante = i;
                if (Columns[i].ToLower() == "placartimevisitante")
                    indexPlacarTimeVisitante = i;
                if (Columns[i].ToLower() == "rodada")
                    indexRodada = i;
                if (Columns[i].ToLower() == "datahorajogo")
                    indexDataHoraJogo = i;
            }
            return (indexNomeTimeCasa,
                    indexPlacarTimeCasa,
                    indexNomeTimeVisitante,
                    indexPlacarTimeVisitante,
                    indexRodada,
                    indexDataHoraJogo);
        }

        public static List<DadosModel> FazerUmaLeitura(StreamReader reader,
            int indexNomeTimeCasa,
            int indexPlacarTimeCasa,
            int indexNomeTimeVisitante,
            int indexPlacarTimeVisitante,
            int indexRodada,
            int indexDataHoraJogo)
        {
            string line;
            var result = new List<DadosModel>();
            DadosModel dadosModel;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(";");
                dadosModel = new DadosModel();
                if (indexNomeTimeCasa != -1)
                    dadosModel.NomeTimeCasa = values[indexNomeTimeCasa];
                if (indexPlacarTimeCasa != -1)
                    dadosModel.PlacarTimeCasa = Convert.ToInt32(values[indexPlacarTimeCasa]);
                if (indexNomeTimeVisitante != -1)
                    dadosModel.NomeTimeVisitante = values[indexNomeTimeVisitante];
                if (indexPlacarTimeVisitante != -1)
                    dadosModel.PlacarTimeVisitante = Convert.ToInt32(values[indexPlacarTimeVisitante]);
                if (indexRodada != -1)
                    dadosModel.Rodada = Convert.ToInt32(values[indexRodada]);
                if (indexDataHoraJogo != -1)
                    dadosModel.DataHoraJogo = Convert.ToDateTime(values[indexDataHoraJogo]);
                result.Add(dadosModel);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}