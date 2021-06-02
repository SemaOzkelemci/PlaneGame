using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class ucaksecimi: MonoBehaviour
{
    public GameObject plane1;
    public GameObject plane2;
    public GameObject plane3;
    public GameObject plane4;
    public GameObject plane5;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(false);
        plane4.SetActive(false);
        plane5.SetActive(false);
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void plane1Button(){
        plane1.SetActive(true);
        plane2.SetActive(false);
        plane3.SetActive(false);
        plane4.SetActive(false);
        plane5.SetActive(false);
        panel.SetActive(false);
    }
    public void plane2Button(){
        plane1.SetActive(false);
        plane2.SetActive(true);
        plane3.SetActive(false);
        plane4.SetActive(false);
        plane5.SetActive(false);
        panel.SetActive(false);
    }
    public void plane3Button(){
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(true);
        plane4.SetActive(false);
        plane5.SetActive(false);
        panel.SetActive(false);
    }
    public void plane4Button(){
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(false);
        plane4.SetActive(true);
        plane5.SetActive(false);
        panel.SetActive(false);
    }
    public void plane5Button(){
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(false);
        plane4.SetActive(false);
        plane5.SetActive(true);
        panel.SetActive(false);
    }
}



