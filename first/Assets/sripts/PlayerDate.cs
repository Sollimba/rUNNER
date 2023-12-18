using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObject/PlayerData")]

public class PlayerData : ScriptableObject
{
    [SerializeField] private float score;
    [SerializeField] private int cred;

    public float Score {
        get
        { return score; }
        set
        { score = value; }
            }
    public int Cred
    {
        get
        { return cred; }
        set
        { cred = value; }
    }

}
