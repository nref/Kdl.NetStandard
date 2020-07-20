#pragma once
#include "../src/frames.hpp"

namespace KDL
{
	class Property
	{
	public:
		static double get(Frame& f, int i, int j)
		{
			return f(i, j);
		}

		static void set(Rotation& r, int i, int j, double value)
		{
			r(i, j) = value;
		}

		static double get(Rotation& r, int i, int j)
		{
			return r(i, j);
		}
	};

}