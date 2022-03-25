using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MultiplexerTests
{
    private GameObject gameObject;
    private Multiplexer mux;
    private InputPort[] inputPorts;
    private Wire[] outputWires;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        mux = gameObject.AddComponent<Multiplexer>();
        var input0 = gameObject.AddComponent<InputPort>();
        var input1 = gameObject.AddComponent<InputPort>();
        var controlBit = gameObject.AddComponent<InputPort>();
        var muxOutput = gameObject.AddComponent<Wire>();

        InputPort[] inputPorts = { input0, input1, controlBit };
        this.inputPorts = inputPorts;
        Wire[] outputWires = { muxOutput };
        this.outputWires = outputWires;

        mux.inputPorts = inputPorts;
        mux.outputWires = outputWires;

        input0.ownerCircuitParent = mux;
        input1.ownerCircuitParent = mux;
        controlBit.ownerCircuitParent = mux;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(mux);
        Object.Destroy(inputPorts[0]);
        Object.Destroy(inputPorts[1]);
        Object.Destroy(inputPorts[2]);
        Object.Destroy(outputWires[0]);
        Object.Destroy(gameObject);
    }

    #region control bit false
    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_withControlBitFalse_ShouldOutputTrue()
    {
        bool in0 = true;
        bool in1 = true;
        bool control = false;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_withControlBitFalse_ShouldOutputTrue()
    {
        bool in0 = true;
        bool in1 = false;
        bool control = false;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_withControlBitFalse_ShouldOutputFalse()
    {
        bool in0 = false;
        bool in1 = true;
        bool control = false;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_withControlBitFalse_ShouldOutputFalse()
    {
        bool in0 = false;
        bool in1 = false;
        bool control = false;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }
    #endregion

    #region control bit true
    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_withControlBitTrue_ShouldOutputTrue()
    {
        bool in0 = true;
        bool in1 = true;
        bool control = true;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_withControlBitTrue_ShouldOutputFalse()
    {
        bool in0 = true;
        bool in1 = false;
        bool control = true;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_withControlBitTrue_ShouldOutputTrue()
    {
        bool in0 = false;
        bool in1 = true;
        bool control = true;
        bool[] expectedOutput = { true };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_withControlBitTrue_ShouldOutputFalse()
    {
        bool in0 = false;
        bool in1 = false;
        bool control = true;
        bool[] expectedOutput = { false };

        inputPorts[0].setValue(in0);
        inputPorts[1].setValue(in1);
        inputPorts[2].setValue(control);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, mux.calculateOutputs());
    }
    #endregion
}