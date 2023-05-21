using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_sc : MonoBehaviour
{
    public int MovementSpeed;

    public AudioSource dsmn_ses;
    public AudioClip kus_ses;
    public AudioClip tank_ses;
    public AudioClip kucuk_dus;

    void yandi()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "atýlan")
        {
            if (gameObject.tag=="kus")
            {
                dsmn_ses.PlayOneShot(kus_ses);
            }
            if (gameObject.tag=="tank")
            {
                dsmn_ses.PlayOneShot(tank_ses);
            }
            if (gameObject.tag == "insan")
            {
                dsmn_ses.PlayOneShot(kucuk_dus);
            }


            GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("yandi", 0.5f);
        }

        if (collision.gameObject.tag=="kus_sýnýrý")
        {
            
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="tank")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        if (collision.gameObject.tag == "kaya")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        if (collision.gameObject.tag == "insan")
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x == -0.1f)
        {
            gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

        }
        if (transform.localScale.x == 0.1f)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;

        }

        if (transform.localScale.x == -0.2f)
        {
            gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

        }
        if (transform.localScale.x == 0.2f)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;

        }

        if (transform.localScale.x == -0.15f)
        {
            gameObject.transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

        }
        if (transform.localScale.x == 0.15f)
        {
            gameObject.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;

        }
    }
}
