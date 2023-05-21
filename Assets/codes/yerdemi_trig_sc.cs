using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yerdemi_trig_sc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="yer"|| collision.gameObject.tag == "kaya")
        {
            karakter_sc.yerdemi = true;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "yer" || collision.gameObject.tag == "kaya")
        {
            karakter_sc.yerdemi = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "yer" || collision.gameObject.tag == "kaya")
        {
            karakter_sc.yerdemi = false;
        }
    }
    //void OnTriggerEnter2D()
    //{

    //    karakter_sc.yerdemi = true;
    //}
    //void OnTriggerStay2D()
    //{
    //    karakter_sc.yerdemi = true;
    //}
    //void OnTriggerExit2D()
    //{
    //    karakter_sc.yerdemi = false;
    //}
}
