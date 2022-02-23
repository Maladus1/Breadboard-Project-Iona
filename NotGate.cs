using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : LogicGate
{
    public void FixedUpdate()
    {
        computeNot(inputs[0], outputs[0]);
    }
    public void computeNot(Wire in0, Wire out0)
    {
        if (!in0.value) { out0.value = true; }
        else { out0.value = false; }

        sendOutput();
    }
}
