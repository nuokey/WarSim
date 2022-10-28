using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{   
    public GameObject playerCountry;

    void afterStart() {
        transform.GetChild(0).GetComponent<Image>().sprite = playerCountry.GetComponent<Country>().countryFlag;
        
    }

    void Start() {
        Invoke("afterStart", 0.001f);
    }
    
    void Update() {
        transform.GetChild(2).GetComponent<Text>().text = System.Convert.ToString(playerCountry.GetComponent<Country>().money);
    }
}
