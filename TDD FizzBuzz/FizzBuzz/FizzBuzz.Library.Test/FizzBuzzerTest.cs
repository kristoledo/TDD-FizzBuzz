﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Test
{
    [TestFixture]
    public class FizzBuzzerTest
    {
       
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput(
            [Values(1,2,4,7,8,11,13,14)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz(
            [Values(3,6,9,12)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz(
            [Values(5,10)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
