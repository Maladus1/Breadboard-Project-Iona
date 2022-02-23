using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexInverter : Chip
{
    public new List<NotGate> gates;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            assignSingleInput(gates[i], chipIns[i]);
        }
    }

    void FixedUpdate()
    {
        for (int i = 0; i < 6; i++)
        {
            gates[i].computeNot(chipIns[i], chipOuts[i]);
        }
    }
}
