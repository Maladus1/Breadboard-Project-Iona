using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NandGate : LogicGate
{
    public void computeNand()
    {
        if (inputs[0].GetOuput() && inputs[1].GetOuput()) { output = false; }
        else { output = true; }
    }
}
