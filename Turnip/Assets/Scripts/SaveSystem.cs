using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {
    
    public static void SavePlayer(GameState player) {
        BinaryFormatter formatter = new BinaryFormatter();
        Debug.Log("SavePlayer in SaveSystem");
        Debug.Log(player.playerPosition);
        FileStream stream = new FileStream(GetPath(), FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer() {
        if (File.Exists(GetPath())) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(GetPath(), FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        Debug.LogError("Save file not found in " + GetPath());
        return null;
    }

    public static bool PlayerFileExists() {
        return File.Exists(GetPath());
    }

    private static string GetPath() {
        return Application.persistentDataPath + "/player.nip";
    }
}
