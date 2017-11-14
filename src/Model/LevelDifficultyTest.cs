using System;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture()]
	public class LevelDifficultyTest
	{
		[Test ()]
		public void EasyLevelTest ()
		{
			MenuController.PerformSetupMenuAction (0);
			Assert.IsTrue (GameController._aiSetting == AIOption.Easy);
		}

		[Test ()]
		public void MediumLevelTest ()
		{
			MenuController.PerformSetupMenuAction (1);
			Assert.IsTrue (GameController._aiSetting == AIOption.Medium);
		}
	}
}
