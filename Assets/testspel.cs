using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testspel : MonoBehaviour { 
    public bool IsChecked;
    public int MyIntValue = 10;
    public float UserValue;
    public int tärning;
    public int tärningminus;
    public int uppgift2poäng = 10;
    public int drake;
    public int spelare = 100;
    private int drakenSlår;
    private int drakendmg1 = 10;
    private int drakendmg2 = 20;

    // Use this for initialization
    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("it's true");
        }
        else
        {
            Debug.Log("die");
        }

        drake = Random.Range(99, 151);
        spelare = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        uppgift1();
        uppgift2();
        uppgift3();
        // == lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >= mer än eller i lika med
        // > större än
        // < mindre än
        // || eller (or)

        ////if (MyIntValue == 10 || IsChecked == true)
        //{   
        // print("måndag");
        //}
        //else if (MyIntValue == 9)
        // {
        // print("tisdag");
        // }
        // else
        //{
        //    print("okänd dag");
        //}

        if (Input.GetKeyDown(KeyCode.O) == true)
        {
            print("rekoad");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            MyIntValue = Random.Range(0, 10);
            print(Random.Range(0f, 10f));
            print("lean left");
        }

    }
    void uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UserValue = UserValue + 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserValue = UserValue / 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(UserValue);
        }
    }

    void uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            tärning= Random.Range(1, (6+1));
            tärningminus = Random.Range(1, (6 + 1));
            uppgift2poäng = uppgift2poäng += tärning - tärningminus;
            Debug.Log(uppgift2poäng);
        
        }
        if (uppgift2poäng >= 20)
        {
            Debug.Log("du vinner");

        }
        if (uppgift2poäng <= 0)
            Debug.Log("du förlorar");
       
        
    }
    void uppgift3()
    {
        drakenSlår = Random.Range(0, 3);
        if (1 == drakendmg1 - drake) {
            Debug.Log(string.Format("Draken har {0}",2));
        }

        if (2 == drakendmg2 - drake)
        {
            Debug.Log(string.Format("draken har {0}", 2));
        }
    }

}
