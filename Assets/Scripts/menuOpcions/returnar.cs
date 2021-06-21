using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class returnar : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
  
    public Canvas canvas;
    public Canvas canvas2;
    void Start()
    {
       
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
       
        canvas.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);
    }


}
