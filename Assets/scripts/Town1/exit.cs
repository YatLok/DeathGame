using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("gotoHome");
        GameObject msg = GameObject.Find("MessageUI");
        msg.GetComponent<ui>().GotoHome();
        //SceneManager.LoadScene("map");
    }
    void OnCollisionExit(Collision other)
    {
        Debug.Log("returnTown");
        GameObject msg = GameObject.Find("MessageUI");
        msg.GetComponent<ui>().ReturnTown();
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0)){
        //    SceneManager.LoadScene("map");
        //}

    }
}
