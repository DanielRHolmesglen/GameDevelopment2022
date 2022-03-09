using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public GameObject currentWeapon;
    public GameObject weaponHand;
    public List<GameObject> reachableObjects;
    public float reach;
    public void PickUpWeapon(Transform newWeapon)
    {
        DropWeapon();
        var rb = newWeapon.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeAll;
        rb.velocity = Vector3.zero;
        

        newWeapon.parent = weaponHand.transform;
        newWeapon.localRotation = Quaternion.Euler(Vector3.zero);
        newWeapon.localPosition = Vector3.zero;
        
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
    public void GetReachableWeapons()
    {
        reachableObjects.Clear();
        //use a sphere collision to maintain a list of weapons that are grabable and in range.
        var possibleObjects = Physics.OverlapSphere(transform.position, reach);

        foreach(Collider item in possibleObjects)
        {
            if (item.gameObject == currentWeapon) continue;
            reachableObjects.Add(item.gameObject);
        }
        //this list should reset each time the function is called.
        //the list cannot include the current weapon
    }
    public void PickClosestWeapon()
    {
        //compare each item in the weapons list. If the this item is closer than the last, set it as the newWeapon
        //once all are compared, call PickUpWeapon
        float distOfObject;
        float distOfLastObject;
        var newWeapon = reachableObjects[0];
        distOfLastObject = Vector3.Distance(transform.position, newWeapon.transform.position);
        for (int i = 1; i < reachableObjects.Count; i++)
        {
            distOfObject = Vector3.Distance(transform.position, newWeapon.transform.position);
            if(distOfObject < distOfLastObject)
            {
                newWeapon = reachableObjects[i];
            }
            distOfLastObject = distOfObject;
        }
    }
    private void Update()
    {
        GetReachableWeapons();
    }
}
