
using Microsoft.VisualBasic;
using System.Threading;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

/// <summary>
/// The EndingGameController is responsible for managing the interactions at the end
/// of a game.
/// </summary>

static class EndingGameController
{

	/// <summary>
	/// Draw the end of the game screen, shows the win/lose state
	/// </summary>
	public static void DrawEndOfGame ()
	{
		UtilityFunctions.DrawField (GameController.ComputerPlayer.PlayerGrid, GameController.ComputerPlayer, true);
		UtilityFunctions.DrawSmallField (GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);

		if (GameController.HumanPlayer.IsDestroyed) {
			SwinGame.DrawTextLines ("YOU LOSE!", Color.White, Color.Transparent, GameResources.GameFont ("ArialLarge"), FontAlignment.AlignCenter, 0, 250, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
			SwinGame.DrawTextLines ("Click to return to menu", Color.White, Color.Transparent, GameResources.GameFont ("Courier"), FontAlignment.AlignCenter, 0, 370, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());


		} else {
			SwinGame.DrawTextLines ("-- WINNER! --", Color.White, Color.Transparent, GameResources.GameFont ("ArialLarge"), FontAlignment.AlignCenter, 0, 250, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		}
	}

	/// <summary>
	/// Handle the input during the end of the game. Any interaction
	/// will result in it reading in the highsSwinGame.
	/// </summary>
	public static void HandleEndOfGameInput ()
	{
		string time = DateTime.Now.ToString ("h:mm:ss ");
		var date = DateTime.Now.ToString ("dd.MM.yyy");
		var result = DialogResult.OK;

		if (SwinGame.MouseClicked (MouseButton.LeftButton) || SwinGame.KeyTyped (KeyCode.vk_RETURN) || SwinGame.KeyTyped (KeyCode.vk_ESCAPE)) {

			MessageBox.Show ("Time : " + time + Environment.NewLine + "Date : " + date, "Message", MessageBoxButtons.OK);

			if (result == DialogResult.OK) {
				HighScoreController.ReadHighScore (GameController.HumanPlayer.Score);
				GameController.EndCurrentState ();
				SwinGame.PlayMusic (GameResources.GameMusic ("Menu"));
			}
		}

		//static public void Tick (Object stateInfo)
		//{
		//	string time = DateTime.Now.ToString ("h:mm:ss");


		//	MessageBox.Show ("You WON!!!" + Environment.NewLine + "Tick: " + time,
		//					"Message",
		//					MessageBoxButtons.OK,
		//					MessageBoxIcon.Information);

		//}

		//static void TimerCallBack ()
		//{
		//	TimerCallback callback = new TimerCallback (Tick);

		//	// create a one second timer tick
		//	System.Threading.Timer stateTimer = new System.Threading.Timer (callback, null, 0, 1000);


		//	// loop here forever
		//	var i = 0;

		//	do {
		//		// add a sleep for 100 mSec to reduce CPU usage
		//		Thread.Sleep (1000);
		//		stateTimer.Dispose ();
		//	}
		//	while (i < 1);


		//	Console.ReadLine ();
		//}

	}
}
