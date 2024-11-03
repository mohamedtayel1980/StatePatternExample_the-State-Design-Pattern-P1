namespace StatePatternExample
{
    // Context class representing the LightSwitch
    public class LightSwitch
    {
        // Field to store the current state
        private LightState _state;

        // Constructor initializes the LightSwitch in the OffState
        public LightSwitch()
        {
            // Initial state is Off
            State = new OffState();
        }

        public LightState State { get => _state; set => _state = value; }

        // Method to change the state of the LightSwitch
        public void SetState(LightState state)
        {
            State = state;
        }

        // Method to toggle the light by delegating to the current state's Toggle method
        public void Toggle()
        {
            State.Toggle(this);
        }
    }
}
