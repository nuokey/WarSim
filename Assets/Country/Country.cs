using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public Color32 countryColor;
    public Sprite countryFlag;
    public bool isPlayed;
    

    public GameObject playerPanel;
    public GameObject aboutPlayer;

    void Start() {
        if (isPlayed) {
            playerPanel = GameObject.Find("Player Panel");
            playerPanel.GetComponent<PlayerPanel>().playerCountry = gameObject;

            aboutPlayer = GameObject.Find("About");
            aboutPlayer.GetComponent<AboutPlayer>().country = gameObject;
        }
    }
}
