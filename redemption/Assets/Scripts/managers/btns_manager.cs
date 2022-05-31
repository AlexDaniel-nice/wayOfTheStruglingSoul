using System;
using UnityEngine;

public class btns_manager : MonoBehaviour
{
    public event EventHandler onAcceptBtnPressed;
    public event EventHandler onClearListBtnPressed;

    public void Accep()
    {
        onAcceptBtnPressed?.Invoke(this, EventArgs.Empty);
    }

    public void Clear_List()
    {
        onClearListBtnPressed?.Invoke(this, EventArgs.Empty);
        Debug.Log("CLEAR");
    }
}
