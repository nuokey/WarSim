using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Division : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    public bool targetIsChoosing = false;
    public bool isChosen = false;
    public GameObject descriptionPanel;

    public new string name = "Division";
    public Color chosenColor;

    public LineRenderer line;

    void Start()
    {
        descriptionPanel = GameObject.Find("Division Description");
        transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().divisionColor;
    }

    void Update()
    {
        if (targetIsChoosing)
        {   
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                targetIsChoosing = false;
                transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().divisionColor;
            }
        }
        if (isChosen)
        { 
            descriptionPanel.transform.GetChild(0).GetComponent<Text>().text = name;
        }
    }

    void FixedUpdate()
    {
        Vector3 range = target - transform.position;

        float tg = range.y / range.x;

        float length = Mathf.Sqrt(range.x * range.x + range.y * range.y);

        float sin = range.y / length;
        float cosin = range.x / length;

        transform.position = transform.position + new Vector3(cosin * speed, sin * speed, 0);

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Territory>())
        {   
            if (!collision.transform.GetComponent<Territory>().isDefenced)
            {
                collision.transform.SetParent(transform.parent);

                
                collision.transform.GetComponent<SpriteRenderer>().color = transform.parent.GetComponent<Country>().countryColor;
            }       
        }
    }
     void OnMouseOver()
     {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetIsChoosing = true;
            gameObject.GetComponent<SpriteRenderer>().color = chosenColor;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {   
            if (!isChosen)
            {
                isChosen = true;
                gameObject.GetComponent<SpriteRenderer>().color = chosenColor;
            }
            else
            {
                isChosen = false;
                transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().divisionColor;
            }
        }
     }
}
