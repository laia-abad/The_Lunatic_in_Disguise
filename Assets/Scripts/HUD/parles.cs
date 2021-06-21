using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parles : MonoBehaviour
{
    public GameObject Barry;
    public GameObject Bruce;
    public GameObject Carol;
    public GameObject Oliver;
    public GameObject Pamela;
    
    public Flowchart BarryFc;
    public Flowchart BruceFc;
    public Flowchart CarolFc;
    public Flowchart OliverFc;
    public Flowchart PamelaFc;

    public GameObject llistaBarry;
    public GameObject llistaBruce;
    public GameObject llistaOliver;
    public GameObject llistaCarol;
    public GameObject llistaPamela;


    //Array amb totes les notes de tots els suspitosos
    public List<Mouobj> notes;
    public int notaAntiga;
    public int notaNova;
    public int notaBarry;
    public int notaBruce;
    public int notaCarol;
    public int notaOliver;
    public int notaPamela;


    // Start is called before the first frame update
    void Start()
    {
        notes = new List<Mouobj>();
        notes.AddRange(llistaBarry.GetComponentsInChildren<Mouobj>());
        notes.AddRange(llistaBruce.GetComponentsInChildren<Mouobj>());
        notes.AddRange(llistaOliver.GetComponentsInChildren<Mouobj>());
        notes.AddRange(llistaCarol.GetComponentsInChildren<Mouobj>());
        notes.AddRange(llistaPamela.GetComponentsInChildren<Mouobj>());

        foreach (Mouobj nota in notes)
        {
            nota.desactivar();
        }

        newScene();
    }

    public void newScene()
    {
        Barry = GameObject.Find("Barry");
        BarryFc = Barry.GetComponent<Flowchart>();

        Bruce = GameObject.Find("Bruce");
        BruceFc = Bruce.GetComponent<Flowchart>();

        Carol = GameObject.Find("Carol");
        CarolFc = Carol.GetComponent<Flowchart>();

        Oliver = GameObject.Find("Oliver");
        OliverFc = Oliver.GetComponent<Flowchart>();

        Pamela = GameObject.Find("Pamela");
        PamelaFc = Pamela.GetComponent<Flowchart>();
    }

    // Update is called once per frame
    void Update()
    {
        int notaBarryNova = BarryFc.GetIntegerVariable("Barry");
        int notaBruceNova = BruceFc.GetIntegerVariable("Bruce");
        int notaCarolNova = CarolFc.GetIntegerVariable("Carol");
        int notaOliverNova = OliverFc.GetIntegerVariable("Oliver");
        int notaPamelaNova = PamelaFc.GetIntegerVariable("Pamela");

        if (notaBarry != notaBarryNova)
        {
            notaBarry = notaBarryNova;
            notaNova = notaBarry;
        }
        if (notaBruce != notaBruceNova)
        {
            notaBruce = notaBruceNova;
            notaNova = notaBruce;
        }
        if (notaCarol != notaCarolNova)
        {
            notaCarol = notaCarolNova;
            notaNova = notaCarol;
        }
        if (notaOliver != notaOliverNova)
        {
            notaOliver = notaOliverNova;
            notaNova = notaOliver;
        }
        if (notaPamela != notaPamelaNova)
        {
            notaPamela = notaPamelaNova;
            notaNova = notaPamela;
        }

        //Si es sobreescriu una variable nova del fungus, s'escriu a la seva nota corresponent
        if (notaNova != notaAntiga)
        {
            foreach(Mouobj nota in notes) {
                if (nota.idnota == notaNova) {
                    nota.activar();
                }
            }
            notaAntiga = notaNova;
        }
    }
}
