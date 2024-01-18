using HarmonyLib;
using Kingmaker;

namespace AllowModdedAchievements;

[HarmonyPatch(typeof(Player), nameof(Player.ModsUser), MethodType.Getter)]
public static class Player_ModsUser
{
    [HarmonyPostfix]
    [HarmonyAfter("0ToyBox0")]
    [HarmonyPriority(Priority.Last)]
    public static void Postfix(ref bool __result)
    {
        __result = false;
    }
}
