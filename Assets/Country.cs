using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public Color32 countryColor;
    public Sprite countryFlag;
    public bool isPlayed;

    public GameObject countryDescription;

    void Start() {
        if (isPlayed) {
            countryDescription = GameObject.Find("Country Description");
            countryDescription.GetComponent<CountryDescription>().playerCountry = gameObject;
        }
    }
}
