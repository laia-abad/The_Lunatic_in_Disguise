using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CinematiquesHabitacio : MonoBehaviour
{
    public GameObject Robin;
    private Flowchart fc;
    private Animator anim;
    public GameObject canviEscena;
    private static bool primerDialeg;
    public Animator transicio;
    public static bool parlatAmbTothom;
    public RuntimeAnimatorController cineAnim;
    public RuntimeAnimatorController animRobin;

    void Start()
    {
        fc = Robin.GetComponent<Flowchart>();
        anim = Robin.GetComponent<Animator>();
        Robin.GetComponent<MovimentSimple>().Mov = true;
        if (!primerDialeg) dialegIntroduccio();
        if (parlatAmbTothom) setDialegCanviFase();
    }

    public void moure() { Robin.GetComponent<MovimentSimple>().Mov = true; }
    public void noMoure() { Robin.GetComponent<MovimentSimple>().Mov = false; }

    public void anarADormir()
    {
        noMoure();
        transicio.SetTrigger("starts");
        parlatAmbTothom = false;
        GameObject.Find("canviFase").GetComponent<Flowchart>().SetBooleanVariable("parlatAmbTothom", false);

    }

    public void despertarse()
    {
        transicio.SetTrigger("ends");
        moure();
    }

    //Un cop a parlat amb els 5 sospitosos s'activa la variable per canviar el dialeg de canvi de fase
    public void setDialegCanviFase()
    {
        GameObject.Find("canviFase").GetComponent<Flowchart>().SetBooleanVariable("parlatAmbTothom", parlatAmbTothom);
    }

    /*************************
     * 
     * FASE 1
     * 
     * **********************/
    //Primerdialeg de l'habitacio. PART 1
    public void dialegIntroduccio()
    {
        anim.runtimeAnimatorController = cineAnim;
        Robin.transform.position = new Vector3(-10.7f, -1.97f, 0f);
        primerDialeg = true;
        canviEscena.GetComponent<BoxCollider2D>().enabled = false;
        noMoure();
        fc.ExecuteBlock("iniciConv");
        GameObject.Find("canviFase").GetComponent<BoxCollider2D>().enabled = false;
    }

    //Part 2
    public void dialegIntroduccio2()
    {
        // Execucio de l'animacio
        anim.Play("Dormir0");
    }

    //Part 3
    public void dialegIntroduccio3()
    {
        //S'activa el canvi d'escena
        canviEscena.GetComponent<BoxCollider2D>().enabled = true;

        // Execucio de l'animacio d'estirar-se al llit
        anim.Play("Dormir 1");
    }

    //Part 4
    public void dialegIntroduccio4()
    {
        //animacio d'aixecar-se del llit i anar a la porta
        anim.Play("Dormir 2");
        transicio.SetTrigger("ends");
    }

    public void setAnimator() { anim.runtimeAnimatorController = animRobin; }

    /**********************
     * 
     * FASE 2
     * 
     * *******************/

    public void iniciFase2()
    {
        noMoure();
        Cinematiques.setPrimerDialegFase2();
        //dialeg inicial
        fc.ExecuteBlock("iniciFase2");
        moure();
    }

    /*********************
     * 
     * FASE 3
     * 
     * ******************/
    public void iniciFase3()
    {
        noMoure();
        Cinematiques.setPrimerDialegFase3();

        //dialeg inicial
        fc.ExecuteBlock("iniciFase3");

        //animacio aixecar-se
        moure();

    }

    public void cinematicaInicialFase()
    {
        Debug.Log("CINEMATICAINICIAL FASE " + SceneChange.fase);
        switch (SceneChange.fase)
        {
            case 2:
                iniciFase2();
                break;
            case 3:
                iniciFase3();
                break;
        }
    }
}
