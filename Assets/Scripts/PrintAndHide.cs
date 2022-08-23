using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    public int i = 3;
    public int trig;
    // Start is called before the first frame update
    void Start()
    {
        trig = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if(i == 100 && gameObject.tag == "Red")
        {
            gameObject.SetActive(false);
        }
        if( i == trig && gameObject.tag == "Blue")
        {
            rend.enabled = false;
        }
    }
}
