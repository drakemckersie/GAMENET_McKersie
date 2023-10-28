using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerNameInputManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetPlayerName(string playerName)
    {
        if (string.IsNullOrEmpty(playerName))
        {
            Debug.LogWarning("Player name is empty!");
            return;
        }

        PhotonNetwork.NickName = playerName;

    }
}
