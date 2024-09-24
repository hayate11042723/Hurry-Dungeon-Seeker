using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshPro test;

    // Update is called once per frame
    void Update()
    {
        // ゲームパッドが接続されていないとnullになる。
        if (Gamepad.current == null)
        {
            test.text = "null";
        }
        if (Gamepad.current != null)
        {
            test.text = "OK";
        }
        if (Gamepad.current.buttonEast.isPressed)
        {
            test.text = "Button North Push";
        }
        if (Gamepad.current.buttonNorth.isPressed)
        {
            test.text = "Button North Pushed！";
        }
        if (Gamepad.current.buttonSouth.isPressed)
        {
            test.text = "Button South Rerease！";
        }
        if (Gamepad.current.buttonWest.isPressed)
        {
            test.text = "Button West Pushed";
        }
    }

}
