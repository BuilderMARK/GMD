using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyActive : MonoBehaviour
{
    private Collider _collider;

    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        active = true;
        Debug.Log(" jeg Bliver ramt");
    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
        Debug.Log("Ikke længere aktiv");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
