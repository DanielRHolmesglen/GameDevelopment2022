using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool canBePickedUp;
    public Collider triggerCollider;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("attempting collision player");
        if (!canBePickedUp) return;
        if (!other.CompareTag("Player")) return;
        Debug.Log("colliding with player");
        if (Input.GetKeyDown(other.GetComponent<PlayerInputs>().interact))
        {
            Debug.Log("attempt to pickup");
            other.GetComponent<WeaponHandler>().PickUpWeapon(transform);
            canBePickedUp = false;
        }
    }
}
