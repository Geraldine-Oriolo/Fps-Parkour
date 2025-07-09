using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    public bool UpdateMoney(float amount)
    {
        if (money + amount >= 0)
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }
        return false;
    }
}

