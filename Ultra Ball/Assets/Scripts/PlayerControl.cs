using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float jumpStrength;
    public AudioSource JumpSound;
    bool canJump = true;
    Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        camOffset = Camera.main.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb.AddForce(speed, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -speed);
        }

        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, speed);
        }
    //
            if (Input.GetKey("d"))
            {
                rb.AddForce(speed, 0, 0);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-speed, 0, 0);
            }

            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -speed);
            }

            if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, speed);
            }
    //
        if (Input.GetKeyDown("space") && canJump == true) 
        {
            JumpSound.Play();
            rb.AddForce(0, jumpStrength, 0, ForceMode.Impulse);
            canJump = false;
        }

        Camera.main.transform.position = transform.position + camOffset;

        if(transform.position.y < -10)
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
}
