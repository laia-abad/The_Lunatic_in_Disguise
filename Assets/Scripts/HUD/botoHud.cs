using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class botoHud : MonoBehaviour
{
    public HUD_manager hud;
    public Button boto;

    // Start is called before the first frame update
    void Start()
    {
        boto.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        hud.actualitzaNotes();
    }
}
