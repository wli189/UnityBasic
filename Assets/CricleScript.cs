using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricleScript : MonoBehaviour
{
    Renderer m_Renderer;
    Rigidbody m_Rigidbody;
    int threshhold = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateColor();
        if (GameObject.Find("Cube").GetComponent<SquareScript>().shiftCount % 5 == threshhold) {
            m_Rigidbody.AddForce(new Vector3(0f, 4f, 0f), ForceMode.Force);
        }
    }

    void UpdateColor() {
        m_Renderer.material.color = GameObject.Find("Cube").GetComponent<SquareScript>().GetColor();
    }
}
