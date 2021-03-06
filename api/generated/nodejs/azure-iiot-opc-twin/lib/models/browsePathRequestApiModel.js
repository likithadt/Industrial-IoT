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
 * Browse nodes by path
 *
 */
class BrowsePathRequestApiModel {
  /**
   * Create a BrowsePathRequestApiModel.
   * @property {string} [nodeId] Node to browse from.
   * (default: RootFolder).
   * @property {array} browsePaths The paths to browse from node.
   * (mandatory)
   * @property {boolean} [readVariableValues] Whether to read variable values
   * on target nodes.
   * (default is false). Default value: false .
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
   * Defines the metadata of BrowsePathRequestApiModel
   *
   * @returns {object} metadata of BrowsePathRequestApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'BrowsePathRequestApiModel',
      type: {
        name: 'Composite',
        className: 'BrowsePathRequestApiModel',
        modelProperties: {
          nodeId: {
            required: false,
            serializedName: 'nodeId',
            type: {
              name: 'String'
            }
          },
          browsePaths: {
            required: true,
            serializedName: 'browsePaths',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'ArrayElementType',
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
              }
            }
          },
          readVariableValues: {
            required: false,
            serializedName: 'readVariableValues',
            defaultValue: false,
            type: {
              name: 'Boolean'
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

module.exports = BrowsePathRequestApiModel;
