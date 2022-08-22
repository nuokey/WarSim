using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Description : MonoBehaviour
{
    public GameObject description;
    public GameObject armyDescription;
    public bool isChosen = false;

    public Color chosenColor;
    public Color defaultColor;

    private void Start()
    {
        description = GameObject.Find("Canvas").transform.GetChild(2).gameObject;
        armyDescription = description.transform.GetChild(2).gameObject;
    }

    public void Choose()
    {
        description.SetActive(true);
        isChosen = true;
        gameObject.GetComponent<SpriteRenderer>().color = chosenColor;
        armyDescription.SetActive(true);
        armyDescription.GetComponent<ArmyDescription>().chosenArmy = gameObject;
        armyDescription.GetComponent<ArmyDescription>().showDescription();
    }

    public void UnChoose()
    {
        isChosen = false;
        transform.GetComponent<SpriteRenderer>().color = defaultColor;
        armyDescription.GetComponent<ArmyDescription>().hideDescription();
        description.SetActive(false);
    }

    void OnMouseOver()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (!isChosen & !armyDescription.GetComponent<ArmyDescription>().armyIsChosen)
            {
                Choose();
            }
        }
    }
}
