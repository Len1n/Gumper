using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    private float hp = 100;
    public Text hptxt;
    public GameObject obj;
    public GameObject lavaBall;



    void Start()
    {
        IEnumerator lavaCouratine = instObj();
        StartCoroutine(lavaCouratine);
       // StartCoroutine(CreateDestroableLavaBall());

    }


    void Update()
    {
        ShowStat();
        HpControll();

    }


    void ShowStat()
    {
        hptxt.text = "hp" + hp.ToString();
    }


    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        hp -= 10;
    }

    void HpControll()
    {
        if (hp < 0)
        {
            Destroy(obj);
            
        }
    }

    IEnumerator instObj()
    {
        int Counter = 0;
        while (Counter<1000 )
        {
            Vector3 coords = new Vector3(Random.Range(-7f, 3f), 15f, Random.Range(-7f, 5f));
            Instantiate(lavaBall,coords, Quaternion.identity);
            Counter++;
            yield return new WaitForSeconds(1.5f);

        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("LavaBall(Clone)"))
        {
            hp -= 5;
        }
        print(col.gameObject.name);
    }

    IEnumerator CreateDestroableLavaBall()
    {
        yield return new WaitForSeconds(10f);
        Destroy(lavaBall);
    }


}

