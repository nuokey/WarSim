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

    public Transform canvas;
    public Transform armyCreate;
    public GameObject army;

    void Start()
    {
        transform.GetComponent<SpriteRenderer>().color = transform.parent.parent.transform.GetComponent<Country>().countryColor;
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = transform.GetComponent<SpriteRenderer>().sprite;

        // armyCreate = GameObject.Find("/Canvas/Player Menu/Army/Tuning/Create Army").transform;
        armyCreate = GameObject.Find("Canvas").transform.GetChild(1).GetChild(4).GetChild(0).GetChild(2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent.parent == transform.parent.parent & collision.transform.GetComponent<Army>())
        {
            defendingArmiesCount += 1;
        }
        if (collision.transform.parent.parent != transform.parent.parent & collision.transform.GetComponent<Army>()) {
            attackingArmiesCount += 1;
        }

        if (collision.transform.GetComponent<Army>())
        {
            transform.GetComponent<SpriteRenderer>().color = collision.transform.parent.parent.GetComponent<Country>().countryColor;
            transform.GetComponent<Territory>().defendingArmiesCount = transform.GetComponent<Territory>().attackingArmiesCount;
            transform.GetComponent<Territory>().attackingArmiesCount = 0;
            transform.SetParent(collision.transform.parent.parent.GetChild(0));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.parent.parent == transform.parent.parent & collision.transform.GetComponent<Army>())
        {
            defendingArmiesCount -= 1;
        }
        if (collision.transform.parent.parent != transform.parent.parent & collision.transform.GetComponent<Army>()) {
            attackingArmiesCount -= 1;
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
            
            if (armyCreate.GetComponent<CreateArmy>().armyIsSpawning)
            {
                Instantiate(army, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation, transform.parent.parent.GetChild(1).transform);
                armyCreate.GetComponent<CreateArmy>().armyIsSpawning = false;
            }
        }
    }
}
