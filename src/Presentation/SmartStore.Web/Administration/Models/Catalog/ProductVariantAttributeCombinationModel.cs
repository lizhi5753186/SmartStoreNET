﻿using System.Collections.Generic;
using SmartStore.Core.Domain.Catalog;
using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SmartStore.Admin.Models.Catalog
{
    public class ProductVariantAttributeCombinationModel : EntityModelBase
    {
        public ProductVariantAttributeCombinationModel()
        {
            ProductVariantAttributes = new List<ProductVariantAttributeModel>();
            AssignedPictureIds = new int[] { }; // init as empty array
            AssignablePictures = new List<PictureSelectItemModel>();
			AvailableDeliveryTimes = new List<SelectListItem>();
            Warnings = new List<string>();
        }
        
        [SmartResourceDisplayName("Admin.Catalog.Products.Variants.ProductVariantAttributes.AttributeCombinations.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [SmartResourceDisplayName("Admin.Catalog.Products.Variants.ProductVariantAttributes.AttributeCombinations.Fields.AllowOutOfStockOrders")]
        public bool AllowOutOfStockOrders { get; set; }

        // codehint: sm-add

        [SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.Sku")]
		public string Sku { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.Gtin")]
		public string Gtin { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.ManufacturerPartNumber")]
		public string ManufacturerPartNumber { get; set; }

        [SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.DeliveryTime")]
        public int? DeliveryTimeId { get; set; }

		public IList<SelectListItem> AvailableDeliveryTimes { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.ProductVariantAttributes.AttributeCombinations.Fields.Pictures")]
        public int[] AssignedPictureIds { get; set; }

        public IList<PictureSelectItemModel> AssignablePictures { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.Length")]
        public decimal? Length { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.Width")]
        public decimal? Width { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.Height")]
        public decimal? Height { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.MUAmount")]
        public decimal? BasePriceAmount { get; set; }

		[SmartResourceDisplayName("Admin.Catalog.Products.Variants.Fields.MUBase")]
        public int? BasePriceBaseAmount { get; set; }

		[SmartResourceDisplayName("Common.IsActive")]
		public bool IsActive { get; set; }

        //[SmartResourceDisplayName("Admin.Catalog.Products.Variants.ProductVariantAttributes.AttributeCombinations.Fields.IsDefaultCombination")]
		//public bool IsDefaultCombination { get; set; }
		

        public IList<ProductVariantAttributeModel> ProductVariantAttributes { get; set; }

        [SmartResourceDisplayName("Admin.Catalog.Products.Variants.ProductVariantAttributes.AttributeCombinations.Fields.Attributes")]
        [AllowHtml]
        public string AttributesXml { get; set; }

		[SmartResourceDisplayName("Common.Product")]
		public string ProductUrl { get; set; }
		public string ProductUrlTitle { get; set; }

        [AllowHtml]
        public IList<string> Warnings { get; set; }

        public int ProductVariantId { get; set; }

        #region Nested classes

        // codehint: sm-add
        public class PictureSelectItemModel : EntityModelBase
        {
            public string PictureUrl { get; set; }
            public bool IsAssigned { get; set; }
        }

        public class ProductVariantAttributeModel : EntityModelBase
        {
            public ProductVariantAttributeModel()
            {
                Values = new List<ProductVariantAttributeValueModel>();
            }

            public int ProductAttributeId { get; set; }

            public string Name { get; set; }

            public string TextPrompt { get; set; }

            public bool IsRequired { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<ProductVariantAttributeValueModel> Values { get; set; }
        }

        public class ProductVariantAttributeValueModel : EntityModelBase
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }
        #endregion
    }
}