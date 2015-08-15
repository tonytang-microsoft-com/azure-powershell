namespace Microsoft.Azure.Commands.Logic
{
    using Microsoft.Azure.Management.Logic;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;

    public abstract class LogicBaseCmdlet : AzurePSCmdlet
    {
        protected ILogicManagementClient Client { get; private set; }

        protected LogicBaseCmdlet()
        {
            this.Client = new LogicManagementClient();
        }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
        }
    }
}
