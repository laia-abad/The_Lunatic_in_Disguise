using UnityEngine;
using Fungus;

public class tes : MonoBehaviour
{
  
    Flowchart flowchart;
    private MovimentSimple moviment;
    public static bool started;
    public seguimentcamera camera;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        moviment = GameObject.Find("Robin").GetComponent<MovimentSimple>();
        //moviment = FindObjectOfType<MovimentSimple>();
        flowchart = GetComponent<Flowchart>();
        camera = GameObject.Find("Main Camera").GetComponent<seguimentcamera>();
        audio = GetComponent<AudioSource>();
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Robin"))
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter)) && !started && !moviment.notesObertes)
            {
                moviment.Mov = false;
                flowchart.ExecuteBlock("iniciConv");
                started = true;
                camera.aproparse();
            }
        }
        //Es repren el moviment Mov a Cinematiques.nouInvestigat();
    }
    public void playEffect()
    {
        audio.Play();
    }
}
