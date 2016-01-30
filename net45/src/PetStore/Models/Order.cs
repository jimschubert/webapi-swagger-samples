using System;
using System.Text;

namespace Petstore.Models
{
    /// <summary>
    /// </summary>
    public class Order : IEquatable<Order>
    {
        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        public long? Id { get; set; }


        /// <summary>
        ///     Gets or Sets PetId
        /// </summary>
        public long? PetId { get; set; }


        /// <summary>
        ///     Gets or Sets Quantity
        /// </summary>
        public int? Quantity { get; set; }


        /// <summary>
        ///     Gets or Sets ShipDate
        /// </summary>
        public DateTime? ShipDate { get; set; }


        /// <summary>
        ///     Order Status
        /// </summary>
        /// <value>Order Status</value>
        public string Status { get; set; }


        /// <summary>
        ///     Gets or Sets Complete
        /// </summary>
        public bool? Complete { get; set; }

        #region Methods 

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(Order other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && PetId == other.PetId && Quantity == other.Quantity &&
                   ShipDate.Equals(other.ShipDate) && string.Equals(Status, other.Status) && Complete == other.Complete;
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PetId: ").Append(PetId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <returns>
        ///     true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">The object to compare with the current object. </param>
        /// <filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Order) obj);
        }

        /// <summary>
        ///     Serves as the default hash function.
        /// </summary>
        /// <returns>
        ///     A hash code for the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode*397) ^ PetId.GetHashCode();
                hashCode = (hashCode*397) ^ Quantity.GetHashCode();
                hashCode = (hashCode*397) ^ ShipDate.GetHashCode();
                hashCode = (hashCode*397) ^ (Status != null ? Status.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Complete.GetHashCode();
                return hashCode;
            }
        }

        #endregion Methods 

        #region Operators 

        public static bool operator ==(Order left, Order right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Order left, Order right)
        {
            return !Equals(left, right);
        }

        #endregion Operators 

    }
}