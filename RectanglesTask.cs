using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		public static bool AreSegmentsIntersected(int r1_1, int r2_1, int r1_2, int r2_2)
		{
			return Math.Max(r1_1, r2_1) <= Math.Min(r1_2, r2_2);
		}

		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			return AreSegmentsIntersected(r1.Left, r2.Left, r1.Right, r2.Right) && AreSegmentsIntersected(r1.Top, r2.Top, r1.Bottom, r2.Bottom);
		}

		public static int SegmentLength(int r1_1, int r2_1, int r1_2, int r2_2)
		{
			return Math.Min(r1_1, r2_1) - Math.Max(r1_2, r2_2);
		}

		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			if (AreIntersected(r1, r2))
				return SegmentLength(r1.Right, r2.Right, r1.Left, r2.Left) * SegmentLength(r1.Bottom, r2.Bottom, r1.Top, r2.Top);
			return 0;
		}

		public static bool IsInserted(Rectangle r1, Rectangle r2)
		{
			return r1.Left >= r2.Left && r1.Top >= r2.Top && r1.Right <= r2.Right && r1.Bottom <= r2.Bottom;
		}

		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (IsInserted(r1, r2))
				return 0;
			else if (IsInserted(r2, r1))
				return 1;
			return -1;
		}
	}
}