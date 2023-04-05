using RimWorld;
using Verse;

namespace Fimir;

public class ThoughtWorker_FimirCasteMearghVsFimirCasteMeargh : ThoughtWorker
{
    protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn otherPawn)
    {
        return !p.RaceProps.Humanlike || !otherPawn.RaceProps.Humanlike ||
               !p.story.traits.HasTrait(FimirDefOf.FimirCasteMeargh) ||
               !otherPawn.story.traits.HasTrait(FimirDefOf.FimirCasteMeargh) ||
               !RelationsUtility.PawnsKnowEachOther(p, otherPawn) ? false :
            p.story.traits.DegreeOfTrait(FimirDefOf.FimirCasteMeargh) == 1 ? ThoughtState.ActiveAtStage(0) :
            ThoughtState.ActiveAtStage(1);
    }
}