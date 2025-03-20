public class ButtonDamage : BaseButton
{
    protected override void HandleButtonClick()
    {
        if(_playerHealth != null)
            _playerHealth.TakeDamage(15);
    }
}