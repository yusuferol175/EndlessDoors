using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton_olay_menu_sc : MonoBehaviour
{
    public void play_but()
    {
        PlayerPrefs.SetInt("bannerdurum", 1);
        SceneManager.LoadScene("oyun");
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
