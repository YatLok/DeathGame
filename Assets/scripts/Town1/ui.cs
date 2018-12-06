using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour {

    GameObject menuPlanes;
    GameObject textGotoHome;
    GameObject textDeath;
    //Button homeButton;
    Button deathButton;
    GameObject death;


    // Use this for initialization
    void Start () {
        this.death = GameObject.Find("skeleton_static");
        Debug.Log(this.death + "死神がいる");
        this.menuPlanes = GameObject.Find("Panel");
        this.textGotoHome = GameObject.Find("TextGotoHome");
        this.textDeath = GameObject.Find("TextDeath");
        //this.homeButton = GameObject.Find("homeButton").GetComponent<Button>();
        this.deathButton = GameObject.Find("deathButton").GetComponent<Button>();
        menuPlanes.gameObject.SetActive(false);
        //homeButton.gameObject.SetActive(false);
        deathButton.gameObject.SetActive(false);
        textGotoHome.GetComponent<Text>().enabled = false;
        textDeath.GetComponent<Text>().enabled = false;
    }
    public void GotoHome()
    {
        menuPlanes.gameObject.SetActive(true);
        textGotoHome.GetComponent<Text>().enabled = true;
        //this.yes = GameObject.Find("Button").GetComponent<Button>();
        //homeButton.gameObject.SetActive(true);
    }

    public void ReturnTown()
    {
        menuPlanes.gameObject.SetActive(false);
        textGotoHome.GetComponent<Text>().enabled = false;
        //this.yes = GameObject.Find("Button").GetComponent<Button>();
        //homeButton.gameObject.SetActive(false);
    }

    public void helloDeath()
    {
        menuPlanes.gameObject.SetActive(true);
        textDeath.GetComponent<Text>().enabled = true;
        deathButton.gameObject.SetActive(true);
    }

    public void byeDeath()
    {
        menuPlanes.gameObject.SetActive(false);
        textDeath.GetComponent<Text>().enabled = false;
        deathButton.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
    }
}
