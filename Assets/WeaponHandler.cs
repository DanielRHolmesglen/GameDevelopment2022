using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public GameObject currentWeapon;
    public GameObject weaponHand;
    public void PickUpWeapon(Transform newWeapon)
    {
        DropWeapon();
        var rb = newWeapon.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
        rb.useGravity = false;

        newWeapon.parent = weaponHand.transform;
        newWeapon.localPosition = Vector3.zero;
        newWeapon.eulerAngles = Vector3.zero;
        var weaponScript = newWeapon.GetComponent<MonoBehaviour>();
        weaponScript.enabled = true;
        currentWeapon = newWeapon.gameObject;
    }
    public void DropWeapon()
    {
        if (currentWeapon == null) return;
        var weaponScript = currentWeapon.GetComponent<MonoBehaviour>();
        weaponScript.enabled = false;
        currentWeapon.transform.parent = null;

        var rb = currentWeapon.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.None;
        rb.useGravity = true;
        rb.AddForce(currentWeapon.transform.forward * 2 + currentWeapon.transform.up * 3, ForceMode.Impulse);
        currentWeapon = null;

    }
}
