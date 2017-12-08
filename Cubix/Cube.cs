using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubix
{
	public class Cube
	{
		public Cube()
		{

		}

		public Cube(CubixBuilder builder)
		{
			Front = new Face(builder.FrontColor);
			Up = new Face(builder.UpColor);
			Right = new Face(builder.RightColor);
			Back = new Face(builder.BackColor);
			Left = new Face(builder.LeftColor);
			Down = new Face(builder.DownColor);

			Front.Corners = new List<Corner>(){
			new Corner(){
			Colors = new List<CubixColor>(){
			
			}
			}
			}
		}

		public Face Front { get; set; }

		public Face Up { get; set; }

		public Face Right { get; set; }

		public Face Back { get; set; }

		public Face Left { get; set; }

		public Face Down { get; set; }
	}

	public class Face
	{
		public Face(CubixColor faceColor)
		{
			Center = new Center()
			{
				Colors = new List<CubixColor>()
				{
					faceColor
				}
			};
		}

		public Face()
		{

		}
		public Center Center { get; set; }

		public List<Corner> Corners { get; set; }

		public List<Edge> Edges { get; set; }

		public CubixColor Color
		{
			get
			{
				return Center.Colors.First();
			}
		}
	}

	public class Edge : Piece
	{

	}

	public class Corner : Piece
	{

	}

	public class Center : Piece
	{

	}

	public abstract class Piece
	{
		public List<CubixColor> Colors { get; set; }
	}

	public enum CubixColor
	{
		White, Green, Blue, Yellow, Orange, Red
	}

	public class CubixBuilder
	{
		public CubixColor FrontColor { get; set; }

		public CubixColor UpColor { get; set; }

		public CubixColor RightColor { get; set; }

		public CubixColor BackColor { get; set; }

		public CubixColor LeftColor { get; set; }

		public CubixColor DownColor { get; set; }
	}
}
