using System;

namespace RicksApp
{
    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Type Type { get; }
        public Wood BackWood { get; }
        public Wood TopWood { get; }
        public int NumStrings { get; }

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood,
            Wood topWood, int numStrings)
        {
            Builder = builder;
            BackWood = backWood;
            TopWood = topWood;
            Model = model;
            Type = type;
            NumStrings = numStrings;
        }

        public bool Matches(GuitarSpec searchSpec)
        {
            Builder builder = searchSpec.Builder;
            var model = searchSpec.Model.ToLower();
            var type = searchSpec.Type;
            var backwood = searchSpec.BackWood;
            var topwood = searchSpec.TopWood;
            var numStrings = searchSpec.NumStrings;
            if ((builder == Builder) && ((model != null) && (!model.Equals("")) && (model == Model.ToLower()))
                && (type == Type) && (backwood == BackWood) && (topwood == TopWood) && (numStrings == NumStrings))
            {
                return true;
            }

                return false;

        }
    }
}