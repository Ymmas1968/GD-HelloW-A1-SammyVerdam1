using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody rb;
    public float Speed = 200f;
    public float NegativeLeftSpeed = -200f;
    public GameObject cubeSpawner;
    public GameObject cube;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ;
        float kaasje = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * Speed);
        }
        if (Input.GetKeyDown(KeyCode.D)) { 
            rb.AddRelativeForce(transform.right  * Speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddRelativeForce(transform.right * NegativeLeftSpeed);
        }
    }
    void Launch ()
    {

    }
}
