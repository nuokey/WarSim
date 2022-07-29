using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public Vector3 target;
    public float speed;
    public bool targetIsChoosing = false;
    public bool isChosen = false;
    public GameObject descriptionPanel;

    public new string name = "Army";
    public Color chosenColor;
    public Color defaultColor;

    public LineRenderer line;

    public bool fighting;

    public Transform fightTarget;

    public float durability;
    public float damage;
    public float damageCoolDown;

    void Start()
    {
        descriptionPanel = GameObject.Find("Army Description");
        transform.GetComponent<SpriteRenderer>().sprite = transform.parent.transform.GetComponent<Country>().countryFlag;
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
            if (collision.transform.GetComponent<Territory>().defendingArmiesCount == 0)
            {
                collision.transform.SetParent(transform.parent);

                
                collision.transform.GetComponent<SpriteRenderer>().color = transform.parent.GetComponent<Country>().countryColor;
                collision.transform.GetComponent<Territory>().defendingArmiesCount = collision.transform.GetComponent<Territory>().attackingArmiesCount;
                collision.transform.GetComponent<Territory>().attackingArmiesCount = 0;
            }       
        }
    }

    void Attack() {
        if (fighting) {
            fightTarget.GetComponent<Army>().durability -= transform.GetComponent<Army>().damage;
            Invoke("Attack", transform.GetComponent<Army>().damageCoolDown);
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.GetComponent<Army>() & collision.transform.parent != transform.parent & !fighting) {
            fightTarget = collision.transform;
            fighting = true;
            Attack();
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (collision.transform == fightTarget) {
            fighting = false;
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
            if (!isChosen & !descriptionPanel.GetComponent<ArmyDescription>().armyIsChosen)
            {
                isChosen = true;
                gameObject.GetComponent<SpriteRenderer>().color = chosenColor;
                descriptionPanel.SetActive(true);
                descriptionPanel.GetComponent<ArmyDescription>().chosenArmy = gameObject;
                descriptionPanel.GetComponent<ArmyDescription>().showDescription();
            }
            else
            {
                isChosen = false;
                transform.GetComponent<SpriteRenderer>().color = defaultColor;
                descriptionPanel.GetComponent<ArmyDescription>().hideDescription();
            }
        }
    }
}
