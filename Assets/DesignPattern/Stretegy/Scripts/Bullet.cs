using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Bullet] Attack to Target!");
    }

    public void Attack(GameObject obj)
    {
        throw new System.NotImplementedException();
    }
}
