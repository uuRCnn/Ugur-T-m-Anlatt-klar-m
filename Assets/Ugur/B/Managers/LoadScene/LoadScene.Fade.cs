// using __Scripts._Utility.Disposable_My_Components;
// using Mirror;
//
// namespace __Scripts._Managers.LoadScene.Main
// {
//   internal partial class LoadSceneManager
//   {
// #region ==> FadeEffects Functions <==
//     // ========================================================================================
//
//
//     private void FadeIn(bool isNetworkSceneActive)
//     {
//       if (isNetworkSceneActive)
//       {
//         if (NetworkServer.active)
//           Ek.Instance.FadeInRpc();
//       }
//       else
//       {
//         LoadingFadeEffect.Instance.FadeIn();
//       }
//     }
//
//     private void FadeOut(bool isNetworkSceneActive = false)
//     {
//       if (isNetworkSceneActive)
//       {
//         if (NetworkServer.active)
//           Ek.Instance.FadeOutRpc();
//       }
//       else
//       {
//         LoadingFadeEffect.Instance.FadeOut();
//       }
//     }
// #endregion
//   }
// }