using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region Singleton
    public static GameManager Instance { get; private set; }
    void Awake() {
        if(Instance && Instance != this) { Debug.LogError("Multiple instance GameManager"); return; }
        Instance = this;
        Speed = 1f;
        Score = 0f;
    }
    #endregion

    [SerializeField] float ScoreMultiplicator = 3;
    [SerializeField, Min(0f)] float SpeedMultiplicator = .3f;

    public GameObject player;

    public float Speed { get; private set; }
    public float Score { get; private set; }

    void FixedUpdate() {
        Score += Time.fixedDeltaTime * ScoreMultiplicator;
        Speed += Time.fixedDeltaTime * SpeedMultiplicator;
    }
}
