using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class And2CircuitTests
{
    private GameObject gameObject;
    private And2Circuit and2;
    private CircuitInputTrigger input1;
    private CircuitInputTrigger input2;
    private Wire and2Output;

    [SetUp]
    public void Setup()
    {
        gameObject = new GameObject();
        and2 = gameObject.AddComponent<And2Circuit>();
        input1 = gameObject.AddComponent<CircuitInputTrigger>();
        input2 = gameObject.AddComponent<CircuitInputTrigger>();
        and2Output = gameObject.AddComponent<Wire>();

        and2.input1 = input1;
        and2.input2 = input2;
        and2.output = and2Output;

        input1.ownerAnd2Circuit = and2;
        input2.ownerAnd2Circuit = and2;
    }

    [TearDown]
    public void Teardown()
    {
        Object.Destroy(and2);
        Object.Destroy(input1);
        Object.Destroy(input2);
        Object.Destroy(and2Output);
        Object.Destroy(gameObject);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_ShouldOutputTrue()
    {
        bool in1 = true;
        bool in2 = true;
        bool expectedOutput = true;

        input1.setValue(in1);
        input2.setValue(in2);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.valueOut);
    }

    [UnityTest]
    public IEnumerator WhenGivenTrueFalse_ShouldOutputFalse()
    {
        bool in1 = true;
        bool in2 = false;
        bool expectedOutput = false;

        input1.setValue(in1);
        input2.setValue(in2);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.valueOut);
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseTrue_ShouldOutputFalse()
    {
        bool in1 = false;
        bool in2 = true;
        bool expectedOutput = false;

        input1.setValue(in1);
        input2.setValue(in2);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.valueOut);
    }

    [UnityTest]
    public IEnumerator WhenGivenFalseFalse_ShouldOutputFalse()
    {
        bool in1 = false;
        bool in2 = false;
        bool expectedOutput = false;

        input1.setValue(in1);
        input2.setValue(in2);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(expectedOutput, and2.valueOut);
    }
}
