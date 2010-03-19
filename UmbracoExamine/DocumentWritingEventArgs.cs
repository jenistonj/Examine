﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Lucene.Net.Documents;
using UmbracoExamine.Core;

namespace UmbracoExamine.Providers
{
    /// <summary>
    /// Event arguments for a Document Writing event
    /// </summary>
    public class DocumentWritingEventArgs : CancelEventArgs, INodeEventArgs
    {
        /// <summary>
        /// Lucene.NET Document, including all previously added fields
        /// </summary>
        public Document Document { get; private set; }
        /// <summary>
        /// Fields of the indexer
        /// </summary>
        public Dictionary<string, string> Fields { get; private set; }
        /// <summary>
        /// NodeId of the document being written
        /// </summary>
        public int NodeId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="d"></param>
        /// <param name="fields"></param>
        public DocumentWritingEventArgs(int nodeId, Document d, Dictionary<string, string> fields)
        {
            this.NodeId = nodeId;
            this.Document = d;
            this.Fields = fields;
        }
    }
}