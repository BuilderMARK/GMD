using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    [SerializeField] private AudioSource _AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
               _AudioSource.Play();
                GameObject bullet = Instantiate(bulletPrefab, new Vector3(transform.position.x,transform.position.y,transform.position.z+0.5f), transform.rotation);

                Debug.Log("hej");
        }
        
    }
}
