//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace Conf.Gameplay
{
public sealed partial class AttributeInfo :  Bright.Config.BeanBase 
{
    public AttributeInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        MaxHp = _buf.ReadInt();
        HpRecovery = _buf.ReadInt();
        MoveSpeed = _buf.ReadFloat();
        EnhancedExp = _buf.ReadInt();
        BulletSpeed = _buf.ReadInt();
        Attraction = _buf.ReadFloat();
        CDRate = _buf.ReadInt();
        Attack = _buf.ReadInt();
        AttackRangeRate = _buf.ReadInt();
        CritRate = _buf.ReadInt();
        CritDamage = _buf.ReadInt();
        DReductionRate = _buf.ReadInt();
        DReduction = _buf.ReadInt();
        ElementSkilled = _buf.ReadInt();
        ThunderER = _buf.ReadInt();
        IceER = _buf.ReadInt();
        FireER = _buf.ReadInt();
        WindER = _buf.ReadInt();
        LightER = _buf.ReadInt();
        DarkER = _buf.ReadInt();
        PostInit();
    }

    public static AttributeInfo DeserializeAttributeInfo(ByteBuf _buf)
    {
        return new Conf.Gameplay.AttributeInfo(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 生命值
    /// </summary>
    public int MaxHp { get; private set; }
    /// <summary>
    /// 生命恢复/s
    /// </summary>
    public int HpRecovery { get; private set; }
    /// <summary>
    /// 移动速度
    /// </summary>
    public float MoveSpeed { get; private set; }
    /// <summary>
    /// 经验增强
    /// </summary>
    public int EnhancedExp { get; private set; }
    /// <summary>
    /// 子弹速度增加
    /// </summary>
    public int BulletSpeed { get; private set; }
    /// <summary>
    /// 引力
    /// </summary>
    public float Attraction { get; private set; }
    /// <summary>
    /// 冷却增加
    /// </summary>
    public int CDRate { get; private set; }
    /// <summary>
    /// 攻击力
    /// </summary>
    public int Attack { get; private set; }
    /// <summary>
    /// 攻击范围增加
    /// </summary>
    public int AttackRangeRate { get; private set; }
    /// <summary>
    /// 暴击概率
    /// </summary>
    public int CritRate { get; private set; }
    /// <summary>
    /// 暴击伤害
    /// </summary>
    public int CritDamage { get; private set; }
    /// <summary>
    /// 伤害减免比
    /// </summary>
    public int DReductionRate { get; private set; }
    /// <summary>
    /// 伤害减免
    /// </summary>
    public int DReduction { get; private set; }
    /// <summary>
    /// 元素精通
    /// </summary>
    public int ElementSkilled { get; private set; }
    /// <summary>
    /// 元素抗性-雷
    /// </summary>
    public int ThunderER { get; private set; }
    /// <summary>
    /// 元素抗性-冰
    /// </summary>
    public int IceER { get; private set; }
    /// <summary>
    /// 元素抗性-火
    /// </summary>
    public int FireER { get; private set; }
    /// <summary>
    /// 元素抗性-风
    /// </summary>
    public int WindER { get; private set; }
    /// <summary>
    /// 元素抗性-光
    /// </summary>
    public int LightER { get; private set; }
    /// <summary>
    /// 元素抗性-暗
    /// </summary>
    public int DarkER { get; private set; }

    public const int __ID__ = -1737180788;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "MaxHp:" + MaxHp + ","
        + "HpRecovery:" + HpRecovery + ","
        + "MoveSpeed:" + MoveSpeed + ","
        + "EnhancedExp:" + EnhancedExp + ","
        + "BulletSpeed:" + BulletSpeed + ","
        + "Attraction:" + Attraction + ","
        + "CDRate:" + CDRate + ","
        + "Attack:" + Attack + ","
        + "AttackRangeRate:" + AttackRangeRate + ","
        + "CritRate:" + CritRate + ","
        + "CritDamage:" + CritDamage + ","
        + "DReductionRate:" + DReductionRate + ","
        + "DReduction:" + DReduction + ","
        + "ElementSkilled:" + ElementSkilled + ","
        + "ThunderER:" + ThunderER + ","
        + "IceER:" + IceER + ","
        + "FireER:" + FireER + ","
        + "WindER:" + WindER + ","
        + "LightER:" + LightER + ","
        + "DarkER:" + DarkER + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}