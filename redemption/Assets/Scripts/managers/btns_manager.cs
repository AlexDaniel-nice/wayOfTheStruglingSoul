using System;
using UnityEngine;

public class btns_manager : MonoBehaviour
{
    public event EventHandler onAcceptBtnPressed;

    public void Accep()
    {
        onAcceptBtnPressed?.Invoke(this, EventArgs.Empty);
    }
}
