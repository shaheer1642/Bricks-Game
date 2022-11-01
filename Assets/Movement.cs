using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 3f;
    void Start() {
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*movementSpeed,0,0);
    }
}
