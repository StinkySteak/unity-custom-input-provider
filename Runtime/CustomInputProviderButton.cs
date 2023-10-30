using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;

namespace StinkySteak.CustomInput
{
    public class CustomInputProviderButton : OnScreenControl
    {
        [InputControl(layout = "Button")]
        [SerializeField] private string _inputAxis;

        protected override string controlPathInternal
        {
            get => _inputAxis;
            set => _inputAxis = value;
        }

        public void SendValue(float value)
            => SendValueToControl(value);

        public void SendValue(bool value)
        {
            float valueToSend = value ? 1.0f : 0.0f;

            SendValueToControl(valueToSend);
        }
    }
}