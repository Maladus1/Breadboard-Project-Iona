using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triple3InputNand : Chip
{
    public new List<NandGate> gates;
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
            computeTripleNand(chipIns[i + j], chipIns[i + j + 1], chipIns[i + j + 2], temp, chipOuts[i]);
            j++;
        }
    }

    public void computeTripleNand(Wire in0, Wire in1, Wire in2, bool tempOut, Wire out0)
    {
        if (in0.value && in1.value) { tempOut = false; }
        else { tempOut = true; }

        if (tempOut && in2.value) { out0.value = false; }
        else { out0.value = true; }
    }
}
