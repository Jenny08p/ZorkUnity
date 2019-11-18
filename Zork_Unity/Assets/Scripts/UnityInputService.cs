using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork_Common;
using UnityEngine.UI;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputReceived;

    public InputField InputField; 

    void Start()
    {
        InputField.Select();
        InputField.ActivateInputField();
    }

    public void ProcessInput()
    {
        InputReceived?.Invoke(this, InputField.text); 
    }
}
