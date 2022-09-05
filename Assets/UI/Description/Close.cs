using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
    public GameObject chosenArmy;
    void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        chosenArmy = transform.parent.GetChild(2).GetComponent<ArmyDescription>().chosenArmy;

        chosenArmy.GetComponent<Description>().UnChoose();
    }
}
