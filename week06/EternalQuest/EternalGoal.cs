    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _Name = name;
            _Description = description;
            _Points = points;
        }

        public override int RecordEvent()
        {
            return _Points;
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {_Name} ({_Description})";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{_Name}:{_Description}:{_Points}";
        }
    }
