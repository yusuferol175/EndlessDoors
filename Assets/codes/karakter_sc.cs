using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class karakter_sc : MonoBehaviour
{

    public float JumpForce;
    public float MovementSpeed;
    public static bool yerdemi;
    Animator animcha;
    Rigidbody2D rb;
    public GameObject asa_pos;
    public GameObject asa_obje;

    public static int can =3;
    public static int tas_sayi =5;
    public GameObject bar_olay;

    public GameObject tas;
    public GameObject tas_pos;
    public static bool asaeldemi;

    public GameObject sinir;
    public GameObject sinir1;
    public GameObject sinir2;
    public GameObject sinir3;
    public GameObject tkpkamera;
    public Cinemachine.CinemachineConfiner tkpkameraconfiner;

    public Text score_text;
    public TextMeshPro high_score;

    bool tek1 = true;
    private int xdurum;

    bool hareket;
    bool kapi_durum;
    

    public GameObject kapi_button;

    private bool hasaryeme = false;

    public AudioSource ses;
    public AudioClip ah;
    public AudioClip tas_ses;
    public AudioClip zipla_ses;
    public AudioClip bitirme;
    public AudioClip bip;


    public static int gonderilen_score;

    public GameObject hikaye_panel;
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public GameObject h4;

    public void ates()
    {
        if (tas_sayi > 0)
        {
            if (gameObject.transform.localScale.x == 1)
            {
                ses.PlayOneShot(tas_ses);
                var spawntas = Instantiate(tas, tas_pos.transform.position, tas_pos.transform.rotation);
                spawntas.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500f);
                tas_sayi--;
                bar_olay.GetComponent<bar_sc>().tas_azalma();
            }
            if (gameObject.transform.localScale.x == -1)
            {
                ses.PlayOneShot(tas_ses);
                var spawntas = Instantiate(tas, tas_pos.transform.position, tas_pos.transform.rotation);
                spawntas.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 500f);
                tas_sayi--;
                bar_olay.GetComponent<bar_sc>().tas_azalma();
            }
        }
    }
    public void zipla()
    {
        if (gameObject)
        {
            if (yerdemi == true)
            {

                ses.PlayOneShot(zipla_ses);
                rb.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);


            }



        }

    }

    public void move_start(bool sol_da_mi)
    {
        if (sol_da_mi)
        {
            if (gameObject.transform.localScale.x > 0)
            {
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y, gameObject.transform.localScale.x);
                MovementSpeed *= -1;
            }

           
        }
        else
        {
            if (gameObject.transform.localScale.x < 0)
            {
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y, gameObject.transform.localScale.x);
                MovementSpeed *= -1;
            }

          
        }

        hareket = true;
    }
    public void move_stop()
    {
        hareket = false;

    }
    public void kapi_ac()
    {
        kapi_durum = true;
        rb.AddForce(new Vector2(0, JumpForce * 0.2f), ForceMode2D.Impulse);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kapi1")
        {
            
                kapi_button.SetActive(false);
            
        }

        if (collision.gameObject.tag == "kapi2")
        {
             kapi_button.SetActive(false);
            
        }

        if (collision.gameObject.tag == "kapi3")
        {
                kapi_button.SetActive(false);
            
        }

        if (collision.gameObject.tag == "kapi4")
        {
            
                kapi_button.SetActive(false);
            
        }
    }
    private int ilerleme = 0;
    public void next_but()
    {
        
        ilerleme++;
        if (ilerleme==1)
        {
            h2.SetActive(true);
        }
        if (ilerleme == 2)
        {
            h3.SetActive(true);
        }
        if (ilerleme == 3)
        {
            h4.SetActive(true);
        }
        if (ilerleme == 4)
        {
            hikaye_panel.SetActive(false);
        }
    }

    void hasaryemeha()
    {
        hasaryeme = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="kapi1")
        {
           
                kapi_button.SetActive(true);
            

            if (kapi_durum == true)
            {

                collision.gameObject.GetComponent<AudioSource>().Play();
                kapi_durum = false;
                kapi_button.SetActive(false);
                tkpkameraconfiner.m_BoundingShape2D = sinir1.GetComponent<CompositeCollider2D>();
                transform.position = new Vector3(-8f, -15.9f, 0f);
                //Debug.Log("kapi1");
                xdurum = asa.k1;
                
            }

        }
        if (collision.gameObject.tag == "kapi2")
        {
           
                kapi_button.SetActive(true);            
            

            if (kapi_durum == true)
            {
                collision.gameObject.GetComponent<AudioSource>().Play();
                kapi_durum = false;
                kapi_button.SetActive(false);
                tkpkameraconfiner.m_BoundingShape2D = sinir2.GetComponent<CompositeCollider2D>();
                transform.position = new Vector3(-8f, -30.9f, 0f);
                //Debug.Log("kapi2");
                xdurum = asa.k2;
            }
        }
        if (collision.gameObject.tag == "kapi3")
        {
            
                kapi_button.SetActive(true);
          
            if (kapi_durum == true)
            {
                collision.gameObject.GetComponent<AudioSource>().Play();
                kapi_durum = false;
                kapi_button.SetActive(false);
                tkpkameraconfiner.m_BoundingShape2D = sinir3.GetComponent<CompositeCollider2D>();
                transform.position = new Vector3(-8f, -45.9f, 0f);
                //Debug.Log("kapi3");
                xdurum = asa.k3;
            }
        }
        if (collision.gameObject.tag == "kapi4")
        {
           
                kapi_button.SetActive(true);
            
            
            if (kapi_durum==true)
            {
                
                kapi_durum = false;
                kapi_button.SetActive(false);
                if (tek1==true)
                {
                    
                    PlayerPrefs.SetInt("bitirme_durum", 1);
                    PlayerPrefs.SetInt("score", (PlayerPrefs.GetInt("score")+100)*xdurum);

                    if (PlayerPrefs.GetInt("high_sc") < PlayerPrefs.GetInt("score"))
                    {
                        PlayerPrefs.SetInt("high_sc", PlayerPrefs.GetInt("score"));
                    }
                    tek1 = false;
                }
                
                SceneManager.LoadScene("oyun");
                //Debug.Log("kapi4");
            }
        }
        if (collision.gameObject.tag=="asa")
        {
            hikaye_panel.SetActive(true);
            
            h2.SetActive(false);
            h3.SetActive(false);
            h4.SetActive(false);

            collision.gameObject.transform.position = new Vector3(asa_pos.transform.position.x,asa_pos.transform.position.y,asa_pos.transform.position.z);
            
            asaeldemi = true;

        }
        if (collision.gameObject.tag == "kus")
        {
            if (hasaryeme==false)
            {
                ses.PlayOneShot(ah);
                rb.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
                GetComponent<SpriteRenderer>().color = Color.red;
                can--;
                bar_olay.GetComponent<bar_sc>().can_durum();
                can--;
                bar_olay.GetComponent<bar_sc>().can_durum();
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 1f);
        }
        if (collision.gameObject.tag=="kalp")
        {
            ses.PlayOneShot(bip);
            Destroy(collision.gameObject);
            if (can<3)
            {
                can++;
                bar_olay.GetComponent<bar_sc>().kalp_durum();
                
            }
        }
        if (collision.gameObject.tag=="tas")
        {
            ses.PlayOneShot(bip);
            Destroy(collision.gameObject);
            if (tas_sayi<5)
            {
                tas_sayi++;
                bar_olay.GetComponent<bar_sc>().tas_artma();
            }
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="tank")
        {
            if (hasaryeme==false)
            {
                ses.PlayOneShot(ah);
                rb.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
                GetComponent<SpriteRenderer>().color = Color.red;              
                can--;
                bar_olay.GetComponent<bar_sc>().can_durum();
                //Debug.Log(can);
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }
        if (collision.gameObject.tag=="insan")
        {
            if (hasaryeme==false)
            {
                ses.PlayOneShot(ah);
                rb.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
                GetComponent<SpriteRenderer>().color = Color.red;
                can--;
                bar_olay.GetComponent<bar_sc>().can_durum();
                can--;
                bar_olay.GetComponent<bar_sc>().can_durum();
            }
            hasaryeme = true;
            Invoke("duzelt", 0.5f);
            Invoke("hasaryemeha", 0.5f);
        }
    }
    void duzelt()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

    }
    // Start is called before the first frame update
    void Start()
    {
        kapi_button.SetActive(false);

        tkpkameraconfiner = tkpkamera.GetComponent<Cinemachine.CinemachineConfiner>();
        tkpkameraconfiner.m_BoundingShape2D = sinir.GetComponent<CompositeCollider2D>();

        animcha = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        can = 3;
        tas_sayi = 5;
        asaeldemi = false;

        score_text.text = PlayerPrefs.GetInt("score").ToString();
        high_score.text = PlayerPrefs.GetInt("high_sc").ToString();

        if (PlayerPrefs.GetInt("bitirme_durum")==1)
        {
            ses.PlayOneShot(bitirme);
            PlayerPrefs.SetInt("bitirme_durum", 0);
        }

        ilerleme = 0;
        hikaye_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hareket)
        {
            if (gameObject)
            {
                gameObject.transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime * 5;
            }

            if (animcha)
            {          
                    animcha.SetBool("yurume", true);
            }
        }
        else
        {
            if (animcha)
            {
                animcha.SetBool("yurume", false);
            }
        }

        if (silah_sc.oldurme==true)
        {
            score_text.text = PlayerPrefs.GetInt("score").ToString();
            silah_sc.oldurme = false;
        }

        //float x = Input.GetAxis("Horizontal");
        //Vector3 move = new Vector3(x * MovementSpeed, rb.velocity.y, 0f);
        //rb.velocity = move;
        //if (x<0 || x>0)
        //{
        //    animcha.SetBool("yurume", true);
        //    //asa.GetComponent<Animator>().SetBool("asa_durum", true);
        //}
        //else
        //{
        //    animcha.SetBool("yurume", false);
        //    //asa.GetComponent<Animator>().SetBool("asa_durum", false);
        //}
        
       
        //if (x<0)
        //{
        //    transform.localScale = new Vector3(-1,1,1);
           
        //}
        //if (x>0)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
            
        //}

        //if (Input.GetKeyDown(KeyCode.K))
        //{
          
        //    if (tas_sayi>0)
        //    {
        //        if (gameObject.transform.localScale.x == 1)
        //        {
        //            var spawntas = Instantiate(tas, tas_pos.transform.position, tas_pos.transform.rotation);
        //            spawntas.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500f);
        //            tas_sayi--;
        //            bar_olay.GetComponent<bar_sc>().tas_azalma();
        //        }
        //        if (gameObject.transform.localScale.x == -1)
        //        {
        //            var spawntas = Instantiate(tas, tas_pos.transform.position, tas_pos.transform.rotation);
        //            spawntas.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 500f);
        //            tas_sayi--;
        //            bar_olay.GetComponent<bar_sc>().tas_azalma();
        //        }
        //    }

        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (yerdemi)
        //    {
        //        rb.AddForce(new Vector2(0, JumpForce * 7), ForceMode2D.Impulse);
        //    }
            
        //}


        if (can==0||can<0)
        {
            PlayerPrefs.SetInt("olumsayisi", PlayerPrefs.GetInt("olumsayisi")+1);

            if (PlayerPrefs.GetInt("high_sc") < PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("high_sc", PlayerPrefs.GetInt("score"));
            }

            gonderilen_score = PlayerPrefs.GetInt("score");
            PlayerPrefs.DeleteKey("score");
            SceneManager.LoadScene("olum");
        }


    }
}
