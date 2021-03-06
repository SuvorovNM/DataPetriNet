using DataPetriNetOnSmt.Enums;
using DataPetriNetOnSmt.SoundnessVerification;
using System.Collections.Generic;

namespace DataPetriNetOnSmt.Visualization.Extensions
{
    public static class DictionaryExtension
    {
        public static void AddStatesForType(this Dictionary<ConstraintState, StateType> resultDictionary, KeyValuePair<StateType, List<ConstraintState>> statesToAdd)
        {
            var stateType = statesToAdd.Key;

            foreach (var state in statesToAdd.Value)
            {
                if (resultDictionary.ContainsKey(state))
                {
                    resultDictionary[state] = stateType;
                }
                else
                {
                    resultDictionary.Add(state, stateType);
                }
            }
        }
    }
}
