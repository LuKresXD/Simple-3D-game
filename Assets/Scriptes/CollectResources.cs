using UnityEngine;

public class CollectResources : MonoBehaviour
{
    [SerializeField] private string _resourceType;
    private string Id => name + transform.position.GetHashCode();

    private void Awake()
    {
        if (PlayerPrefs.HasKey(Id))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerControl>();
        if (player)
        {
            player.GetResource(_resourceType);
            Destroy(gameObject);
            PlayerPrefs.SetFloat(Id, 1);
        }
    }
}
