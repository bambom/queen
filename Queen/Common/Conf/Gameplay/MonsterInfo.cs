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
public sealed partial class MonsterInfo :  Bright.Config.BeanBase 
{
    public MonsterInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        AttributeId = _buf.ReadInt();
        Drop = _buf.ReadInt();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Thinks = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); Thinks.Add(_e0);}}
        CollisionRadius = _buf.ReadFloat();
        CollisionOffset = _buf.ReadString();
        ModelName = _buf.ReadString();
        PostInit();
    }

    public static MonsterInfo DeserializeMonsterInfo(ByteBuf _buf)
    {
        return new Conf.Gameplay.MonsterInfo(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 属性 ID
    /// </summary>
    public int AttributeId { get; private set; }
    /// <summary>
    /// 掉落ID
    /// </summary>
    public int Drop { get; private set; }
    /// <summary>
    /// AI\思想
    /// </summary>
    public System.Collections.Generic.List<int> Thinks { get; private set; }
    /// <summary>
    /// 碰撞盒半径
    /// </summary>
    public float CollisionRadius { get; private set; }
    /// <summary>
    /// 碰撞盒偏移
    /// </summary>
    public string CollisionOffset { get; private set; }
    /// <summary>
    /// 模型资源名
    /// </summary>
    public string ModelName { get; private set; }

    public const int __ID__ = 1451501642;
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
        + "Name:" + Name + ","
        + "AttributeId:" + AttributeId + ","
        + "Drop:" + Drop + ","
        + "Thinks:" + Bright.Common.StringUtil.CollectionToString(Thinks) + ","
        + "CollisionRadius:" + CollisionRadius + ","
        + "CollisionOffset:" + CollisionOffset + ","
        + "ModelName:" + ModelName + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}