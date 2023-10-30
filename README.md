# Unity Custom Input Provider

This plugin is made to simplify the Unity New Input System for sending inputs without dependency on the input class.

### Example Usage
1. Add `CustomInputProviderButton` component to UI Button
1. Change the input type as you want on the inspector
1. Register a onClick button event to call the `CustomInputProviderButton.SendValue(1f);`