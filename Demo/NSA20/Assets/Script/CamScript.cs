using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform cam;
    public Transform rc;
    static float y = 0f;
    Vector3 pos;

    private void Update()
    {
        y = rc.transform.position.y;
        pos = new Vector3(0, y+4, -60);
        cam.transform.position =  pos;
    }
}
