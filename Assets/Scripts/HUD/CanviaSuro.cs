using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanviaSuro : MonoBehaviour
{
    // Start is called before the first frame update
    public contradiccioSuro[] suros;
    public GameObject fons;


    void Start()
    {
        suros = GetComponentsInChildren<contradiccioSuro>();
    }

    public void novesContradiccions(int id)
    {
        foreach(contradiccioSuro contradiccions in suros)
        {
            if (id == contradiccions.idContradiccio)
            {
                Debug.Log("NOVA CONTRADICCIO");
                contradiccions.activar();
                contradiccions.gameObject.SetActive(false);
            }
        }
    }

    public void Activar(bool estat)
    {
        fons.SetActive(estat);
        foreach(contradiccioSuro cs in suros)
        {
            cs.gameObject.SetActive(estat);
        }
    }
}

