using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class BeltMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //_rigidbody = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
       // Vector3 pos = _rigidbody.position;
      //  _rigidbody.position -= new Vector3(pos.x, pos.y, pos.z + 1);
      //  _rigidbody.MovePosition(pos);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
