namespace OOPAssignment.Interfaces
{
	public interface ICommand<T> where T : class
	{
		void ExecuteCommand(T commandObject);
	}
}
