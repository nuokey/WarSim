using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountryDescription : MonoBehaviour
{   
    public GameObject playerCountry;

    void flagShow() {
        transform.GetChild(0).GetComponent<Image>().sprite = playerCountry.GetComponent<Country>().countryFlag;
    }

    void Start() {
        Invoke("flagShow", 0.001f);
    }
    
    void Update() {

    }
}
