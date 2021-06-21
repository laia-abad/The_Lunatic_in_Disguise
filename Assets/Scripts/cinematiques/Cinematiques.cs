using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Cinematiques : MonoBehaviour
{
    private Flowchart fc;
    private static bool primerDialeg;
    private static bool primerDialeg1;
    private static bool primerDialeg2;
    private static bool primerDialeg3;
    private static bool poli;
    public GameObject Robin;
    public GameObject Narrativa;
    private Animator animCamera;
    private Animator animRobin;
    private AnimationEvent moureRobin;
    private static int sospitososInvestigats = 0;
    public seguimentcamera camera;

    // Start is called before the first frame update
    void Start()
    {
        //Helena = GameObject.Find("Helena").GetComponent<Flowchart>();
        fc = Narrativa.GetComponent<Flowchart>();
        Robin.GetComponent<MovimentSimple>().Mov = true;
        GameObject cameraObject = GameObject.Find("Main Camera");
        animCamera = cameraObject.GetComponent<Animator>();
        camera = cameraObject.GetComponent<seguimentcamera>();
        animRobin = Robin.GetComponent<Animator>();
        if (!primerDialeg) DialegIntroduccio();
        if (primerDialeg1) iniciFase1Carrer();
        if (primerDialeg2) iniciFase2Carrer();
        if (primerDialeg3) iniciFase3Carrer();
        if (poli) animacioPoli();
    }

    public void moure() { Robin.GetComponent<MovimentSimple>().Mov = true; }
    public void noMoure() { Robin.GetComponent<MovimentSimple>().Mov = false; }

    void DialegIntroduccio()
    {
        //Prohibir moure el personatge
        Robin.GetComponent<MovimentSimple>().Mov = false;
        primerDialeg = true;
        //Començar la conversa
        fc.ExecuteBlock("iniciConv");
        primerDialeg1 = true;
    }

    void animacioInicial1()
    {
        animCamera.Play("cinematicaInicial");
    }

    void moureRobinAPosicio2()
    {
        animRobin.Play("cineInicialRobin");
    }

    void moureRobinAPorta()
    {
        animRobin.Play("cineRobinAPorta");
    }

    void iniciarFugidaEmmascarat()
    {
        Animator emmascarada = GameObject.Find("Emmascarada").GetComponent<Animator>();
        emmascarada.Play("Fugida");
    }

    void instruccioInicial()
    {
        if (sospitososInvestigats == 1 && SceneChange.fase==1)
        {
            noMoure();
            fc.ExecuteBlock("instruccioInicial");
        }
    }

    public static void setPrimerDialegFase1() { primerDialeg1 = true; }

    void iniciFase1Carrer()
    {
        fc.ExecuteBlock("iniciFase1");
        primerDialeg1 = false;
    }

    /*****************************
     * 
     * FASE 2
     * 
     * **************************/

    public static void setPrimerDialegFase2() { primerDialeg2 = true; }

    void iniciFase2Carrer()
    {
        primerDialeg2 = false;
        sospitososInvestigats = 0;

    }


    /*****************************
     * 
     * FASE 3
     * 
     * **************************/

    public static void setPrimerDialegFase3() { primerDialeg3 = true; }

    void iniciFase3Carrer()
    {
        primerDialeg3 = false;
        sospitososInvestigats = 0;
        fc.ExecuteBlock("foguera");
    }

    void animacioPoli()
    {
        poli = true;
        Narrativa.GetComponent<Animation>().PlayQueued("Poli");
    }



    /*****************************
     * 
     * GLOBAL
     * 
     * **************************/

    void nouInvestigat()
    {
        sospitososInvestigats++;
        Robin.GetComponent<MovimentSimple>().Mov = true;
        instruccioInicial();
        camera.allunyarse();
        if (sospitososInvestigats == 5)
        {
            fc.ExecuteBlock("totsInvestigats");
            CinematiquesHabitacio.parlatAmbTothom = true;
        }
    }

    public void final()
    {
        ScenesManager.Load(ScenesManager.Scene.creditsFinals);
    }

    public void acabarJoc()
    {
        ScenesManager.Load(ScenesManager.Scene.menu);
    }
}