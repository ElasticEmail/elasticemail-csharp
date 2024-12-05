/*
 * Elastic Email REST API
 *
 * This API is based on the REST API architecture, allowing the user to easily manage their data with this resource-based approach.    Every API call is established on which specific request type (GET, POST, PUT, DELETE) will be used.    The API has a limit of 20 concurrent connections and a hard timeout of 600 seconds per request.    To start using this API, you will need your Access Token (available <a target=\"_blank\" href=\"https://app.elasticemail.com/marketing/settings/new/manage-api\">here</a>). Remember to keep it safe. Required access levels are listed in the given request’s description.    Downloadable library clients can be found in our Github repository <a target=\"_blank\" href=\"https://github.com/ElasticEmail?tab=repositories&q=%22rest+api%22+in%3Areadme\">here</a>
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: support@elasticemail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ElasticEmail.Client.OpenAPIDateConverter;

namespace ElasticEmail.Model
{
    /// <summary>
    /// Simple verification file result info
    /// </summary>
    [DataContract(Name = "VerificationFileResult")]
    public partial class VerificationFileResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VerificationStatus
        /// </summary>
        [DataMember(Name = "VerificationStatus", EmitDefaultValue = false)]
        public VerificationStatus? VerificationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationFileResult" /> class.
        /// </summary>
        /// <param name="verificationID">Identifier of this verification result.</param>
        /// <param name="filename">Origin file name.</param>
        /// <param name="verificationStatus">verificationStatus.</param>
        /// <param name="fileUploadResult">fileUploadResult.</param>
        /// <param name="dateAdded">Date of creation in YYYY-MM-DDThh:ii:ss format.</param>
        /// <param name="source">Origin file extension.</param>
        public VerificationFileResult(string verificationID = default(string), string filename = default(string), VerificationStatus? verificationStatus = default(VerificationStatus?), FileUploadResult fileUploadResult = default(FileUploadResult), DateTime dateAdded = default(DateTime), string source = default(string))
        {
            this.VerificationID = verificationID;
            this.Filename = filename;
            this.VerificationStatus = verificationStatus;
            this.FileUploadResult = fileUploadResult;
            this.DateAdded = dateAdded;
            this.Source = source;
        }

        /// <summary>
        /// Identifier of this verification result
        /// </summary>
        /// <value>Identifier of this verification result</value>
        [DataMember(Name = "VerificationID", EmitDefaultValue = false)]
        public string VerificationID { get; set; }

        /// <summary>
        /// Origin file name
        /// </summary>
        /// <value>Origin file name</value>
        [DataMember(Name = "Filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets FileUploadResult
        /// </summary>
        [DataMember(Name = "FileUploadResult", EmitDefaultValue = false)]
        public FileUploadResult FileUploadResult { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        /// <value>Date of creation in YYYY-MM-DDThh:ii:ss format</value>
        [DataMember(Name = "DateAdded", EmitDefaultValue = false)]
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Origin file extension
        /// </summary>
        /// <value>Origin file extension</value>
        [DataMember(Name = "Source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationFileResult {\n");
            sb.Append("  VerificationID: ").Append(VerificationID).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
            sb.Append("  FileUploadResult: ").Append(FileUploadResult).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
