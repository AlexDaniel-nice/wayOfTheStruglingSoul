using TMPro;
using UnityEngine;


public class createTask : MonoBehaviour
{
    //legatura catre event
    [SerializeField] btns_manager addEvent;

    //referinta la Prefab
    [SerializeField] GameObject PF_task;

    //parintele noului task
    [SerializeField] Transform task_panel;

    //cache related vars
    TMP_InputField task_textEditor;

    private void Awake()
    {
        task_textEditor = GetComponent<TMP_InputField>();
        addEvent.onAcceptBtnPressed += addEvent_onAcceptBtnPressed;
    }

    private void addEvent_onAcceptBtnPressed(object sender, System.EventArgs e)
    {
        GameObject new_task;

        //initializare template
        new_task = Instantiate(PF_task);
        new_task.transform.SetParent(task_panel);
        new_task.transform.localScale = task_panel.localScale;

        GameObject task_text;
        task_text = new_task.transform.GetChild(0).gameObject;

        TMP_Text txt;
        txt = task_text.GetComponent<TMP_Text>();
        txt.text = task_textEditor.text;
    }
}
