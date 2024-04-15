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
   
public partial class EquipAttributeWeightInfos
{
    private readonly Dictionary<int, Conf.Gameplay.EquipAttributeWeightInfo> _dataMap;
    private readonly List<Conf.Gameplay.EquipAttributeWeightInfo> _dataList;
    
    public EquipAttributeWeightInfos(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, Conf.Gameplay.EquipAttributeWeightInfo>();
        _dataList = new List<Conf.Gameplay.EquipAttributeWeightInfo>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Conf.Gameplay.EquipAttributeWeightInfo _v;
            _v = Conf.Gameplay.EquipAttributeWeightInfo.DeserializeEquipAttributeWeightInfo(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, Conf.Gameplay.EquipAttributeWeightInfo> DataMap => _dataMap;
    public List<Conf.Gameplay.EquipAttributeWeightInfo> DataList => _dataList;

    public Conf.Gameplay.EquipAttributeWeightInfo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Conf.Gameplay.EquipAttributeWeightInfo Get(int key) => _dataMap[key];
    public Conf.Gameplay.EquipAttributeWeightInfo this[int key] => _dataMap[key];

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