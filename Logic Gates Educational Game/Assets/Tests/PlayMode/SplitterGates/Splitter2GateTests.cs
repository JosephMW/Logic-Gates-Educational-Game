using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Splitter2GateTests
{
    private GameObject gameObject;
    private Splitter2Gate splitter2;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        splitter2 = gameObject.AddComponent<Splitter2Gate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var output0 = gameObject.AddComponent<Wire>();
        var output1 = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { output0, output1 };
        this.outputWires = outputWires;

        splitter2.inputPorts = inputPorts;
        splitter2.outputWires = outputWires;

        input0.ownerCircuitParent = splitter2;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(splitter2);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(outputWires[1]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrue_ShouldOutputTrueTrue()
    {
        bool in0 = true;
        bool[] expectedOutput = { true, true };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalse_ShouldOutputFalseFalse()
    {
        bool in0 = false;
        bool[] expectedOutput = { false, false };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter2.calculateOutputs());
    }
}
