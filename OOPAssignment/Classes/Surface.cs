using OOPAssignment.Interfaces;
using OOPAssignment.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPAssignment.Classes
{
	public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
	{
		long _width;
		long _height;
		private readonly List<CarInfo> ObservableCars = new List<CarInfo>();

		public Surface(long width, long height)
		{
			_width = width;
			_height = height;
		}

		public long Width => _width;
		public long Height => _height;

		public List<CarInfo> GetObservables()
		{
			List<CarInfo> list = new List<CarInfo>();
			if (ObservableCars != null)
			{
				foreach (var item in ObservableCars)
					list.Add(item);
			}
			return list;
		}

		public bool IsCoordinatesEmpty(Coordinates coordinates)
		{
			if (ObservableCars != null)
			{
				foreach (var car in ObservableCars)
				{
					if (car.Coordinates.X == coordinates.X && car.Coordinates.Y == coordinates.Y)
						return false;
				}
			}
			return true;
		}

		public bool IsCoordinatesInBounds(Coordinates coordinates)
		{
			if (coordinates.X > Height || coordinates.Y > Width)
				return false;

			return true;
		}

		public void Update(CarInfo provider)
		{
			var result = GetObservables();
			if (result.Contains(provider))
			{
				var car = ObservableCars.FirstOrDefault(x => x.CarId == provider.CarId);
				car.Coordinates = provider.Coordinates;
			}

			else if (IsCoordinatesEmpty(provider.Coordinates))
				ObservableCars.Add(provider);
			else
			{
				var car = ObservableCars.FirstOrDefault(x => x.CarId == provider.CarId);
				if (car.Coordinates.X == provider.Coordinates.X && car.Coordinates.Y == provider.Coordinates.Y)
					throw new Exception();
				else
					ObservableCars.Add(provider);
			}

		}

	}
}
