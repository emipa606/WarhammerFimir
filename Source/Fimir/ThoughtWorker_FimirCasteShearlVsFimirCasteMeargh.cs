using RimWorld;
using Verse;

namespace Fimir;

public class ThoughtWorker_FimirCasteShearlVsFimirCasteMeargh : ThoughtWorker
{
    protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn otherPawn)
    {
        if (!p.RaceProps.Humanlike || !otherPawn.RaceProps.Humanlike ||
            !p.story.traits.HasTrait(FimirDefOf.FimirCasteShearl) ||
            !otherPawn.story.traits.HasTrait(FimirDefOf.FimirCasteMeargh) ||
            !RelationsUtility.PawnsKnowEachOther(p, otherPawn))
        {
            return false;
        }

        return p.story.traits.DegreeOfTrait(FimirDefOf.FimirCasteMeargh) == 1
            ? ThoughtState.ActiveAtStage(0)
            : ThoughtState.ActiveAtStage(1);
    }
}