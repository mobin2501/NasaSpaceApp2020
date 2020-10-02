using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public Rigidbody rb;

    public static float x = 25f;
    public static float y = 25f;
    Vector3 up = new Vector3(0,y, 0);
    Vector3 side = new Vector3(-x, 0, 0);

    private void Start()
    {
        InvokeRepeating("Thrust", 60*Time.fixedDeltaTime,20*Time.fixedDeltaTime);
    }
    void FixedUpdate()
    {
        //up = rb.position;
        /*y = 25 * Mathf.Cos((rb.rotation.eulerAngles.z)*Mathf.PI/180);
        x = 25 * Mathf.Sin((rb.rotation.eulerAngles.z)* Mathf.PI/180);*/
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(up, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-up, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(side, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-side, ForceMode.Acceleration);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.gameObject.tag=="Plane")
        {
            Debug.Log("Launch Failed");
        }
    }
    void Thrust()
    {
        //Debug.Log(rb.transform.position);
        //Debug.Log(rb.rotation.eulerAngles);
        //Debug.Log(x+" "+y);
    }
}