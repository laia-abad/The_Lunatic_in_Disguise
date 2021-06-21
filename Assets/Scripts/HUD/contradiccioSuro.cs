using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contradiccioSuro : MonoBehaviour
{
    public int idContradiccio;
    public string text;
    private TextMeshProUGUI textMesh;
    private CanvasGroup canvasGroup;


    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        canvasGroup.alpha = 0;
    }

    public void activar()
    {
        canvasGroup.alpha = 1;
        textMesh.SetText(text);
    }
}
