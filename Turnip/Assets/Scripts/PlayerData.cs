using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData {

    public int level;
    public float[] items;
    public float[] position;

    public PlayerData(GameState player) {
        level = SceneManager.GetActiveScene().buildIndex;
        items = new float[1]; // player.items;

        position = new float[3];
        position[0] = player.playerPosition.x;
        position[1] = player.playerPosition.y;
        position[2] = player.playerPosition.z;
    }
}
