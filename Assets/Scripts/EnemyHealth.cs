using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("enemy died!");
        //die anim
        //animator.SetBool("IsDead", true);
        //disable enemy
        //Get Component<Collider2D>().enabled = false;
        this.enabled = false;
        Destroy(gameObject);
    }
}