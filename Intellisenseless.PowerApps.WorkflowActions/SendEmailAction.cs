using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;

namespace Intellisenseless.PowerApps.WorkflowActions
{
    public partial class SendEmailAction : BaseWorkflow
    {        
        [RequiredArgument]
        [Input("Select an email to send")]
        [ReferenceTarget("email")]
        public InArgument<EntityReference> EmailReference { get; set; }

        protected override void ExecuteInternal(LocalWorkflowContext context)
        {
            var email = this.EmailReference.Get(context.CodeActivityContext);
            SendEmailRequest sendEmail = new SendEmailRequest
            {
                EmailId = email.Id,
                TrackingToken = "",
                IssueSend = true
            };

            context.OrganizationService.Execute(sendEmail);
        }
    }
}

