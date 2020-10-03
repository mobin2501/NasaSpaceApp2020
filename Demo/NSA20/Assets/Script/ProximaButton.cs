using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProximaButton : MonoBehaviour
{
    public Button bt;

    private void Start()
    {
        bt.onClick.AddListener(call);
    }
    void call()
    {

        if (Score.c.Equals("1")) 
        {
            SceneManager.LoadScene(3); 
        }
        else
        {
            SceneManager.LoadScene(20);
        }
    }
        
}
