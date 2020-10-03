using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q1 : MonoBehaviour
{
    public Button bt;

    private void Start()
    {
        bt.onClick.AddListener(call);
    }
    void call()
    {
        Score.q[0] = true;
        SceneManager.LoadScene(16);
    }
}
