using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    CharacterMovement cm;
    [SerializeField] public GameObject currentWeapon;
    PlayerInputs inputs;
    // Start is called before the first frame update
    void Start()
    {
        cm = GetComponent<CharacterMovement>();
        inputs = GetComponent<PlayerInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(inputs.fire))
        {
            Shoot();
        }
        cm.anim.SetBool("Dance", Input.GetKey(inputs.taunt));
        
    }
    void Shoot()
    {
        cm.anim.SetTrigger("Shoot");
        if (currentWeapon != null)
        {
            currentWeapon.GetComponent<IShootable>().Shoot();
        }
        else
        {
            Debug.Log("oops no weapon");
        }
    }
}
