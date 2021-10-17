﻿using OOPAssignment.Interfaces;

namespace OOPAssignment.Classes
{
	public class CarCommandExecutorBase
	{
		protected readonly ICarCommand CarCommand;

		public CarCommandExecutorBase(ICarCommand carCommand)
		{
			CarCommand = carCommand;
		}
	}
}
