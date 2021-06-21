using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exits : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Application.Quit();
        

        Debug.Log("exit menu");
    }

    public void sortirJoc()
    {
        ScenesManager.Load(ScenesManager.Scene.menu);
    }

}
