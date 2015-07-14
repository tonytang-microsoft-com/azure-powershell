﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSPoolStatistics
    {
        
        internal Microsoft.Azure.Batch.PoolStatistics omObject;
        
        private PSUsageStatistics usageStatistics;
        
        private PSResourceStatistics resourceStatistics;
        
        internal PSPoolStatistics(Microsoft.Azure.Batch.PoolStatistics omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public System.DateTime? StartTime
        {
            get
            {
                return this.omObject.StartTime;
            }
        }
        
        public System.DateTime? LastUpdateTime
        {
            get
            {
                return this.omObject.LastUpdateTime;
            }
        }
        
        public PSUsageStatistics UsageStatistics
        {
            get
            {
                if (((this.usageStatistics == null) 
                            && (this.omObject.UsageStatistics != null)))
                {
                    this.usageStatistics = new PSUsageStatistics(this.omObject.UsageStatistics);
                }
                return this.usageStatistics;
            }
        }
        
        public PSResourceStatistics ResourceStatistics
        {
            get
            {
                if (((this.resourceStatistics == null) 
                            && (this.omObject.ResourceStatistics != null)))
                {
                    this.resourceStatistics = new PSResourceStatistics(this.omObject.ResourceStatistics);
                }
                return this.resourceStatistics;
            }
        }
    }
}
