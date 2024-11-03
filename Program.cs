using System;

namespace StatePatternExample
{

    // Main Program to test the LightSwitch and state transitions
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new LightSwitch instance, starting in OffState
            LightSwitch lightSwitch = new LightSwitch();
            Console.WriteLine($"intial lightSwitch.state =>{lightSwitch.State} ");
            // Toggle the light to turn it on
            lightSwitch.Toggle(); // Output: Turning light on...

            // Toggle the light again to turn it off
            lightSwitch.Toggle(); // Output: Turning light off...

            // Toggle the light once more to turn it back on
            lightSwitch.Toggle(); // Output: Turning light on...
        }
    }
}
