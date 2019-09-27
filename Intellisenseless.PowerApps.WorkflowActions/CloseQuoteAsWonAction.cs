using Intellisenseless.PowerApps.WorkflowActions.ProxyClasses;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Intellisenseless.PowerApps.WorkflowActions
{
    public partial class CloseQuoteAsWonAction : BaseWorkflow
    {
        // This is an example argument
        [RequiredArgument]
        [Input("Target Quote to Close")]
        [ReferenceTarget(Quote.EntityLogicalName)]
        public InArgument<EntityReference> QuoteReference { get; set; }

        protected override void ExecuteInternal(LocalWorkflowContext context)
        {
            var quoteReference = this.QuoteReference.Get(context.CodeActivityContext);

            WinQuoteRequest winQuoteRequest = new WinQuoteRequest();
            Entity quoteClose = new Entity("quoteclose");
            quoteClose.Attributes["quoteid"] = quoteReference;
            quoteClose.Attributes["subject"] = "Quote Close" + DateTime.Now.ToString();
            winQuoteRequest.QuoteClose = quoteClose;
            winQuoteRequest.Status = new OptionSetValue(-1);
            context.OrganizationService.Execute(winQuoteRequest);
        }
    }
}

