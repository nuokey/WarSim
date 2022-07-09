using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    public bool capital = false;
    public bool isDefenced;

    public Color mouseOverColor;

    public GameObject mouseOverObject;

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

    private void OnMouseEnter()
    {
        mouseOverObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        mouseOverObject.SetActive(false);
    }
}
