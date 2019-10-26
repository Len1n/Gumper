using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBall : MonoBehaviour
{
    public GameObject LB;
    

    IEnumerator DestroyLB()
    {
        yield return new WaitForSeconds(10f);
        Destroy(LB);
    }

    void Update()
    {

    }

    void Start()
    {
        if (!LB.name.Equals("LavaBall"))
        {
            StartCoroutine(DestroyLB());
        }
        
    }


    void OnCollisionEnter(Collision col)
    {
     //  StartCoroutine(DestroyLB());
    }
}
