namespace Microsoft.Azure.Commands.Logic
{
    using System.Management.Automation;
    using Microsoft.Azure.Commands.Logic.Models;
    using Microsoft.Azure.Management.Logic;
    using System.Collections.Generic;    

    [Cmdlet(VerbsCommon.Get, "AzureWorkflow"), OutputType(typeof(PSWorkflow))]
    public class GetAzureWorkflowCmdlet : LogicBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        [Alias("Name")]
        public virtual string ResourceName { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            if (!string.IsNullOrEmpty(this.ResourceName))
            {
                //var workflow = this.Client.Workflows.Get(this.ResourceGroupName, this.ResourceName);
                //this.WriteObject(workflow);
            }
            else if (!string.IsNullOrEmpty(this.ResourceGroupName))
            {
                //var getLbResponse = this.LoadBalancerClient.List(this.ResourceGroupName);

                //var psLoadBalancers = new List<PSWorkflow>();

                //foreach (var lb in getLbResponse.LoadBalancers)
                //{
                //    var psLb = this.ToPsLoadBalancer(lb);
                //    psLb.ResourceGroupName = this.ResourceGroupName;
                //    psLoadBalancers.Add(psLb);
                //}

                //WriteObject(psLoadBalancers, true);
            }
            else
            {
                //var getLbResponse = this.LoadBalancerClient.ListAll();

                //var psLoadBalancers = new List<PSWorkflow>();

                //foreach (var lb in getLbResponse.LoadBalancers)
                //{
                //    var psLb = this.ToPsLoadBalancer(lb);
                //    psLb.ResourceGroupName = NetworkBaseCmdlet.GetResourceGroup(lb.Id);
                //    psLoadBalancers.Add(psLb);
                //}

                //WriteObject(psLoadBalancers, true);
            }
        }
    }
}

