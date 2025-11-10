using ToDoApp.Models;
using ToDoApp.Repositories;

namespace ToDoApp.Services
{
    internal class TarefaService
    {
        private readonly TarefaRepository _repo = new();

        public void CriarTarefa(string titulo, string descricao)
        {
            var tarefa = new Tarefa { Titulo = titulo, Descricao = descricao };
            _repo.Adicionar(tarefa);
        }

        public void ListarTarefas()
        {
            var tarefas = _repo.Listar();
            foreach (var t in tarefas)
                Console.WriteLine($"{t.Id} - {t.Titulo} ({t.Status})");
        }

        public void ConcluirTarefa(int id)
        {
            var tarefa = _repo.BuscarPorId(id);
            if (tarefa != null)
            {
                tarefa.Status = "Concluída";
                _repo.Atualizar(tarefa);
            }
        }
    }
}
