using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeplerButton : MonoBehaviour
{
    public Button bt;

    private void Start()
    {
        bt.onClick.AddListener(call);
    }
    void call()
    {
        if (Score.c.Equals("4"))
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(17);
        }
        
    }
}
