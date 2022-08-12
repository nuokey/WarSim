using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        string count = transform.parent.GetChild(1).GetComponent<Text>().text;
        transform.parent.GetChild(1).GetComponent<Text>().text = System.Convert.ToString(System.Convert.ToInt32(count) + 1);
        System.Convert.ToInt32(count);
    }
}
