using RimWorld;

namespace Fimir;

public class Thought_FimirCasteDirachVsFimirCasteMeargh : Thought_SituationalSocial
{
    public override float OpinionOffset()
    {
        if (pawn.story.traits.DegreeOfTrait(FimirDefOf.FimirCasteDirach) == 1)
        {
            return -200f;
        }

        return 200f;
    }
}