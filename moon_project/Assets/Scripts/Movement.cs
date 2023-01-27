using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processThrust();
        processInput();
    }

    void processThrust() {
        if (Input.GetKey(KeyCode.Space)) {
            rb.AddRelativeForce();
        }
    }

    void processInput()
    {
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("Rotate Left");
        }
        else if (Input.GetKey(KeyCode.D)) {
            Debug.Log("Rotate Right");
        }
    }
}
