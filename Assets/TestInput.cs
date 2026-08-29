using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class TestInput: MonoBehaviour
{
    [SerializeField] private InputActionProperty triggerValue;
    [SerializeField] private InputActionProperty gripValue;

    private void Update()
    {
        float value = triggerValue.action.ReadValue<float>();
        Debug.Log($"Value: {value}");

        bool button = gripValue.action.IsPressed();
        Debug.Log($"Button: {button}"); 
    }
}