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
   
public partial class ParkourInfos
{

     private readonly Conf.Gameplay.ParkourInfo _data;

    public ParkourInfos(ByteBuf _buf)
    {
        int n = _buf.ReadSize();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = Conf.Gameplay.ParkourInfo.DeserializeParkourInfo(_buf);
        PostInit();
    }


    /// <summary>
    /// Stage 构建的距离
    /// </summary>
     public float BuildStageDis => _data.BuildStageDis;
    /// <summary>
    /// Stage 超出的有效距离
    /// </summary>
     public float RecycleInvalidStageDis => _data.RecycleInvalidStageDis;
    /// <summary>
    /// 重力4.5
    /// </summary>
     public float Gravity => _data.Gravity;
    /// <summary>
    /// 角色黏附地面的力
    /// </summary>
     public float GroundStickForce => _data.GroundStickForce;
    /// <summary>
    /// 速降持续多久触发落地缓冲
    /// </summary>
     public float Drop2LandDuration => _data.Drop2LandDuration;
    /// <summary>
    /// 自由落体持续多久触发落地缓冲
    /// </summary>
     public float Fall2LandDuration => _data.Fall2LandDuration;
    /// <summary>
    /// 滑铲的持续时间
    /// </summary>
     public float SlideDuration => _data.SlideDuration;
    /// <summary>
    /// 跳跃，高度的力
    /// </summary>
     public float JumpRiseForce => _data.JumpRiseForce;
    /// <summary>
    /// 二段跳跃，高度的力
    /// </summary>
     public float AirJumpRiseForce => _data.AirJumpRiseForce;
    /// <summary>
    /// 切换为自由落体状态，需要跟地面超过多少的距离
    /// </summary>
     public float FallGroundDis => _data.FallGroundDis;
    /// <summary>
    /// 滑翔状态下降的力，档位0|档位1|档位2|档位3
    /// </summary>
     public System.Collections.Generic.List<float> GlideDropForce => _data.GlideDropForce;
    /// <summary>
    /// 处于自由落体状态持续 n/s，转换为滑翔状态
    /// </summary>
     public float Fall2GlideDuration => _data.Fall2GlideDuration;
    /// <summary>
    /// 主动下降的速度
    /// </summary>
     public float DropSpeed => _data.DropSpeed;
    /// <summary>
    /// 奔跑时旋转插值
    /// </summary>
     public float RunDegSmooth => _data.RunDegSmooth;
    /// <summary>
    /// 滑铲时旋转插值
    /// </summary>
     public float SlideDegSmooth => _data.SlideDegSmooth;
    /// <summary>
    /// 滑翔状态每个档位持续n/s，升档
    /// </summary>
     public float GlideDuration => _data.GlideDuration;
    /// <summary>
    /// 切换为滑翔状态，需要跟地面超过多少的距离
    /// </summary>
     public float GlideGroundDis => _data.GlideGroundDis;
    /// <summary>
    /// 切换为滑翔状态，需要速度超过多少
    /// </summary>
     public float GlideMinSpeed => _data.GlideMinSpeed;
    /// <summary>
    /// 滑翔状态，升档时速率
    /// </summary>
     public System.Collections.Generic.List<float> GlideTurbo => _data.GlideTurbo;
    /// <summary>
    /// 升档加速持续时间（小于档位持续时间GlideDuration）
    /// </summary>
     public System.Collections.Generic.List<float> GlideTurboDuration => _data.GlideTurboDuration;
    /// <summary>
    /// 下坡加速度比例系数
    /// </summary>
     public float AccelerateK => _data.AccelerateK;
    /// <summary>
    /// 上坡减速度比例系数
    /// </summary>
     public float DecelerateK => _data.DecelerateK;
    /// <summary>
    /// 角度归零的阈值，小于此值时取0（斜坡）
    /// </summary>
     public float DegThreshold => _data.DegThreshold;
    /// <summary>
    /// 减速角度每帧渐变步长百分比（0~1）
    /// </summary>
     public float UpStep => _data.UpStep;
    /// <summary>
    /// 加速角度每帧渐变步长百分比（0~1）
    /// </summary>
     public float DownStep => _data.DownStep;
    /// <summary>
    /// 飞坡力比例系数（角度向量*当前速度*比例系数），瞬间改为0重力，离地后复原为4.5
    /// </summary>
     public float LiftForceK => _data.LiftForceK;
    /// <summary>
    /// 力归零的阈值，小于此角度值时取0（飞坡）
    /// </summary>
     public float ForceThreshold => _data.ForceThreshold;
    /// <summary>
    /// 上一帧力到目标力的步长（飞坡）
    /// </summary>
     public float ForceLerpStep => _data.ForceLerpStep;
    /// <summary>
    /// 坡角系数K(飞坡)
    /// </summary>
     public float LiftJudgeK => _data.LiftJudgeK;
    /// <summary>
    /// 滑翔3档玩家触摸灵敏度
    /// </summary>
     public float DragSpeed => _data.DragSpeed;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        _data.TranslateText(translator);
    }

    
    partial void PostInit();
    partial void PostResolve();
}

}