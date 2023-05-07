using System;
using System.Collections;
using System.Collections.Generic;
using Ammo;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour,IAmmo
{
    private int Ammo;
    public TextMeshProUGUI ammoText;
    private void Start()
    {
        Ammo = 10;
    }
    private void OnTriggerEnter(Collider other)
    {
        Ammo++;
        UpdateAmmoText();
    }

    private void UpdateAmmoText()
    {
        ammoText.text = Ammo.ToString();
    }

    public int GetAmmo()
    {
        return Ammo;
    }

    public void SetAmmo(int amount)
    {
        Ammo = amount;
        UpdateAmmoText();
    }

}
