using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyDescription : MonoBehaviour
{   
    public GameObject chosenArmy;
    public bool armyIsChosen = false;

    public string durability;

    void Start() {
        Invoke("hideDescription", 0.001f);
    }

    public void updateDescription() {
        transform.GetChild(0).GetComponent<Text>().text = "Durability: " + System.Convert.ToString(chosenArmy.GetComponent<Army>().durability);
        transform.GetChild(1).GetComponent<Text>().text = "Damage: " + System.Convert.ToString(chosenArmy.GetComponent<Army>().damage);
        transform.GetChild(2).GetComponent<Text>().text = "Attack speed: " + System.Convert.ToString(1 / chosenArmy.GetComponent<Army>().damageCoolDown);
    }

    public void Update() {
        if (armyIsChosen) {
            updateDescription();
        }
        
    }

    public void showDescription() {
        transform.GetChild(0).GetComponent<Text>().text = chosenArmy.GetComponent<Army>().name;
        updateDescription();
        armyIsChosen = true;
    }

    public void hideDescription() {
        armyIsChosen = false;
        gameObject.SetActive(false);
    }
}
