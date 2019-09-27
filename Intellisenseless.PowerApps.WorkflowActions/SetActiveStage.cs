using Intellisenseless.PowerApps.WorkflowActions.ProxyClasses;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Linq;

namespace Intellisenseless.PowerApps.WorkflowActions
{
    public partial class SetActiveStage : BaseWorkflow
    {
        [RequiredArgument]
        [Input("Stage Name to Set")]
        public InArgument<string> StageNameInArgument { get; set; }

        protected override void ExecuteInternal(LocalWorkflowContext context)
        {            
            var stageNameToSet = this.StageNameInArgument.Get(context.CodeActivityContext).ToUpper();

            RetrieveProcessInstancesRequest retrieveProcessInstancesRequest = new RetrieveProcessInstancesRequest
            {
                EntityId = context.WorkflowContext.PrimaryEntityId,
                EntityLogicalName = context.WorkflowContext.PrimaryEntityName
            };

            RetrieveProcessInstancesResponse retrievedProcessInstancesResponse = (RetrieveProcessInstancesResponse)context.OrganizationService.Execute(retrieveProcessInstancesRequest);
            
            var activeProcessInstance = retrievedProcessInstancesResponse.Processes.Entities[0]; // First record is the active process instance                        
            var workflowReference = (EntityReference)activeProcessInstance.Attributes["processid"];
            Process workflow = context.OrganizationService.Retrieve(workflowReference.LogicalName, workflowReference.Id, new ColumnSet(true)).ToEntity<Process>();
                                   
            RetrieveActivePathRequest pathRequest = new RetrieveActivePathRequest
            {
                ProcessInstanceId = activeProcessInstance.Id
            };

            RetrieveActivePathResponse pathResponse = (RetrieveActivePathResponse)context.OrganizationService.Execute(pathRequest);
            var stageToSetId = (Guid)pathResponse.ProcessStages.Entities.Where(x => x.Attributes["stagename"].ToString().ToUpper() == stageNameToSet).First().Attributes["processstageid"];

            ColumnSet columns = new ColumnSet();
            columns.AddColumn("activestageid");
            Entity retrievedProcessInstance = context.OrganizationService.Retrieve(workflow.UniqueName, activeProcessInstance.Id, columns);

            // Set the next stage as the active stage
            retrievedProcessInstance["activestageid"] = new EntityReference(ProcessStage.EntityLogicalName, stageToSetId);
            context.OrganizationService.Update(retrievedProcessInstance);
        }
    }
}

