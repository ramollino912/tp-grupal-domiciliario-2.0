using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class manager : MonoBehaviour
{
    public GameObject[] objects;

    public Text texto1;
    public Text texto2;
    public Text texto3;

    public Text textoobjeto;


    public Text textosuma;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;

    public Transform spawnobjeto;

    public Text ganaroperder;

    public GameObject[] menus;
    int suma1;
    int suma2;
    int resultado;
    void Start()
    {

        int i = Random.Range(0, objects.Length);
        Instantiate(objects[i], spawnobjeto.position, Quaternion.identity);

        resultado = Random.Range(1, 20);
        suma1 = Random.Range(1, resultado);
        suma2 = resultado - suma1;

        textoobjeto.text = suma1 + "$";
        textosuma.text = "+  ?  = " + resultado;

        i = Random.Range(0, objects.Length);

        Instantiate(objects[i], spawn1.position, Quaternion.identity);
        texto1.text = suma2 + "$";

        i = Random.Range(0, objects.Length);
        Instantiate(objects[i], spawn2.position, Quaternion.identity);
        int a;
        do
        {
            a = Random.Range(1, 20);
        } while (a != suma2);
        texto3.text = a.ToString() + "$";

        i = Random.Range(0, objects.Length);
        Instantiate(objects[i], spawn3.position, Quaternion.identity);
        int b;
        do
        {
            b = Random.Range(1, 20);
        } while (b != suma2);
        texto3.text = b.ToString() + "$";
    }


    public void responder()
    {
        if (!o1 && !o2 && !o3) cambionoselecciono();
        else
        {
            cambiarganaroperder();
            if (o1) ganaroperder.text = "Ganar";
            else ganaroperder.text = "Perder";
        }
    }
    public void cambionoselecciono()
    {
        for (int i = 0; i < 3; i++)
        {
            menus[i].SetActive(false);
        }
        menus[1].SetActive(true);
    }
    public void cambiarganaroperder()
    {
        for (int i = 0; i < 3; i++)
        {
            menus[i].SetActive(false);
        }
        menus[2].SetActive(true);
    }
    public void salir()
    {
        SceneManager.LoadScene(0);
    }
    public void reinicio()
    {
        SceneManager.LoadScene(1);
    }
    public void volverseleccion()
    {
        for (int i = 0; i < 3; i++)
        {
            menus[i].SetActive(false);
        }
        menus[0].SetActive(true);
    }


    bool o1 = false;
    bool o2 = false;
    bool o3 = false;

    public void objeto1()
    {
        if (o1) o1 = false;
        else o1 = true;
    }
    public void objeto2()
    {
        if (o2) o2 = false;
        else o2 = true;
    }
    public void objeto3()
    {
        if (o3) o3 = false;
        else o3 = true;
    }
}
