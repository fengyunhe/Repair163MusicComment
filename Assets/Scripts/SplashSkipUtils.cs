using UnityEngine.Scripting;

#if !UNITY_EDITOR
using UnityEngine;
using UnityEngine.Rendering;
#endif

/// <summary>
/// 防止脚本没有被打包, 注意打Release包才能生效
/// </summary>
[Preserve]
public class SplashSkipUtils
{
#if !UNITY_EDITOR
    /// <summary>
    /// 启动画面之前回调该方法
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    private static void Run()
    {
        System.Threading.Tasks.Task.Run(() =>
        {
            SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
        });
    }
#endif
}