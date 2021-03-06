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
 * Attribute to read
 *
 */
class AttributeReadRequestApiModel {
  /**
   * Create a AttributeReadRequestApiModel.
   * @property {string} nodeId Node to read from or write to (mandatory)
   * @property {string} attribute Possible values include: 'NodeClass',
   * 'BrowseName', 'DisplayName', 'Description', 'WriteMask', 'UserWriteMask',
   * 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops',
   * 'EventNotifier', 'Value', 'DataType', 'ValueRank', 'ArrayDimensions',
   * 'AccessLevel', 'UserAccessLevel', 'MinimumSamplingInterval',
   * 'Historizing', 'Executable', 'UserExecutable', 'DataTypeDefinition',
   * 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions'
   */
  constructor() {
  }

  /**
   * Defines the metadata of AttributeReadRequestApiModel
   *
   * @returns {object} metadata of AttributeReadRequestApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'AttributeReadRequestApiModel',
      type: {
        name: 'Composite',
        className: 'AttributeReadRequestApiModel',
        modelProperties: {
          nodeId: {
            required: true,
            serializedName: 'nodeId',
            type: {
              name: 'String'
            }
          },
          attribute: {
            required: true,
            serializedName: 'attribute',
            type: {
              name: 'Enum',
              allowedValues: [ 'NodeClass', 'BrowseName', 'DisplayName', 'Description', 'WriteMask', 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier', 'Value', 'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel', 'MinimumSamplingInterval', 'Historizing', 'Executable', 'UserExecutable', 'DataTypeDefinition', 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions' ]
            }
          }
        }
      }
    };
  }
}

module.exports = AttributeReadRequestApiModel;
