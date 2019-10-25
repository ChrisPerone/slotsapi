using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Amazon.DynamoDBv2.DataModel;

namespace SlotsApi.Models
{
    [DynamoDBTable("SlotModels")]
    public class SlotModel
    {
        [DynamoDBHashKey]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}