namespace StatePatternExample
{
    // Concrete State representing the light being "On"
    public class OnState : LightState
    {
        // Method to turn the light off and change to OffState
        public override void Toggle(LightSwitch lightSwitch)
        {
            Console.WriteLine("Turning light off...");
            Console.WriteLine($"current lightSwitch.state =>{lightSwitch.State} ");
            // Transition to OffState
            lightSwitch.SetState(new OffState());
            Console.WriteLine($"after set state  lightSwitch.state =>{lightSwitch.State} ");
        }
    }
}
