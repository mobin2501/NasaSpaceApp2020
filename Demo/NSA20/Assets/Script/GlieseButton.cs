using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlieseButton : MonoBehaviour
{
    public Button bt;

    private void Start()
    {
        bt.onClick.AddListener(call);
    }
    void call()
    {
        if (Score.c.Equals("2"))
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(19);
        }
        
    }
    
}
