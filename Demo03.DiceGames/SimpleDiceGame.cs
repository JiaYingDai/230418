using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.DiceGames
{
	public class SimpleDiceGame : BaseDiceGame
	{
		public SimpleDiceGame() : base("單顆骰子遊戲") { }

		public override void Play()
		{
			_dices.Add(Dice.Roll());
		}

		public override string GetInformation()
		{
			return (_dices.Count != 1)
				? $"錯誤: Count of Dices= {_dices.Count}"
				: $"點數: {_dices[0].Value}";
		}
	}
}
