using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketScript : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject sphere;
    public static float x = 15f;
    public static float y = 15f;
    Vector3 up;
    Vector3 down= new Vector3(0, 10, 0);
    //Vector3 side = new Vector3(-x, 0, 0);
    Vector3 rot = new Vector3(0, 0, 15);
    static float ang = 0f;

    
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
            Thrust();
            rb.AddForce(up, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Thrust();
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
        if (collision.collider.gameObject.tag == "Asteroid")
        {
            SceneManager.LoadScene(8);
        }
        if (collision.collider.gameObject.tag == "BigPlanet")
        {
            SceneManager.LoadScene(13);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Planet")
        {
            SceneManager.LoadScene(7);
        }
        
    }
    void Thrust()
    {
        sphere.SetActive(true);
        //Debug.Log(rb.transform.position);
        //Debug.Log(rb.rotation.eulerAngles.z+" "+x+" "+y);
        //Debug.Log(x+" "+y);
    }
}