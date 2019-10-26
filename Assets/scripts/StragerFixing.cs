using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StragerFixing : MonoBehaviour
{
    public GameObject obj;

    void Update()
    {
        if (obj.transform.rotation.x > 20|| obj.transform.rotation.x < -20)
        {
            obj.transform.rotation = Quaternion.Euler(0, obj.transform.rotation.y, obj.transform.rotation.z);
        }
    }
}
