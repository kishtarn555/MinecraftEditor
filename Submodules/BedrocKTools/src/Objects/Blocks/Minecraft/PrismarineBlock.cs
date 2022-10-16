//==============================================================================
// THIS CODE WAS AUTOGENERATED BY:
//    BedrockTools_Build.Generator.MinecraftBlocks.VariationGenerator
// Do not modify, any changes will be lost when the generation tool is run again
// version: 0.1.0
//==============================================================================
using BedrockTools.Nbt.Elements;

namespace BedrockTools.Objects.Blocks.Minecraft {
    public class PrismarineBlock : Block {
        public readonly PrismarineType Variation;

        public PrismarineBlock (string identifier, PrismarineType variation) : base(identifier) {
            Variation = variation;
        }

        public override NbtCompoundSorted GetBlockState () {
            return new NbtCompoundSorted() {
                {"prismarine_block_type", (NbtString)Variation.ToString().ToLower()}
            };
        }

        public enum PrismarineType {
            Default,
            Dark,
            Bricks
        }

    }
}