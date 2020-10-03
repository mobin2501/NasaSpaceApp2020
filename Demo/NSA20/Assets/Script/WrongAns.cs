using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WrongAns : MonoBehaviour
{
    public Button bt;
    private void Start()
    {
        bt.onClick.AddListener(call);
    }
    void call()
    {
        SceneManager.LoadScene(15);
    }
}
