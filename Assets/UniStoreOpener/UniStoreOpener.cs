using UnityEngine;
using System.Collections;

public class UniStoreOpener {

    // set your itunes app id like 00000000
    private const string itunesAppId = "";

    public static void OpenStore(){
        #if UNITY_EDITOR
        return;
        #elif UNITY_IOS
        Application.OpenURL(string.Format("itms-apps://itunes.apple.com/app/id{0}?mt=8", itunesAppId));
        #elif UNITY_ANDROID
        new AndroidJavaClass("jp.ne.donuts.storeopener.StoreOpener").CallStatic("Open");
        #endif
    }
}
