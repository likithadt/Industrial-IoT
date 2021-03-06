package azureiiotopcpublisherapi

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

import (
    "context"
    "go/azure-iiot-opc-publisher"
    "github.com/Azure/go-autorest/autorest"
)

        // BaseClientAPI contains the set of methods on the BaseClient type.
        type BaseClientAPI interface {
            GetFirstListOfPublishedNodes(ctx context.Context, endpointID string, body azureiiotopcpublisher.PublishedItemListRequestAPIModel) (result azureiiotopcpublisher.PublishedItemListResponseAPIModel, err error)
            GetNextListOfPublishedNodes(ctx context.Context, endpointID string, continuationToken string) (result azureiiotopcpublisher.PublishedItemListResponseAPIModelPage, err error)
                GetNextListOfPublishedNodesComplete(ctx context.Context, endpointID string, continuationToken string) (result azureiiotopcpublisher.PublishedItemListResponseAPIModelIterator, err error)
            StartPublishingValues(ctx context.Context, endpointID string, body azureiiotopcpublisher.PublishStartRequestAPIModel) (result azureiiotopcpublisher.PublishStartResponseAPIModel, err error)
            StopPublishingValues(ctx context.Context, endpointID string, body azureiiotopcpublisher.PublishStopRequestAPIModel) (result azureiiotopcpublisher.PublishStopResponseAPIModel, err error)
            Subscribe(ctx context.Context, endpointID string, body string) (result autorest.Response, err error)
            Unsubscribe(ctx context.Context, endpointID string, userID string) (result autorest.Response, err error)
        }

        var _ BaseClientAPI = (*azureiiotopcpublisher.BaseClient)(nil)
