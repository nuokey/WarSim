using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCountryMenu : MonoBehaviour
{   
    void afterStart() {
        gameObject.SetActive(false);
    }

    void Start() {
        Invoke("afterStart", 0.001f);
    }
}
