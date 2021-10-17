using OOPAssignment.Interfaces;
using System;

namespace OOPAssignment.Classes
{
	public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
	{
		public CarStringCommandExecutor(ICarCommand command) : base(command)
		{

		}

		public void ExecuteCommand(string commandObject)
		{
			if (string.IsNullOrEmpty(commandObject))
				throw new Exception();

			foreach (var letter in commandObject)
			{
				if (letter != 'L' && letter != 'R' && letter != 'M')
					throw new Exception();
			}

			for (int i = 0; i < commandObject.Length; i++)
			{
				switch (commandObject[i])
				{
					case 'L':
						CarCommand.TurnLeft();
						break;
					case 'R':
						CarCommand.TurnRight();
						break;
					case 'M':
						CarCommand.Move();
						break;
				}
			}
		}
	}
}
