using System.Collections.Generic;

namespace OOPAssignment.Interfaces
{
	public interface IObserver<T> where T : class
	{
		void Update(T provider);
		List<T> GetObservables();
	}
}
