﻿
using RimWorld;
using System;
using Verse;

namespace NikolaisIdeology_GenderWorks
{

    public class ThoughtWorker_Precept_NeedBeauty : ThoughtWorker_Precept
    {
            protected override ThoughtState ShouldHaveThought(Pawn p)
            {
            if (p.needs.beauty == null)
                return ThoughtState.Inactive;
            switch (p.needs.beauty.CurCategory)
            {
                case BeautyCategory.Hideous:
                    return ThoughtState.ActiveAtStage(0);
                case BeautyCategory.VeryUgly:
                    return ThoughtState.ActiveAtStage(1);
                case BeautyCategory.Ugly:
                    return ThoughtState.ActiveAtStage(2);
                case BeautyCategory.Neutral:
                    return ThoughtState.Inactive;
                case BeautyCategory.Pretty:
                    return ThoughtState.ActiveAtStage(3);
                case BeautyCategory.VeryPretty:
                    return ThoughtState.ActiveAtStage(4);
                case BeautyCategory.Beautiful:
                    return ThoughtState.ActiveAtStage(5);
                default:
                    throw new InvalidOperationException("Unknown BeautyCategory");
            }
        }
    }
}