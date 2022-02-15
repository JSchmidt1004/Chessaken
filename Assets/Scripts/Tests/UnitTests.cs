using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UnitTests
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(new int[] { 3, 7, -1, -1, 4, -1, 5, -1 }, 4)]
    public void CheckPieceSafeTrueCheck(int[] positions, int pieceIndex)
    {
        Assert.That(Board.checkPieceSafe(positions, pieceIndex));
    }

    [Test]
    [TestCase(new int[] { 4, 7, -1, -1, 4, -1, 5, -1 }, 4)]
    public void CheckPieceSafeFalseCheck(int[] positions, int pieceIndex)
    {
        Assert.That(!Board.checkPieceSafe(positions, pieceIndex));
    }

    [Test]
    [TestCase(new int[] {-1, -1, -1, -1, -1, -1, -1, -1 })]
    public void GetRooksCheck(int[] positions)
    {
        Board.getRookLocations(positions);
        Assert.That(!(Math.Abs(positions[0] - positions[1]) < 2));
    }

    [Test]
    [TestCase(new int[] { 3, 7, -1, -1, -1, -1, 5, -1 })]
    public void GetBishopsCheck(int[] positions)
    {
        Board.getBishopLocations(positions);
        Assert.That(positions[4] % 2 != positions[5] % 2);
    }

    [Test]
    [TestCase(new int[] { 3, 7, -1, -1, 4, 1, 5, -1 })]
    public void GetOthersCheck(int[] positions)
    {
        bool othersPlaced = Board.getOtherLocations(positions);
        Assert.That(othersPlaced);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator UnitTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
