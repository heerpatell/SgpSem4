﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void btn_change_scene(string scene){
        SceneManager.LoadScene(scene);
    }
    
    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
