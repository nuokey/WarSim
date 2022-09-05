using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Country : MonoBehaviour
{
    public Color32 countryColor;
    public Sprite countryFlag;
    public int money;

    public int taxesPercent;
    public int taxesPerTime;

    public bool isPlayed;

    public GameObject playerPanel;
    public GameObject aboutPlayer;
    public GameObject economyMenu;

    private void Start() {
        if (isPlayed) {
            economyMenu = GameObject.Find("Canvas").transform.GetChild(1).GetChild(3).gameObject;

            playerPanel = GameObject.Find("Player Panel");
            playerPanel.GetComponent<PlayerPanel>().playerCountry = gameObject;

            aboutPlayer = GameObject.Find("About");
        }
    }

    private void Update()
    {   
        if (isPlayed)
        {
            EconomyMenu();
        }
        
    }

    public void EconomyMenu()
    {
        economyMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = System.Convert.ToString(taxesPerTime);
    }
}
