using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject interactionMessage;
    public MoneyScript mercancia;
    public MoneyManager moneyManager;

    // Start is called before the first frame update
    void Start()
    {
        interactionMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mercancia && moneyManager.money >= mercancia.cost)
            {
                moneyManager.UpdateMoney(-mercancia.cost);
                Destroy(mercancia.gameObject);
                StopInteraction();
            } else if (moneyManager.money < mercancia.cost)
            {
                Debug.Log("No te alcanza");
            }
            void OnTriggerEnter (Collider other)
            {
                Debug.Log(other.gameObject.name);
                mercancia = other.GetComponent<MoneyScript>();
                if (mercancia)
                {
                    interactionMessage.SetActive(true);
                        }
                }
            }
         
        }
    }
}
