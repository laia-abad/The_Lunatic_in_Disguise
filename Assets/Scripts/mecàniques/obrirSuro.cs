using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obrirSuro : MonoBehaviour
{
    public HUD_manager HUD;
    public MovimentSimple moviment;
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        HUD = GameObject.Find("HUD").GetComponent<HUD_manager>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Collision " + collision.gameObject.name);
        if (collision.gameObject.name.Equals("Robin"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                activarSuro(!isActive);
                isActive = !isActive;
                Debug.Log("DINS");
            }
        }
    }

    //true per obrir i false per tancar el suro
    public void activarSuro(bool enable)
    {
        HUD.activarSuro(enable);
        moviment.Mov = !enable;
    }
}
