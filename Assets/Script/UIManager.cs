using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject GamePlayUI;
    public GameObject PausedUI;
    


    public void EnableMainMenuUI() 
    {
        DisableAllUI();
        MainMenuUI.gameObject.SetActive(true);
        
    }

    public void EnableGamePlay() 
    {
        DisableAllUI();
        GamePlayUI.gameObject.SetActive(true);
        
    }

    public void EnablePause() 
    {
        PausedUI.gameObject.SetActive(true);
        
    }

    public void DisablePause() 
    {
        PausedUI.gameObject.SetActive(false);
        
    }

    public void DisableAllUI() 
    {
        PausedUI.gameObject.SetActive(false);
        GamePlayUI.gameObject.SetActive(false);
        MainMenuUI.gameObject.SetActive(false); 
    }
}
