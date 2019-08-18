using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour

{
    public GameObject obj;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;


    void Start()
    {


    }

    void Update()
    {
        Move();
        EvenOut();
    }
    

    void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

    }

    void EvenOut()
    {
        if (Input.GetMouseButtonDown(2))
        {
            // obj.rotation.transform.y = 0;
            //obj.rotation.transform.x = 0;
            //obj.rotation.transform.z = 0;
            obj.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
       
    }
    
}

