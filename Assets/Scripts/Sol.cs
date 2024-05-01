using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour
{
   [SerializeField][Range(0,24)] private float hora = 12;
   public Transform sol;
   [SerializeField] private float duracionDiaEnSegundos = 30;
   private float solX;
    
    
    private void RotacionSol()
    {
        solX = 15 * hora;
        sol.localEulerAngles = new Vector3(solX, 0, 0);
        if (hora<6 || hora>24)
        {
            sol.GetComponent<Light>().intensity = 0;
        }
        else
        {
            sol.GetComponent<Light>().intensity = 1;
        }
    }


    void Update()
    {
        hora += Time.deltaTime * (24 / duracionDiaEnSegundos);
        if (hora>24)
        {
            hora = 0;
        }

        RotacionSol();
    }
}
