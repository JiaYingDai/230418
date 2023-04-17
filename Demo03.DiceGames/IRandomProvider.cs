using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.DiceGames
{
	public interface IRandomProvider
	{
		/// <summary>
		/// 傳回大於等於min, 小於 max的亂數
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		int Next(int min, int max);
	}
}
