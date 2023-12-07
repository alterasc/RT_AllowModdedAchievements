using HarmonyLib;
using Kingmaker;
using Kingmaker.Modding;

namespace AllowModdedAchievements;

[HarmonyPatch(typeof(OwlcatModificationsManager), nameof(OwlcatModificationsManager.IsAnyModActive), MethodType.Getter)]
public static class OwlcatModificationsManager_IsAnyModActive
{
    [HarmonyPrefix]
    [HarmonyAfter("0ToyBox0")]
    public static bool Prefix(ref bool __result)
    {
        __result = false;
        return false;
    }
}

[HarmonyPatch(typeof(Player), nameof(Player.ModsUser), MethodType.Getter)]
public static class Player_ModsUser
{
    [HarmonyPrefix]
    [HarmonyAfter("0ToyBox0")]
    public static bool Prefix(ref bool __result)
    {
        __result = false;
        return false;
    }
}
