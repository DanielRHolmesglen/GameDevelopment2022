using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : MonoBehaviour, IShootable
{
    public void Shoot()
    {
        Debug.Log("BANG! I'M a ShOtGuN");
    }
}
