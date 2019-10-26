using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour

{
    public GameObject obj;
    private float moveSpeed = 3f, turnSpeed = 40f, force = 75;
    private float energy = 100;
    public Text eng;

    void Start()
    {


    }

    void Update()
    {
        RestoretEnergy();
        Move();
        EvenOut();
        ShowStat();
    }
    

    void Move()
    {
        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space) && energy>0 )
        {
            obj.transform.Translate(Vector3.up * force * Time.deltaTime);
            energy -= 10;

        }
    }

    void EvenOut()
    {
        if (Input.GetMouseButtonDown(2) && obj.transform.rotation.x>20)
        {
            
            obj.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
       
    }
    
    void ShowStat()
    {
        eng.text = "Energy:" + energy.ToString();
    }

    void RestoretEnergy()
    {
        if (energy < 100)
        {
            energy += 0.1f;
        }
        
    }




}

