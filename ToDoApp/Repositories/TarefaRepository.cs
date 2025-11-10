using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    internal class TarefaRepository
    {
        private readonly AppDbContext _context = new();

        public void Adicionar(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }

        public List<Tarefa> Listar() => _context.Tarefas.ToList();

        public Tarefa? BuscarPorId(int id) => _context.Tarefas.FirstOrDefault(t => t.Id == id);

        public void Atualizar(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var tarefa = BuscarPorId(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                _context.SaveChanges();
            }
        }
    }
}
