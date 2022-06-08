using TMPro;
using UnityEngine;


public class createTask : MonoBehaviour
{
    //pt event
    [SerializeField] btns_manager addEvent;

    //pt a obtine prefab-ul pt task
    [SerializeField] GameObject PF_task;

    //pt a obine parintele final
    [SerializeField] Transform task_panel;

    GameObject task_text;
    TMP_Text txt;
    TMP_InputField task_textEditor;

    //initializare
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

        task_text = new_task.transform.GetChild(0).gameObject;
        txt = task_text.GetComponent<TMP_Text>();

        txt.text = task_textEditor.text;
    }
}
