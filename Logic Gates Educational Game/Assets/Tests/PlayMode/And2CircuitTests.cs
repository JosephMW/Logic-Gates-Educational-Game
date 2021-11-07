using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class And2CircuitTests
{
    [UnityTest]
    public IEnumerator WhenGivenTrueTrue_shouldCalculateTrue()
    {
        var gameObject = new GameObject();
        var and2 = gameObject.AddComponent<And2Circuit>();
        var input1 = gameObject.AddComponent<CircuitInputTrigger>();
        var input2 = gameObject.AddComponent<CircuitInputTrigger>();
        var and2Output = gameObject.AddComponent<Wire>();

        and2.input1 = input1;
        and2.input2 = input2;
        and2.output = and2Output;

        input1.ownerAnd2Circuit = and2;
        input2.ownerAnd2Circuit = and2;

        input1.setValue(true);
        input2.setValue(true);

        yield return new WaitForSeconds(3);

        Assert.AreEqual(true, and2.valueOut);
    }
}
