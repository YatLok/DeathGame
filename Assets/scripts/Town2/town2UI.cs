using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class town2UI : MonoBehaviour
{

    GameObject textGotoHome;
    GameObject textDeath;
    Button homeButton;
    //Button deathButton;


    // Use this for initialization
    void Start()
    {
        this.textGotoHome = GameObject.Find("TextGotoHome");
        //this.textDeath = GameObject.Find("TextDeath");
        this.homeButton = GameObject.Find("homeButton").GetComponent<Button>();
        //this.deathButton = GameObject.Find("deathButton").GetComponent<Button>();
        homeButton.gameObject.SetActive(false);
        //deathButton.gameObject.SetActive(false);
        textGotoHome.GetComponent<Text>().enabled = false;
        //textDeath.GetComponent<Text>().enabled = false;
    }
    public void GotoHome()
    {
        textGotoHome.GetComponent<Text>().enabled = true;
        //this.yes = GameObject.Find("Button").GetComponent<Button>();
        homeButton.gameObject.SetActive(true);
    }
    public void ReturnTown()
    {
        textGotoHome.GetComponent<Text>().enabled = false;
        //this.yes = GameObject.Find("Button").GetComponent<Button>();
        homeButton.gameObject.SetActive(false);
    }

    //public void helloDeath()
    //{
    //    textDeath.GetComponent<Text>().enabled = true;
    //    deathButton.gameObject.SetActive(true);
    //}

    //public void byeDeath()
    //{
    //    textDeath.GetComponent<Text>().enabled = false;
    //    deathButton.gameObject.SetActive(false);
    //}


    // Update is called once per frame
    void Update()
    {
    }
}
