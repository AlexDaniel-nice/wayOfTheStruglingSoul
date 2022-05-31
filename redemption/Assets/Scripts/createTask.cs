using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class createTask : MonoBehaviour
{
    //pt event
    [SerializeField] GameObject btn_manager;

    //pt a obtine prefab-ul pt task
    [SerializeField] GameObject PF_task;

    //pt a obine parintele final
    [SerializeField] Transform task_content;

    GameObject task_text;
    TMP_Text txt;
    btns_manager clickedAccept;
    TMP_InputField task_textEditor;

    void Start()
    {
        task_textEditor = GetComponent<TMP_InputField>();
        
        task_text = PF_task.transform.GetChild(0).gameObject;
        txt = task_text.GetComponent<TMP_Text>();

        clickedAccept = btn_manager.GetComponent<btns_manager>();
        clickedAccept.onAcceptBtnPressed += ClickedAccept_onAcceptBtnPressed;      
    }

    private void ClickedAccept_onAcceptBtnPressed(object sender, System.EventArgs e)
    {
        GameObject new_task;

        new_task = Instantiate(PF_task);
        new_task.transform.SetParent(task_content);
        new_task.transform.localScale = task_content.localScale;

        txt.text = task_textEditor.text;

        Debug.Log("Boing");
        Debug.Log(task_textEditor.text);
    }
}
