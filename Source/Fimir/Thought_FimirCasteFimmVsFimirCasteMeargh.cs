using RimWorld;

namespace Fimir;

public class Thought_FimirCasteFimmVsFimirCasteMeargh : Thought_SituationalSocial
{
    public override float OpinionOffset()
    {
        if (pawn.story.traits.DegreeOfTrait(FimirDefOf.FimirCasteFimm) == 1)
        {
            return 200f;
        }

        return 0f;
    }
}