using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    Color[] ColorWheel = {Color.black, Color.blue, Color.clear, Color.cyan, Color.gray, Color.green, Color. magenta, Color.red, Color.white, Color.yellow};
    Renderer m_Renderer;
    public int shiftCount  = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z")) {
            ShiftColor();
        }
    }

    public Color GetColor() {
        return m_Renderer.material.color;
    }
    
    public void ShiftColor() {
        Color randColor;
        randColor = ColorWheel[Random.Range(0, 9)];
        Debug.Log("the random color is: " + randColor);
        m_Renderer.material.color = randColor;
        shiftCount++;
    }
}
