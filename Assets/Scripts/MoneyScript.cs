using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;


    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }
    
   /* void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (moneyManager.UpdateMoney(-cost))
            {
                Destroy(gameObject);
            }
        }
    }*/
}
