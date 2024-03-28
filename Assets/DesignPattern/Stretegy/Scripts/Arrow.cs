using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Arrow] Attack to Target!");
    }

    public void Attack(GameObject obj)
    {
        throw new System.NotImplementedException();
    }
}
