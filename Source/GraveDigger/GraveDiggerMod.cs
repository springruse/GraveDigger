using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using HarmonyLib;
using Verse;

namespace GraveDigger
{
    public class GraveDiggerMod : Mod
    {
        public GraveDiggerMod(ModContentPack content) : base(content)
        {
            Log.Message("GraveDigger mod loaded!");
        }
    }
}
