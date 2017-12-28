using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamerClass;
public class NewBehaviourScript : MonoBehaviour {

    public const string MatchReady = "MatchController.Ready";
    public bool IsReady { get { return localPlayer != null && remotePlayer != null; } }
    public Gamer localPlayer;
    public Gamer remotePlayer;
    public Gamer hostPlayer;
    public Gamer clientPlayer;
    public List<Gamer> players = new List<Gamer>();

}
