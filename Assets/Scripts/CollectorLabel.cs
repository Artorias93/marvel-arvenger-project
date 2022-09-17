using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorLabel : MonoBehaviour
{

    public GameObject blackPanther;
    public GameObject blackWidow;
    public GameObject captainAmerica;
    public GameObject doctorStrange;
    public GameObject hawkeye;
    public GameObject hulk;
    public GameObject ironMan;
    public GameObject spiderman;
    public GameObject thanos;
    public GameObject thor;
    public GameObject ultron;
    public GameObject vision;

    public void HideAll()
    {
        blackPanther.SetActive(false);
        blackWidow.SetActive(false);
        captainAmerica.SetActive(false);
        doctorStrange.SetActive(false);
        hawkeye.SetActive(false);
        hulk.SetActive(false);
        ironMan.SetActive(false);
        spiderman.SetActive(false);
        thanos.SetActive(false);
        thor.SetActive(false);
        ultron.SetActive(false);
        vision.SetActive(false);
    }


}
