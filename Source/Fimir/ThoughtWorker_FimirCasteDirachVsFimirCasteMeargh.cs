using RimWorld;
using Verse;

namespace Fimir;

public class ThoughtWorker_FimirCasteDirachVsFimirCasteMeargh : ThoughtWorker
{
    protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn otherPawn)
    {
        if (!p.RaceProps.Humanlike || !otherPawn.RaceProps.Humanlike ||
            !p.story.traits.HasTrait(FimirDefOf.FimirCasteDirach) ||
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