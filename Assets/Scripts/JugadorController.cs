using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuadorController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5.0f;
    private Rigidbody rb;
    public Transform camara;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 forward = camara.forward;
        Vector3 right = camara.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = (forward * moveZ + right * moveX);
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);

        rb.AddForce(moveX * moveSpeed, 0, moveZ * moveSpeed, ForceMode.Acceleration);

    }

}