using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HaveSpool : MonoBehaviour
{
    public bool spoolCheck = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spool")
        {
            spoolCheck = true;
        }
    }
}
