using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Splitter3GateTests
{
    private GameObject gameObject;
    private Splitter3Gate splitter3;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        splitter3 = gameObject.AddComponent<Splitter3Gate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var output0 = gameObject.AddComponent<Wire>();
        var output1 = gameObject.AddComponent<Wire>();
        var output2 = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { output0, output1, output2 };
        this.outputWires = outputWires;

        splitter3.inputPorts = inputPorts;
        splitter3.outputWires = outputWires;

        input0.ownerCircuitParent = splitter3;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(splitter3);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(outputWires[1]);
        Object.Destroy(outputWires[2]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrue_ShouldOutputTrueTrueTrue()
    {
        bool in0 = true;
        bool[] expectedOutput = { true, true, true };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter3.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalse_ShouldOutputFalseFalseFalse()
    {
        bool in0 = false;
        bool[] expectedOutput = { false, false, false };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter3.calculateOutputs());
    }
}
