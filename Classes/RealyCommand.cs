using System.Windows.Input;

namespace TaskManager_Markova.Classes
{
	public class RealyCommand : ICommand
	{
		private Action<object> execute;
		private Func<object, bool> canExecute;
		public RealyCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}
		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}
			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}
		public bool CanExecute(object parametr)
		{
			return this.CanExecute == null || this.CanExecute(parametr);
		}
		public void Execute(object parametr) =>
			this.execute(parametr);
	}
}
