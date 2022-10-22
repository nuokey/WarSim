using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Army : MonoBehaviour
{   
    public new string name = "Army";
    public float durability;
    public float damage;
    public float damageCoolDown;
    public float speed;

    public Vector3 target;
    
    public bool targetIsChoosing = false;

    public Color defaultColor;
    public Color chosenColor;


    

    void Start()
    {
        transform.GetComponent<SpriteRenderer>().sprite = transform.parent.parent.transform.GetComponent<Country>().countryFlag;
    }

    void Update()
    {
        if (targetIsChoosing)
        {   
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                targetIsChoosing = false;
                transform.GetComponent<SpriteRenderer>().color = defaultColor;
            }
        }

        if (durability <= 0) {
            Destroy(gameObject);
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
    

    

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetIsChoosing = true;
            gameObject.GetComponent<SpriteRenderer>().color = chosenColor;
        }
    }

}
