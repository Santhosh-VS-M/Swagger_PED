/* 
 * PED Test API
 *
 * PED Test API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InventoryItem
    /// </summary>
    [DataContract]
        public partial class InventoryItem :  IEquatable<InventoryItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItem" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="releaseDate">releaseDate (required).</param>
        /// <param name="manufacturer">manufacturer (required).</param>
        public InventoryItem(Guid? id = default(Guid?), string name = default(string), DateTime? releaseDate = default(DateTime?), Manufacturer manufacturer = default(Manufacturer))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InventoryItem and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InventoryItem and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "releaseDate" is required (not null)
            if (releaseDate == null)
            {
                throw new InvalidDataException("releaseDate is a required property for InventoryItem and cannot be null");
            }
            else
            {
                this.ReleaseDate = releaseDate;
            }
            // to ensure "manufacturer" is required (not null)
            if (manufacturer == null)
            {
                throw new InvalidDataException("manufacturer is a required property for InventoryItem and cannot be null");
            }
            else
            {
                this.Manufacturer = manufacturer;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseDate
        /// </summary>
        [DataMember(Name="releaseDate", EmitDefaultValue=false)]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InventoryItem);
        }

        /// <summary>
        /// Returns true if InventoryItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReleaseDate == input.ReleaseDate ||
                    (this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(input.ReleaseDate))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReleaseDate != null)
                    hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                return hashCode;
            }
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
