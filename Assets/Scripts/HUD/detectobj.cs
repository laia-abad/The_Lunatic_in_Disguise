using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class detectobj : MonoBehaviour, IDropHandler
{
    //public GameObject movobj;
    public Mouobj mouobj;
    public GameObject movobj;
    public detectobj detobj;

    public TextMeshProUGUI text;
    public int idNota;
    public detectorContradiccions contradiccions;
    public Animator animator;


    private void Start()
    {
        mouobj = null;//movobj.GetComponentInChildren<Mouobj>();
        contradiccions = GetComponentInParent<detectorContradiccions>();
    }



    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Mouobj nota = eventData.pointerDrag.GetComponentInChildren<Mouobj>();
            Debug.Log("On drop " + nota);

            if (nota.isInterectable())
            {
                if (mouobj != null) mouobj.activar();
                mouobj = nota;
                //mouobj = eventData.pointerDrag.GetComponentInChildren<Mouobj>();

                //RectTransform cardRect = eventData.pointerDrag.GetComponent<RectTransform>();
                //cardRect.SetParent(transform, false);
                //cardRect.transform.position = transform.position;
                Debug.Log("vaig a fer l'if.idnota: " + mouobj.idnota);
                text.SetText(mouobj.text);
                //mouobj.textMesh.SetText("");

                idNota = mouobj.idnota;
                contradiccions.esContradiccio();
            }

        }

    }

    public void novaContradiccio(bool estat)
    {
        if (estat)
        {
            //correcte
            Debug.Log("EScorrecte");
            animator.Play("correcte", -1, 0f);
        } else
        {
            //incorrecte
            Debug.Log("mal");
            animator.Play("malament",-1, 0f);
        }
    }
}
