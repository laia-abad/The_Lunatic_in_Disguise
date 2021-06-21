using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class res : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
  
    public Canvas canvas;
    void Start()
    {
      
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Time.timeScale = 1;
        canvas.gameObject.SetActive(false);
    }


}
