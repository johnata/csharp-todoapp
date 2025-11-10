using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Services;

using (var context = new AppDbContext())
{
    context.Database.Migrate();
}

var service = new TarefaService();

while (true)
{
    Console.WriteLine("\n--- Menu de Tarefas ---");
    Console.WriteLine("1 - Criar Tarefa");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Concluir Tarefa");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Título: ");
            var titulo = Console.ReadLine()!;
            Console.Write("Descrição: ");
            var descricao = Console.ReadLine()!;
            service.CriarTarefa(titulo, descricao);
            break;
        case "2":
            service.ListarTarefas();
            break;
        case "3":
            Console.Write("ID da tarefa: ");
            var id = int.Parse(Console.ReadLine()!);
            service.ConcluirTarefa(id);
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}