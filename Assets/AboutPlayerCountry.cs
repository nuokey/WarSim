using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutPlayerCountry : MonoBehaviour
{   
    public string name;

    public GameObject country;

    void Update() {
        name = country.GetComponent<Country>().name;
        transform.GetChild(0).GetComponent<Text>().text = name;
    }
}
