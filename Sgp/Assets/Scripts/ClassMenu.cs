using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassMenu : MonoBehaviour
{
  public void capital(string scene3)
    {
        SceneManager.LoadScene(scene3);
    }
  public void small(string scene4)
    {
        SceneManager.LoadScene(scene4);
    }
}