using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class asa : MonoBehaviour
{
    public  TextMeshPro kapi_tex_1;
    public  TextMeshPro kapi_tex_2;
    public  TextMeshPro kapi_tex_3;

    public GameObject pano1;
    public GameObject pano2;
    public GameObject pano3;

    float yol1;
    float yol2;
    float yol3;

    float yuksek;
    float orta;
    float dusuk;

    public static int k1;
    public static int k2;
    public static int k3;
    
    // Start is called before the first frame update
    void Start()
    {
        pano1.SetActive(false);
        pano2.SetActive(false);
        pano3.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (karakter_sc.asaeldemi==true)
        {
            pano1.SetActive(true);
            pano2.SetActive(true);
            pano3.SetActive(true);


            yol1 = float.Parse(PlayerPrefs.GetFloat("yol1").ToString("0.##"));
            yol2 = float.Parse(PlayerPrefs.GetFloat("yol2").ToString("0.##"));
            yol3 = float.Parse(PlayerPrefs.GetFloat("yol3").ToString("0.##"));

            yuksek=Mathf.Max(yol1, yol2,yol3);
            if (yuksek==yol1)
            {
                kapi_tex_1.text = PlayerPrefs.GetFloat("yol1").ToString("0.## \n 3X SCORE");
                k1 = 3;
            }
            else if (yuksek == yol2)
            {
                kapi_tex_2.text = PlayerPrefs.GetFloat("yol2").ToString("0.## \n 3X SCORE");
                k2 = 3;
            }
            else if (yuksek == yol3)
            {
                kapi_tex_3.text = PlayerPrefs.GetFloat("yol3").ToString("0.## \n 3X SCORE");
                k3 = 3;
            }

            dusuk=Mathf.Min(yol1, yol2, yol3);
            if (dusuk == yol1)
            {
                kapi_tex_1.text = PlayerPrefs.GetFloat("yol1").ToString("0.## \n 1X SCORE");
                k1 = 1;
            }
            else if (dusuk == yol2)
            {
                kapi_tex_2.text = PlayerPrefs.GetFloat("yol2").ToString("0.## \n 1X SCORE");
                k2 = 1;
            }
            else if (dusuk == yol3)
            {
                kapi_tex_3.text = PlayerPrefs.GetFloat("yol3").ToString("0.## \n 1X SCORE");
                k3 = 1;
            }

            if (yuksek != yol1 && dusuk !=yol1)
            {
                kapi_tex_1.text = PlayerPrefs.GetFloat("yol1").ToString("0.## \n 2X SCORE");
                k1 = 2;
            }
            else if (yuksek != yol2 && dusuk != yol2)
            {
                kapi_tex_2.text = PlayerPrefs.GetFloat("yol2").ToString("0.## \n 2X SCORE");
                k2 = 2;
            }
            else if (yuksek != yol3 && dusuk != yol3)
            {
                kapi_tex_3.text = PlayerPrefs.GetFloat("yol3").ToString("0.## \n 2X SCORE");
                k3 = 2;
            }









            //kapi_tex_1.text=PlayerPrefs.GetFloat("yol1").ToString("0.##");
            //kapi_tex_2.text=PlayerPrefs.GetFloat("yol2").ToString("0.##");
            //kapi_tex_3.text=PlayerPrefs.GetFloat("yol3").ToString("0.##");



        }
    }
}
