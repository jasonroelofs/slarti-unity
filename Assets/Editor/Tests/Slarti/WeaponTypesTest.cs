using UnityEngine;
using NUnit.Framework;

namespace Slarti {
	
	[TestFixture] 
	public class WeaponTypesTest {

		[Test]
		public void BuildsWeaponOfGivenType() {
			Weapon newWeapon = WeaponTypes.BuildWeapon(WeaponTypes.Types.SemiAuto);
			Assert.NotNull(newWeapon);
			Assert.IsInstanceOf<SemiAutoWeapon>(newWeapon);
		}

		[Test]
		public void RaisesErrorIfWeaponTypeNotImplemented() {
			Assert.Throws<WeaponTypes.NotImplementedWeaponTypeException>( () => WeaponTypes.BuildWeapon(WeaponTypes.Types.Unknown) );
		}
	}
}

