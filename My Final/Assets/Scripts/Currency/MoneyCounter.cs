using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour,IMoney
{
    private int money;
    public TextMeshProUGUI moneyText;
    private void Start()
    {
        money = 10000;
    }
    private void OnTriggerEnter(Collider other)
    {
        money++;
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        moneyText.text = money.ToString();
    }

    public int GetMoney()
    {
        return money;
    }

    public void SetMoney(int amount)
    {
        money = amount;
        UpdateMoneyText();
    }

}
