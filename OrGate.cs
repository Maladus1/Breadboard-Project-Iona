using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGate : LogicGate
{
    public void FixedUpdate()
    {
        computeOr(inputs[0], inputs[1], outputs[0]);
    }
    public void computeOr(Wire in0, Wire in1, Wire out0)
    {
        if (!in0.value && !in1.value) { out0.value = false; }
        else if (in0.value && !in1.value) { out0.value = true; }
        else if (!in0.value && in1.value) { out0.value = true; }
        else { out0.value = true; }

        sendOutput();
    }
}
