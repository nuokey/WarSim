using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{   
    public int time = 0;

    GameObject canvas;

    GameObject timePanel;
    GameObject timePanelText;

    string month;
    int years;
    int days;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");

        timePanel = canvas.transform.GetChild(3).gameObject;
        timePanelText = timePanel.transform.GetChild(0).gameObject;
    }

    void ShowTime()
    {
        years = time / 365;

        days = time % 365;

        if (days <= 31)
        {
            month = "January";
        }
        else
        {
            if (days <= 31)
            {
                month = "January";
            }




            

            if (days <= 59)
            {
                month = "February";
                if (days <= 90)
                {
                    month = "March";
                    if (days <= 120)
                    {
                        month = "April";
                        if (days <= 151)
                        {
                            month = "May";
                            if (days <= 181)
                            {
                                month = "June";
                                if (days <= 212)
                                {
                                    month = "July";
                                    if (days <= 243)
                                    {
                                        month = "August";
                                        if (days <= 273)
                                        {
                                            month = "September";
                                            if (days <= 304)
                                            {
                                                month = "October";
                                                if (days <= 334)
                                                {
                                                    month = "November";
                                                    if (days <= 365)
                                                    {
                                                        month = "December";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        

        timePanelText.GetComponent<Text>().text = month + "." + System.Convert.ToString(years);

    }

    private void FixedUpdate()
    {
        time += 1;
        ShowTime();

    }

    
}
