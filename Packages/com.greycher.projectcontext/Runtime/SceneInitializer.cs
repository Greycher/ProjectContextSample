using System.Linq;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    private void Awake()
    {
        var initializables = FindObjectsOfType<MonoBehaviour>().OfType<IInitializable>();
        foreach (var initializable in initializables)
        {
            initializable.Initialize();
        }
    }
}
