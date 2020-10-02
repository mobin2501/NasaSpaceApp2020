using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public Rigidbody rb;

    public static float x = 15f;
    public static float y = 15f;
    Vector3 up;
    Vector3 down= new Vector3(0, 10, 0);
    //Vector3 side = new Vector3(-x, 0, 0);
    Vector3 rot = new Vector3(0, 0, 15);
    static float ang = 0f;

    private void Start()
    {
        InvokeRepeating("Thrust", 60*Time.fixedDeltaTime,20*Time.fixedDeltaTime);
    }
    void FixedUpdate()
    {
        up = new Vector3(x, y, 0); 
        ang = rb.rotation.eulerAngles.z;
        if(ang>=0 && ang <= 90)
        {
            y = 25 * Mathf.Cos((rb.rotation.eulerAngles.z) * Mathf.PI / 180);
            x = -25 * Mathf.Sin((rb.rotation.eulerAngles.z) * Mathf.PI / 180);
        }
        if (ang >= 270 && ang < 360)
        {
            y = 25 * Mathf.Cos((rb.rotation.eulerAngles.z) * Mathf.PI / 180);
            x = -25 * Mathf.Sin((rb.rotation.eulerAngles.z) * Mathf.PI / 180);
        }
        //y = 25 * Mathf.Cos((rb.rotation.eulerAngles.z)*Mathf.PI/180);
        //x = 25 * Mathf.Sin((rb.rotation.eulerAngles.z)* Mathf.PI/180);
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
            rb.transform.Rotate(-rot * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(rot * Time.fixedDeltaTime);
        }
        /*if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    {
        rb.AddForce(side, ForceMode.Acceleration);
    }
    if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    {
        rb.AddForce(-side, ForceMode.Acceleration);
    }*/
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.gameObject.tag=="Plane")
        {
            Debug.Log("Launch Failed");
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Planet")
        {
            Debug.Log(other.gameObject.name);
        }
    }
    void Thrust()
    {
        //Debug.Log(rb.transform.position);
        //Debug.Log(rb.rotation.eulerAngles.z+" "+x+" "+y);
        //Debug.Log(x+" "+y);
    }
}