using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData
{
    public bool Left { get { return Input.GetKey(KeyCode.A); } }
    public bool Right { get { return Input.GetKey(KeyCode.D); } }
    public bool Down { get { return Input.GetKey(KeyCode.S); } }
    public bool Up { get { return Input.GetKey(KeyCode.W); } }
    public bool Action { get { return Input.GetKeyDown(KeyCode.E); } }
    public bool Exit { get { return Input.GetKeyDown(KeyCode.Escape); } }
    public bool Shift { get { return Input.GetKey(KeyCode.LeftShift); } }
    public bool SpacePress { get { return Input.GetKeyDown(KeyCode.Space); } }
}
