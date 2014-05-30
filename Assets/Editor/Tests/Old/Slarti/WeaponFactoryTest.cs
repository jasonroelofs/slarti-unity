using UnityEngine;
using NUnit.Framework;

namespace Slarti {
	
	[TestFixture] 
	public class WeaponFactoryTest {

		[Test]
		public void BuildsWeaponOfGivenType() {
			Weapon newWeapon = WeaponFactory.BuildWeapon(WeaponType.SemiAuto);
			Assert.NotNull(newWeapon);
			Assert.IsInstanceOf<SemiAutoWeapon>(newWeapon);
		}

		[Test]
		public void RaisesErrorIfWeaponTypeNotImplemented() {
			Assert.Throws<WeaponFactory.NotImplementedWeaponTypeException>( () => WeaponFactory.BuildWeapon(WeaponType.Unknown) );
		}
	}
}

