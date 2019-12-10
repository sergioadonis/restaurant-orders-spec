/*
 * Restaurant Orders
 *
 * Simple API to manage restaurant orders
 *
 * OpenAPI spec version: v1
 * Contact: sergio.adonis@outlook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RestaurantObjectResultDataRestaurant : IEquatable<RestaurantObjectResultDataRestaurant>
    { 
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category")]
        public CommonProps Category { get; set; }

        /// <summary>
        /// Gets or Sets Menus
        /// </summary>
        [DataMember(Name="menus")]
        public List<CommonProps> Menus { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products")]
        public List<CommonProps> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantObjectResultDataRestaurant {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Menus: ").Append(Menus).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RestaurantObjectResultDataRestaurant)obj);
        }

        /// <summary>
        /// Returns true if RestaurantObjectResultDataRestaurant instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantObjectResultDataRestaurant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantObjectResultDataRestaurant other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
                ) && 
                (
                    Menus == other.Menus ||
                    Menus != null &&
                    Menus.SequenceEqual(other.Menus)
                ) && 
                (
                    Products == other.Products ||
                    Products != null &&
                    Products.SequenceEqual(other.Products)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Menus != null)
                    hashCode = hashCode * 59 + Menus.GetHashCode();
                    if (Products != null)
                    hashCode = hashCode * 59 + Products.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RestaurantObjectResultDataRestaurant left, RestaurantObjectResultDataRestaurant right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RestaurantObjectResultDataRestaurant left, RestaurantObjectResultDataRestaurant right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}