using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 moveDIv;
    float movePower = 5;

    Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDIv.x += Input.GetAxis("Horizontal") * Time.deltaTime * movePower;
        moveDIv.z += Input.GetAxis("Vertical") * Time.deltaTime * movePower;
        if (moveDIv != Vector3.zero) {
            rigidbody.MovePosition(moveDIv);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            moveDIv += Vector3.up * Time.deltaTime * 100f;
        }
    }
}
