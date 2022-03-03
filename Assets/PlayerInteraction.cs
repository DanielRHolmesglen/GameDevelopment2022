using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    CharacterMovement cm;
    [SerializeField] public GameObject currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        cm = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Shoot();
        }
        cm.anim.SetBool("Dance", Input.GetKey(KeyCode.Q));
        
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
