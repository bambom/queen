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
   
public partial class EquipAttributeInfos
{
    private readonly Dictionary<int, Conf.Gameplay.EquipAttributeInfo> _dataMap;
    private readonly List<Conf.Gameplay.EquipAttributeInfo> _dataList;
    
    public EquipAttributeInfos(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, Conf.Gameplay.EquipAttributeInfo>();
        _dataList = new List<Conf.Gameplay.EquipAttributeInfo>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Conf.Gameplay.EquipAttributeInfo _v;
            _v = Conf.Gameplay.EquipAttributeInfo.DeserializeEquipAttributeInfo(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, Conf.Gameplay.EquipAttributeInfo> DataMap => _dataMap;
    public List<Conf.Gameplay.EquipAttributeInfo> DataList => _dataList;

    public Conf.Gameplay.EquipAttributeInfo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Conf.Gameplay.EquipAttributeInfo Get(int key) => _dataMap[key];
    public Conf.Gameplay.EquipAttributeInfo this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}