using DIOSeries.ConsoleApp.Interfaces;
using System.Collections.Generic;

namespace DIOSeries.ConsoleApp.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();

        public void Atualizar(int id, Serie entity)
        {
            listaSeries[id] = entity;
        }

        public Serie ConsultarPorId(int id)
        {
            return listaSeries[id];
        }

        public void Excluir(int id)
        {
            listaSeries[id].Inativar();
        }

        public void Inserir(Serie entity)
        {
            listaSeries.Add(entity);
        }

        public int RetornarProximoId()
        {
            return listaSeries.Count;
        }

        public List<Serie> Listar()
        {
            return listaSeries;
        }
    }
}
