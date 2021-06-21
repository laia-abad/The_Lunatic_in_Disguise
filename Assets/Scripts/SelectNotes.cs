using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectNotes : MonoBehaviour
{
    public GameObject contradiction;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Toggle>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (contradiction.GetComponent<Toggle>().isOn)
        {
            GetComponent<Toggle>().enabled = true;
        }
        if (!contradiction.GetComponent<Toggle>().isOn)
        {
            GetComponent<Toggle>().enabled = false;
        }
    }
}
