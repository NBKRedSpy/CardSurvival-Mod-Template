using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace $safeprojectname$
{
    [HarmonyPatch(typeof(BlueprintModelsScreen), "ShowTab")]
    public static class Patch_Patch
    {
        public static void Postfix(BlueprintModelsScreen __instance)
        {
        }

    }
}
