using HarmonyLib;
using UnityModManagerNet;

namespace AllowModdedAchievements;

public static class Main
{
    public static bool Load(UnityModManager.ModEntry modEntry)
    {
        var harmony = new Harmony(modEntry.Info.Id);
        harmony.PatchAll();
        return true;
    }
}