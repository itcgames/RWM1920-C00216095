using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FanTestScript
    {
        GameObject Fan = Resources.Load("Fan") as GameObject;
        GameObject TestBall = Resources.Load("TestBall") as GameObject;
        //Tests that the Fan is in the scene
        [UnityTest]
        public IEnumerator SearchTest()
        {
            Assert.IsNotNull(Fan);
            yield return null;
        }

        //Tests to see if the fan is repelled upwards
        [UnityTest]
        public IEnumerator VelocityTest()
        {
            bool velocityFlipped = false;
            if (TestBall.GetComponent<Rigidbody2D>().velocity.y > 1)
            {
                velocityFlipped = true;
            }
            yield return velocityFlipped;
        }
    }
}
