using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorGate : LogicGate
{
    public void FixedUpdate()
    {
        computeXor(inputs[0], inputs[1], outputs[0]);
    }
    public void computeXor(Wire in0, Wire in1, Wire out0)
    {
        if (in0.value == in1.value) { outValue = false; }
        else { out0.value = true; }

        sendOutput();
    }
}
