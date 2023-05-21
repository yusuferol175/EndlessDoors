using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class silah_sc : MonoBehaviour
{
    public int puan;
    public static bool oldurme;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="kaya")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "tank")
        {
            Destroy(gameObject);
            if (collision.gameObject.GetComponent<CircleCollider2D>().enabled == false)
            {
                if (collision.gameObject.GetComponent<EdgeCollider2D>().enabled == false)
                {
                    Destroy(collision.gameObject);
                    puan = PlayerPrefs.GetInt("score")+50;
                    PlayerPrefs.SetInt("score", puan);
                    oldurme = true;
                }
                collision.gameObject.GetComponent<EdgeCollider2D>().enabled = false;

            }
            collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }

        if (collision.gameObject.tag == "insan")
        {
            Destroy(gameObject);
            if (collision.gameObject.GetComponent<CircleCollider2D>().enabled == false)
            {
                Destroy(collision.gameObject);
                puan = PlayerPrefs.GetInt("score") + 30;
                PlayerPrefs.SetInt("score", puan);
                oldurme = true;
            }
            collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;

        }

        if (collision.gameObject.tag=="kus")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            puan = PlayerPrefs.GetInt("score") + 20;
            PlayerPrefs.SetInt("score", puan);
            oldurme = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
