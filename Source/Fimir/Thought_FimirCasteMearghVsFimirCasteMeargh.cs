using RimWorld;

namespace Fimir;

public class Thought_FimirCasteMearghVsFimirCasteMeargh : Thought_SituationalSocial
{
    public override float OpinionOffset()
    {
        if (pawn.story.traits.DegreeOfTrait(FimirDefOf.FimirCasteMeargh) == 1)
        {
            return 200f;
        }

        return -200f;
    }
}