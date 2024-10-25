using System;
using Ugur.A.Desing_Paterns.Singleton;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene_a : SingletonPersistent<LoadScene_a>
{
  public string sceneName_a1 = "Scene_a1";
  public string sceneName_a2 = "Scene_a2";

  [ContextMenu("Scene 1 yükle")]
  public void LoadScene1()
  {
    SceneManager.LoadScene(sceneName_a1);
  }

  [ContextMenu("Scene 2 yükle")]
  public void LoadScen2()
  {
    SceneManager.LoadScene(sceneName_a2);
  }
}