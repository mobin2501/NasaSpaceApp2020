using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LuytenButton : MonoBehaviour
{
    public Button bt;

    private void Start()
    {
        bt.onClick.AddListener(call);
    }
    void call()
    {
        if (Score.num.Equals("3"))
        {
            SceneManager.LoadScene(6);
        }
        else
        {
            SceneManager.LoadScene(18);
        }

    }
}
