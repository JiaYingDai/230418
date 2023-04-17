using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.DiceGames
{
	/// <summary>
	/// 骰子遊戲的介面
	/// </summary>
	public interface IDiceGame
	{
		/// <summary>
		/// 遊戲名稱
		/// </summary>
		string Title { get; }

		/// <summary>
		/// 完成(玩)一局新遊戲
		/// </summary>
		void Play();

		/// <summary>
		/// 計算總點數, 預設是所有骰子點數之和, 子類別可視需要覆寫
		/// </summary>
		/// <returns></returns>
		int ComputePoints();

		/// <summary>
		/// 傳回單一遊戲的詳細資訊
		/// </summary>
		/// <returns></returns>
		string GetInformation();

		/// <summary>
		/// 清空骰子
		/// </summary>
		void EmptyDices();
	}
}
