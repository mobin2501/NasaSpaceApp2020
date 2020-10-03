using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Q");
            Application.Quit();
        }
    }
}
