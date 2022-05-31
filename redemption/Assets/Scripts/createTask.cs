using TMPro;
using UnityEngine;


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

    //initializare
    private void Awake()
    {
        task_textEditor = GetComponent<TMP_InputField>();

        clickedAccept = btn_manager.GetComponent<btns_manager>();
    }
    void Start()
    {
        clickedAccept.onAcceptBtnPressed += ClickedAccept_onAcceptBtnPressed;
    }

    private void ClickedAccept_onAcceptBtnPressed(object sender, System.EventArgs e)
    {
        GameObject new_task;
        new_task = Instantiate(PF_task);
        new_task.transform.SetParent(task_content);
        new_task.transform.localScale = task_content.localScale;

        task_text = new_task.transform.GetChild(0).gameObject;
        txt = task_text.GetComponent<TMP_Text>();

        txt.text = task_textEditor.text;
    }
}
