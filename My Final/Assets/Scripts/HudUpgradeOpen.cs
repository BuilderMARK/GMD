using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HudUpgradeOpen : MonoBehaviour
{
    public GameObject hudCanvas;
    public IMoney moneyCounter; // Referencen til klassen, der holder styr på spillerens penge

    public bool CanBuyUpgrade(int upgradePrice)
    {
        if (moneyCounter.GetMoney() >= upgradePrice)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Burde Åbne");
            hudCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Burde lukke");
            hudCanvas.SetActive(false);
        }
    }
}
