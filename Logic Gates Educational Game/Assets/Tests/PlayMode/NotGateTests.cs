using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NotGateTests
{
    private GameObject gameObject;
    private NotGate not;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        not = gameObject.AddComponent<NotGate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var notOutput = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { notOutput };
        this.outputWires = outputWires;

        not.inputPorts = inputPorts;
        not.outputWires = outputWires;

        input0.ownerCircuitParent = not;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(not);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrue_ShouldOutputFalse()
    {
        bool in0 = true;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, not.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalse_ShouldOutputTrue()
    {
        bool in0 = false;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, not.calculateOutputs());
    }
}
