using OOPAssignment.Structs;

namespace OOPAssignment.Interfaces
{
	public interface ISurface
	{
		long Width { get; }
		long Height { get; }
		bool IsCoordinatesInBounds(Coordinates coordinates);
	}
}
