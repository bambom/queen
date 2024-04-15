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
public sealed partial class EvolutionOptionInfo :  Bright.Config.BeanBase 
{
    public EvolutionOptionInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Type = _buf.ReadInt();
        Param = _buf.ReadInt();
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        Icon = _buf.ReadString();
        PostInit();
    }

    public static EvolutionOptionInfo DeserializeEvolutionOptionInfo(ByteBuf _buf)
    {
        return new Conf.Gameplay.EvolutionOptionInfo(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 类型
    /// </summary>
    public int Type { get; private set; }
    /// <summary>
    /// 参数
    /// </summary>
    public int Param { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 描述
    /// </summary>
    public string Desc { get; private set; }
    /// <summary>
    /// 图标
    /// </summary>
    public string Icon { get; private set; }

    public const int __ID__ = -1185579200;
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
        + "Type:" + Type + ","
        + "Param:" + Param + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Icon:" + Icon + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}