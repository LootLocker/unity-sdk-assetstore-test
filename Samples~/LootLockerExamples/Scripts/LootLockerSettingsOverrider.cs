using LootLocker.Requests;

namespace LootLocker {
public static class LootLockerSettingsOverrider
{
    public static void OverrideSettings()
    {
        LootLockerSDKManager.Init("9e4bda3a853f1eb6342f1dfd289c1c9531c21998", "0.0.0.1", true, "2112hpxu");
        LootLocker.LootLockerConfig.current.currentDebugLevel = LootLocker.LootLockerConfig.DebugLevel.All;
    }
}
}
