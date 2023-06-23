using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ZipLine : MonoBehaviour
{
    public GameObject zipline_start;
    public GameObject zipline_end;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = zipline_start.transform;
        anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == zipline_end.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == zipline_end.transform)
        {
            currentPoint = zipline_start.transform;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(zipline_start.transform.position, 0.5f);
        Gizmos.DrawWireSphere(zipline_end.transform.position, 0.5f);
        Gizmos.DrawLine(zipline_start.transform.position, zipline_end.transform.position);
    }
}
