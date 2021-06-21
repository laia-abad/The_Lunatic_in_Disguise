using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class but_barry : MonoBehaviour
{
    public Canvas canvas_actiu;
    public Canvas canvas2;
    public Canvas canvas3;
    public Canvas canvas4;
    public Canvas canvas5;
    //public Button yourButton;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        canvas_actiu.gameObject.SetActive(true);
        canvas2.gameObject.SetActive(false);
        canvas3.gameObject.SetActive(false);
        canvas4.gameObject.SetActive(false);
        canvas5.gameObject.SetActive(false);
    }
}
