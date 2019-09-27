using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace Intellisenseless.PowerApps.WorkflowActions
{
    public partial class DateStringFormatAction : BaseWorkflow
    {
        // This is an example argument
        [RequiredArgument]
        [Input("Date String")]
        public InArgument<string> DateString { get; set; }

        [RequiredArgument]
        [Input("Date Format")]
        public InArgument<string> DateFormat { get; set; }

        [Output("Formatted Date String")]
        public OutArgument<string> FormattedDateString { get; set; }

        protected override void ExecuteInternal(LocalWorkflowContext context)
        {
            string dateString = DateString.Get(context.CodeActivityContext);
            string format = DateFormat.Get(context.CodeActivityContext);
            DateTime date = DateTime.Now;
            if (DateTime.TryParse(dateString, out date))
            {
                FormattedDateString.Set(context.CodeActivityContext, date.ToString(format));
            }
            else if (dateString.ToUpper() == "NOW")
            {
                FormattedDateString.Set(context.CodeActivityContext, DateTime.Now.ToString(format));
            }
            else
            {
                FormattedDateString.Set(context.CodeActivityContext, dateString);
            }
        }
    }
}