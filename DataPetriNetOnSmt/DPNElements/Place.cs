using DataPetriNetOnSmt.Abstractions;

namespace DataPetriNetOnSmt.DPNElements
{
    public class Place : Node
    {
        public int Tokens { get; set; }
        public bool IsFinal { get; set; }
    }
}
