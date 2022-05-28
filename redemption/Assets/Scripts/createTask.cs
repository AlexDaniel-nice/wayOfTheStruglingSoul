using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createTask : MonoBehaviour
{
    [SerializeField] GameObject btn_manager;

    btns_manager clickedAccept;
    InputField newChore;

    // Start is called before the first frame update
    void Start()
    {
        clickedAccept = btn_manager.GetComponent<btns_manager>();
        newChore = this.GetComponent<InputField>();

        clickedAccept.onAcceptBtnPressed += ClickedAccept_onAcceptBtnPressed;
        
    }

    private void ClickedAccept_onAcceptBtnPressed(object sender, System.EventArgs e)
    {
        //instantiez un task cu textul imput fieldului
        //plasez copia in chenar
        Debug.Log("Boing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
