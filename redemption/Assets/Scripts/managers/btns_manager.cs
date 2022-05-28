using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class btns_manager : MonoBehaviour
{
    public event EventHandler onAcceptBtnPressed;

    public void Accep()
    {
        onAcceptBtnPressed?.Invoke(this, EventArgs.Empty);
    }
}
