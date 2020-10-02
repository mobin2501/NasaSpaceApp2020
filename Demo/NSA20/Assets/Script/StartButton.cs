using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button bt;

    /*public void FixedUpdate()
    {
        bt.onClick.AddListener(Task);
    }*/
    public void Start()
    {
       //Button btn =
        bt.onClick.AddListener(Task);
    }
    void Task()
    {
        Debug.Log("Boo");
    }
}
