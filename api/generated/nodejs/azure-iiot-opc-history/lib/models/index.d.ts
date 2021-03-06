/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is regenerated.
 */

import * as moment from "moment";

/**
 * Deletes data at times
 */
export interface DeleteValuesAtTimesDetailsApiModel {
  /**
   * The timestamps to delete
   */
  reqTimes: Date[];
}

/**
 * Credential model
 */
export interface CredentialApiModel {
  /**
   * Possible values include: 'None', 'UserName', 'X509Certificate', 'JwtToken'
   */
  type?: string;
  /**
   * Value to pass to server
   */
  value?: any;
}

/**
 * Diagnostics configuration
 */
export interface DiagnosticsApiModel {
  /**
   * Possible values include: 'None', 'Status', 'Operations', 'Diagnostics', 'Verbose'
   */
  level?: string;
  /**
   * Client audit log entry.
   * (default: client generated)
   */
  auditId?: string;
  /**
   * Timestamp of request.
   * (default: client generated)
   */
  timeStamp?: Date;
}

/**
 * Request header model
 */
export interface RequestHeaderApiModel {
  elevation?: CredentialApiModel;
  /**
   * Optional list of locales in preference order.
  */
  locales?: string[];
  diagnostics?: DiagnosticsApiModel;
}

/**
 * Request node history update
*/
export interface DeleteValuesAtTimesDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: DeleteValuesAtTimesDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * Service result
*/
export interface ServiceResultApiModel {
  /**
   * Error code - if null operation succeeded.
  */
  statusCode?: number;
  /**
   * Error message in case of error or null.
  */
  errorMessage?: string;
  /**
   * Additional diagnostics information
  */
  diagnostics?: any;
}

/**
 * History update results
*/
export interface HistoryUpdateResponseApiModel {
  /**
   * List of results from the update operation
  */
  results?: ServiceResultApiModel[];
  errorInfo?: ServiceResultApiModel;
}

/**
 * Delete raw modified data
*/
export interface DeleteValuesDetailsApiModel {
  /**
   * Start time
  */
  startTime?: Date;
  /**
   * End time to delete until
  */
  endTime?: Date;
}

/**
 * Request node history update
*/
export interface DeleteValuesDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: DeleteValuesDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * Delete raw modified data
*/
export interface DeleteModifiedValuesDetailsApiModel {
  /**
   * Start time
  */
  startTime?: Date;
  /**
   * End time to delete until
  */
  endTime?: Date;
}

/**
 * Request node history update
*/
export interface DeleteModifiedValuesDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: DeleteModifiedValuesDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * The events to delete
*/
export interface DeleteEventsDetailsApiModel {
  /**
   * Events to delete
  */
  eventIds: Buffer[];
}

/**
 * Request node history update
*/
export interface DeleteEventsDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: DeleteEventsDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * Request node history read
*/
export interface JTokenHistoryReadRequestApiModel {
  /**
   * Node to read from (mandatory)
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  /**
   * The HistoryReadDetailsType extension object
   * encoded in json and containing the tunneled
   * Historian reader request.
  */
  details?: any;
  /**
   * Index range to read, e.g. 1:2,0:1 for 2 slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
  */
  indexRange?: string;
  header?: RequestHeaderApiModel;
}

/**
 * History read results
*/
export interface JTokenHistoryReadResponseApiModel {
  /**
   * History as json encoded extension object
  */
  history?: any;
  /**
   * Continuation token if more results pending.
  */
  continuationToken?: string;
  errorInfo?: ServiceResultApiModel;
}

/**
 * Request node history read continuation
*/
export interface HistoryReadNextRequestApiModel {
  /**
   * Continuation token to continue reading more
   * results.
  */
  continuationToken: string;
  /**
   * Abort reading after this read
  */
  abort?: boolean;
  header?: RequestHeaderApiModel;
}

/**
 * History read continuation result
*/
export interface JTokenHistoryReadNextResponseApiModel {
  /**
   * History as json encoded extension object
  */
  history?: any;
  /**
   * Continuation token if more results pending.
  */
  continuationToken?: string;
  errorInfo?: ServiceResultApiModel;
}

/**
 * Request node history update
*/
export interface JTokenHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  /**
   * The HistoryUpdateDetailsType extension object
   * encoded as json Variant and containing the tunneled
   * update request for the Historian server. The value
   * is updated at edge using above node address.
  */
  details: any;
  header?: RequestHeaderApiModel;
}

/**
 * Modification information
*/
export interface ModificationInfoApiModel {
  /**
   * Modification time
  */
  modificationTime?: Date;
  /**
   * Possible values include: 'Insert', 'Replace', 'Update', 'Delete'
  */
  updateType?: string;
  /**
   * User who made the change
  */
  userName?: string;
}

/**
 * Historic data
*/
export interface HistoricValueApiModel {
  /**
   * ,
   * The value of data value.
  */
  value?: any;
  /**
   * The status code associated with the value.
  */
  statusCode?: number;
  /**
   * The source timestamp associated with the value.
  */
  sourceTimestamp?: Date;
  /**
   * Additional resolution for the source timestamp.
  */
  sourcePicoseconds?: number;
  /**
   * The server timestamp associated with the value.
  */
  serverTimestamp?: Date;
  /**
   * Additional resolution for the server timestamp.
  */
  serverPicoseconds?: number;
  modificationInfo?: ModificationInfoApiModel;
}

/**
 * Insert historic data
*/
export interface InsertValuesDetailsApiModel {
  /**
   * Values to insert
  */
  values: HistoricValueApiModel[];
}

/**
 * Request node history update
*/
export interface InsertValuesDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: InsertValuesDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * Simple attribute operand model
*/
export interface SimpleAttributeOperandApiModel {
  /**
   * Type definition node id if operand is
   * simple or full attribute operand.
  */
  nodeId?: string;
  /**
   * Browse path of attribute operand
  */
  browsePath?: string[];
  /**
   * Possible values include: 'NodeClass', 'BrowseName', 'DisplayName', 'Description', 'WriteMask',
   * 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier',
   * 'Value', 'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel',
   * 'MinimumSamplingInterval', 'Historizing', 'Executable', 'UserExecutable',
   * 'DataTypeDefinition', 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions'
  */
  attributeId?: string;
  /**
   * Index range of attribute operand
  */
  indexRange?: string;
}

/**
 * Filter operand
*/
export interface FilterOperandApiModel {
  /**
   * Element reference in the outer list if
   * operand is an element operand
  */
  index?: number;
  /**
   * Variant value if operand is a literal
  */
  value?: any;
  /**
   * Type definition node id if operand is
   * simple or full attribute operand.
  */
  nodeId?: string;
  /**
   * Browse path of attribute operand
  */
  browsePath?: string[];
  /**
   * Possible values include: 'NodeClass', 'BrowseName', 'DisplayName', 'Description', 'WriteMask',
   * 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier',
   * 'Value', 'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel',
   * 'MinimumSamplingInterval', 'Historizing', 'Executable', 'UserExecutable',
   * 'DataTypeDefinition', 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions'
  */
  attributeId?: string;
  /**
   * Index range of attribute operand
  */
  indexRange?: string;
  /**
   * Optional alias to refer to it makeing it a
   * full blown attribute operand
  */
  alias?: string;
}

/**
 * An expression element in the filter ast
*/
export interface ContentFilterElementApiModel {
  /**
   * Possible values include: 'Equals', 'IsNull', 'GreaterThan', 'LessThan', 'GreaterThanOrEqual',
   * 'LessThanOrEqual', 'Like', 'Not', 'Between', 'InList', 'And', 'Or', 'Cast', 'InView',
   * 'OfType', 'RelatedTo', 'BitwiseAnd', 'BitwiseOr'
  */
  filterOperator?: string;
  /**
   * The operands in the element for the operator
  */
  filterOperands?: FilterOperandApiModel[];
}

/**
 * Content filter
*/
export interface ContentFilterApiModel {
  /**
   * The flat list of elements in the filter AST
  */
  elements?: ContentFilterElementApiModel[];
}

/**
 * Event filter
*/
export interface EventFilterApiModel {
  /**
   * Select statements
  */
  selectClauses?: SimpleAttributeOperandApiModel[];
  whereClause?: ContentFilterApiModel;
}

/**
 * Historic event
*/
export interface HistoricEventApiModel {
  /**
   * The selected fields of the event
  */
  eventFields?: any[];
}

/**
 * Insert historic events
*/
export interface InsertEventsDetailsApiModel {
  filter?: EventFilterApiModel;
  /**
   * The new events to insert
  */
  events: HistoricEventApiModel[];
}

/**
 * Request node history update
*/
export interface InsertEventsDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: InsertEventsDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * Read event data
*/
export interface ReadEventsDetailsApiModel {
  /**
   * Start time to read from
  */
  startTime?: Date;
  /**
   * End time to read to
  */
  endTime?: Date;
  /**
   * Number of events to read
  */
  numEvents?: number;
  filter?: EventFilterApiModel;
}

/**
 * Request node history read
*/
export interface ReadEventsDetailsApiModelHistoryReadRequestApiModel {
  /**
   * Node to read from (mandatory)
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details?: ReadEventsDetailsApiModel;
  /**
   * Index range to read, e.g. 1:2,0:1 for 2 slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
  */
  indexRange?: string;
  header?: RequestHeaderApiModel;
}

/**
 * Read historic values
*/
export interface ReadValuesDetailsApiModel {
  /**
   * Beginning of period to read. Set to null
   * if no specific start time is specified.
  */
  startTime?: Date;
  /**
   * End of period to read. Set to null if no
   * specific end time is specified.
  */
  endTime?: Date;
  /**
   * The maximum number of values returned for any Node
   * over the time range. If only one time is specified,
   * the time range shall extend to return this number
   * of values. 0 or null indicates that there is no
   * maximum.
  */
  numValues?: number;
  /**
   * Whether to return the bounding values or not.
  */
  returnBounds?: boolean;
}

/**
 * Request node history read
*/
export interface ReadValuesDetailsApiModelHistoryReadRequestApiModel {
  /**
   * Node to read from (mandatory)
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details?: ReadValuesDetailsApiModel;
  /**
   * Index range to read, e.g. 1:2,0:1 for 2 slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
  */
  indexRange?: string;
  header?: RequestHeaderApiModel;
}

/**
 * Read data at specified times
*/
export interface ReadValuesAtTimesDetailsApiModel {
  /**
   * Requested datums
  */
  reqTimes: Date[];
  /**
   * Whether to use simple bounds
  */
  useSimpleBounds?: boolean;
}

/**
 * Request node history read
*/
export interface ReadValuesAtTimesDetailsApiModelHistoryReadRequestApiModel {
  /**
   * Node to read from (mandatory)
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details?: ReadValuesAtTimesDetailsApiModel;
  /**
   * Index range to read, e.g. 1:2,0:1 for 2 slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
  */
  indexRange?: string;
  header?: RequestHeaderApiModel;
}

/**
 * Aggregate configuration
*/
export interface AggregateConfigurationApiModel {
  /**
   * Whether to use the default server caps
  */
  useServerCapabilitiesDefaults?: boolean;
  /**
   * Whether to treat uncertain as bad
  */
  treatUncertainAsBad?: boolean;
  /**
   * Percent of data that is bad
  */
  percentDataBad?: number;
  /**
   * Percent of data that is good
  */
  percentDataGood?: number;
  /**
   * Whether to use sloped extrapolation.
  */
  useSlopedExtrapolation?: boolean;
}

/**
 * Read processed historic data
*/
export interface ReadProcessedValuesDetailsApiModel {
  /**
   * Start time to read from.
  */
  startTime?: Date;
  /**
   * End time to read until
  */
  endTime?: Date;
  /**
   * Interval to process
  */
  processingInterval?: number;
  /**
   * The aggregate type node ids
  */
  aggregateTypeId?: string;
  aggregateConfiguration?: AggregateConfigurationApiModel;
}

/**
 * Request node history read
*/
export interface ReadProcessedValuesDetailsApiModelHistoryReadRequestApiModel {
  /**
   * Node to read from (mandatory)
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details?: ReadProcessedValuesDetailsApiModel;
  /**
   * Index range to read, e.g. 1:2,0:1 for 2 slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
  */
  indexRange?: string;
  header?: RequestHeaderApiModel;
}

/**
 * Read modified data
*/
export interface ReadModifiedValuesDetailsApiModel {
  /**
   * The start time to read from
  */
  startTime?: Date;
  /**
   * The end time to read to
  */
  endTime?: Date;
  /**
   * The number of values to read
  */
  numValues?: number;
}

/**
 * Request node history read
*/
export interface ReadModifiedValuesDetailsApiModelHistoryReadRequestApiModel {
  /**
   * Node to read from (mandatory)
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details?: ReadModifiedValuesDetailsApiModel;
  /**
   * Index range to read, e.g. 1:2,0:1 for 2 slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
  */
  indexRange?: string;
  header?: RequestHeaderApiModel;
}

/**
 * Replace historic data
*/
export interface ReplaceValuesDetailsApiModel {
  /**
   * Values to replace
  */
  values: HistoricValueApiModel[];
}

/**
 * Request node history update
*/
export interface ReplaceValuesDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: ReplaceValuesDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * Replace historic events
*/
export interface ReplaceEventsDetailsApiModel {
  filter?: EventFilterApiModel;
  /**
   * The events to replace
  */
  events: HistoricEventApiModel[];
}

/**
 * Request node history update
*/
export interface ReplaceEventsDetailsApiModelHistoryUpdateRequestApiModel {
  /**
   * Node to update
  */
  nodeId?: string;
  /**
   * An optional path from NodeId instance to
   * the actual node.
  */
  browsePath?: string[];
  details: ReplaceEventsDetailsApiModel;
  header?: RequestHeaderApiModel;
}

/**
 * History read results
*/
export interface HistoricEventApiModelHistoryReadResponseApiModel {
  /**
   * History as json encoded extension object
  */
  history?: HistoricEventApiModel[];
  /**
   * Continuation token if more results pending.
  */
  continuationToken?: string;
  errorInfo?: ServiceResultApiModel;
}

/**
 * History read continuation result
*/
export interface HistoricEventApiModelHistoryReadNextResponseApiModel {
  /**
   * History as json encoded extension object
  */
  history?: HistoricEventApiModel[];
  /**
   * Continuation token if more results pending.
  */
  continuationToken?: string;
  errorInfo?: ServiceResultApiModel;
}

/**
 * History read results
*/
export interface HistoricValueApiModelHistoryReadResponseApiModel {
  /**
   * History as json encoded extension object
  */
  history?: HistoricValueApiModel[];
  /**
   * Continuation token if more results pending.
  */
  continuationToken?: string;
  errorInfo?: ServiceResultApiModel;
}

/**
 * History read continuation result
*/
export interface HistoricValueApiModelHistoryReadNextResponseApiModel {
  /**
   * History as json encoded extension object
  */
  history?: HistoricValueApiModel[];
  /**
   * Continuation token if more results pending.
  */
  continuationToken?: string;
  errorInfo?: ServiceResultApiModel;
}
