using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceen_controller : MonoBehaviour
{

    public void Section2()
    {
        SceneManager.LoadScene("Section2");
    }
    public void Section3()
    {
        SceneManager.LoadScene("Section3");
    }
    public void home()
    {
        SceneManager.LoadScene("main menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
