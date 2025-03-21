public class SharpSliderHealthView : Slider
{
    protected override void UpdateCounterDisplay(float health)
    {
        _slider.value = health;
    }
}
