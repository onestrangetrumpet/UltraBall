using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;
         
    void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(transform.up * 5);
    }
}