using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    public List<LogicGate> inputs;
    public List<bool> outputs;
    public List<LogicGate> gates;

    public LogicGate GetInput(int i) { return inputs[i]; }

    public bool GetOutput(int i) { return outputs[i]; }

}
