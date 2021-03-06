/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Method metadata request model
 *
 */
class MethodMetadataRequestApiModel {
  /**
   * Create a MethodMetadataRequestApiModel.
   * @property {string} [methodId] Method id of method to call.
   * (Required)
   * @property {array} [methodBrowsePath] An optional component path from the
   * node identified by
   * MethodId to the actual method node.
   * @property {object} [header]
   * @property {object} [header.elevation]
   * @property {string} [header.elevation.type] Possible values include:
   * 'None', 'UserName', 'X509Certificate', 'JwtToken'
   * @property {object} [header.elevation.value] Value to pass to server
   * @property {array} [header.locales] Optional list of locales in preference
   * order.
   * @property {object} [header.diagnostics]
   * @property {string} [header.diagnostics.level] Possible values include:
   * 'None', 'Status', 'Operations', 'Diagnostics', 'Verbose'
   * @property {string} [header.diagnostics.auditId] Client audit log entry.
   * (default: client generated)
   * @property {date} [header.diagnostics.timeStamp] Timestamp of request.
   * (default: client generated)
   */
  constructor() {
  }

  /**
   * Defines the metadata of MethodMetadataRequestApiModel
   *
   * @returns {object} metadata of MethodMetadataRequestApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'MethodMetadataRequestApiModel',
      type: {
        name: 'Composite',
        className: 'MethodMetadataRequestApiModel',
        modelProperties: {
          methodId: {
            required: false,
            serializedName: 'methodId',
            type: {
              name: 'String'
            }
          },
          methodBrowsePath: {
            required: false,
            serializedName: 'methodBrowsePath',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          },
          header: {
            required: false,
            serializedName: 'header',
            type: {
              name: 'Composite',
              className: 'RequestHeaderApiModel'
            }
          }
        }
      }
    };
  }
}

module.exports = MethodMetadataRequestApiModel;
