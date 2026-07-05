using Microsoft.EntityFrameworkCore;
using TaskManager_Markova.Classes.Database;
using TaskManager_Markova.Models;

namespace TaskManager_Markova.Context
{
	public class TasksContext : DbContext
	{
		public DbSet<Tasks> Tasks { get; set; }
		public TasksContext()
		{
			Database.EnsureCreated();
			Tasks.Load();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
			optionsBuilder.UseMySql(Config.connection, Config.version);
	}
}
