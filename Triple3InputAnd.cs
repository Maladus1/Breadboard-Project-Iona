using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triple3InputAnd : Chip
{
    public new List<AndGate> gates;
    void Start()
    {
        int j = 0;
        for (int i = 0; i < 3; i++)
        {
            assignTripleInputs(gates[i], chipIns[i + j], chipIns[i + j + 1], chipIns[i + j + 2]);
            j++;
        }
    }

    void FixedUpdate()
    {
        int j = 0;
        for (int i = 0; i < 3; i++)
        {
            bool temp = false;
            computeTripleAnd(chipIns[i + j], chipIns[i + j + 1], chipIns[i + j + 2], temp, chipOuts[i]);
            j++;
        }
    }

    public void computeTripleAnd(Wire in0, Wire in1, Wire in2, bool tempOut, Wire out0)
    {
        if (in0.value && in1.value) { tempOut = true; }
        else { tempOut = false; }

        if (tempOut && in2.value) { out0.value = true; }
        else { out0.value = false; }
    }
}
