using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorContradiccions : MonoBehaviour
{
    public detectobj detector1;
    public detectobj detector2;

    private int id1;
    private int id2;

    public CanviaSuro cs;


    public void esContradiccio()
    {
        id1 = detector1.idNota;
        id2 = detector2.idNota;

        if (idCoincidents(105, 108))
        {
            animacioButxaques(true);
            setContradiccio(1);
        }

        else if (idCoincidents(208, 302))
        {
            animacioButxaques(true);
            setContradiccio(6);
        }

        else if (idCoincidents(303, 413))
        {
            animacioButxaques(true);
            setContradiccio(4);
            setContradiccio(8);
        }

        else if (idCoincidents(501, 412))
        {
            animacioButxaques(true);
            setContradiccio(11);
        }

        else if (idCoincidents(125, 221))
        {
            animacioButxaques(true);
            setContradiccio(2);
        }

        else if (idCoincidents(420, 424))
        {
            animacioButxaques(true);
            setContradiccio(9);
        }

        else if (idCoincidents(425, 521))
        {
            animacioButxaques(true);
            setContradiccio(12);

        }
        else if (idCoincidents(523, 520))
        {
            animacioButxaques(true);
            setContradiccio(13);
        }

        else if (idCoincidents(552, 553))
        {
            animacioButxaques(true);
            setContradiccio(14);
        }

        else if (idCoincidents(550, 451))
        {
            animacioButxaques(true);
            setContradiccio(15);
        }

        else if (idCoincidents(150, 551))
        {
            animacioButxaques(true);
            setContradiccio(16);
            setContradiccio(3);
        }

        else if (idCoincidents(251, 452))
        {
            animacioButxaques(true);
            setContradiccio(7);
            setContradiccio(10);
        }

        else if (idCoincidents(351, 354))
        {
            animacioButxaques(true);
            setContradiccio(5);
        } else
        {
            animacioButxaques(false);
        }
    }

    private bool idCoincidents(int varA, int varB)
    {
        return (this.id1 == varA && id2 == varB || id1 == varB && id2 == varA);
    }

    //Es crida a la funcio que pinta vermell o verd segons el resultat
    void animacioButxaques(bool estat)
    {
        Debug.Log("la contradiccio shauria de posar tal que " + estat);
        detector1.novaContradiccio(estat);
        detector2.novaContradiccio(estat);
    }

    //Funció que es crida quan s'ha trobat una contradicció
    private void setContradiccio(int id)
    {
        cs.novesContradiccions(id);
    }

}