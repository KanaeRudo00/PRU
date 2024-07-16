using Cinemachine;

public class ScreenShakeManager : Singleton<ScreenShakeManager>
{
    private CinemachineImpulseSource source;

    protected override void Awake()
    {
        base.Awake();
        source = GetComponent<CinemachineImpulseSource>();

    }

    public void ShakeScreen()
    {
        if (source == null)
        {
            source = GetComponent<CinemachineImpulseSource>();
        }
        source.GenerateImpulse();
    }
}