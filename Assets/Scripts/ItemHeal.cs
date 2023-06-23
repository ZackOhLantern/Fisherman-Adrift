using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemHeal : MonoBehaviour
{
    public int healAmount;
    public Player_Health playerHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(-1 * healAmount);
            Destroy(gameObject);
        }
    }
}
