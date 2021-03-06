# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.registry
  module Models
    #
    # Application information
    #
    class ApplicationRegistrationQueryApiModel
      # @return [ApplicationType] Possible values include: 'Server', 'Client',
      # 'ClientAndServer', 'DiscoveryServer'
      attr_accessor :application_type

      # @return [String] Application uri
      attr_accessor :application_uri

      # @return [String] Product uri
      attr_accessor :product_uri

      # @return [String] Name of application
      attr_accessor :application_name

      # @return [String] Locale of application name - default is "en"
      attr_accessor :locale

      # @return [String] Application capability to query with
      attr_accessor :capability

      # @return [String] Discovery profile uri
      attr_accessor :discovery_profile_uri

      # @return [String] Gateway server uri
      attr_accessor :gateway_server_uri

      # @return [String] Supervisor or site the application belongs to.
      attr_accessor :site_or_gateway_id

      # @return [Boolean] Whether to include apps that were soft deleted
      attr_accessor :include_not_seen_since

      # @return [String] Discoverer id to filter with
      attr_accessor :discoverer_id


      #
      # Mapper for ApplicationRegistrationQueryApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ApplicationRegistrationQueryApiModel',
          type: {
            name: 'Composite',
            class_name: 'ApplicationRegistrationQueryApiModel',
            model_properties: {
              application_type: {
                client_side_validation: true,
                required: false,
                serialized_name: 'applicationType',
                type: {
                  name: 'Enum',
                  module: 'ApplicationType'
                }
              },
              application_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'applicationUri',
                type: {
                  name: 'String'
                }
              },
              product_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'productUri',
                type: {
                  name: 'String'
                }
              },
              application_name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'applicationName',
                type: {
                  name: 'String'
                }
              },
              locale: {
                client_side_validation: true,
                required: false,
                serialized_name: 'locale',
                type: {
                  name: 'String'
                }
              },
              capability: {
                client_side_validation: true,
                required: false,
                serialized_name: 'capability',
                type: {
                  name: 'String'
                }
              },
              discovery_profile_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'discoveryProfileUri',
                type: {
                  name: 'String'
                }
              },
              gateway_server_uri: {
                client_side_validation: true,
                required: false,
                serialized_name: 'gatewayServerUri',
                type: {
                  name: 'String'
                }
              },
              site_or_gateway_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'siteOrGatewayId',
                type: {
                  name: 'String'
                }
              },
              include_not_seen_since: {
                client_side_validation: true,
                required: false,
                serialized_name: 'includeNotSeenSince',
                type: {
                  name: 'Boolean'
                }
              },
              discoverer_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'discovererId',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end
