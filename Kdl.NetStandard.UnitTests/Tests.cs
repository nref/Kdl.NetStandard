using NUnit.Framework;
using System;
using System.Linq;

namespace Kdl.NetStandard.UnitTests;

[TestFixture]
public class Tests
{
    private Chain chain_;
    [SetUp]
    public void Setup()
    {
        // Create a KDL chain object
        chain_ = new();

        // Add segments to the chain
        chain_.addSegment(new Segment(new Joint(Joint.JointType.RotZ), new Frame(new Vector(0.0, 0.0, 330.0))));
        chain_.addSegment(new Segment(new Joint(Joint.JointType.RotY), new Frame(new Vector(0.0, 0.0, 440.0))));
        chain_.addSegment(new Segment(new Joint(Joint.JointType.RotY), new Frame(new Vector(420.0, 0.0, 50.0))));
        chain_.addSegment(new Segment(new Joint(Joint.JointType.RotX), new Frame(new Vector(0.0, 0.0, 0.0))));
        chain_.addSegment(new Segment(new Joint(Joint.JointType.RotY), new Frame(new Vector(80.0, 0.0, 0.0))));
        chain_.addSegment(new Segment(new Joint(Joint.JointType.RotZ), new Frame(new Vector(0.0, 0.0, 0.0))));
    }

    [Test]
    public void GetNrOfJoints_ReturnsCorrectNumberOfJoints()
    {
        double nj = chain_.getNrOfJoints();
        Assert.AreEqual(6, nj);
    }

    [Test]
    public void JntArray_GetSet_RoundTripPreserved()
    {
        JntArray arr = new(3);
        arr.set(0, 1.234);
        arr.set(1, 2.234);
        arr.set(2, 3.234);

        double j0 = arr.get(0);
        double j1 = arr.get(1);
        double j2 = arr.get(2);

        Assert.AreEqual(1.234, j0);
        Assert.AreEqual(2.234, j1);
        Assert.AreEqual(3.234, j2);
    }

    [Test]
    public void JntToCart_IsCorrect()
    {
        JntArray jointpositions = new(6);

        foreach (int i in Enumerable.Range(0, 6))
        {
            jointpositions.set(i, 0);
        }

        Frame cartesianPos = new();

        // Create the forward kinematics solver
        var fk = new ChainFkSolverPos_recursive(chain_);
        var kinematics_status = fk.JntToCart(jointpositions, cartesianPos);
        Assert.AreEqual(0, kinematics_status);

        double x = cartesianPos.p.x();
        double y = cartesianPos.p.y();
        double z = cartesianPos.p.z();

        Assert.AreEqual(500, x);
        Assert.AreEqual(0, y);
        Assert.AreEqual(820, z);
    }

    [Test]
    public void GetEulerZyx_IsCorrect()
    {
        var jointAngles = new double[] { 0, Math.PI/2, Math.PI/8, 0, 0, 0 };
        JntArray jointpositions = new((uint)jointAngles.Length);

        foreach (int i in Enumerable.Range(0, 6))
        {
            jointpositions.set(i, jointAngles[i]);
        }

        Frame cartesianPos = new();

        // Create the forward kinematics solver
        var fk = new ChainFkSolverPos_recursive(chain_);
        var kinematics_status = fk.JntToCart(jointpositions, cartesianPos);
        Assert.AreEqual(0, kinematics_status);

        cartesianPos.M.GetEulerZYX(out double alfa, out double beta, out double gamma);

        Assert.AreEqual(Math.PI, alfa);
        Assert.AreEqual(Math.PI/4 + Math.PI/8, beta);
        Assert.AreEqual(Math.PI, gamma);
    }
}
