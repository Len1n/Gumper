using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
    public GameObject obj;
public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.UpArrow))
        obj.transform.Translate(Vector3.forward  moveSpeed  Time.deltaTime);
}
}
