using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour, IShootable
{
    public void Shoot()
    {
        Debug.Log("pew! I'M a pistolß");
    }
}