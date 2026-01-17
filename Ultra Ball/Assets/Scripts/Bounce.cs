using System.IO;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;
    public int power;
         
    void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(transform.up * power);
    }
}