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
public sealed partial class StageGroupInfo :  Bright.Config.BeanBase 
{
    public StageGroupInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Stages = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); Stages.Add(_e0);}}
        PostInit();
    }

    public static StageGroupInfo DeserializeStageGroupInfo(ByteBuf _buf)
    {
        return new Conf.Gameplay.StageGroupInfo(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 指向关卡集合
    /// </summary>
    public System.Collections.Generic.List<int> Stages { get; private set; }

    public const int __ID__ = -929434995;
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
        + "Stages:" + Bright.Common.StringUtil.CollectionToString(Stages) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}