using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{
    public int damage;
    public Player_Health playerHealth;

    public float attackRate = 1f;
    float nextAttackTime = 0f;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (Time.time >= nextAttackTime)
            {
                playerHealth.TakeDamage(damage);
                nextAttackTime = Time.time + 1f / attackRate;
                
            }
        }
    }
}
