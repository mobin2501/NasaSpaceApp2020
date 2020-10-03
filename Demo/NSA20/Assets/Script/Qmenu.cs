using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Qmenu : MonoBehaviour
{
    public Button bt;
    public Button bt2;
    public Button bt3;
    public Button bt4;
    private void Start()
    {
        bt.onClick.AddListener(B1);
        bt2.onClick.AddListener(B2);
        bt3.onClick.AddListener(B3);
        bt4.onClick.AddListener(B4);
    }
    void B1()
    {
        SceneManager.LoadScene(9);
    }
    void B2()
    {
        SceneManager.LoadScene(10);
    }
    void B3()
    {
        SceneManager.LoadScene(11);
    }
    void B4()
    {
        SceneManager.LoadScene(12);
    }

}
