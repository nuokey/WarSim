using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public Color32 countryColor;
    public Sprite countryFlag;
    public bool isPlayed;

    public GameObject playerCountryPanel;
    public GameObject aboutPlayerCountry;

    void Start() {
        if (isPlayed) {
            playerCountryPanel = GameObject.Find("Player Country Panel");
            playerCountryPanel.GetComponent<PlayerCountryPanel>().playerCountry = gameObject;

            aboutPlayerCountry = GameObject.Find("About");
            aboutPlayerCountry.GetComponent<AboutPlayerCountry>().country = gameObject;
        }
    }
}
