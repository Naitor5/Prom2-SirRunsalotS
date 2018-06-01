using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {

    public static Quest instance;

    public int cuero;
    public int pelaje;
    public int hierro;
    public int madera;
    public int planta;
    public int agua;
    public bool p1 = false;
    public bool p2 = false;
    public bool p3 = false;

	void Start () {
	}
	


    private void Awake()
    {
        instance = this;
    }

    public void Pregunta1()
    {
        if (cuero == 5 && pelaje == 7)
        {
            p1 = true;
        }
        else
            p1 = false;
    }

    public void Pregunta2()
    {
        if (hierro == 20 && madera == 10)
        {
            p2 = true;
        }
        else
            p2 = false;
    }

    public void Pregunta3()
    {
        if (planta == 2 && agua == 1)
        {
            p3 = true;
        }
        else
            p3 = false;
    }
}
