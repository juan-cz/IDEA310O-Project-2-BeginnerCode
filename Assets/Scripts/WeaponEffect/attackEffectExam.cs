using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class attackEffectExam : Weapon.WeaponAttackEffect
{
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attackData.AddDamage(StatSystem.DamageType.Fire, 4);
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        user.Stats.ChangeHealth(5);
    }
}
