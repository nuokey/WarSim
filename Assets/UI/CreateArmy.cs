using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateArmy: MonoBehaviour
{      
    public bool armyIsSpawning;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        armyIsSpawning = true;
    }
}
