using UnityEngine;

// ReSharper disable MemberCanBePrivate.Global

namespace Ugur.A.Desing_Paterns.Singleton
{
  public class Singleton<T> : MonoBehaviour where T : Component
  {
    public static T Instance { get; private set; }

    public virtual void Awake()
    {
      if (Instance == null)
        // -<                                                                         --> bilgi = bu This as T = bu T tipinde ise ata demek. Degilse Null ata.
        Instance = this as T;
      else
        Destroy(gameObject);
    }
  }


  public class SingletonPersistent<T> : MonoBehaviour where T : Component
  {
    public static T Instance { get; private set; }

    public virtual void Awake()
    {
      if (Instance == null)
      {
        DontDestroyOnLoad(this);
        Instance = this as T;
      }
      else
        Destroy(gameObject);
    }
  }



















  // For Online Game
  // ==========================================================================================



  // public class SingletonNetwork<T> : NetworkBehaviour where T : Component // sahende 2 tane olan bir şey olursa, bunu kullanmak hatalara nedne olabilir test et
  // {
  //   public static T Instance { get; private set; }
  //
  //   public override void OnStartClient()
  //   {
  //     if (Instance == null && isOwned)
  //       Instance = this as T;
  //     else
  //       enabled = false; //burda Destroy etmiyorum çünkü: diger oyuncuların bir objelerini yok etmiş olurum.
  //   }
  // }
  //
  // // ---- buna yukardaki gibi isOwner eklemedim. çünkü Managerlarda kullandıgımdan böyle bir if koşuluna gerek duymadım.
  // public class SingletonNetworkPersistent<T> : NetworkBehaviour where T : Component
  // {
  //   public static T Instance { get; private set; }
  //
  //   public virtual void Awake()
  //   {
  //     if (Instance == null)
  //     {
  //       Instance = this as T;
  //       DontDestroyOnLoad(this);
  //     }
  //     else
  //       Destroy(gameObject);
  //   }
  // }
}