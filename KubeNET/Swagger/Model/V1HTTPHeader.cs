using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// HTTPHeader describes a custom header to be used in HTTP probes
  /// </summary>
  [DataContract]
  public class V1HTTPHeader {
    
    /// <summary>
    /// The header field name
    /// </summary>
    /// <value>The header field name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// The header field value
    /// </summary>
    /// <value>The header field value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public string Value { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1HTTPHeader {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
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
