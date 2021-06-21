using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class Mouobj : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
   // [SerializeField] private Sprite sprite;
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Vector2 startPosition;

    public int idnota;
    public string text;
    public TextMeshProUGUI textMesh;
    private Image image;
    public bool interactable;
    public static int separacio;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        canvas = GetComponentInParent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {        
        startPosition = transform.position;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        //Si s'arrossega per la pantalla
        if (!eventData.pointerEnter.name.Equals("text-detector"))
        {
            Debug.Log("FAIL");
        }
        //Si s'arrosega a un detector
        else
        {
            //Operacio per retornar a la posicio inicial
            desactivar();
            //desactivar();
            transform.position = startPosition;
            Debug.Log("OLEE");
        }
    }

    public void activar()
    {
        this.rectTransform.Translate(new Vector3(separacio, -separacio, 0));
        separacio = separacio + 5;
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        textMesh.SetText(text);
        interactable = true;
        this.gameObject.SetActive(true);
    }

    public void desactivar()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        this.gameObject.SetActive(false);
        interactable = false;
    }
    public bool isInterectable() { return interactable; }
}
