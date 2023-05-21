using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class olasilik : MonoBehaviour
{
    
    List<float> yesiller = new List<float>();
    List<float> kirmizilar = new List<float>();
    List<string> isimlerY = new List<string>();
    List<string> isimlerK = new List<string>();
    void Start()
    {
      
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
        int KdegerY = Random.Range(0, 4);
        float kirmizimob = kirmizilar[KdegerK];
        float yesilmob = yesiller[KdegerY];
        float cikis = (float)((kirmizimob + yesilmob) / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
