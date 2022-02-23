using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    public List<Wire> chipIns;
    public List<Wire> chipOuts;
    public List<LogicGate> gates;

    public void assignSingleInput(LogicGate gate, Wire in0) { gate.inputs[0] = in0; }

    public void assignDuoInputs(LogicGate gate, Wire in0, Wire in1)
    {
        gate.inputs[0] = in0;
        gate.inputs[1] = in1;    
    }

    public void assignTripleInputs(LogicGate gate, Wire in0, Wire in1, Wire in2)
    {
        gate.inputs[0] = in0;
        gate.inputs[1] = in1;
        gate.inputs[2] = in2;
    }

}
