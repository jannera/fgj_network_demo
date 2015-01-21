using UnityEngine;
using System.Collections;

public class AudioPlayer : Photon.MonoBehaviour {
    [RPC]
    public void PlayAudio()
    {
        Debug.Log("playing audio");
        audio.Play();
    }
}
