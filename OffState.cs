namespace StatePatternExample
{
    // Concrete State representing the light being "Off"
    public class OffState : LightState
    {
        // Method to turn the light on and change to OnState
        public override void Toggle(LightSwitch lightSwitch)
        {
            Console.WriteLine("Turning light on...");
            Console.WriteLine($"current lightSwitch.state =>{lightSwitch.State} ");
            // Transition to OnState
            lightSwitch.SetState(new OnState());
            Console.WriteLine($"after set state  lightSwitch.state =>{lightSwitch.State} ");
        }
    }
}
