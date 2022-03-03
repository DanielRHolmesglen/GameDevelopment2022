using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    [Tooltip("Health amounts")]
    public int maxHealth, startingHealth, currentHealth;
    public bool canBeDamaged;

    //components
    public Slider healthUI;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        UpdateHealthUI();
    }

    public virtual void TakeDamage(int amount)
    {
        if (!canBeDamaged)
        {
            Debug.Log("attempted to attack " + gameObject.name + " but the object can not be damaged right now");
            return;
        }
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            TriggerDeath();
        }
        UpdateHealthUI();
    }
    public virtual void TriggerDeath()
    {
        //begin Death animations and stuff
        Debug.Log(gameObject.name + " has been killed");
        Invoke("Die", 2);
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }
    private void UpdateHealthUI()
    {
        if (!healthUI) return;
        healthUI.maxValue = maxHealth;
        healthUI.value = currentHealth;
    }
}
