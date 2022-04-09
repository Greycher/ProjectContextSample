using UnityEngine;

[CreateAssetMenu(fileName = nameof(ProjectContext), menuName = "ScriptableObjects/" + nameof(ProjectContext), order = 1)]
public class ProjectContext : ScriptableObject
{
    public GameSetting GameSetting;
    
    private static ProjectContext _instance;
    
    public static ProjectContext Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = Resources.Load<ProjectContext>(nameof(ProjectContext));
                Debug.Log($"{nameof(ProjectContext)} instance is loaded from resource folder and assigned as singleton.");
            }

            return _instance;
        }
    }
    
    private void Awake()
    {
        if (_instance)
        {
            if (_instance != this)
            {
                Destroy(this);
                Debug.Log($"Another {nameof(ProjectContext)} instance is found and destroyed.");
            }
        }
        else
        {
            _instance = this;
            Debug.Log($"{nameof(ProjectContext)} instance is assigned as singleton.");
        }
    }
}
