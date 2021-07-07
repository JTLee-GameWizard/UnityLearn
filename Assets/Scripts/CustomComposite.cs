using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
[DisplayStringFormat("{firstPart}+{secondPart}")]
public class CustomComposite : InputBindingComposite<float>
{
    [InputControl(layout = "Button")]
    public int firstPart;

    [InputControl(layout = "Button")]
    public int secondPart;

    public float floatParamater;
    public bool boolParamater;

    public override float ReadValue(ref InputBindingCompositeContext context)
    {
        var firstPartValue = context.ReadValue<float>(firstPart);
        var secondPartValue = context.ReadValue<float>(secondPart);
        return firstPart + secondPart;
    }

    static CustomComposite()
    {
        InputSystem.RegisterBindingComposite<CustomComposite>();
    }

    [RuntimeInitializeOnLoadMethod]
    static void Init() { }
}
