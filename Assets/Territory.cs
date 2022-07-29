using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    public bool capital = false;
    public int defendingArmiesCount = 0;
    public int attackingArmiesCount = 0;

    public Color mouseOverColor;

    public GameObject mouseOverObject;

    void Start()
    {
        transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().countryColor;
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = transform.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent == transform.parent)
        {
            defendingArmiesCount += 1;
        }
        if (collision.transform.parent != transform.parent & collision.transform.GetComponent<Army>()) {
            attackingArmiesCount += 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.parent == transform.parent)
        {
            defendingArmiesCount -= 1;
        }
        if (collision.transform.parent != transform.parent & collision.transform.GetComponent<Army>()) {
            attackingArmiesCount += 1;
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
