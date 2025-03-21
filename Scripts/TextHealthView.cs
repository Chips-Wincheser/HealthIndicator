using TMPro;
using UnityEngine;

public class TextHealthView : HealthViewBase
{
    [SerializeField] private TextMeshProUGUI _counterText;
    
    protected override void UpdateCounterDisplay(float health)
    {
        if (_counterText != null)
        {
            _counterText.text = health.ToString();
        }
    }
}