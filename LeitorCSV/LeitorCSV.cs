using System;
using System.Collections.Generic;
using System.IO;
using LeitorCBF.LeitorCSV.Models;

namespace LeitorCBF.LeitorCSV.Repository
{
    public class LeitorCSVModel
    {
        public LeitorCSVModel()
        {
        }

        public List<DadosModel> GETDadosJogo()
        {

            var path = @"C:\cbfInfo.csv";
            var result = new List<DadosModel>();

            using (var reader = new StreamReader(File.OpenRead(path)))
           {
                var line = reader.ReadLine();
                var columns = line.Split(";");
                (int indexNomeTimeCasa,
                int indexPlacarTimeCasa,
                int indexNomeTimeVisitante,
                int indexPlacarTimeVisitante,
                int indexRodada,
                int indexDataHoraJogo) = LeitorCSVModelRepository.SetColumnsIndex(columns);

                result = LeitorCSVModelRepository.FazerUmaLeitura(reader,
                    indexNomeTimeCasa,
                    indexPlacarTimeCasa,
                    indexNomeTimeVisitante,
                    indexPlacarTimeVisitante,
                    indexRodada,
                    indexDataHoraJogo);
            } 
            return result;
        }
    }
}