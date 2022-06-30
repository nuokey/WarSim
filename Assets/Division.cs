using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : MonoBehaviour
{
    public Vector3 target;
    public float speed;


    void Start()
    {
        transform.GetComponent<SpriteRenderer>().color = transform.parent.transform.GetComponent<Country>().divisionColor;
    }

    void FixedUpdate()
    {
        Vector3 range = target - transform.position;

        float tg = range.y / range.x;

        float length = Mathf.Sqrt(range.x * range.x + range.y * range.y);

        float sin = range.y / length;
        float cosin = range.x / length;

        transform.position = transform.position + new Vector3(cosin * speed, sin * speed, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Territory>())
        {
            collision.transform.SetParent(transform.parent);


            collision.transform.GetComponent<SpriteRenderer>().color = transform.parent.GetComponent<Country>().countryColor;
        }
    }
    // void OnMouseEnter()
    // {
    //    transform.position = new Vector3(0, 0, 0);
    //}
}
