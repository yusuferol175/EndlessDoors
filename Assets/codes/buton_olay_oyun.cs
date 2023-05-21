using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay_oyun : MonoBehaviour
{

    public void evedon()
    {
        PlayerPrefs.SetInt("bannerdurum", 0);
        if (PlayerPrefs.GetInt("high_sc") < PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("high_sc", PlayerPrefs.GetInt("score"));
        }

        PlayerPrefs.DeleteKey("score");

        SceneManager.LoadScene("menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
