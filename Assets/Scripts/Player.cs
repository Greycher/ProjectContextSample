using UnityEngine;

public class Player : MonoBehaviour, IInitializable
{
    public void Initialize()
    {
        Debug.Log($"Player speed is {ProjectContext.Instance.GameSetting.PlayerSpeed}");
    }
}