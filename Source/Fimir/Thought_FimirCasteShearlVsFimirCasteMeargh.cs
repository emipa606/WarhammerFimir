using RimWorld;

namespace Fimir;

public class Thought_FimirCasteShearlVsFimirCasteMeargh : Thought_SituationalSocial
{
    public override float OpinionOffset()
    {
        if (pawn.story.traits.DegreeOfTrait(FimirDefOf.FimirCasteShearl) == 1)
        {
            return -200f;
        }

        return 200f;
    }
}