using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay_olum_sc : MonoBehaviour
{
    public Text score_olm;
    public void restart()
    {
        if (PlayerPrefs.GetInt("reklamvar") == 1)
        {

        }
        else
        {
            SceneManager.LoadScene("oyun");
        }
       
    }

    public void eve_don()
    {
        if (PlayerPrefs.GetInt("reklamvar") == 1)
        {

        }
        else
        {
            PlayerPrefs.SetInt("bannerdurum", 0);
            SceneManager.LoadScene("menu");
        }
        
    }
    

    void Start()
    {
        score_olm.text = karakter_sc.gonderilen_score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
