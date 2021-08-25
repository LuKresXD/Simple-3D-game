using UnityEngine;


public class Resource : MonoBehaviour
{
    public string ResourceName;
    [SerializeField] private float _amount;
    public float Amount {
        get => _amount;
        set{
            _amount = value;
            OnChange?.Invoke(_amount);  
        }
    }
    public event System.Action<float> OnChange;
    
    private void Start()
    {
        Amount = PlayerPrefs.GetFloat(ResourceName);
    }

    private void Save()
    {
        PlayerPrefs.SetFloat(ResourceName, Amount);
    }

    private void OnDestroy()
    {
        Save();
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}
