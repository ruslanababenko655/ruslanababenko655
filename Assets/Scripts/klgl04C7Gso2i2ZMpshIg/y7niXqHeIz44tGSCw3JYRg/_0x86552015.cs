using UnityEngine;

public class _0x86552015 : MonoBehaviour
{
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x86552015>();
            DontDestroyOnLoad(this.gameObject);
            this._0x3ac68b65();
        }
        else
        {
            this._0x915312c9();
            Destroy(this.gameObject);
        }
    }

    public bool IsSkipSplashEnabled;
    private void _0x915312c9()
    {
    }

    public bool IsLevelIncrementOnWin;
    public bool IsTimerEnabled;
    public bool IsStoryEnabled;
    public bool IsBestScoreEnabled;
    public static _0x86552015 Instance;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelSelectorEnabled;
    private void _0x3ac68b65()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsCheckScoreEnabled;
}