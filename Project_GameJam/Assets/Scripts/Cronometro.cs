 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public int minutos;
    public int segundos;
    public TMP_Text tiempo;
    private float restantes;
    public bool enMarcha;

    public MenuManager menuManager;

    private void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
    }
    public void Awake()
    {
        restantes = (minutos * 60) + segundos;
        enMarcha = true;
    }

    public void Update() 
    {
        if (enMarcha)
        {
            restantes -= Time.deltaTime;

            if (restantes < 1) 
            {
                enMarcha=false;
                menuManager.Lose();
            }

            int tempMin = Mathf.FloorToInt(restantes / 60);
            int tempSegundos = Mathf.FloorToInt(restantes % 60);

            tiempo.text = string.Format("{00:00} : {01:00}", tempMin, tempSegundos);
        }
    }

}
