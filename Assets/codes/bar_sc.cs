using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar_sc : MonoBehaviour
{
    public Image kalp1;
    public Image kalp2;
    public Image kalp3;

    public Sprite kirmizi_kalp;
    public Sprite siyah_kalp;

    public Image tas1;
    public Image tas2;
    public Image tas3;
    public Image tas4;
    public Image tas5;

    public Sprite kirik_tas;
    public Sprite duzgun_tas;
    // Start is called before the first frame update

    public void tas_azalma()
    {
        if (karakter_sc.tas_sayi==0)
        {
            tas1.gameObject.GetComponent<Image>().sprite = kirik_tas;
        }
        if (karakter_sc.tas_sayi == 1)
        {
            tas2.gameObject.GetComponent<Image>().sprite = kirik_tas;
        }
        if (karakter_sc.tas_sayi == 2)
        {
            tas3.gameObject.GetComponent<Image>().sprite = kirik_tas;
        }
        if (karakter_sc.tas_sayi == 3)
        {
            tas4.gameObject.GetComponent<Image>().sprite = kirik_tas;
        }
        if (karakter_sc.tas_sayi == 4)
        {
            tas5.gameObject.GetComponent<Image>().sprite = kirik_tas;
        }
    }
    public void tas_artma()
    {
        if (karakter_sc.tas_sayi == 1)
        {
            tas1.gameObject.GetComponent<Image>().sprite = duzgun_tas;
        }
        if (karakter_sc.tas_sayi == 2)
        {
            tas2.gameObject.GetComponent<Image>().sprite = duzgun_tas;
        }
        if (karakter_sc.tas_sayi == 3)
        {
            tas3.gameObject.GetComponent<Image>().sprite = duzgun_tas;
        }
        if (karakter_sc.tas_sayi == 4)
        {
            tas4.gameObject.GetComponent<Image>().sprite = duzgun_tas;
        }
        if (karakter_sc.tas_sayi == 5)
        {
            tas5.gameObject.GetComponent<Image>().sprite = duzgun_tas;
        }

    }
    public void can_durum()
    {
        if (karakter_sc.can == 0)
        {

            kalp1.gameObject.GetComponent<Image>().sprite = siyah_kalp;
        }
        if (karakter_sc.can==1)
        {
            
            kalp2.gameObject.GetComponent<Image>().sprite = siyah_kalp;
        }
        if (karakter_sc.can == 2)
        {

            kalp3.gameObject.GetComponent<Image>().sprite = siyah_kalp;
        }

    }
    public void kalp_durum()
    {
        if (karakter_sc.can == 1)
        {

            kalp1.gameObject.GetComponent<Image>().sprite = kirmizi_kalp;
        }
        if (karakter_sc.can == 2)
        {

            kalp2.gameObject.GetComponent<Image>().sprite = kirmizi_kalp;
        }
        if (karakter_sc.can == 3)
        {

            kalp3.gameObject.GetComponent<Image>().sprite = kirmizi_kalp;
        }

    }
}
