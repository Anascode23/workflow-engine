public class Workflow
{
    private readonly List<IActivity> _activity = [];
    public void AddActivity(IActivity activity)
    {
        if (_activity == null)
            throw new ArgumentException("activity can't be null");
        _activity.Add(activity);
    }
    public void Run()
    {
        foreach (var act in _activity)
            act.Execute();
    }
}
