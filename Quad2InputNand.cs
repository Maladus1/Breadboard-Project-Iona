using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad2InputNand : Chip
{
    public new List<NandGate> gates;
    void Start()
    {
        int j = 0;
        for (int i = 0; i < 4; i++) 
        {
            assignDuoInputs(gates[i], chipIns[i+j], chipIns[i+j+1]);
            j++;
        }
    }

    void FixedUpdate()
    {
        int j = 0;
        for (int i = 0; i < 4; i++)
        {
            gates[i].computeNand(chipIns[i + j], chipIns[i + j + 1], chipOuts[i]);
            j++;
        }
    }
}
