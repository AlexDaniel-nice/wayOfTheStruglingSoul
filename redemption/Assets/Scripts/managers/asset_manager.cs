using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class asset_manager : MonoBehaviour
{
    [SerializeField] private GameObject task_template;

    private static asset_manager _i;

    private static asset_manager i
    {
        get
        {
            if (_i == null) _i = (Instantiate(Resources.Load("mng_asset")) as GameObject).GetComponent<asset_manager>();
            return _i;
        }
    }


}
