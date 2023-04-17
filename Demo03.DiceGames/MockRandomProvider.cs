using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.DiceGames
{
	public class MockRandomProvider : IRandomProvider
	{
		private List<int> _numbers = new List<int>();
		private int currentIdx = 0;

		public MockRandomProvider(int value, params int[] others)
		{
			_numbers.Add(value);
			_numbers.AddRange(others);
		}

		public int Next(int min, int max)
		{
			int count = _numbers.Count;

			return _numbers[(currentIdx++ + count) % count];
		}
	}
}
