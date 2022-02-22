using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public bool value;
    private int i;

    void Update()
    {
        if (value == true) { this.GetComponent<LineRenderer>().material.color = new Color(0f, 1f, 0f, 0f); }
        else if (value == false) { this.GetComponent<LineRenderer>().material.color = new Color(1f, 0f, 0f, 0f); }
    }
}
