using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Notesba : MonoBehaviour
{


    public parles parla;


    public TMP_Text MyText;
    public TMP_Text MyText2;
    public TMP_Text MyText3;
    public TMP_Text MyText4;
    public TMP_Text MyText5;
    public TMP_Text MyText6;
    public TMP_Text MyText7;
    public TMP_Text MyText8;
    public TMP_Text MyText9;
    public TMP_Text MyText10;
    public TMP_Text MyText11;
    public TMP_Text MyText12;
    public TMP_Text MyText13;
    public TMP_Text MyText14;
    public TMP_Text MyText15;
    public TMP_Text MyText16;
    public TMP_Text MyText17;
    public TMP_Text MyText18;
    public TMP_Text bMyText;
    public TMP_Text bMyText2;
    public TMP_Text bMyText3;
    public TMP_Text bMyText4;
    public TMP_Text bMyText5;
    public TMP_Text bMyText6;
    public TMP_Text bMyText7;
    public TMP_Text bMyText8;
    public TMP_Text bMyText9;
    public TMP_Text bMyText10;
    public TMP_Text bMyText11;
    public TMP_Text bMyText12;
    public TMP_Text bMyText13;
    public TMP_Text bMyText14;
    public TMP_Text cMyText;
    public TMP_Text cMyText2;
    public TMP_Text cMyText3;
    public TMP_Text cMyText4;
    public TMP_Text cMyText5;
    public TMP_Text cMyText6;
    public TMP_Text cMyText7;
    public TMP_Text cMyText8;
    public TMP_Text cMyText9;
    public TMP_Text cMyText10;
    public TMP_Text cMyText11;
    public TMP_Text cMyText12;
    public TMP_Text cMyText13;
    public TMP_Text cMyText14;
    public TMP_Text cMyText15;
    public TMP_Text cMyText16;
    public TMP_Text cMyText17;
    public TMP_Text cMyText18;
    public TMP_Text oMyText;
    public TMP_Text oMyText2;
    public TMP_Text oMyText3;
    public TMP_Text oMyText4;
    public TMP_Text oMyText5;
    public TMP_Text oMyText6;
    public TMP_Text oMyText7;
    public TMP_Text oMyText8;
    public TMP_Text oMyText9;
    public TMP_Text oMyText10;
    public TMP_Text oMyText11;
    public TMP_Text oMyText12;
    public TMP_Text oMyText13;
    public TMP_Text oMyText14;
    public TMP_Text oMyText15;
    public TMP_Text oMyText16;
    public TMP_Text oMyText17;
    public TMP_Text oMyText18;
    public TMP_Text oMyText19;
    public TMP_Text oMyText20;
    public TMP_Text oMyText21;
    public TMP_Text oMyText22;
    public TMP_Text oMyText23;
    public TMP_Text oMyText24;
    public TMP_Text pMyText;
    public TMP_Text pMyText2;
    public TMP_Text pMyText3;
    public TMP_Text pMyText4;
    public TMP_Text pMyText5;
    public TMP_Text pMyText6;
    public TMP_Text pMyText7;
    public TMP_Text pMyText8;
    public TMP_Text pMyText9;
    public TMP_Text pMyText10;
    public TMP_Text pMyText11;
    public TMP_Text pMyText12;
    public TMP_Text pMyText13;
    public TMP_Text pMyText14;
    public TMP_Text pMyText15;
    public TMP_Text pMyText16;






    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*int notabarry1 = flowchart.GetIntegerVariable("Barry");
        Debug.Log("NOTA ANTINFGA = " + notaAntiga + ". NOTA NOVA = " + notabarry1);

        if(notabarry1 != notaAntiga)
        {
            setText(notabarry1);
            notaAntiga = notabarry1;
        }

        if (parl.ba102 == true)
        {

            MyText.text = "Eleanor’s brother";
        }

        if (parl.ba107 == true)
        {

            MyText2.text = "Super rich";
        }

        if (parl.ba101 == true)
        {

            MyText3.text = "People think he’s miserable";
        }

        if (parl.ba105 == true)
        {

            MyText4.text = "Was out of town with friends";
        }

        if (parl.ba108 == true)
        {

            MyText6.text = "Mum’s ex";
        }

        if (parl.ba122 == true)
        {

            MyText5.text = "Was out of town with friends";
        }
        if (parl.ba123 == true)
        {

            MyText7.text = "orphan too young";
        }

        if (parl.ba121 == true)
        {

            MyText8.text = "Won the lottery";
        }

        if (parl.ba120 == true)
        {

            MyText9.text = "Owns a clothes factory";
        }

        if (parl.ba125 == true)
        {

            MyText10.text = "Nobody complains about his factory";
        }

        if (parl.ba156 == true)
        {

            MyText11.text = "Lonely guy";
        }

        if (parl.ba155 == true)
        {

            MyText12.text = "Can’t leave ‘cause mum";
        }
        if (parl.ba155 == true)
        {

            MyText13.text = "Has no friends";
        }

        if (parl.ba153 == true)
        {

            MyText14.text = "Still has a crush on mum";
        }

        if (parl.ba151 == true)
        {

            MyText15.text = "Reported Bruce to cops";
        }

        if (parl.ba150 == true)
        {

            MyText16.text = "Thinks Pamela is the masked";
        }

        if (parl.ba154 == true)
        {

            MyText17.text = "tornar amb els seus nebots";

        }
        /*if (parl.ba999== true)
        {

            MyText18.text = "Blames Bruce Eleanor’s dead";
        }

        if (parl.br301 == true)
        {

            bMyText.text = "Has 2 children";
        }

        if (parl.br307 == true)
        {

            bMyText2.text = "Began drinking to overcome wife’s death";
        }

        if (parl.br300 == true)
        {

            bMyText3.text = "Alcohol made him more negligent";
        }

        if (parl.br302 == true)
        {

            bMyText4.text = "Heard people talking at Carol’s";
        }

        if (parl.br303 == true)
        {

            bMyText6.text = "Was at bar drinking";
        }

        if (parl.br323 == true)
        {

            bMyText5.text = "Lost custody because alcohol";
        }
        if (parl.br321 == true)
        {

            bMyText7.text = "Wife died at a car crash";
        }

        if (parl.br320 == true)
        {

            bMyText8.text = "Town’s cleaner";
        }

        if (parl.br322 == true)
        {

            bMyText9.text = "ruined";
        }

        if (parl.br354 == true)
        {

            bMyText10.text = "He controls drink, but fools town";
        }

        if (parl.br351 == true)
        {

            bMyText11.text = "Can’t stop drinking";
        }

        if (parl.br350 == true)
        {

            bMyText12.text = "Believes is incompetent to rise his children";
        }
        if (parl.br352 == true)
        {

            bMyText13.text = "Feels guilty for wife’s death";
        }

        if (parl.br353 == true)
        {

            bMyText14.text = "tornen l’Helena i el Damian al poble ";
        }

        if (parl.car207 == true)
        {

            cMyText.text = "Eleanor’s brother";
        }

        if (parl.car211 == true)
        {

            cMyText2.text = "Super rich";
        }

        if (parl.car206 == true)
        {

            cMyText3.text = "People think he’s miserable";
        }

        if (parl.car201 == true)
        {

            cMyText4.text = "Was out of town with friends";
        }

        if (parl.car204 == true)
        {

            cMyText6.text = "Mum’s ex";
        }

        if (parl.car205 == true)
        {

            cMyText5.text = "Was out of town with friends";
        }
        if (parl.car207 == true)
        {

            cMyText7.text = "orphan too young";
        }

        /*if (parl.car999 == true)
        {

            cMyText8.text = "Payed her collection with legacy";
        }

        if (parl.car998 == true)
        {

            cMyText9.text = "Unable to reach her dreams";
        }

        if (parl.car220 == true)
        {

            cMyText10.text = "In a relation with Oliver’s sister";
        }

        if (parl.car221 == true)
        {

            cMyText11.text = "Complains about Barry’s factory";
        }

        if (parl.car222 == true)
        {

            cMyText12.text = "Pamela has looked after her since always";
        }
        if (parl.car223 == true)
        {

            cMyText13.text = "Wants to be the new mayor";
        }

        if (parl.car254 == true)
        {

            cMyText14.text = "Had it off with Oliver";
        }

        if (parl.car250 == true)
        {

            cMyText15.text = "Oliver has discovered their relation";
        }

        /*if (parl.car997 == true)
        {

            cMyText16.text = "Left the city because the lack of apportunities";
        }

        if (parl.car251 == true)
        {

            cMyText17.text = "Been at home all night";

        }
        if (parl.car253 == true)
        {

            cMyText18.text = " acabar juntes públicament";
        }


        if (parl.ol416 == true)
        {

            oMyText.text = "Lidia’s son";
        }

        if (parl.ol401 == true)
        {

            oMyText2.text = "Verdant’s Barman";
        }

        if (parl.ol402 == true)
        {

            oMyText3.text = "Mayor";
        }

        if (parl.ol415 == true)
        {

            oMyText4.text = "Married to Felicity";
        }

        if (parl.ol409 == true)
        {

            oMyText6.text = "Two children(Connor and Mia)";
        }

        if (parl.ol405 == true)
        {

            oMyText5.text = "Sexist";
        }
        if (parl.ol414 == true)
        {

            oMyText7.text = "Sister’s wasn’t at home";
        }

        if (parl.ol413 == true)
        {

            oMyText8.text = "Closed Verdant’s earlier";
        }

        if (parl.ol412 == true)
        {

            oMyText9.text = "Her aunt never visits his mother Lidia";
        }

        if (parl.ol403 == true)
        {

            oMyText10.text = "Thea’s in weelchair";
        }

        if (parl.ol404 == true)
        {

            oMyText11.text = "Somebody wreck the Verdant’s";
        }

        if (parl.ol408 == true)
        {

            oMyText12.text = "Barry has no friends";
        }
        if (parl.ol410 == true)
        {

            oMyText13.text = "Bruce’s friend";
        }

        if (parl.ol422 == true)
        {

            oMyText14.text = "Thea became paralytic few ago";
        }

        if (parl.ol423 == true)
        {

            oMyText15.text = "Both siblings wanted the Verdant’s";
        }

        if (parl.ol420 == true)
        {

            oMyText16.text = "Verdant’s close to bankruptcy";
        }

        if (parl.ol421 == true)
        {

            oMyText17.text = "Homophobic";

        }
        if (parl.ol424 == true)
        {

            oMyText18.text = "Verdant’s doing well economically";
        }
        if (parl.ol425 == true)
        {

            oMyText19.text = "Barry found cow’s excrement at the sewer";
        }
        if (parl.ol450 == true)
        {

            oMyText20.text = "Doesn’t love Felicity";
        }
        if (parl.ol453 == true)
        {

            oMyText21.text = "Diverted públic funds to keep Verdant’s afloat";
        }
        if (parl.ol451 == true)
        {

            oMyText22.text = "Pamela hates he doesn’t use her cow’s milk";
        }
        if (parl.ol452 == true)
        {

            oMyText23.text = "Saw Carol pilled up";
        }
        /*if (parl.ol999 == true)
        {

            oMyText24.text = "Carol nova alcaldessa reina legend la amo";
        }



        if (parl.pam999 == true)
        {

            pMyText.text = "Runs the farm";
        }

        if (parl.pam505 == true)
        {

            pMyText2.text = "Hates to be bothered by villagers";
        }

        if (parl.pam506 == true)
        {

            pMyText3.text = "Prefers loneliness";
        }

        if (parl.pam501 == true)
        {

            pMyText4.text = "Was taking care of her sister Lidia";
        }

        if (parl.pam503 == true)
        {

            pMyText6.text = "Loves kids";
        }

        if (parl.pam504 == true)
        {

            pMyText5.text = "Turtle ate her vegetable garden";
        }
        if (parl.pam502 == true)
        {

            pMyText7.text = "Goes to sleep at 9pm and wakes at 5am";
        }

        if (parl.pam523 == true)
        {

            pMyText8.text = "Never been in a relation";
        }

        if (parl.pam524 == true)
        {

            pMyText9.text = "Work at the farm everyday";
        }

        if (parl.pam520 == true)
        {

            pMyText10.text = "Confessed she was pregnant once";
        }

        if (parl.pam521 == true)
        {

            pMyText11.text = "Has not seen any excrement robbery";
        }

        if (parl.pam522 == true)
        {

            pMyText12.text = "Has found water polluted because Barry’s factory";
        }
        if (parl.pam552 == true)
        {

            pMyText13.text = "Heard Oliver screaming from Carol’s house";
        }

        if (parl.pam553 == true)
        {

            pMyText14.text = "Been sleeping ‘till fire";
        }

        if (parl.pam550 == true)
        {

            pMyText15.text = "Went to sleep to milk her cows and feed town";
        }

        if (parl.pam551 == true)
        {

            pMyText16.text = "Think Barry is the masked”";
        }*/


    }
}
