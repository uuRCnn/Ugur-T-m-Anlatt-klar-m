// using System.Collections;
// using __Scripts._Utility.Disposable_My_Components;
// using IngameDebugConsole;
// using Mirror;
// using UnityEngine;
// using UnityEngine.AddressableAssets;
// using UnityEngine.SceneManagement;
//
// // ReSharper disable ReplaceWithSingleAssignment.True
//
// namespace __Scripts._Managers.LoadScene.Main
// {
//   internal partial class LoadSceneManager
//   {
//     private void Start()
//     {
//       DebugLogConsole.AddCommand<MainSceneName>("Scene.LoadMainScene", "MainSceneName parametresi gir", LoadMainScene); // todo:tüm oyuncuların oyunu nası reste atıcagını düşün
//     }
//
// #region ==> LoadingScene <==
//     // ========================================================================================
//
//     public void LoadMainScene(MainSceneName sceneToLoad)
//     {
//       var isLocalScene = sceneToLoad is MainSceneName.Menu or MainSceneName.Null;
//
//       var isNetworkSceneActive = true;
//
//       if (isLocalScene) // Menu veya Null ise true döner.
//         isNetworkSceneActive = false;
//
//
//       StartCoroutine(Loading(sceneToLoad, isNetworkSceneActive));
//     }
//
//     private IEnumerator Loading(MainSceneName sceneToLoad,
//                                 bool          isNetworkSceneActive = true)
//     {
//       FadeIn(isNetworkSceneActive);
//
//       yield return new WaitUntil(() => LoadingFadeEffect.CanLoadScene);
//
//
//       if (isNetworkSceneActive)
//         LoadSceneNetwork(sceneToLoad);
//       else
//         LoadSceneLoacal(sceneToLoad);
//
//       // Burası sadece Menu ve Bootstrap ekranında true olur.                                         --> (onun dışında ServerInıt Fonksiyonun sonunda FadeOut kendiliginden çalışıyor)
//       if (!isNetworkSceneActive)
//       {
//         yield return new WaitForSeconds(1f);
//         FadeOut();
//       }
//     }
//
//     private void LoadSceneLoacal(MainSceneName sceneToLoad)
//     {
//       // -<                                                                           --> Addressables kullanıyorum çünkü daha hızlı ve performanslı 
//       var loadSceneAsync = Addressables.LoadSceneAsync(sceneToLoad.ToString());
//       loadSceneAsync.Completed += async => OnLoadLocalSceneComplete(async, sceneToLoad);
//
//
//       // SceneManager.LoadScene(sceneToLoad.ToString(), LoadSceneMode.Single);  //bunu kullandıgımda onCompleted yaptıgımda Netwokr sahnelerinide kapsadıgından Addreasble kullandım.  
//       // Addressables.LoadSceneAsync(sceneToLoad.ToString());
//     }
//
//
//     private static void LoadSceneNetwork(MainSceneName sceneToLoad)
//     {
//       if (NetworkServer.active)
//         Mirror.NetworkManager.singleton.ServerChangeScene(sceneToLoad.ToString());
//
//       // NetworkManager.Singleton.SceneManager.LoadScene( sceneToLoad.ToString(), LoadSceneMode.Single);
//     }
// #endregion
//   }
// }