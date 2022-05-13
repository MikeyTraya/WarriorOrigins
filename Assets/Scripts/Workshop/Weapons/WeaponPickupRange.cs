using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarriorOrigins
{
    public class WeaponPickupRange : MonoBehaviour
    {
        public int WeaponID;

        public void PickupWeapon()
        {
            GameManager.Instance.currentRangeWeaponEquipped = WeaponID;
            Destroy(gameObject);
        }
    }
}
