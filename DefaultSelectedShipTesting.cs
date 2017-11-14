using System;
using System.Windows.Forms;
using NUnit.Framework;
namespace MyGame
{
	[TestFixture ()]
	public class UnitTesting
	{
		[Test ()]
		public void DefaultSelectedShip ()
		{
			ShipName _selectedShip = ShipName.Tug;
			ShipName selected = default (ShipName);

			if (selected != ShipName.None) {
				_selectedShip = selected;
			}

			Assert.AreEqual (selected, _selectedShip);

		}

	}
}
