using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerInteraction : MonoBehaviour
{
    //replace this with the name of your own movement script;
    NewCharacterMovement cm;
    public GameObject currentWeapon;
    // Start is called before the first frame update
    void Start()
    {
        cm = GetComponent<NewCharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Shoot();
        }

        cm.anim.SetBool("Dancing", Input.GetKey(KeyCode.Q));
    }
    public void Shoot()
    {
        cm.anim.SetTrigger("Shoot");
        currentWeapon.GetComponent<IShootable>().Shoot();
    }
}
