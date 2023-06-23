using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTeleport : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    private GameObject currentTeleporter;

    private void Start()
    {

    }
    void Update()
    {
        if (currentTeleporter != null)
        {
            transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MapTeleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
        if (collision.CompareTag("Map"))
        {
            Vector3 pos = collision.gameObject.transform.position;
            pos.z = cam1.transform.position.z;
            cam1.transform.position = pos;
            //cam1.transform.position = collision.gameObject.transform.position;
            //cam1.transform.Translate(0, 0, -10);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("MapTeleporter"))
        {
            currentTeleporter = null;
        }
    }
}
