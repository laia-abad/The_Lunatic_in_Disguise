using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_manager : MonoBehaviour
{
    private bool canvi = false;

    public Canvas canvas1;
    public Canvas canvas2;
    public Canvas canvas3;
    public Canvas canvas4;
    public Canvas canvas5;
    private MovimentSimple Robin;
    public Canvas blaus;
    public GameObject suro;
    public GameObject botons;
    public bool HUD_activable;
    public GameObject pausa;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        newScene();
        actualitzaNotes();
        suro.GetComponent<CanviaSuro>().Activar(false);
        //no desactivar-lo, moure'l del centre
        botons.SetActive(false);
        pausa.SetActive(false);
        menu.SetActive(false);
    }

    public void newScene()
    {
        GetComponent<parles>().newScene();
        Robin = GameObject.Find("Robin").GetComponent<MovimentSimple>();
    }

    public void activarBotoHud()
    {
        botons.SetActive(true);
        HUD_activable = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            actualitzaNotes();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pausa.SetActive(true);
        }
    }

    public void actualitzaNotes()
    {
        if (HUD_activable)
        {
            setNotes(canvi);
            Robin.notesObertes = canvi;
            canvi = !canvi;
        }
    }

    public void activarSuro(bool estat)
    {
        if(HUD_activable) suro.GetComponent<CanviaSuro>().Activar(estat);
    }

    //Funcio que activa o desactiva les notes del Barry
    public void setNotes(bool estat)
    {
        blaus.gameObject.SetActive(estat);
        canvas1.gameObject.SetActive(estat);
        canvas2.gameObject.SetActive(false);
        canvas3.gameObject.SetActive(false);
        canvas4.gameObject.SetActive(false);
        canvas5.gameObject.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausa.SetActive(false);
    }

    public void Options()
    {
        pausa.SetActive(false);
        menu.SetActive(true);
    }

    public void exit()
    {
        ScenesManager.Load(ScenesManager.Scene.menu);
        Destroy(this.gameObject);
    }

    public void tornarAMenu()
    {
        pausa.SetActive(true);
        menu.SetActive(false);
    }
}
