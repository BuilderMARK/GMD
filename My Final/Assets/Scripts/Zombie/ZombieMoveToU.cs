using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoveToU : MonoBehaviour
{
public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
