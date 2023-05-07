using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject GameObject;

    public GameObject GameObject2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TEST");
        GameObject.transform.position = new Vector3(GameObject2.transform.position.x,GameObject2.transform.position.y+1,GameObject2.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
