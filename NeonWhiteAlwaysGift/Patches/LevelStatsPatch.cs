using HarmonyLib;

namespace NeonWhiteAlwaysGift.Patches;

[HarmonyPatch(typeof(LevelStats))]
public class LevelStatsPatch {
    [HarmonyPrefix]
    [HarmonyPatch(nameof(LevelStats.HasCollectibleBeenFound))]
    private static bool HasCollectibleBeenFound(ref bool __result) {
        __result = false;
        return false;
    }
}
