using System.Collections.ObjectModel;
using TaskManager_Markova.Classes;
using TaskManager_Markova.Context;
using TaskManager_Markova.Models;

namespace TaskManager_Markova.ViewModels
{
	public class VM_Tasks : Notification
	{
		public TasksContext tasksContext = new TasksContext();
		public ObservableCollection<Tasks> Tasks { get; set; }
		public VM_Tasks() =>
			Tasks = new ObservableCollection<Tasks>(tasksContext.Tasks.OrderBy(x => x.Done));
		public RealyCommand OnAddTask
		{
			get
			{
				return new RealyCommand(obj =>
				{
					Tasks NewTask = new Tasks()
					{
						DateExecute = DateTime.Now
					};
					Tasks.Add(NewTask);
					tasksContext.Tasks.Add(NewTask);
					tasksContext.SaveChanges();
				});
			}
		}
	}
}
