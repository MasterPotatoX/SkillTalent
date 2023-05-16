public class DamageEffect : BaseEffect
{
    public float _damage;

    public override void ApplyEffect(Character target)
    {
        target.TakeDamage(_damage);
    }
}
