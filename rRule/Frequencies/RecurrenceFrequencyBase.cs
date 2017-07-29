namespace Vico.rRule.Frequencies
{
    public abstract class RecurrenceFrequencyBase : ITaggable
    {
        public string TagName => FrequencyConsts.FrequencyTagName;

        public abstract string PatternName { get; }
    }
}
