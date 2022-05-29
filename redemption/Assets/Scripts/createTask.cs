using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createTask : MonoBehaviour
{
    [SerializeField] GameObject btn_manager;
    [SerializeField] GameObject task_template;
    [SerializeField] Transform task_content;

    btns_manager clickedAccept;
    void Start()
    {
        clickedAccept = btn_manager.GetComponent<btns_manager>();
        clickedAccept.onAcceptBtnPressed += ClickedAccept_onAcceptBtnPressed;      
    }

    private void ClickedAccept_onAcceptBtnPressed(object sender, System.EventArgs e)
    {
        GameObject task;

        task = Instantiate(task_template);
        task.transform.SetParent(task_content);
        task.transform.localScale = task_content.localScale;
        Debug.Log("Boing");
    }
}
