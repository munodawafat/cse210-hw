using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _Goals;
    private int _Score;
    public GoalManager()
    {
        _Goals = new List<Goal>();
        _Score = 0;
    }

    public void AddGoal(Goal goal)
    {}

    public void RecordEvent(int index)
    {}

    public void DisplayGoals()
    {}

    public int GetScore()
    {
        return _Score;
    }

    public void SaveGoals(string filename)
    {}

    public void LoadGoals(string filename)
    {}
}