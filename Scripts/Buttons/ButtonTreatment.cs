public class ButtonTreatment : BaseButton
{
    protected override void HandleButtonClick()
    {
        if (_playerHealth != null)
            _playerHealth.Treatment(15);
    }
}