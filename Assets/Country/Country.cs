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

    public GameObject canvas;
    public GameObject playerPanel;
    public GameObject aboutPlayer;
    public GameObject economyMenu;

    public GameObject time;

    private void Start() {
        if (isPlayed) {
            canvas = GameObject.Find("Canvas");

            economyMenu = canvas.transform.GetChild(1).GetChild(3).gameObject;

            playerPanel = canvas.transform.GetChild(0).gameObject;
            playerPanel.GetComponent<PlayerPanel>().playerCountry = gameObject;

            aboutPlayer = GameObject.Find("About");
        }

        time = GameObject.Find("/Time");
    }

    private void FixedUpdate()
    {   
        if (isPlayed)
        {
            EconomyMenu();
        }

        TimeUpdate();
    }

    public void TimeUpdate()
    {
        Taxes();
    }

    public void EconomyMenu()
    {
        economyMenu.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = System.Convert.ToString(taxesPerTime);
    }

    public void Taxes()
    {
        if (time.GetComponent<Time>().days == 1)
        {
            money += 1;
        }
    }
}
