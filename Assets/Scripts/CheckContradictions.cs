using UnityEngine;
using UnityEngine.UI;

public class CheckContradictions : MonoBehaviour
{
    public GameObject statement;

    private int[] array;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (statement.GetComponent<Toggle>().isOn && GetComponent<Toggle>().isOn)
        {
            Debug.Log("Has trobat una contradicció.");
            statement.GetComponent<Toggle>().isOn = false;
            GetComponent<Toggle>().isOn = false;
        }
    }
}
