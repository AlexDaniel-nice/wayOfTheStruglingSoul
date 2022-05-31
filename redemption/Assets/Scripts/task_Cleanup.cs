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

        for (int i = 0; i < Task_Container.childCount; i++)
        {
            GameObject child = Task_Container.GetChild(i).gameObject;

            child.transform.DetachChildren();
            Destroy(child);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
