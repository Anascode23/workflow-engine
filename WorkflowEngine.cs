public class WorkflowEngine
{
    private readonly Workflow _workflow1;
    public WorkflowEngine(Workflow workflow)
    {
        _workflow1 = workflow;
        if (_workflow1 == null)
            throw new ArgumentException("Workflow can't be null");

    }

    public void Run(Workflow workflow)
    {
       workflow.Run();
    }
}
