using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //typ zmiennej nazwa;
        //deklaracja;
        int a;
        //inicjalizacja
        a = 10;
        //2 w 1
        int b = 20;
        

        {//skakanie
            Debug.Log(b);
        }

        {//chodzenie
            int c = 20;
        }
        //Debug.Log(c);

        float fa = 1.5f;
        fa = 4;
        bool logiczna = true; //false
        string str = "napis";

        Debug.Log("fa: " + fa + " logiczna: " + logiczna + " str: " + str);

        //operacje na zmiennych 
        Debug.Log(a/b);
        Debug.Log(a/fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);

        //if (warunek logiczny) {
        //}

        if(a == b)
        {
            Debug.Log("Tak, jest taka sama");
            koniukcja(a, b);
        } else if(a > b)
        {
            Debug.Log("Tak, jest rozna");
            Alternatywa();
        } else
        {
            Debug.Log("zadne z powyzszych");
            Alternatywa();
            koniukcja(a, b);
        }

        koniukcja(a, b);

        Alternatywa();
    }

    public void koniukcja(int a, int b)
    {
        //koniukcja
        Debug.Log((a != b) && (a > 0));

        if (a != b)
        {
            if (a > 0)
            {
                //kod
            }
        }

        if ((a != b) && (a > 0))
        {
            //kod
        }
    }

    public void Alternatywa()
    {
        // brzydka wersja
        int hp = 2, time = 1;
        bool amulet = true;

        if (hp <= 0)
        {
            if (!amulet) //sprawdzimy czy amulet == false
            {

            }
            else
            {

            }
        }

        //ladna wersja
        if ((hp <= 0 || time <= 0)
        {
            if (!amulet)
            {

            }
            else
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
