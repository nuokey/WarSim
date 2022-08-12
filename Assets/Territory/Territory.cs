using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    public bool capital;
    public bool canCreateArmies;


    public int defendingArmiesCount = 0;
    public int attackingArmiesCount = 0;

    public Color mouseOverColor;

    public GameObject mouseOverObject;

    public Transform armyCreate;
    public GameObject army;

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

    void OnMouseOver()
    {   
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (armyCreate.GetComponent<Create>().armyIsSpawning)
            {
                Instantiate(army, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation, transform.parent);
                armyCreate.GetComponent<Create>().armyIsSpawning = false;
            }
        }
    }
}
