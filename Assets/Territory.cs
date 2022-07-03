using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    public bool capital = false;
    public bool isDefenced;

    void Start()
    {
        transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().countryColor;
    }

    void Update()
    {
        isDefenced = false;
    }
    private void FixedUpdate()
    {
        isDefenced = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.parent == transform.parent)
        {
            isDefenced = true;
        }

    }
}
