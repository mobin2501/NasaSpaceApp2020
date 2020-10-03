using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(back);
    }
    void back()
    {
        SceneManager.LoadScene(14);
    }
}
