using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class seguimentcamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject seguir;
    public Vector3 posicioRelativa;
    private Animation cinematiques;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        cinematiques = GetComponent<Animation>();
        camera = GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seguir.GetComponent<MovimentSimple>().Mov)
        {
            transform.position = new Vector3(seguir.transform.position.x + posicioRelativa.x, transform.position.y, transform.position.z);
        }
        
    }
    public void aproparse()
    {
        camera.orthographicSize = 3;
        transform.position = new Vector3(seguir.transform.position.x, -7.66f, transform.position.z);

    }

    public void allunyarse()
    {
        camera.orthographicSize = 5.85f;
        transform.position = new Vector3(seguir.transform.position.x, posicioRelativa.y, transform.position.z);
        tes.started = false;
    }

}


