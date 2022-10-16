//==============================================================================
// THIS CODE WAS AUTOGENERATED BY:
//    BedrockTools_Build.Generator.MinecraftBlocks.VariationGenerator
// Do not modify, any changes will be lost when the generation tool is run again
// version: 0.1.0
//==============================================================================
using BedrockTools.Nbt.Elements;

namespace BedrockTools.Objects.Blocks.Minecraft {
    public class StoneBlock : Block {
        public readonly StoneType Variation;

        public StoneBlock (string identifier, StoneType variation) : base(identifier) {
            Variation = variation;
        }

        public override NbtCompoundSorted GetBlockState () {
            return new NbtCompoundSorted() {
                {"stone_type", (NbtString)Variation.ToString().ToLower()}
            };
        }

        public enum StoneType {
            Stone,
            Andesite,
            Andesite_Smooth,
            Diorite,
            Diorite_Smooth,
            Granite,
            Granite_Smooth
        }

    }
}