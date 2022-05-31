using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_Cleanup : MonoBehaviour
{
    [SerializeField] btns_manager cleanEvent;
    [SerializeField] Transform Task_Container;

    // Start is called before the first frame update
    void Start()
    {
        cleanEvent.onClearListBtnPressed += CleanEvent_onClearListBtnPressed;
    }

    private void CleanEvent_onClearListBtnPressed(object sender, System.EventArgs e)
    {
        Debug.Log("CLEAR");

        foreach (GameObject child in Task_Container)
        {
            child.transform.DetachChildren();
            Destroy(child);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
