using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            m_Rigidbody.velocity = -transform.up * m_Speed;
        if (Input.GetKey(KeyCode.S))
            m_Rigidbody.velocity = transform.up * m_Speed;
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0f, 0f, 1.5f);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0f, 0f, -1.5f);
    }
}
