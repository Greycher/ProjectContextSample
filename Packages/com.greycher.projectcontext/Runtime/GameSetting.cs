using UnityEngine;

[CreateAssetMenu(fileName = nameof(GameSetting), menuName = "ScriptableObjects/" + nameof(GameSetting), order = 1)]
public class GameSetting : ScriptableObject
{
    public float PlayerSpeed;
}