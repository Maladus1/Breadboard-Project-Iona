using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorGate : LogicGate
{
    public void FixedUpdate()
    {
        computeNor(inputs[0], inputs[1], outputs[0]);
    }
    public void computeNor(Wire in0, Wire in1, Wire out0)
    {
        if (!in0.value && !in1.value) { out0.value = true; }
        else { out0.value = false; }

        sendOutput();
    }
}
