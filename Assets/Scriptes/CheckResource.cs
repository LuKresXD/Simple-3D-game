using UnityEngine;
using UnityEngine.Events;

public class CheckResource : MonoBehaviour
{
    [SerializeField] private string _resourceType;
    [SerializeField] private int _amount = 1;
    [SerializeField] private bool _remove = false;
    [SerializeField] private UnityEvent OnCheckTrue;
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerControl>();
        if (player)
        {
            if (player.CheckResource(_resourceType, _amount, _remove))
            {
                OnCheckTrue.Invoke();
            }
        }
    }
}
