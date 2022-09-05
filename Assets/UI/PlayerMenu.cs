using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu : MonoBehaviour
{
    public Transform army;
    void Army()
    {
        
    }

    void afterStart() {
        gameObject.SetActive(false);
    }

    void Start() {
        Invoke("afterStart", 0.001f);

        army = transform.GetChild(4);
    }
}
