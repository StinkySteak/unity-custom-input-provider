using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;

namespace StinkySteak.CustomInput
{
    public class CustomInputProviderVector2 : OnScreenControl
    {
        [InputControl(layout = "Vector2")]
        [SerializeField] private string _inputAxis;

        protected override string controlPathInternal
        {
            get => _inputAxis;
            set => _inputAxis = value;
        }

        public void SendValue(Vector2 value)
        {
            SendValueToControl(value);
        }
    }
}