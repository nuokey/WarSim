using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    void Start()
    {
        transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().countryColor;
    }

    void Update()
    {

    }
}
