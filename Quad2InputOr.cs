using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad2InputOr : Chip
{
    public new List<OrGate> gates;
    void Start()
    {
        int j = 0;
        for (int i = 0; i < 4; i++)
        {
            assignDuoInputs(gates[i], chipIns[i + j], chipIns[i + j + 1]);
            j++;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int j = 0;
        for (int i = 0; i < 4; i++)
        {
            gates[i].computeOr(chipIns[i + j], chipIns[i + j + 1], chipOuts[i]);
            j++;
        }
    }
}
