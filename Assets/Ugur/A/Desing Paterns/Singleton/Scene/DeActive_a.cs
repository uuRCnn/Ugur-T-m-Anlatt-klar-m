using System;
using UnityEngine;

namespace Ugur.A.Desing_Paterns.Singleton.Scene
{
  public class DeActive_a : MonoBehaviour
  {
    private void Start()
    {
      simple_a1.Instance.gameObject.SetActive(false); // Burdaki amaç, [SerizalizeField] ile baglamadan erişebilmek.
    }
  }
}