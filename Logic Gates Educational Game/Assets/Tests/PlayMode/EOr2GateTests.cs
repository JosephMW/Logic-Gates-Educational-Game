using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EOr2GateTests
{
    private GameObject gameObject;
    private EOr2Gate eor2;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        eor2 = gameObject.AddComponent<EOr2Gate>();
        var input0 = gameObject.AddComponent<InputPort>();
        var input1 = gameObject.AddComponent<InputPort>();
        var eor2Output = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0, input1 };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { eor2Output };
        this.outputWires = outputWires;

        eor2.inputPorts = inputPorts;
        eor2.outputWires = outputWires;

        input0.ownerCircuitParent = eor2;
        input1.ownerCircuitParent = eor2;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(eor2);
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

        Assert.AreEqual(expectedOutput, eor2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_ShouldOutputTrue()
    {
        bool in0 = true;
        bool in1 = false;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, eor2.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_ShouldOutputTrue()
    {
        bool in0 = false;
        bool in1 = true;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, eor2.calculateOutputs());
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

        Assert.AreEqual(expectedOutput, eor2.calculateOutputs());
    }
}
