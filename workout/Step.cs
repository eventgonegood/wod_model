using System.Collections;
using System.Collections.Generic;

namespace v23athletics.wod.workout
{
    using System;
    using priority;

    public class Step : IEnumerable<Step>
    {
        readonly IDictionary<string, Step> _children = new Dictionary<string, Step>();

        public readonly string Label;
        public Step Parent { get; private set; }
        public List<Movement> Movements { get; set; }
        public int Rounds { get; set; }
        public Priority Priority { get; set; }
        public TimeSpan Cutoff { get; set; }

        public Step(string label)
        {
            Label = label;
        }

        public Step GetSubStep(string label)
        {
            return _children[label];
        }

        public void AddStep(Step step)
        {
            if (step.Parent != null)
            {
                step.Parent._children.Remove(step.Label);
            }

            step.Parent = this;
            _children.Add(step.Label, step);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Step> GetEnumerator()
        {
            return _children.Values.GetEnumerator();
        }

        public int Count()
        {
            return _children.Count;
        }
    }
}