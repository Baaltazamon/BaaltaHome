using System;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    public class Command : ICommand
    {
		private readonly Action<object> execute;
		private readonly Predicate<object> canExecute;

		public Command(Action<object> execute) : this(execute, null)
		{
		}

		public Command(Action<object> Execute, Predicate<object> CanExecute = null)
		{
			this.execute = Execute;
			this.canExecute = CanExecute;
		}

		public bool CanExecute(object parameter)
		{
			return canExecute?.Invoke(parameter) ?? true;
		}

		public void Execute(object parameter)
		{
			execute?.Invoke(parameter);
		}

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}
	}
}
