using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Splitter4GateTests
{
    private GameObject gameObject;
    private Splitter4Gate splitter4;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        splitter4 = gameObject.AddComponent<Splitter4Gate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var output0 = gameObject.AddComponent<Wire>();
        var output1 = gameObject.AddComponent<Wire>();
        var output2 = gameObject.AddComponent<Wire>();
        var output3 = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { output0, output1, output2, output3 };
        this.outputWires = outputWires;

        splitter4.inputPorts = inputPorts;
        splitter4.outputWires = outputWires;

        input0.ownerCircuitParent = splitter4;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(splitter4);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(outputWires[1]);
        Object.Destroy(outputWires[2]);
        Object.Destroy(outputWires[3]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrue_ShouldOutputTrueTrueTrueTrue()
    {
        bool in0 = true;
        bool[] expectedOutput = { true, true, true, true };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter4.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalse_ShouldOutputFalseFalseFalseFalse()
    {
        bool in0 = false;
        bool[] expectedOutput = { false, false, false, false };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter4.calculateOutputs());
    }
}
