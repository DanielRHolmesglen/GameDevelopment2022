using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public override void TriggerDeath()
    {
        base.TriggerDeath();
        Animator anim = GetComponentInChildren<Animator>();
        anim.SetBool("Death", true);
    }
}
