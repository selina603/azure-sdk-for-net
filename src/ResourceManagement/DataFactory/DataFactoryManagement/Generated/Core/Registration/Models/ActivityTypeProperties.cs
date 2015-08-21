// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Core.Registration.Models
{
    /// <summary>
    /// Activity type properties.
    /// </summary>
    public partial class ActivityTypeProperties
    {
        private string _baseType;
        
        /// <summary>
        /// Optional. Base type of the ActivityType. Must be a built-in Data
        /// Factory Activity type.
        /// </summary>
        public string BaseType
        {
            get { return this._baseType; }
            set { this._baseType = value; }
        }
        
        private string _schema;
        
        /// <summary>
        /// Required. Schema for type-specific properties of the ActivityType.
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }
        
        private string _scope;
        
        /// <summary>
        /// Required. The scope of the ActivityType.
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ActivityTypeProperties class.
        /// </summary>
        public ActivityTypeProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ActivityTypeProperties class with
        /// required arguments.
        /// </summary>
        public ActivityTypeProperties(string scope, string schema)
            : this()
        {
            if (scope == null)
            {
                throw new ArgumentNullException("scope");
            }
            if (schema == null)
            {
                throw new ArgumentNullException("schema");
            }
            this.Scope = scope;
            this.Schema = schema;
        }
    }
}