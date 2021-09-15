using System.Collections.Generic;

namespace DIOSeries.ConsoleApp.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Listar();
        T ConsultarPorId(int id);
        void Inserir(T entity);
        void Excluir(int id);
        void Atualizar(int id, T entity);
        int RetornarProximoId();
    }
}
