using UnityEngine;
using UnityEngine.UI;

public class TreatmentButtonEvent : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _playerHealth;

    protected void OnEnable()
    {
        _button.onClick.AddListener(HandleButtonClick);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        if (_playerHealth != null)
            _playerHealth.Treatment(15);
    }
}