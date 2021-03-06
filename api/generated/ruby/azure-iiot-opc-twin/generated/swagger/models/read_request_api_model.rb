# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.twin
  module Models
    #
    # Request node attribute read
    #
    class ReadRequestApiModel
      # @return [Array<AttributeReadRequestApiModel>] Attributes to read
      attr_accessor :attributes

      # @return [RequestHeaderApiModel]
      attr_accessor :header


      #
      # Mapper for ReadRequestApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ReadRequestApiModel',
          type: {
            name: 'Composite',
            class_name: 'ReadRequestApiModel',
            model_properties: {
              attributes: {
                client_side_validation: true,
                required: true,
                serialized_name: 'attributes',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'AttributeReadRequestApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'AttributeReadRequestApiModel'
                      }
                  }
                }
              },
              header: {
                client_side_validation: true,
                required: false,
                serialized_name: 'header',
                type: {
                  name: 'Composite',
                  class_name: 'RequestHeaderApiModel'
                }
              }
            }
          }
        }
      end
    end
  end
end
