using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;


public class LevelCreator
{

    [UnityEditor.MenuItem("Assets/Create/Level Asset from Musician mode")]
    public static void DoesStuff()
    {
        LevelObject assetente = ScriptableObject.CreateInstance<LevelObject>();

        JsonPayload payload;
        
        using(System.IO.StreamReader reader = new System.IO.StreamReader(@"C:\dev\Unity\LetsLearnUnity\Assets\LevelData\HitTimesData.json"))
        {
            string jsonData = reader.ReadToEnd();
            payload = UnityEngine.JsonUtility.FromJson<JsonPayload>(jsonData);
        }

        assetente.hitTimes = payload.hitTimes;
        string songName = payload.songName;

        AudioClip song = Resources.Load<AudioClip>($@"Songs\{songName}");
        assetente.song = song;

        AssetDatabase.CreateAsset(assetente, $"Assets/LevelData/{songName}.asset");
        AssetDatabase.SaveAssets();
    }
}
