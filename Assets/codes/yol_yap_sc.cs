using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yol_yap_sc : MonoBehaviour
{
    public GameObject arkaplan;
    float arkaplan_x = -1f;
    float arkaplan_x_1 = -1f;
    float arkaplan_x_2 = -1f;
    float arkaplan_y = -15f;
    float arkaplan_y_1 = -30f;
    float arkaplan_y_2 = -45f;

    public GameObject kaya;
    float kaya_x = -5f;
    float kaya_x_1 = -5f;
    float kaya_x_2 = -5f;
    float kaya_y = -16.79f;
    float kaya_y_1 = -31.79f;
    float kaya_y_2 = -46.79f;

    private GameObject mob;
    public GameObject yesil_dino;
    public GameObject insan;
    public GameObject kus;

    float mob_pos_x = 5f;
    float mob_pos_x_1 = 5f;
    float mob_pos_x_2 = 5f;
    float mob_pos_y = -15f;
    float mob_pos_y_1 = -30f;
    float mob_pos_y_2 = -45f;

    public int rast_mob;

    public int rast_nesne;

    private GameObject nesne;
    public GameObject kalp;
    public GameObject tas;

    public GameObject kapi_son;

    List<float> yesiller = new List<float>();
    List<float> insanlar = new List<float>();
    List<float> yolinsanlar = new List<float>();
    List<float> kirmizilar = new List<float>();
    List<string> isimlerY = new List<string>();
    List<string> isimlerK = new List<string>();
    List<float> yol1deger = new List<float>();
    List<float> yol2deger = new List<float>();
    List<float> yol3deger = new List<float>();

    float kirmizimob;
    float yesilmob;
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
       
        
        //yol 1
        for (int i = 0; i < 10; i++)
        {
            
            arkaplan.transform.localScale = new Vector3(arkaplan.transform.localScale.x*-1, arkaplan.transform.localScale.y, arkaplan.transform.localScale.z);
            Instantiate(arkaplan, new Vector3(arkaplan_x, arkaplan_y, 0f), arkaplan.transform.rotation);
            arkaplan_x += 17.85f;

            Instantiate(kaya, new Vector3(kaya_x, kaya_y, 0f), kaya.transform.rotation);

            rast_nesne = random.Next(0,2);
            if (rast_nesne==0)
            {
                nesne = kalp;
            }
            if (rast_nesne==1)
            {
                nesne = tas;
            }
            Instantiate(nesne, new Vector3(kaya_x, kaya_y+1.5f, 0f), nesne.transform.rotation);
            kaya_x += 30f;

            rast_mob = random.Next(0, 3);
            if (rast_mob == 0)
            {
                mob = yesil_dino;
                float Yc1h0 = Random.Range(0, 26);//26 dahil edðil
                yesiller.Add(Yc1h0);
                isimlerY.Add(nameof(Yc1h0));
                float Yc1h1 = Random.Range(25, 51);
                yesiller.Add(Yc1h1);
                isimlerY.Add(nameof(Yc1h1));
                float Yc2h0 = Random.Range(50, 76);
                yesiller.Add(Yc2h0);
                isimlerY.Add(nameof(Yc2h0));
                float Yc2h1 = Random.Range(75, 101);
                yesiller.Add(Yc2h1);
                isimlerY.Add(nameof(Yc2h1));




                int KdegerY = Random.Range(0, 4);

                yesilmob = yesiller[KdegerY];




            }

            if (rast_mob == 1)
            {
                mob = kus;
                float Kc1h0 = Random.Range(0, 26);//26 dahil edðil
                kirmizilar.Add(Kc1h0);
                isimlerK.Add(nameof(Kc1h0));
                float Kc1h1 = Random.Range(25, 51);
                kirmizilar.Add(Kc1h1);
                isimlerK.Add(nameof(Kc1h1));
                float Kc2h0 = Random.Range(50, 76);
                kirmizilar.Add(Kc2h0);
                isimlerK.Add(nameof(Kc2h0));
                float Kc2h1 = Random.Range(75, 101);
                kirmizilar.Add(Kc2h1);
                isimlerK.Add(nameof(Kc2h1));

                int KdegerK = Random.Range(0, 4);
                kirmizimob = kirmizilar[KdegerK];
            }

            if (rast_mob == 2)
            {
                mob = insan;
                float Yc1h0 = Random.Range(0, 26);//26 dahil edðil
                insanlar.Add(Yc1h0);

                float Yc1h1 = Random.Range(25, 51);
                insanlar.Add(Yc1h1);
                float Yc2h0 = Random.Range(50, 76);
                insanlar.Add(Yc2h0);
                float Yc2h1 = Random.Range(75, 101);
                insanlar.Add(Yc2h1);

                int idegeri = Random.Range(0, 4);
                float cikisi = insanlar[idegeri];
                yolinsanlar.Add(cikisi);

            }
            Instantiate(mob, new Vector3(mob_pos_x, mob_pos_y, 0f), mob.transform.rotation);
            mob_pos_x += 15f;

            float cikis = (float)((kirmizimob + yesilmob) / 2);
            yol1deger.Add(cikis);

        }
        //yol2
        for (int i = 0; i < 10; i++)
        {
            
            arkaplan.transform.localScale = new Vector3(arkaplan.transform.localScale.x * -1, arkaplan.transform.localScale.y, arkaplan.transform.localScale.z);
            Instantiate(arkaplan, new Vector3(arkaplan_x_1, arkaplan_y_1, 0f), arkaplan.transform.rotation);
            arkaplan_x_1 += 17.85f;

            Instantiate(kaya, new Vector3(kaya_x_1, kaya_y_1, 0f), kaya.transform.rotation);

            rast_nesne = random.Next(0, 2);
            if (rast_nesne == 0)
            {
                nesne = kalp;
            }
            if (rast_nesne == 1)
            {
                nesne = tas;
            }
            Instantiate(nesne, new Vector3(kaya_x_1, kaya_y_1 + 1.5f, 0f), nesne.transform.rotation);

            kaya_x_1 += 30f;

            rast_mob = random.Next(0, 3);
            if (rast_mob == 0)
            {
                mob = yesil_dino;
                float Yc1h0 = Random.Range(0, 26);//26 dahil edðil
                yesiller.Add(Yc1h0);
                isimlerY.Add(nameof(Yc1h0));
                float Yc1h1 = Random.Range(25, 51);
                yesiller.Add(Yc1h1);
                isimlerY.Add(nameof(Yc1h1));
                float Yc2h0 = Random.Range(50, 76);
                yesiller.Add(Yc2h0);
                isimlerY.Add(nameof(Yc2h0));
                float Yc2h1 = Random.Range(75, 101);
                yesiller.Add(Yc2h1);
                isimlerY.Add(nameof(Yc2h1));
                
                
                

                int KdegerY = Random.Range(0, 4);
                
                yesilmob = yesiller[KdegerY];

                


            }

            if (rast_mob == 1)
            {
                mob = kus;
                float Kc1h0 = Random.Range(0, 26);//26 dahil edðil
                kirmizilar.Add(Kc1h0);
                isimlerK.Add(nameof(Kc1h0));
                float Kc1h1 = Random.Range(25, 51);
                kirmizilar.Add(Kc1h1);
                isimlerK.Add(nameof(Kc1h1));
                float Kc2h0 = Random.Range(50, 76);
                kirmizilar.Add(Kc2h0);
                isimlerK.Add(nameof(Kc2h0));
                float Kc2h1 = Random.Range(75, 101);
                kirmizilar.Add(Kc2h1);
                isimlerK.Add(nameof(Kc2h1));

                int KdegerK = Random.Range(0, 4);
                kirmizimob = kirmizilar[KdegerK];
            }

            if (rast_mob == 2)
            {
                mob = insan;
                float Yc1h0 = Random.Range(0, 26);//26 dahil edðil
                insanlar.Add(Yc1h0);

                float Yc1h1 = Random.Range(25, 51);
                insanlar.Add(Yc1h1);
                float Yc2h0 = Random.Range(50, 76);
                insanlar.Add(Yc2h0);
                float Yc2h1 = Random.Range(75, 101);
                insanlar.Add(Yc2h1);

                int idegeri = Random.Range(0, 4);
                float cikisi = insanlar[idegeri];
                yolinsanlar.Add(cikisi);
                
            }
            Instantiate(mob, new Vector3(mob_pos_x_1, mob_pos_y_1, 0f), mob.transform.rotation);
            mob_pos_x_1 += 15f;

            float cikis = (float)((kirmizimob + yesilmob) / 2);
            yol2deger.Add(cikis);

        }
        //yol3
        for (int i = 0; i < 10; i++)
        {
            
            arkaplan.transform.localScale = new Vector3(arkaplan.transform.localScale.x * -1, arkaplan.transform.localScale.y, arkaplan.transform.localScale.z);
            Instantiate(arkaplan, new Vector3(arkaplan_x_2, arkaplan_y_2, 0f), arkaplan.transform.rotation);
            arkaplan_x_2 += 17.85f;

            Instantiate(kaya, new Vector3(kaya_x_2, kaya_y_2, 0f), kaya.transform.rotation);

            rast_nesne = random.Next(0, 2);
            if (rast_nesne == 0)
            {
                nesne = kalp;
            }
            if (rast_nesne == 1)
            {
                nesne = tas;
            }
            Instantiate(nesne, new Vector3(kaya_x_2, kaya_y_2 + 1.5f, 0f), nesne.transform.rotation);

            kaya_x_2 += 30f;

            rast_mob = random.Next(0, 3);
            if (rast_mob == 0)
            {
                mob = yesil_dino;
                float Yc1h0 = Random.Range(0, 26);//26 dahil edðil
                yesiller.Add(Yc1h0);
                isimlerY.Add(nameof(Yc1h0));
                float Yc1h1 = Random.Range(25, 51);
                yesiller.Add(Yc1h1);
                isimlerY.Add(nameof(Yc1h1));
                float Yc2h0 = Random.Range(50, 76);
                yesiller.Add(Yc2h0);
                isimlerY.Add(nameof(Yc2h0));
                float Yc2h1 = Random.Range(75, 101);
                yesiller.Add(Yc2h1);
                isimlerY.Add(nameof(Yc2h1));




                int KdegerY = Random.Range(0, 4);

                yesilmob = yesiller[KdegerY];




            }

            if (rast_mob == 1)
            {
                mob = kus;
                float Kc1h0 = Random.Range(0, 26);//26 dahil edðil
                kirmizilar.Add(Kc1h0);
                isimlerK.Add(nameof(Kc1h0));
                float Kc1h1 = Random.Range(25, 51);
                kirmizilar.Add(Kc1h1);
                isimlerK.Add(nameof(Kc1h1));
                float Kc2h0 = Random.Range(50, 76);
                kirmizilar.Add(Kc2h0);
                isimlerK.Add(nameof(Kc2h0));
                float Kc2h1 = Random.Range(75, 101);
                kirmizilar.Add(Kc2h1);
                isimlerK.Add(nameof(Kc2h1));

                int KdegerK = Random.Range(0, 4);
                kirmizimob = kirmizilar[KdegerK];
            }

            if (rast_mob == 2)
            {
                mob = insan;
                float Yc1h0 = Random.Range(0, 26);//26 dahil edðil
                insanlar.Add(Yc1h0);

                float Yc1h1 = Random.Range(25, 51);
                insanlar.Add(Yc1h1);
                float Yc2h0 = Random.Range(50, 76);
                insanlar.Add(Yc2h0);
                float Yc2h1 = Random.Range(75, 101);
                insanlar.Add(Yc2h1);

                int idegeri = Random.Range(0, 4);
                float cikisi = insanlar[idegeri];
                yolinsanlar.Add(cikisi);

            }
            Instantiate(mob, new Vector3(mob_pos_x_2, mob_pos_y_2, 0f), mob.transform.rotation);
            mob_pos_x_2 += 15f;

            float cikis = (float)((kirmizimob + yesilmob) / 2);
            yol3deger.Add(cikis);
        }

        Instantiate(kapi_son,new Vector3(160f,-15.5f,0f),kapi_son.transform.rotation);
        Instantiate(kapi_son,new Vector3(160f,-30.5f,0f),kapi_son.transform.rotation);
        Instantiate(kapi_son,new Vector3(160f,-45.5f,0f),kapi_son.transform.rotation);

        float sonuc1 = 0;
        foreach (var item in yol1deger)
        {

            sonuc1 = sonuc1 + item;
        }

        float sonuc2 = 0;
        foreach (var item in yol2deger)
        {

            sonuc2 = sonuc2 + item;
        }
        float sonuc3 = 0;
        foreach (var item in yol3deger)
        {

            sonuc3 = sonuc3 + item;
        }
        float sonuci = 0;
        foreach (var item in yolinsanlar)
        {
            sonuci = sonuci + item;
        }
        PlayerPrefs.SetFloat("yol1", ((sonuc1 / yol1deger.Count) + (sonuci / yolinsanlar.Count)) / 2);
        PlayerPrefs.SetFloat("yol2", ((sonuc2 / yol2deger.Count) + (sonuci / yolinsanlar.Count)) / 2);
        PlayerPrefs.SetFloat("yol3", ((sonuc3 / yol3deger.Count) + (sonuci / yolinsanlar.Count)) / 2);
        //Debug.Log("yol 1 = " +((sonuc1 / yol1deger.Count)+(sonuci / yolinsanlar.Count))/2);
        //Debug.Log("yol 2 = " +((sonuc2 / yol2deger.Count)+(sonuci / yolinsanlar.Count)) / 2);
        //Debug.Log("yol 3 = " +((sonuc3 / yol3deger.Count)+(sonuci / yolinsanlar.Count)) / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
