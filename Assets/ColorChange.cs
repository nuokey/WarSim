using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().countryColor;
        // transform.position = new Vector3(2, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
