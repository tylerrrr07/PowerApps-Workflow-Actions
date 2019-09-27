//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intellisenseless.PowerApps.WorkflowActions.ProxyClasses
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.1.0.7711")]
	public enum WorkflowState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Activated = 1,
	}
	
	/// <summary>
	/// Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("workflow")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.1.0.7711")]
	public partial class Process : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Process() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "workflow";
		
		public const int EntityTypeCode = 4703;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the latest activation record for the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeworkflowid")]
		public Microsoft.Xrm.Sdk.EntityReference ActiveProcessID
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activeworkflowid");
			}
		}
		
		/// <summary>
		/// Indicates whether the asynchronous system job is automatically deleted on completion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncautodelete")]
		public System.Nullable<bool> DeleteJobOnCompletion
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("asyncautodelete");
			}
			set
			{
				this.OnPropertyChanging("DeleteJobOnCompletion");
				this.SetAttributeValue("asyncautodelete", value);
				this.OnPropertyChanged("DeleteJobOnCompletion");
			}
		}
		
		/// <summary>
		/// Business Process Type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocesstype")]
		public Microsoft.Xrm.Sdk.OptionSetValue BusinessProcessType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businessprocesstype");
			}
			set
			{
				this.OnPropertyChanging("BusinessProcessType");
				this.SetAttributeValue("businessprocesstype", value);
				this.OnPropertyChanged("BusinessProcessType");
			}
		}
		
		/// <summary>
		/// Category of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
		public Microsoft.Xrm.Sdk.OptionSetValue Category
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("category");
			}
			set
			{
				this.OnPropertyChanging("Category");
				this.SetAttributeValue("category", value);
				this.OnPropertyChanged("Category");
			}
		}
		
		/// <summary>
		/// Business logic converted into client data
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientdata")]
		public string ClientData
		{
			get
			{
				return this.GetAttributeValue<string>("clientdata");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the process was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy_Delegate
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Stage of the process when triggered on Create.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createstage")]
		public Microsoft.Xrm.Sdk.OptionSetValue CreateStage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("createstage");
			}
			set
			{
				this.OnPropertyChanging("CreateStage");
				this.SetAttributeValue("createstage", value);
				this.OnPropertyChanged("CreateStage");
			}
		}
		
		/// <summary>
		/// Stage of the process when triggered on Delete.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deletestage")]
		public Microsoft.Xrm.Sdk.OptionSetValue DeleteStage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("deletestage");
			}
			set
			{
				this.OnPropertyChanging("DeleteStage");
				this.SetAttributeValue("deletestage", value);
				this.OnPropertyChanged("DeleteStage");
			}
		}
		
		/// <summary>
		/// Description of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Shows the default image for the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
		public byte[] DefaultImage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("entityimage");
			}
			set
			{
				this.OnPropertyChanging("DefaultImage");
				this.SetAttributeValue("entityimage", value);
				this.OnPropertyChanged("DefaultImage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
		public System.Nullable<long> EntityImage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
		public string EntityImage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("entityimage_url");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
		public System.Nullable<System.Guid> EntityImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		public System.Nullable<System.Guid> FormID
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("formid");
			}
			set
			{
				this.OnPropertyChanging("FormID");
				this.SetAttributeValue("formid", value);
				this.OnPropertyChanged("FormID");
			}
		}
		
		/// <summary>
		/// Input parameters to the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inputparameters")]
		public string InputParameters
		{
			get
			{
				return this.GetAttributeValue<string>("inputparameters");
			}
			set
			{
				this.OnPropertyChanging("InputParameters");
				this.SetAttributeValue("inputparameters", value);
				this.OnPropertyChanged("InputParameters");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Indicates whether the process was created using the Microsoft Dynamics 365 Web application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscrmuiworkflow")]
		public System.Nullable<bool> IsCRMProcess
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscrmuiworkflow");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty Customizable
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				this.OnPropertyChanging("Customizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("Customizable");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Whether or not the steps in the process are executed in a single transaction.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istransacted")]
		public System.Nullable<bool> IsTransacted
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("istransacted");
			}
			set
			{
				this.OnPropertyChanging("IsTransacted");
				this.SetAttributeValue("istransacted", value);
				this.OnPropertyChanged("IsTransacted");
			}
		}
		
		/// <summary>
		/// Language of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
		public System.Nullable<int> Language
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("languagecode");
			}
			set
			{
				this.OnPropertyChanging("Language");
				this.SetAttributeValue("languagecode", value);
				this.OnPropertyChanged("Language");
			}
		}
		
		/// <summary>
		/// Shows the mode of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Mode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode");
			}
			set
			{
				this.OnPropertyChanging("Mode");
				this.SetAttributeValue("mode", value);
				this.OnPropertyChanged("Mode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the process was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy_Delegate
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string ProcessName
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("ProcessName");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("ProcessName");
			}
		}
		
		/// <summary>
		/// Indicates whether the process is able to run as an on-demand process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ondemand")]
		public System.Nullable<bool> RunAsOnDemand
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ondemand");
			}
			set
			{
				this.OnPropertyChanging("RunAsOnDemand");
				this.SetAttributeValue("ondemand", value);
				this.OnPropertyChanged("RunAsOnDemand");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> RecordOverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference Owner
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("Owner");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("Owner");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Unique identifier of the definition for process activation.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentworkflowid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentProcessID
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentworkflowid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
			}
		}
		
		/// <summary>
		/// Primary entity for the process. The process can be associated for one or more SDK operations defined on the primary entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentity")]
		public string PrimaryEntity
		{
			get
			{
				return this.GetAttributeValue<string>("primaryentity");
			}
			set
			{
				this.OnPropertyChanging("PrimaryEntity");
				this.SetAttributeValue("primaryentity", value);
				this.OnPropertyChanged("PrimaryEntity");
			}
		}
		
		/// <summary>
		/// Type the business process flow order.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processorder")]
		public System.Nullable<int> ProcessOrder
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("processorder");
			}
			set
			{
				this.OnPropertyChanging("ProcessOrder");
				this.SetAttributeValue("processorder", value);
				this.OnPropertyChanged("ProcessOrder");
			}
		}
		
		/// <summary>
		/// Contains the role assignment for the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processroleassignment")]
		public string RoleAssignmentForProcess
		{
			get
			{
				return this.GetAttributeValue<string>("processroleassignment");
			}
			set
			{
				this.OnPropertyChanging("RoleAssignmentForProcess");
				this.SetAttributeValue("processroleassignment", value);
				this.OnPropertyChanged("RoleAssignmentForProcess");
			}
		}
		
		/// <summary>
		/// Indicates the rank for order of execution for the synchronous workflow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rank")]
		public System.Nullable<int> Rank
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("rank");
			}
			set
			{
				this.OnPropertyChanging("Rank");
				this.SetAttributeValue("rank", value);
				this.OnPropertyChanged("Rank");
			}
		}
		
		/// <summary>
		/// The renderer type of Workflow
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rendererobjecttypecode")]
		public string RendererType
		{
			get
			{
				return this.GetAttributeValue<string>("rendererobjecttypecode");
			}
			set
			{
				this.OnPropertyChanging("RendererType");
				this.SetAttributeValue("rendererobjecttypecode", value);
				this.OnPropertyChanged("RendererType");
			}
		}
		
		/// <summary>
		/// Specifies the system user account under which a workflow executes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("runas")]
		public Microsoft.Xrm.Sdk.OptionSetValue RunAsUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("runas");
			}
			set
			{
				this.OnPropertyChanging("RunAsUser");
				this.SetAttributeValue("runas", value);
				this.OnPropertyChanged("RunAsUser");
			}
		}
		
		/// <summary>
		/// Scope of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scope")]
		public Microsoft.Xrm.Sdk.OptionSetValue Scope
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("scope");
			}
			set
			{
				this.OnPropertyChanging("Scope");
				this.SetAttributeValue("scope", value);
				this.OnPropertyChanged("Scope");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK Message associated with this workflow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SDKMessage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> Solution
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Status of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<WorkflowState> Status
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((WorkflowState)(System.Enum.ToObject(typeof(WorkflowState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("Status");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("Status");
			}
		}
		
		/// <summary>
		/// Additional information about status of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusReason
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusReason");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusReason");
			}
		}
		
		/// <summary>
		/// Indicates whether the process can be included in other processes as a child process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subprocess")]
		public System.Nullable<bool> IsChildProcess
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("subprocess");
			}
			set
			{
				this.OnPropertyChanging("IsChildProcess");
				this.SetAttributeValue("subprocess", value);
				this.OnPropertyChanged("IsChildProcess");
			}
		}
		
		/// <summary>
		/// Select whether synchronous workflow failures will be saved to log files.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncworkflowlogonfailure")]
		public System.Nullable<bool> LogUponFailure
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("syncworkflowlogonfailure");
			}
			set
			{
				this.OnPropertyChanging("LogUponFailure");
				this.SetAttributeValue("syncworkflowlogonfailure", value);
				this.OnPropertyChanged("LogUponFailure");
			}
		}
		
		/// <summary>
		/// Indicates whether the process will be triggered when the primary entity is created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("triggeroncreate")]
		public System.Nullable<bool> TriggerOnCreate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("triggeroncreate");
			}
			set
			{
				this.OnPropertyChanging("TriggerOnCreate");
				this.SetAttributeValue("triggeroncreate", value);
				this.OnPropertyChanged("TriggerOnCreate");
			}
		}
		
		/// <summary>
		/// Indicates whether the process will be triggered on deletion of the primary entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("triggerondelete")]
		public System.Nullable<bool> TriggerOnDelete
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("triggerondelete");
			}
			set
			{
				this.OnPropertyChanging("TriggerOnDelete");
				this.SetAttributeValue("triggerondelete", value);
				this.OnPropertyChanged("TriggerOnDelete");
			}
		}
		
		/// <summary>
		/// Attributes that trigger the process when updated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("triggeronupdateattributelist")]
		public string TriggerOnUpdateAttributeList
		{
			get
			{
				return this.GetAttributeValue<string>("triggeronupdateattributelist");
			}
			set
			{
				this.OnPropertyChanging("TriggerOnUpdateAttributeList");
				this.SetAttributeValue("triggeronupdateattributelist", value);
				this.OnPropertyChanged("TriggerOnUpdateAttributeList");
			}
		}
		
		/// <summary>
		/// Type of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
		public Microsoft.Xrm.Sdk.OptionSetValue Type
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type");
			}
			set
			{
				this.OnPropertyChanging("Type");
				this.SetAttributeValue("type", value);
				this.OnPropertyChanged("Type");
			}
		}
		
		/// <summary>
		/// Unique name of the process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// Select the stage a process will be triggered on update.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updatestage")]
		public Microsoft.Xrm.Sdk.OptionSetValue UpdateStage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("updatestage");
			}
			set
			{
				this.OnPropertyChanging("UpdateStage");
				this.SetAttributeValue("updatestage", value);
				this.OnPropertyChanged("UpdateStage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("workflowid");
			}
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("workflowid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ProcessId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowidunique")]
		public System.Nullable<System.Guid> WorkflowIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("workflowidunique");
			}
		}
		
		/// <summary>
		/// XAML that defines the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("xaml")]
		public string Xaml
		{
			get
			{
				return this.GetAttributeValue<string>("xaml");
			}
			set
			{
				this.OnPropertyChanging("Xaml");
				this.SetAttributeValue("xaml", value);
				this.OnPropertyChanged("Xaml");
			}
		}
		
		/// <summary>
		/// 1:N process_processstage
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processstage")]
		public System.Collections.Generic.IEnumerable<ProcessStage> process_processstage
		{
			get
			{
				return this.GetRelatedEntities<ProcessStage>("process_processstage", null);
			}
			set
			{
				this.OnPropertyChanging("process_processstage");
				this.SetRelatedEntities<ProcessStage>("process_processstage", null, value);
				this.OnPropertyChanged("process_processstage");
			}
		}
		
		/// <summary>
		/// 1:N workflow_active_workflow
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Process> Referencedworkflow_active_workflow
		{
			get
			{
				return this.GetRelatedEntities<Process>("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedworkflow_active_workflow");
				this.SetRelatedEntities<Process>("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedworkflow_active_workflow");
			}
		}
		
		/// <summary>
		/// 1:N workflow_parent_workflow
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Process> Referencedworkflow_parent_workflow
		{
			get
			{
				return this.GetRelatedEntities<Process>("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedworkflow_parent_workflow");
				this.SetRelatedEntities<Process>("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedworkflow_parent_workflow");
			}
		}
		
		/// <summary>
		/// N:1 workflow_active_workflow
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeworkflowid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Process Referencingworkflow_active_workflow
		{
			get
			{
				return this.GetRelatedEntity<Process>("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
		
		/// <summary>
		/// N:1 workflow_parent_workflow
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentworkflowid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Process Referencingworkflow_parent_workflow
		{
			get
			{
				return this.GetRelatedEntity<Process>("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
		}
	}
}
