using UnityEngine;
using System.Collections;

public class NetworkStartClient : MonoBehaviour {

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("0.1");
    }
    
    private RoomInfo[] roomsList;

    void OnReceivedRoomListUpdate()
    {
        roomsList = PhotonNetwork.GetRoomList();

        foreach (RoomInfo info in roomsList)
        {
            if (info.name.Equals(NetworkStartServer.roomName))
            {
                PhotonNetwork.JoinRoom(info.name);
                Debug.Log("Joined existing game as client");
                return;
            }
        }
        Debug.Log("Couldn't find an existing room from the server");
    }
    void OnJoinedRoom()
    {
        Debug.Log("Connected to Room");
    }
}
