var workflow = new Workflow();
workflow.AddActivity(new UploadVideo());
workflow.AddActivity(new CallService());
workflow.AddActivity(new Send());
workflow.AddActivity(new Change());
var engnie = new WorkflowEngine(workflow);
engnie.Run(workflow);