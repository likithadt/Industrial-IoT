// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.OpcUa.Api.Vault
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OPC UA Vault Service
    /// </summary>
    public partial interface IOpcVault : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Register new application.
        /// </summary>
        /// <remarks>
        /// After registration an application is in the 'New' state and needs
        /// approval by a manager to be avavilable for certificate operation.
        /// Requires Writer role.
        /// </remarks>
        /// <param name='application'>
        /// The new application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationRecordApiModel>> RegisterApplicationWithHttpMessagesAsync(ApplicationRecordApiModel application = default(ApplicationRecordApiModel), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get application.
        /// </summary>
        /// <remarks>
        /// Returns the record of any application.
        /// </remarks>
        /// <param name='applicationId'>
        /// The application id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationRecordApiModel>> GetApplicationWithHttpMessagesAsync(string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update application.
        /// </summary>
        /// <remarks>
        /// Update the application with given application id, however state
        /// information is unchanged.
        /// Requires Writer role.
        /// </remarks>
        /// <param name='applicationId'>
        /// </param>
        /// <param name='application'>
        /// The updated application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationRecordApiModel>> UpdateApplicationWithHttpMessagesAsync(string applicationId, ApplicationRecordApiModel application = default(ApplicationRecordApiModel), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete application.
        /// </summary>
        /// <remarks>
        /// Deletes the application record.
        /// Certificate Requests associated with the application id are set in
        /// the deleted state,
        /// and will be revoked with the next CRL update.
        /// Requires Manager role.
        /// </remarks>
        /// <param name='applicationId'>
        /// The application id
        /// </param>
        /// <param name='force'>
        /// optional, skip sanity checks and force to delete application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteApplicationWithHttpMessagesAsync(string applicationId, bool? force = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Approve or reject a new application.
        /// </summary>
        /// <remarks>
        /// A manager can approve a new application or force an application
        /// from any state.
        /// After approval the application is in the 'Approved' or 'Rejected'
        /// state.
        /// Requires Manager role.
        /// </remarks>
        /// <param name='applicationId'>
        /// The application id
        /// </param>
        /// <param name='approved'>
        /// approve or reject the new application
        /// </param>
        /// <param name='force'>
        /// optional, force application in new state
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationRecordApiModel>> ApproveApplicationWithHttpMessagesAsync(string applicationId, bool approved, bool? force = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unregister application.
        /// </summary>
        /// <remarks>
        /// Unregisters the application record and all associated information.
        /// The application record remains in the database in 'Unregistered'
        /// state.
        /// Certificate Requests associated with the application id are set to
        /// the 'Deleted' state,
        /// and will be revoked with the next CRL update.
        /// Requires Writer role.
        /// </remarks>
        /// <param name='applicationId'>
        /// The application id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> UnregisterApplicationWithHttpMessagesAsync(string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List applications with matching application Uri.
        /// </summary>
        /// <remarks>
        /// List approved applications that match the application Uri.
        /// Application Uris may have duplicates in the application database.
        /// The returned model can contain a next page link if more results are
        /// available.
        /// </remarks>
        /// <param name='applicationUri'>
        /// The application Uri
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<QueryApplicationsResponseApiModel>> ListApplicationsWithHttpMessagesAsync(string applicationUri, string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query applications by id.
        /// </summary>
        /// <remarks>
        /// A query model which supports the OPC UA Global Discovery Server
        /// query.
        /// </remarks>
        /// <param name='query'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<QueryApplicationsByIdResponseApiModel>> QueryApplicationsByIdWithHttpMessagesAsync(QueryApplicationsByIdApiModel query = default(QueryApplicationsByIdApiModel), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query applications.
        /// </summary>
        /// <remarks>
        /// List applications that match the query model.
        /// The returned model can contain a next page link if more results are
        /// available.
        /// </remarks>
        /// <param name='query'>
        /// The Application query parameters
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<QueryApplicationsResponseApiModel>> QueryApplicationsWithHttpMessagesAsync(QueryApplicationsApiModel query = default(QueryApplicationsApiModel), string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Issuer Certificate for Authority Information Access endpoint.
        /// </summary>
        /// <param name='serial'>
        /// </param>
        /// <param name='cert'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> GetIssuerCertWithHttpMessagesAsync(string serial, string cert, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Issuer CRL in CRL Distribution Endpoint.
        /// </summary>
        /// <param name='serial'>
        /// </param>
        /// <param name='crl'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> GetIssuerCrlWithHttpMessagesAsync(string serial, string crl, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Certificate Group Names.
        /// </summary>
        /// <remarks>
        /// Returns a list of supported group names. The names are typically
        /// used as parameter.
        /// The Default group name is 'Default'.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateGroupListApiModel>> GetCertificateGroupsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get group configuration.
        /// </summary>
        /// <remarks>
        /// The group configuration for a group is stored in KeyVault and
        /// contains information
        /// about the CA subject, the lifetime and the security algorithms
        /// used.
        /// </remarks>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateGroupConfigurationApiModel>> GetCertificateGroupConfigurationWithHttpMessagesAsync(string group, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update group configuration.
        /// </summary>
        /// <remarks>
        /// Updates the configuration for a certificate group.
        /// Use this function with care and only if you are aware of the
        /// security implications.
        /// - A change of the subject requires to issue a new CA certificate.
        /// - A change of the lifetime and security parameter of the issuer
        /// certificate takes
        /// effect on the next Issuer CA key generation.
        /// - A change in lifetime for issued certificates takes effect on the
        /// next request approval.
        /// In general, security parameters should not be changed after a
        /// security group is established.
        /// Instead, a new certificate group with new parameters should be
        /// created for all subsequent
        /// operations.
        /// Requires manager role.
        /// </remarks>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='config'>
        /// The group configuration
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateGroupConfigurationApiModel>> UpdateCertificateGroupConfigurationWithHttpMessagesAsync(string group, CertificateGroupConfigurationApiModel config = default(CertificateGroupConfigurationApiModel), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a group configuration.
        /// </summary>
        /// <remarks>
        /// Deletes a group with configuration.
        /// After this operation the Issuer CA, CRLs and keys become
        /// inaccessible.
        /// Use this function with extreme caution.
        /// Requires manager role.
        /// </remarks>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteCertificateGroupWithHttpMessagesAsync(string group, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new group configuration.
        /// </summary>
        /// <remarks>
        /// Creates a new group with configuration.
        /// The security parameters are preset with defaults.
        /// The group should be updated with final settings before the Issuer
        /// CA
        /// certificate is created for the first time.
        /// Requires manager role.
        /// </remarks>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='subject'>
        /// The Issuer CA subject
        /// </param>
        /// <param name='certType'>
        /// The certificate type
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateGroupConfigurationApiModel>> CreateCertificateGroupWithHttpMessagesAsync(string group, string subject, string certType, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all group configurations.
        /// </summary>
        /// <remarks>
        /// The group configurations for all groups are stored in KeyVault and
        /// contain information
        /// about the CA subject, the lifetime and the security algorithms
        /// used.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateGroupConfigurationCollectionApiModel>> GetCertificateGroupsConfigurationWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Issuer CA Certificate versions.
        /// </summary>
        /// <remarks>
        /// Returns all Issuer CA certificate versions.
        /// By default only the thumbprints, subject, lifetime and state are
        /// returned.
        /// </remarks>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='withCertificates'>
        /// Optional, true to include the full certificates
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<X509Certificate2CollectionApiModel>> GetCertificateGroupIssuerCAVersionsWithHttpMessagesAsync(string group, bool? withCertificates = default(bool?), string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Issuer CA Certificate chain.
        /// </summary>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='thumbPrint'>
        /// optional, the thumbrint of the Issuer CA Certificate
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<X509Certificate2CollectionApiModel>> GetCertificateGroupIssuerCAChainWithHttpMessagesAsync(string group, string thumbPrint = default(string), string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Issuer CA CRL chain.
        /// </summary>
        /// <param name='group'>
        /// The group name
        /// </param>
        /// <param name='thumbPrint'>
        /// optional, the thumbrint of the Issuer CA Certificate
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<X509CrlCollectionApiModel>> GetCertificateGroupIssuerCACrlChainWithHttpMessagesAsync(string group, string thumbPrint = default(string), string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get Trust lists.
        /// </summary>
        /// <remarks>
        /// The trust lists contain lists for Issuer and Trusted certificates.
        /// The Issuer and Trusted list can each contain CA certificates with
        /// CRLs,
        /// signed certificates and self signed certificates.
        /// By default the trusted list contains all versions of Issuer CA
        /// certificates
        /// and their latest CRLs.
        /// The issuer list contains certificates and CRLs which might be
        /// needed to
        /// validate chains.
        /// </remarks>
        /// <param name='group'>
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrustListApiModel>> GetCertificateGroupTrustListWithHttpMessagesAsync(string group, string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new Issuer CA Certificate.
        /// </summary>
        /// <param name='group'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<X509Certificate2ApiModel>> CreateCertificateGroupIssuerCACertWithHttpMessagesAsync(string group, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a certificate request with a certificate signing request
        /// (CSR).
        /// </summary>
        /// <remarks>
        /// The request is in the 'New' state after this call.
        /// Requires Writer or Manager role.
        /// </remarks>
        /// <param name='signingRequest'>
        /// The signing request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> CreateSigningRequestWithHttpMessagesAsync(CreateSigningRequestApiModel signingRequest = default(CreateSigningRequestApiModel), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a certificate request with a new key pair.
        /// </summary>
        /// <remarks>
        /// The request is in the 'New' state after this call.
        /// Requires Writer or Manager role.
        /// </remarks>
        /// <param name='newKeyPairRequest'>
        /// The new key pair request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> CreateNewKeyPairRequestWithHttpMessagesAsync(CreateNewKeyPairRequestApiModel newKeyPairRequest = default(CreateNewKeyPairRequestApiModel), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Approve the certificate request.
        /// </summary>
        /// <remarks>
        /// Validates the request with the application database.
        /// - If Approved:
        /// - New Key Pair request: Creates the new key pair
        /// in the requested format, signs the certificate and stores the
        /// private key for later securely in KeyVault.
        /// - Cert Signing Request: Creates and signs the certificate.
        /// Deletes the CSR from the database.
        /// Stores the signed certificate for later use in the Database.
        /// The request is in the 'Approved' or 'Rejected' state after this
        /// call.
        /// Requires Approver role.
        /// Approver needs signing rights in KeyVault.
        /// </remarks>
        /// <param name='requestId'>
        /// The certificate request id
        /// </param>
        /// <param name='rejected'>
        /// if the request is rejected(true) or approved(false)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ApproveCertificateRequestWithHttpMessagesAsync(string requestId, bool rejected, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Accept request and delete the private key.
        /// </summary>
        /// <remarks>
        /// By accepting the request the requester takes ownership of the
        /// certificate
        /// and the private key, if requested. A private key with metadata is
        /// deleted from KeyVault.
        /// The public certificate remains in the database for sharing public
        /// key information
        /// or for later revocation once the application is deleted.
        /// The request is in the 'Accepted' state after this call.
        /// Requires Writer role.
        /// </remarks>
        /// <param name='requestId'>
        /// The certificate request id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> AcceptCertificateRequestWithHttpMessagesAsync(string requestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a specific certificate request.
        /// </summary>
        /// <param name='requestId'>
        /// The certificate request id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateRequestRecordApiModel>> GetCertificateRequestWithHttpMessagesAsync(string requestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete request. Mark the certificate for revocation.
        /// </summary>
        /// <remarks>
        /// If the request is in the 'Approved' or 'Accepted' state,
        /// the request is set in the 'Deleted' state.
        /// A deleted request is marked for revocation.
        /// The public certificate is still available for the revocation
        /// procedure.
        /// If the request is in the 'New' or 'Rejected' state,
        /// the request is set in the 'Removed' state.
        /// The request is in the 'Deleted' or 'Removed'state after this call.
        /// Requires Manager role.
        /// </remarks>
        /// <param name='requestId'>
        /// The certificate request id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteCertificateRequestWithHttpMessagesAsync(string requestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Purge request. Physically delete the request.
        /// </summary>
        /// <remarks>
        /// The request must be in the 'Revoked','Rejected' or 'New' state.
        /// By purging the request it is actually physically deleted from the
        /// database, including the public key and other information.
        /// The request is purged after this call.
        /// Requires Manager role.
        /// </remarks>
        /// <param name='requestId'>
        /// The certificate request id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> PurgeCertificateRequestWithHttpMessagesAsync(string requestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revoke request. Create New CRL version with revoked certificate.
        /// </summary>
        /// <remarks>
        /// The request must be in the 'Deleted' state for revocation.
        /// The certificate issuer CA and CRL are looked up, the certificate
        /// serial number is added and a new CRL version is issued and updated
        /// in the certificate group storage.
        /// Preferably deleted certificates are revoked with the RevokeGroup
        /// call to batch multiple revoked certificates in a single CRL update.
        /// Requires Approver role.
        /// Approver needs signing rights in KeyVault.
        /// </remarks>
        /// <param name='requestId'>
        /// The certificate request id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> RevokeCertificateRequestWithHttpMessagesAsync(string requestId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revoke all deleted certificate requests for a group.
        /// </summary>
        /// <remarks>
        /// Select all requests for a group in the 'Deleted' state are marked
        /// for revocation.
        /// The certificate issuer CA and CRL are looked up, all the
        /// certificate
        /// serial numbers are added and a new CRL version is issued and
        /// updated
        /// in the certificate group storage.
        /// Requires Approver role.
        /// Approver needs signing rights in KeyVault.
        /// </remarks>
        /// <param name='group'>
        /// The certificate group id
        /// </param>
        /// <param name='allVersions'>
        /// optional, if all certs for all CA versions should be revoked.
        /// Default: true
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> RevokeCertificateGroupWithHttpMessagesAsync(string group, bool? allVersions = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query for certificate requests.
        /// </summary>
        /// <remarks>
        /// Get all certificate requests in paged form.
        /// The returned model can contain a link to the next page if more
        /// results are
        /// available.
        /// </remarks>
        /// <param name='appId'>
        /// optional, query for application id
        /// </param>
        /// <param name='requestState'>
        /// optional, query for request state. Possible values include: 'new',
        /// 'approved', 'rejected', 'accepted', 'deleted', 'revoked', 'removed'
        /// </param>
        /// <param name='nextPageLink'>
        /// optional, link to next page
        /// </param>
        /// <param name='pageSize'>
        /// optional, the maximum number of result per page
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CertificateRequestQueryResponseApiModel>> QueryCertificateRequestsWithHttpMessagesAsync(string appId = default(string), string requestState = default(string), string nextPageLink = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Fetch certificate request approval result.
        /// </summary>
        /// <remarks>
        /// Can be called in any state.
        /// Returns only cert request information in 'New', 'Rejected',
        /// 'Deleted' and 'Revoked' state.
        /// Fetches private key in 'Approved' state, if requested.
        /// Fetches the public certificate in 'Approved' and 'Accepted' state.
        /// After a successful fetch in 'Approved' state, the request should be
        /// accepted to delete the private key.
        /// Requires Writer role.
        /// </remarks>
        /// <param name='requestId'>
        /// </param>
        /// <param name='applicationId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<FetchRequestResultApiModel>> FetchCertificateRequestResultWithHttpMessagesAsync(string requestId, string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the status.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<StatusApiModel>> GetStatusWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
