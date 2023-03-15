using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaxesPuntos : MonoBehaviour
{
    public static int score = 0;
    public string scoreText = "Score";

    /* Hace que la puntuacion se muestre en pantalla */
    public Text textscore;
    //public static Score_UI gamescore;

    void Awake()
    {
        //gamescore = this;
    }

    void Update()
    {
        if (textscore != null)
        {
            textscore.text = scoreText + score.ToString();
        }
    }


}
