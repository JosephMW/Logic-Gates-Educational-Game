using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SplitterGateTests
{
    private GameObject gameObject;
    private SplitterGate splitter;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        splitter = gameObject.AddComponent<SplitterGate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var splitterOutput = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { splitterOutput };
        this.outputWires = outputWires;

        splitter.inputPorts = inputPorts;
        splitter.outputWires = outputWires;

        input0.ownerCircuitParent = splitter;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(splitter);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrue_ShouldOutputTrue()
    {
        bool in0 = true;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalse_ShouldOutputFalse()
    {
        bool in0 = false;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, splitter.calculateOutputs());
    }
}
