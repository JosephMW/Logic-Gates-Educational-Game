using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FullAdderTests
{
    private GameObject gameObject;
    private FullAdder fullAdd;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        fullAdd = gameObject.AddComponent<FullAdder>();

        var input0 = gameObject.AddComponent<InputPort>();
        var input1 = gameObject.AddComponent<InputPort>();
        var carryIn = gameObject.AddComponent<InputPort>();

        var outputSum = gameObject.AddComponent<Wire>();
        var carryOut = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0, input1, carryIn };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { outputSum, carryOut };
        this.outputWires = outputWires;

        fullAdd.inputPorts = inputPorts;
        fullAdd.outputWires = outputWires;

        input0.ownerCircuitParent = fullAdd;
        input1.ownerCircuitParent = fullAdd;
        carryIn.ownerCircuitParent = fullAdd;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(fullAdd);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(inputPorts[1]);
        Object.Destroy(inputPorts[2]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(gameObject);
    }

    #region carryIn bit false
    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_withcarryInFalse_ShouldOutput_SumFalse_carryOutTrue()
    {
        bool in0 = true;
        bool in1 = true;
        bool carryIn = false;
        bool[] expectedOutput = { false, true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_withcarryInFalse_ShouldOutput_SumTrue_carryOutFalse()
    {
        bool in0 = true;
        bool in1 = false;
        bool carryIn = false;
        bool[] expectedOutput = { true, false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_withcarryInFalse_SumTrue_carryOutFalse()
    {
        bool in0 = false;
        bool in1 = true;
        bool carryIn = false;
        bool[] expectedOutput = { true, false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_withcarryInFalse_ShouldOutput_SumFalse_carryOutFalse()
    {
        bool in0 = false;
        bool in1 = false;
        bool carryIn = false;
        bool[] expectedOutput = { false, false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }
    #endregion

    #region carryIn bit true
    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_withcarryInTrue_ShouldOutput_SumTrue_carryOutTrue()
    {
        bool in0 = true;
        bool in1 = true;
        bool carryIn = true;
        bool[] expectedOutput = { true, true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_withcarryInTrue_ShouldOutput_SumFalse_carryOutTrue()
    {
        bool in0 = true;
        bool in1 = false;
        bool carryIn = true;
        bool[] expectedOutput = { false, true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_withcarryInTrue_ShouldOutput_SumFalse_carryOutTrue()
    {
        bool in0 = false;
        bool in1 = true;
        bool carryIn = true;
        bool[] expectedOutput = { false, true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_withcarryInTrue_ShouldOutput_SumTrue_carryOutFalse()
    {
        bool in0 = false;
        bool in1 = false;
        bool carryIn = true;
        bool[] expectedOutput = { true, false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(carryIn);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, fullAdd.calculateOutputs());
    }
    #endregion
}