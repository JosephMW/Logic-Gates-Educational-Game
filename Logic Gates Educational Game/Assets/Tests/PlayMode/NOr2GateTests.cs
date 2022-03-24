using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NOr2GateTests
{
    private GameObject gameObject;
    private NOr2Gate nor2;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        nor2 = gameObject.AddComponent<NOr2Gate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var input1 = gameObject.AddComponent<InputPort>();
        var nor2Output = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0, input1 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { nor2Output };
        this.outputWires = outputWires;

        nor2.inputPorts = inputPorts;
        nor2.outputWires = outputWires;

        input0.ownerCircuitParent = nor2;
        input1.ownerCircuitParent = nor2;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(nor2);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(inputPorts[1]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_ShouldOutputFalse()
    {
        bool in0 = true;
        bool in1 = true;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, nor2.calculateOutputs());
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

        Assert.AreEqual(expectedOutput, nor2.calculateOutputs());
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

        Assert.AreEqual(expectedOutput, nor2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_ShouldOutputTrue()
    {
        bool in0 = false;
        bool in1 = false;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, nor2.calculateOutputs());
    }
}
