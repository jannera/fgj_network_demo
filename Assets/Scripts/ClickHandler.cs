using UnityEngine;
using System.Collections;

public class ClickHandler : Photon.MonoBehaviour {

    public void PlayAudioOnServer()
    {
        Debug.Log("making the RPC..");
        photonView.RPC("PlayAudio", PhotonTargets.MasterClient);
    }
}
