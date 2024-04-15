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
public sealed partial class EquipAttributeWeightInfo :  Bright.Config.BeanBase 
{
    public EquipAttributeWeightInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);MainWeight = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); MainWeight.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Weight = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); Weight.Add(_e0);}}
        PostInit();
    }

    public static EquipAttributeWeightInfo DeserializeEquipAttributeWeightInfo(ByteBuf _buf)
    {
        return new Conf.Gameplay.EquipAttributeWeightInfo(_buf);
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
    /// 主权重
    /// </summary>
    public System.Collections.Generic.List<int> MainWeight { get; private set; }
    /// <summary>
    /// 权重
    /// </summary>
    public System.Collections.Generic.List<int> Weight { get; private set; }

    public const int __ID__ = 955201360;
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
        + "MainWeight:" + Bright.Common.StringUtil.CollectionToString(MainWeight) + ","
        + "Weight:" + Bright.Common.StringUtil.CollectionToString(Weight) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}