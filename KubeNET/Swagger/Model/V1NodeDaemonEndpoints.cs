using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// NodeDaemonEndpoints lists ports opened by daemons running on the Node.
  /// </summary>
  [DataContract]
  public class V1NodeDaemonEndpoints {
    
    /// <summary>
    /// Endpoint on which Kubelet is listening.
    /// </summary>
    /// <value>Endpoint on which Kubelet is listening.</value>
    [DataMember(Name="kubeletEndpoint", EmitDefaultValue=false)]
    public V1DaemonEndpoint KubeletEndpoint { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1NodeDaemonEndpoints {\n");
      
      sb.Append("  KubeletEndpoint: ").Append(KubeletEndpoint).Append("\n");
      
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
