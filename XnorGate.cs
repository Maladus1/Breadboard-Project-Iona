using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XnorGate : LogicGate
{
    public void computeXnor()
    {
        if (inputs[0].GetOuput() == inputs[1].GetOuput()) { output = true; }
        else { output = false; }
    }
}
