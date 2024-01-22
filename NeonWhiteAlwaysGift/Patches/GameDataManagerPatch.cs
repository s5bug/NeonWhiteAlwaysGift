using HarmonyLib;

namespace NeonWhiteAlwaysGift.Patches;

[HarmonyPatch(typeof(GameDataManager))]
public class GameDataManagerPatch {
    [HarmonyPrefix]
    [HarmonyPatch(nameof(GameDataManager.SaveGame))]
    private static bool SaveGame() {
        return false;
    }
}
