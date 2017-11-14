using NUnit.Framework;
namespace MyGame
{
	[TestFixture()]
	public class TestState
	{
		[Test ()]
		public void TestStateAdd ()
		{
			GameController.AddNewState (GameState.AlteringSettings);
			Assert.AreEqual (GameController.CurrentState, GameState.AlteringSettings);

			GameController.AddNewState (GameState.EndingGame);
			Assert.AreEqual (GameController.CurrentState, GameState.EndingGame);

			GameController.EndCurrentState ();
			Assert.AreEqual (GameController.CurrentState, GameState.AlteringSettings);
		}
	}
}
