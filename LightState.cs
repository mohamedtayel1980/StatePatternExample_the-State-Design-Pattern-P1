namespace StatePatternExample
{
    // Abstract class defining a State for the LightSwitch
    public abstract class LightState
    {
        // Toggle method that each state will implement differently
        public abstract void Toggle(LightSwitch lightSwitch);
    }
}
