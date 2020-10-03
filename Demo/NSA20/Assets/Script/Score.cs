using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text t;
    public static bool[] q = { false, false, false, false };
    public static int num = 0;
    public static string c = "";
    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            if (q[i] == true)
            {
                num++;
            }
        }
        t.text = num.ToString();
        num = 0;
    }
    private void FixedUpdate()
    {
        c = t.text;
        Debug.Log(c);
    }
}
