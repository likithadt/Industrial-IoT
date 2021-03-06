﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Opc.Ua.PubSub {
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Encodeable Network message
    /// </summary>
    public class NetworkMessage : IEncodeable {

        /// <summary>
        /// Message content
        /// </summary>
        public uint MessageContentMask { get; set; }

        /// <summary>
        /// Message id
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Publisher identifier
        /// </summary>
        public string PublisherId { get; set; }

        /// <summary>
        /// Dataset class
        /// </summary>
        public string DataSetClassId { get; set; }

        /// <summary>
        /// Message type 
        /// </summary>
        public string MessageType { get; set; } = "ua-data";

        /// <summary>
        /// Dataset Messages
        /// </summary>
        public List<DataSetMessage> Messages { get; set; }

        /// <inheritdoc/>
        public ExpandedNodeId TypeId => ExpandedNodeId.Null;

        /// <inheritdoc/>
        public ExpandedNodeId BinaryEncodingId => ExpandedNodeId.Null;

        /// <inheritdoc/>
        public ExpandedNodeId XmlEncodingId => ExpandedNodeId.Null;

        /// <inheritdoc/>
        public void Decode(IDecoder decoder) {
            switch (decoder.EncodingType) {
                case EncodingType.Binary:
                    DecodeBinary(decoder);
                    break;
                case EncodingType.Json:
                    DecodeJson(decoder);
                    break;
                case EncodingType.Xml:
                    throw new NotSupportedException("XML encoding is not supported.");
                default:
                    throw new NotImplementedException(
                        $"Unknown encoding: {decoder.EncodingType}");
            }
        }

        /// <inheritdoc/>
        public void Encode(IEncoder encoder) {
            switch (encoder.EncodingType) {
                case EncodingType.Binary:
                    EncodeBinary(encoder);
                    break;
                case EncodingType.Json:
                    EncodeJson(encoder);
                    break;
                case EncodingType.Xml:
                    throw new NotSupportedException("XML encoding is not supported.");
                default:
                    throw new NotImplementedException(
                        $"Unknown encoding: {encoder.EncodingType}");
            }
        }


        /// <inheritdoc/>
        public override bool Equals(Object value) {
            return IsEqual(value as IEncodeable);
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        /// <inheritdoc/>
        public bool IsEqual(IEncodeable encodeable) {
            if (ReferenceEquals(this, encodeable)) {
                return true;
            }

            if (!(encodeable is NetworkMessage wrapper)) {
                return false;
            }

            if (!Utils.IsEqual(wrapper.MessageContentMask, MessageContentMask) ||
                !Utils.IsEqual(wrapper.MessageId, MessageId) ||
                !Utils.IsEqual(wrapper.DataSetClassId, DataSetClassId) ||
                !Utils.IsEqual(wrapper.BinaryEncodingId, BinaryEncodingId) ||
                !Utils.IsEqual(wrapper.MessageType, MessageType) ||
                !Utils.IsEqual(wrapper.PublisherId, PublisherId) ||
                !Utils.IsEqual(wrapper.TypeId, TypeId) ||
                !Utils.IsEqual(wrapper.XmlEncodingId, XmlEncodingId) ||
                !Utils.IsEqual(wrapper.Messages, Messages)) {
                return false;
            }

            if (Messages.Count != wrapper.Messages.Count) {
                return false;
            }

            return true;
        }

#pragma warning disable IDE0060 // Remove unused parameter
        /// <summary>
        /// Decode from binary
        /// </summary>
        /// <param name="decoder"></param>
        private void DecodeBinary(IDecoder decoder) {
#pragma warning restore IDE0060 // Remove unused parameter
            // TODO
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        private void DecodeJson(IDecoder decoder) {
            MessageId = decoder.ReadString("MessageId");
            MessageContentMask = 0;
            if (MessageId != null) {
                MessageContentMask |= (uint)JsonNetworkMessageContentMask.NetworkMessageHeader;
            }
            
            MessageType = decoder.ReadString("MessageType");
            if (MessageType != "ua-data"){
                // todo throw incorrect message format
            }

            PublisherId = decoder.ReadString("PublisherId");
            if (PublisherId != null) {
                MessageContentMask |= (uint)JsonNetworkMessageContentMask.PublisherId;
            }

            DataSetClassId = decoder.ReadString("DataSetClassId");
            if(DataSetClassId != null){
                MessageContentMask |= (uint)JsonNetworkMessageContentMask.DataSetClassId;
            }

            Array messagesArray = decoder.ReadEncodeableArray("Messages", typeof(DataSetMessage));
            Messages = new List<DataSetMessage>();
            foreach (var value in messagesArray) {
                Messages.Add(value as DataSetMessage);
            }
            if (Messages.Count == 1) {
                MessageContentMask |= (uint)JsonNetworkMessageContentMask.SingleDataSetMessage;
            }
        }

#pragma warning disable IDE0060 // Remove unused parameter
        /// <summary>
        /// Encode as binary
        /// </summary>
        /// <param name="encoder"></param>
        private void EncodeBinary(IEncoder encoder) {
#pragma warning restore IDE0060 // Remove unused parameter
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Encode as json
        /// </summary>
        /// <param name="encoder"></param>
        private void EncodeJson(IEncoder encoder) {
            if ((MessageContentMask & (uint)JsonNetworkMessageContentMask.NetworkMessageHeader) != 0) {
                encoder.WriteString(nameof(MessageId), MessageId);
                encoder.WriteString("MessageType", "ua-data");
                if ((MessageContentMask & (uint)JsonNetworkMessageContentMask.PublisherId) != 0) {
                    encoder.WriteString(nameof(PublisherId), PublisherId);
                }
                if ((MessageContentMask & (uint)JsonNetworkMessageContentMask.DataSetClassId) != 0) {
                    encoder.WriteString(nameof(DataSetClassId), DataSetClassId);
                }
                if (Messages != null && Messages.Count > 0) {
                    if ((MessageContentMask & (uint)JsonNetworkMessageContentMask.SingleDataSetMessage) != 0) {
                        encoder.WriteEncodeable(nameof(Messages), Messages[0], typeof(DataSetMessage));
                    }
                    else {
                        encoder.WriteEncodeableArray(nameof(Messages), Messages.ToArray(), typeof(DataSetMessage[]));
                    }
                }
            }
        }
    }
}