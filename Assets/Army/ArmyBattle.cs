using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyBattle : MonoBehaviour
{
    public bool fighting;

    public Transform fightTarget;

    void Attack()
    {
        if (fighting)
        {
            fightTarget.GetComponent<Army>().durability -= transform.parent.GetComponent<Army>().damage;
            Invoke("Attack", transform.parent.GetComponent<Army>().damageCoolDown);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Army>() & collision.transform.parent.parent != transform.parent.parent.parent & !fighting)
        {
            fightTarget = collision.transform;
            fighting = true;
            fighting = true;
            Attack();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform == fightTarget)
        {
            fighting = false;
        }
    }
}
