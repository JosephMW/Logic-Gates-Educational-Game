using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class And2CircuitTests
{
    private GameObject gameObject;
    private And2Circuit and2;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        and2 = gameObject.AddComponent<And2Circuit>();
        var input0 = gameObject.AddComponent<InputPort>();
        var input1 = gameObject.AddComponent<InputPort>();
        var and2Output = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0, input1 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { and2Output };
        this.outputWires = outputWires;

        and2.inputPorts = inputPorts;
        and2.outputWires = outputWires;

        input0.ownerCircuitParent = and2;
        input1.ownerCircuitParent = and2;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(and2);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(inputPorts[1]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_ShouldOutputTrue()
    {
        bool in0 = true;
        bool in1 = true;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_ShouldOutputFalse()
    {
        bool in0 = true;
        bool in1 = false;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_ShouldOutputFalse()
    {
        bool in0 = false;
        bool in1 = true;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_ShouldOutputFalse()
    {
        bool in0 = false;
        bool in1 = false;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.calculateOutputs());
    }
}
