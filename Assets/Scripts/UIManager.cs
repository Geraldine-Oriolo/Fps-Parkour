using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    public void UpdateMoneyText(string changingValue){
        txtMoney.text = "money: $" + changingValue;
    }
}
