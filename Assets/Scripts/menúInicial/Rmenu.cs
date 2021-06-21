using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rmenu : MonoBehaviour
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
        ScenesManager.Load(ScenesManager.Scene.menu);
    }


}
