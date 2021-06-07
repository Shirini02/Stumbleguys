using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public GameObject toppanel, middlepanel, helppanel,optionspanel;
    public void GoToNextScene()
    {
        SceneManager.LoadScene(1);
    }
   
    public void back()
    {
        toppanel.SetActive(true);
        middlepanel.SetActive(true);
        helppanel.SetActive(false);

    }
    public void Help()
    {
        helppanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
    public void OptionsMenu()
    {
        optionspanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
    public void optionsBack()
    {
        optionspanel.SetActive(false);
        toppanel.SetActive(true);
        middlepanel.SetActive(true);


    }



}
