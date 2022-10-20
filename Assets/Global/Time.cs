using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    GameObject canvas;

    GameObject timePanel;
    GameObject timePanelText;

    public int defaultYear;
    public int time = 0;
    public string month;
    public int years;
    public int days;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");

        timePanel = canvas.transform.GetChild(3).gameObject;
        timePanelText = timePanel.transform.GetChild(0).gameObject;

        Invoke("AddTime", 1);
    }

    void AddTime()
    {
        time += 1;
        Invoke("AddTime", 1);
    }

    void ShowTime()
    {
        years = time / 365 + defaultYear;

        days = time % 365;

        if (days <= 31)
        {
            month = "01";
            days = days;
        }
        else
        {
            if (days <= 59)
            {
                month = "02";
                days = days - 31;
            }
            else
            {
                if (days <= 90)
                {
                    month = "03";
                    days = days - 59;
                }
                else
                {
                    if (days <= 120)
                    {
                        month = "04";
                        days = days - 90;
                    }
                    else
                    {
                        if (days <= 151)
                        {
                            month = "05";
                            days = days - 120;
                        }
                    }
                }
            }
        }

        

        timePanelText.GetComponent<Text>().text = System.Convert.ToString(days) + "." + month + "." + System.Convert.ToString(years);

    }

    private void FixedUpdate()
    {
        
        ShowTime();

    }

    
}
