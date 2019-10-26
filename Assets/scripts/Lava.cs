using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public GameObject Lavaobj;
    

  
    void Update()
    {
        Lavaobj.transform.Translate(Vector3.up * 0.5f * Time.deltaTime);

    }
}
