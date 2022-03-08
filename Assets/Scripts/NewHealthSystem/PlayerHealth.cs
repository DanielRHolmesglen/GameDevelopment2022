using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public Image healthUIImage;
    private void Update()
    {
        UpdateHealthUI();
    }
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        canBeDamaged = false;
        Invoke("ResetDamage", 1);
    }
    public override void TriggerDeath()
    {
        base.TriggerDeath();
        Animator anim = GetComponentInChildren<Animator>();
        anim.SetBool("Death", true);
    }
    public override void UpdateHealthUI()
    {
        if (!healthUIImage) return;
        float amount = ((float)currentHealth / (float)maxHealth);
        healthUIImage.fillAmount = amount;
    }
    private void ResetDamage()
    {
        canBeDamaged = true;
        Debug.Log("can be damaged again");
    }
}
