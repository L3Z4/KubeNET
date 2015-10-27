using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.
  /// </summary>
  [DataContract]
  public class V1ObjectMeta {
    
    /// <summary>
    /// Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names
    /// </summary>
    /// <value>Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#names</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.\n\nIf this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry (optionally after the time indicated in the Retry-After header).\n\nApplied only if Name is not specified. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#idempotency
    /// </summary>
    /// <value>GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.\n\nIf this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry (optionally after the time indicated in the Retry-After header).\n\nApplied only if Name is not specified. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#idempotency</value>
    [DataMember(Name="generateName", EmitDefaultValue=false)]
    public string GenerateName { get; set; }

    
    /// <summary>
    /// Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \"default\" namespace, but \"default\" is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.\n\nMust be a DNS_LABEL. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/namespaces.md
    /// </summary>
    /// <value>Namespace defines the space within each name must be unique. An empty namespace is equivalent to the \"default\" namespace, but \"default\" is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.\n\nMust be a DNS_LABEL. Cannot be updated. More info: http://releases.k8s.io/HEAD/docs/user-guide/namespaces.md</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    public string Namespace { get; set; }

    
    /// <summary>
    /// SelfLink is a URL representing this object. Populated by the system. Read-only.
    /// </summary>
    /// <value>SelfLink is a URL representing this object. Populated by the system. Read-only.</value>
    [DataMember(Name="selfLink", EmitDefaultValue=false)]
    public string SelfLink { get; set; }

    
    /// <summary>
    /// UID is the unique in time and space value for this object. It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.\n\nPopulated by the system. Read-only. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#uids
    /// </summary>
    /// <value>UID is the unique in time and space value for this object. It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.\n\nPopulated by the system. Read-only. More info: http://releases.k8s.io/HEAD/docs/user-guide/identifiers.md#uids</value>
    [DataMember(Name="uid", EmitDefaultValue=false)]
    public string Uid { get; set; }

    
    /// <summary>
    /// An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.\n\nPopulated by the system. Read-only. Value must be treated as opaque by clients and . More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    /// <value>An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.\n\nPopulated by the system. Read-only. Value must be treated as opaque by clients and . More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#concurrency-control-and-consistency</value>
    [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
    public string ResourceVersion { get; set; }

    
    /// <summary>
    /// A sequence number representing a specific generation of the desired state. Currently only implemented by replication controllers. Populated by the system. Read-only.
    /// </summary>
    /// <value>A sequence number representing a specific generation of the desired state. Currently only implemented by replication controllers. Populated by the system. Read-only.</value>
    [DataMember(Name="generation", EmitDefaultValue=false)]
    public int? Generation { get; set; }

    
    /// <summary>
    /// CreationTimestamp is a timestamp representing the server time when this object was created. It is not guaranteed to be set in happens-before order across separate operations. Clients may not set this value. It is represented in RFC3339 form and is in UTC.\n\nPopulated by the system. Read-only. Null for lists. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
    /// </summary>
    /// <value>CreationTimestamp is a timestamp representing the server time when this object was created. It is not guaranteed to be set in happens-before order across separate operations. Clients may not set this value. It is represented in RFC3339 form and is in UTC.\n\nPopulated by the system. Read-only. Null for lists. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</value>
    [DataMember(Name="creationTimestamp", EmitDefaultValue=false)]
    public string CreationTimestamp { get; set; }

    
    /// <summary>
    /// DeletionTimestamp is RFC 3339 date and time at which this resource will be deleted. This field is set by the server when a graceful deletion is requested by the user, and is not directly settable by a client. The resource will be deleted (no longer visible from resource lists, and not reachable by name) after the time in this field. Once set, this value may not be unset or be set further into the future, although it may be shortened or the resource may be deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet will react by sending a graceful termination signal to the containers in the pod. Once the resource is deleted in the API, the Kubelet will send a hard termination signal to the container. If not set, graceful deletion of the object has not been requested.\n\nPopulated by the system when a graceful deletion is requested. Read-only. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
    /// </summary>
    /// <value>DeletionTimestamp is RFC 3339 date and time at which this resource will be deleted. This field is set by the server when a graceful deletion is requested by the user, and is not directly settable by a client. The resource will be deleted (no longer visible from resource lists, and not reachable by name) after the time in this field. Once set, this value may not be unset or be set further into the future, although it may be shortened or the resource may be deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet will react by sending a graceful termination signal to the containers in the pod. Once the resource is deleted in the API, the Kubelet will send a hard termination signal to the container. If not set, graceful deletion of the object has not been requested.\n\nPopulated by the system when a graceful deletion is requested. Read-only. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</value>
    [DataMember(Name="deletionTimestamp", EmitDefaultValue=false)]
    public string DeletionTimestamp { get; set; }

    
    /// <summary>
    /// Number of seconds allowed for this object to gracefully terminate before it will be removed from the system. Only set when deletionTimestamp is also set. May only be shortened. Read-only.
    /// </summary>
    /// <value>Number of seconds allowed for this object to gracefully terminate before it will be removed from the system. Only set when deletionTimestamp is also set. May only be shortened. Read-only.</value>
    [DataMember(Name="deletionGracePeriodSeconds", EmitDefaultValue=false)]
    public int? DeletionGracePeriodSeconds { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1ObjectMeta {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  GenerateName: ").Append(GenerateName).Append("\n");
      
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
      
      sb.Append("  SelfLink: ").Append(SelfLink).Append("\n");
      
      sb.Append("  Uid: ").Append(Uid).Append("\n");
      
      sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
      
      sb.Append("  Generation: ").Append(Generation).Append("\n");
      
      sb.Append("  CreationTimestamp: ").Append(CreationTimestamp).Append("\n");
      
      sb.Append("  DeletionTimestamp: ").Append(DeletionTimestamp).Append("\n");
      
      sb.Append("  DeletionGracePeriodSeconds: ").Append(DeletionGracePeriodSeconds).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
