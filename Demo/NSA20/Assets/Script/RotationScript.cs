
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 rot = new Vector3(0, 25, 0);

    private void Start()
    {
        InvokeRepeating("Thrust", 60 * Time.fixedDeltaTime, 20 * Time.fixedDeltaTime);
    }
    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(rot * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(-rot * Time.fixedDeltaTime);
        }
    }
    void Thrust()
    {
        //Debug.Log(rb.transform.position);
        Debug.Log(rb.transform.rotation.eulerAngles.y);
        //Debug.Log(x+" "+y);
    }
}
