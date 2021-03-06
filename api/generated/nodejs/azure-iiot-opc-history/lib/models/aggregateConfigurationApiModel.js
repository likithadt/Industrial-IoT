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
 * Aggregate configuration
 *
 */
class AggregateConfigurationApiModel {
  /**
   * Create a AggregateConfigurationApiModel.
   * @property {boolean} [useServerCapabilitiesDefaults] Whether to use the
   * default server caps
   * @property {boolean} [treatUncertainAsBad] Whether to treat uncertain as
   * bad
   * @property {number} [percentDataBad] Percent of data that is bad
   * @property {number} [percentDataGood] Percent of data that is good
   * @property {boolean} [useSlopedExtrapolation] Whether to use sloped
   * extrapolation.
   */
  constructor() {
  }

  /**
   * Defines the metadata of AggregateConfigurationApiModel
   *
   * @returns {object} metadata of AggregateConfigurationApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'AggregateConfigurationApiModel',
      type: {
        name: 'Composite',
        className: 'AggregateConfigurationApiModel',
        modelProperties: {
          useServerCapabilitiesDefaults: {
            required: false,
            serializedName: 'useServerCapabilitiesDefaults',
            type: {
              name: 'Boolean'
            }
          },
          treatUncertainAsBad: {
            required: false,
            serializedName: 'treatUncertainAsBad',
            type: {
              name: 'Boolean'
            }
          },
          percentDataBad: {
            required: false,
            serializedName: 'percentDataBad',
            type: {
              name: 'Number'
            }
          },
          percentDataGood: {
            required: false,
            serializedName: 'percentDataGood',
            type: {
              name: 'Number'
            }
          },
          useSlopedExtrapolation: {
            required: false,
            serializedName: 'useSlopedExtrapolation',
            type: {
              name: 'Boolean'
            }
          }
        }
      }
    };
  }
}

module.exports = AggregateConfigurationApiModel;
