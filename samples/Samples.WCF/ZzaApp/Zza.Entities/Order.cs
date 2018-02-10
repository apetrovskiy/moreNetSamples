namespace Zza.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Guid CustomerId { get; set; }
        [DataMember]
        public int OrderStatusId { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public decimal ItemsTotal { get; set; }
        [DataMember]
        public List<OrderItem> OrderItems { get; set; }
    }
}