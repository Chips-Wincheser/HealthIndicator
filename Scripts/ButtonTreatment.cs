using UnityEngine;
using UnityEngine.UI;

public class ButtonTreatment : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _playerHealth;

    private void OnEnable()
    {
        _button.onClick.AddListener(HandleButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        if (_playerHealth != null)
            _playerHealth.Treatment(15);
    }
}