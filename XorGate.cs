using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorGate : LogicGate
{
    public void computeXor()
    {
        if (inputs[0].GetOuput() == inputs[1].GetOuput()) { output = false; }
        else { output = true; }
    }
}
