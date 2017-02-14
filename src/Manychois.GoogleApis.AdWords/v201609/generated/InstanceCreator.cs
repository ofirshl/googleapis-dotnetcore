using System;
using System.Xml.Linq;

namespace Manychois.GoogleApis.AdWords.v201609
{
	internal static class InstanceCreator
	{
		public static Ad CreateAd(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "CallOnlyAd")
			{
				return new CallOnlyAd();
			}
			else if (type == "DeprecatedAd")
			{
				return new DeprecatedAd();
			}
			else if (type == "DynamicSearchAd")
			{
				return new DynamicSearchAd();
			}
			else if (type == "ExpandedTextAd")
			{
				return new ExpandedTextAd();
			}
			else if (type == "ImageAd")
			{
				return new ImageAd();
			}
			else if (type == "ProductAd")
			{
				return new ProductAd();
			}
			else if (type == "ResponsiveDisplayAd")
			{
				return new ResponsiveDisplayAd();
			}
			else if (type == "TemplateAd")
			{
				return new TemplateAd();
			}
			else if (type == "TextAd")
			{
				return new TextAd();
			}
			else if (type == "ThirdPartyRedirectAd")
			{
				return new ThirdPartyRedirectAd();
			}
			else
			{
				return new Ad();
			}
		}
		public static AdGroupCriterion CreateAdGroupCriterion(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "BiddableAdGroupCriterion")
			{
				return new BiddableAdGroupCriterion();
			}
			else if (type == "NegativeAdGroupCriterion")
			{
				return new NegativeAdGroupCriterion();
			}
			else
			{
				return new AdGroupCriterion();
			}
		}
		public static AdUnionId CreateAdUnionId(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "TempAdUnionId")
			{
				return new TempAdUnionId();
			}
			else
			{
				return new AdUnionId();
			}
		}
		public static ApiError CreateApiError(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdCustomizerError")
			{
				return new AdCustomizerError();
			}
			else if (type == "AdCustomizerFeedError")
			{
				return new AdCustomizerFeedError();
			}
			else if (type == "AdError")
			{
				return new AdError();
			}
			else if (type == "AdGroupAdError")
			{
				return new AdGroupAdError();
			}
			else if (type == "AdGroupCriterionError")
			{
				return new AdGroupCriterionError();
			}
			else if (type == "AdGroupFeedError")
			{
				return new AdGroupFeedError();
			}
			else if (type == "AdGroupServiceError")
			{
				return new AdGroupServiceError();
			}
			else if (type == "AdParamError")
			{
				return new AdParamError();
			}
			else if (type == "AdxError")
			{
				return new AdxError();
			}
			else if (type == "AppPostbackUrlError")
			{
				return new AppPostbackUrlError();
			}
			else if (type == "AudioError")
			{
				return new AudioError();
			}
			else if (type == "AuthenticationError")
			{
				return new AuthenticationError();
			}
			else if (type == "AuthorizationError")
			{
				return new AuthorizationError();
			}
			else if (type == "BatchJobError")
			{
				return new BatchJobError();
			}
			else if (type == "BatchJobProcessingError")
			{
				return new BatchJobProcessingError();
			}
			else if (type == "BiddingErrors")
			{
				return new BiddingErrors();
			}
			else if (type == "BiddingStrategyError")
			{
				return new BiddingStrategyError();
			}
			else if (type == "BudgetError")
			{
				return new BudgetError();
			}
			else if (type == "BudgetOrderError")
			{
				return new BudgetOrderError();
			}
			else if (type == "CampaignCriterionError")
			{
				return new CampaignCriterionError();
			}
			else if (type == "CampaignError")
			{
				return new CampaignError();
			}
			else if (type == "CampaignFeedError")
			{
				return new CampaignFeedError();
			}
			else if (type == "CampaignPreferenceError")
			{
				return new CampaignPreferenceError();
			}
			else if (type == "CampaignSharedSetError")
			{
				return new CampaignSharedSetError();
			}
			else if (type == "ClientTermsError")
			{
				return new ClientTermsError();
			}
			else if (type == "CollectionSizeError")
			{
				return new CollectionSizeError();
			}
			else if (type == "ConversionTrackingError")
			{
				return new ConversionTrackingError();
			}
			else if (type == "CriterionError")
			{
				return new CriterionError();
			}
			else if (type == "CurrencyCodeError")
			{
				return new CurrencyCodeError();
			}
			else if (type == "CustomerError")
			{
				return new CustomerError();
			}
			else if (type == "CustomerFeedError")
			{
				return new CustomerFeedError();
			}
			else if (type == "CustomerOrderLineError")
			{
				return new CustomerOrderLineError();
			}
			else if (type == "CustomerSyncError")
			{
				return new CustomerSyncError();
			}
			else if (type == "DatabaseError")
			{
				return new DatabaseError();
			}
			else if (type == "DataError")
			{
				return new DataError();
			}
			else if (type == "DateError")
			{
				return new DateError();
			}
			else if (type == "DateRangeError")
			{
				return new DateRangeError();
			}
			else if (type == "DistinctError")
			{
				return new DistinctError();
			}
			else if (type == "DraftError")
			{
				return new DraftError();
			}
			else if (type == "EntityAccessDenied")
			{
				return new EntityAccessDenied();
			}
			else if (type == "EntityCountLimitExceeded")
			{
				return new EntityCountLimitExceeded();
			}
			else if (type == "EntityNotFound")
			{
				return new EntityNotFound();
			}
			else if (type == "ExtensionSettingError")
			{
				return new ExtensionSettingError();
			}
			else if (type == "FeedAttributeReferenceError")
			{
				return new FeedAttributeReferenceError();
			}
			else if (type == "FeedError")
			{
				return new FeedError();
			}
			else if (type == "FeedItemError")
			{
				return new FeedItemError();
			}
			else if (type == "FeedMappingError")
			{
				return new FeedMappingError();
			}
			else if (type == "ForwardCompatibilityError")
			{
				return new ForwardCompatibilityError();
			}
			else if (type == "FunctionError")
			{
				return new FunctionError();
			}
			else if (type == "FunctionParsingError")
			{
				return new FunctionParsingError();
			}
			else if (type == "IdError")
			{
				return new IdError();
			}
			else if (type == "ImageError")
			{
				return new ImageError();
			}
			else if (type == "InternalApiError")
			{
				return new InternalApiError();
			}
			else if (type == "LabelError")
			{
				return new LabelError();
			}
			else if (type == "LabelServiceError")
			{
				return new LabelServiceError();
			}
			else if (type == "ListError")
			{
				return new ListError();
			}
			else if (type == "LocationCriterionServiceError")
			{
				return new LocationCriterionServiceError();
			}
			else if (type == "ManagedCustomerServiceError")
			{
				return new ManagedCustomerServiceError();
			}
			else if (type == "MediaBundleError")
			{
				return new MediaBundleError();
			}
			else if (type == "MediaError")
			{
				return new MediaError();
			}
			else if (type == "MultiplierError")
			{
				return new MultiplierError();
			}
			else if (type == "MutateMembersError")
			{
				return new MutateMembersError();
			}
			else if (type == "NewEntityCreationError")
			{
				return new NewEntityCreationError();
			}
			else if (type == "NotEmptyError")
			{
				return new NotEmptyError();
			}
			else if (type == "NotWhitelistedError")
			{
				return new NotWhitelistedError();
			}
			else if (type == "NullError")
			{
				return new NullError();
			}
			else if (type == "OfflineCallConversionError")
			{
				return new OfflineCallConversionError();
			}
			else if (type == "OfflineConversionError")
			{
				return new OfflineConversionError();
			}
			else if (type == "OperationAccessDenied")
			{
				return new OperationAccessDenied();
			}
			else if (type == "OperatorError")
			{
				return new OperatorError();
			}
			else if (type == "PagingError")
			{
				return new PagingError();
			}
			else if (type == "PolicyViolationError")
			{
				return new PolicyViolationError();
			}
			else if (type == "QueryError")
			{
				return new QueryError();
			}
			else if (type == "QuotaCheckError")
			{
				return new QuotaCheckError();
			}
			else if (type == "RangeError")
			{
				return new RangeError();
			}
			else if (type == "RateExceededError")
			{
				return new RateExceededError();
			}
			else if (type == "ReadOnlyError")
			{
				return new ReadOnlyError();
			}
			else if (type == "RegionCodeError")
			{
				return new RegionCodeError();
			}
			else if (type == "RejectedError")
			{
				return new RejectedError();
			}
			else if (type == "ReportDefinitionError")
			{
				return new ReportDefinitionError();
			}
			else if (type == "RequestError")
			{
				return new RequestError();
			}
			else if (type == "RequiredError")
			{
				return new RequiredError();
			}
			else if (type == "SelectorError")
			{
				return new SelectorError();
			}
			else if (type == "SettingError")
			{
				return new SettingError();
			}
			else if (type == "SharedCriterionError")
			{
				return new SharedCriterionError();
			}
			else if (type == "SharedSetError")
			{
				return new SharedSetError();
			}
			else if (type == "SizeLimitError")
			{
				return new SizeLimitError();
			}
			else if (type == "StatsQueryError")
			{
				return new StatsQueryError();
			}
			else if (type == "StringFormatError")
			{
				return new StringFormatError();
			}
			else if (type == "StringLengthError")
			{
				return new StringLengthError();
			}
			else if (type == "TargetingIdeaError")
			{
				return new TargetingIdeaError();
			}
			else if (type == "TrafficEstimatorError")
			{
				return new TrafficEstimatorError();
			}
			else if (type == "TrialError")
			{
				return new TrialError();
			}
			else if (type == "UrlError")
			{
				return new UrlError();
			}
			else if (type == "UserListError")
			{
				return new UserListError();
			}
			else if (type == "VideoError")
			{
				return new VideoError();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static ApplicationException CreateApplicationException(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "ApiException")
			{
				return new ApiException();
			}
			else
			{
				return new ApplicationException();
			}
		}
		public static Attribute CreateAttribute(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "BooleanAttribute")
			{
				return new BooleanAttribute();
			}
			else if (type == "CriterionAttribute")
			{
				return new CriterionAttribute();
			}
			else if (type == "DoubleAttribute")
			{
				return new DoubleAttribute();
			}
			else if (type == "IdeaTypeAttribute")
			{
				return new IdeaTypeAttribute();
			}
			else if (type == "IntegerAttribute")
			{
				return new IntegerAttribute();
			}
			else if (type == "IntegerSetAttribute")
			{
				return new IntegerSetAttribute();
			}
			else if (type == "KeywordAttribute")
			{
				return new KeywordAttribute();
			}
			else if (type == "LongAttribute")
			{
				return new LongAttribute();
			}
			else if (type == "LongRangeAttribute")
			{
				return new LongRangeAttribute();
			}
			else if (type == "MoneyAttribute")
			{
				return new MoneyAttribute();
			}
			else if (type == "MonthlySearchVolumeAttribute")
			{
				return new MonthlySearchVolumeAttribute();
			}
			else if (type == "StringAttribute")
			{
				return new StringAttribute();
			}
			else if (type == "WebpageDescriptorAttribute")
			{
				return new WebpageDescriptorAttribute();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static BiddingScheme CreateBiddingScheme(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "BudgetOptimizerBiddingScheme")
			{
				return new BudgetOptimizerBiddingScheme();
			}
			else if (type == "ConversionOptimizerBiddingScheme")
			{
				return new ConversionOptimizerBiddingScheme();
			}
			else if (type == "EnhancedCpcBiddingScheme")
			{
				return new EnhancedCpcBiddingScheme();
			}
			else if (type == "ManualCpcBiddingScheme")
			{
				return new ManualCpcBiddingScheme();
			}
			else if (type == "ManualCpmBiddingScheme")
			{
				return new ManualCpmBiddingScheme();
			}
			else if (type == "PageOnePromotedBiddingScheme")
			{
				return new PageOnePromotedBiddingScheme();
			}
			else if (type == "TargetCpaBiddingScheme")
			{
				return new TargetCpaBiddingScheme();
			}
			else if (type == "TargetOutrankShareBiddingScheme")
			{
				return new TargetOutrankShareBiddingScheme();
			}
			else if (type == "TargetRoasBiddingScheme")
			{
				return new TargetRoasBiddingScheme();
			}
			else if (type == "TargetSpendBiddingScheme")
			{
				return new TargetSpendBiddingScheme();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static BidLandscape CreateBidLandscape(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdGroupBidLandscape")
			{
				return new AdGroupBidLandscape();
			}
			else if (type == "CriterionBidLandscape")
			{
				return new CriterionBidLandscape();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Bids CreateBids(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "CpaBid")
			{
				return new CpaBid();
			}
			else if (type == "CpcBid")
			{
				return new CpcBid();
			}
			else if (type == "CpmBid")
			{
				return new CpmBid();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static CampaignCriterion CreateCampaignCriterion(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "NegativeCampaignCriterion")
			{
				return new NegativeCampaignCriterion();
			}
			else
			{
				return new CampaignCriterion();
			}
		}
		public static ComparableValue CreateComparableValue(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "DoubleValue")
			{
				return new DoubleValue();
			}
			else if (type == "LongValue")
			{
				return new LongValue();
			}
			else if (type == "Money")
			{
				return new Money();
			}
			else if (type == "MoneyWithCurrency")
			{
				return new MoneyWithCurrency();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static ConstantData CreateConstantData(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "ProductBiddingCategoryData")
			{
				return new ProductBiddingCategoryData();
			}
			else
			{
				return new ConstantData();
			}
		}
		public static ConversionTracker CreateConversionTracker(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdCallMetricsConversion")
			{
				return new AdCallMetricsConversion();
			}
			else if (type == "AdWordsConversionTracker")
			{
				return new AdWordsConversionTracker();
			}
			else if (type == "AppConversion")
			{
				return new AppConversion();
			}
			else if (type == "UploadCallConversion")
			{
				return new UploadCallConversion();
			}
			else if (type == "UploadConversion")
			{
				return new UploadConversion();
			}
			else if (type == "WebsiteCallMetricsConversion")
			{
				return new WebsiteCallMetricsConversion();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Criterion CreateCriterion(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdSchedule")
			{
				return new AdSchedule();
			}
			else if (type == "AgeRange")
			{
				return new AgeRange();
			}
			else if (type == "AppPaymentModel")
			{
				return new AppPaymentModel();
			}
			else if (type == "Carrier")
			{
				return new Carrier();
			}
			else if (type == "ContentLabel")
			{
				return new ContentLabel();
			}
			else if (type == "CriterionUserInterest")
			{
				return new CriterionUserInterest();
			}
			else if (type == "CriterionUserList")
			{
				return new CriterionUserList();
			}
			else if (type == "Gender")
			{
				return new Gender();
			}
			else if (type == "IpBlock")
			{
				return new IpBlock();
			}
			else if (type == "Keyword")
			{
				return new Keyword();
			}
			else if (type == "Language")
			{
				return new Language();
			}
			else if (type == "Location")
			{
				return new Location();
			}
			else if (type == "LocationGroups")
			{
				return new LocationGroups();
			}
			else if (type == "MobileAppCategory")
			{
				return new MobileAppCategory();
			}
			else if (type == "MobileApplication")
			{
				return new MobileApplication();
			}
			else if (type == "MobileDevice")
			{
				return new MobileDevice();
			}
			else if (type == "OperatingSystemVersion")
			{
				return new OperatingSystemVersion();
			}
			else if (type == "Parent")
			{
				return new Parent();
			}
			else if (type == "Placement")
			{
				return new Placement();
			}
			else if (type == "Platform")
			{
				return new Platform();
			}
			else if (type == "PreferredContent")
			{
				return new PreferredContent();
			}
			else if (type == "ProductPartition")
			{
				return new ProductPartition();
			}
			else if (type == "ProductScope")
			{
				return new ProductScope();
			}
			else if (type == "Proximity")
			{
				return new Proximity();
			}
			else if (type == "Vertical")
			{
				return new Vertical();
			}
			else if (type == "Webpage")
			{
				return new Webpage();
			}
			else if (type == "YouTubeChannel")
			{
				return new YouTubeChannel();
			}
			else if (type == "YouTubeVideo")
			{
				return new YouTubeVideo();
			}
			else
			{
				return new Criterion();
			}
		}
		public static CriterionParameter CreateCriterionParameter(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "WebpageParameter")
			{
				return new WebpageParameter();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static DataEntry CreateDataEntry(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdGroupBidLandscape")
			{
				return new AdGroupBidLandscape();
			}
			else if (type == "CriterionBidLandscape")
			{
				return new CriterionBidLandscape();
			}
			else if (type == "DomainCategory")
			{
				return new DomainCategory();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static DimensionProperties CreateDimensionProperties(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "DomainCategory")
			{
				return new DomainCategory();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Estimate CreateEstimate(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdGroupEstimate")
			{
				return new AdGroupEstimate();
			}
			else if (type == "CampaignEstimate")
			{
				return new CampaignEstimate();
			}
			else if (type == "KeywordEstimate")
			{
				return new KeywordEstimate();
			}
			else
			{
				return new Estimate();
			}
		}
		public static EstimateRequest CreateEstimateRequest(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdGroupEstimateRequest")
			{
				return new AdGroupEstimateRequest();
			}
			else if (type == "CampaignEstimateRequest")
			{
				return new CampaignEstimateRequest();
			}
			else if (type == "KeywordEstimateRequest")
			{
				return new KeywordEstimateRequest();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static ExtensionFeedItem CreateExtensionFeedItem(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AppFeedItem")
			{
				return new AppFeedItem();
			}
			else if (type == "CallFeedItem")
			{
				return new CallFeedItem();
			}
			else if (type == "CalloutFeedItem")
			{
				return new CalloutFeedItem();
			}
			else if (type == "PriceFeedItem")
			{
				return new PriceFeedItem();
			}
			else if (type == "ReviewFeedItem")
			{
				return new ReviewFeedItem();
			}
			else if (type == "SitelinkFeedItem")
			{
				return new SitelinkFeedItem();
			}
			else if (type == "StructuredSnippetFeedItem")
			{
				return new StructuredSnippetFeedItem();
			}
			else
			{
				return new ExtensionFeedItem();
			}
		}
		public static FunctionArgumentOperand CreateFunctionArgumentOperand(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "ConstantOperand")
			{
				return new ConstantOperand();
			}
			else if (type == "FeedAttributeOperand")
			{
				return new FeedAttributeOperand();
			}
			else if (type == "FunctionOperand")
			{
				return new FunctionOperand();
			}
			else if (type == "GeoTargetOperand")
			{
				return new GeoTargetOperand();
			}
			else if (type == "IncomeOperand")
			{
				return new IncomeOperand();
			}
			else if (type == "LocationExtensionOperand")
			{
				return new LocationExtensionOperand();
			}
			else if (type == "PlacesOfInterestOperand")
			{
				return new PlacesOfInterestOperand();
			}
			else if (type == "RequestContextOperand")
			{
				return new RequestContextOperand();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Label CreateLabel(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "TextLabel")
			{
				return new TextLabel();
			}
			else
			{
				return new Label();
			}
		}
		public static LabelAttribute CreateLabelAttribute(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "DisplayAttribute")
			{
				return new DisplayAttribute();
			}
			else
			{
				return new LabelAttribute();
			}
		}
		public static ListReturnValue CreateListReturnValue(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdCustomizerFeedReturnValue")
			{
				return new AdCustomizerFeedReturnValue();
			}
			else if (type == "AdGroupAdLabelReturnValue")
			{
				return new AdGroupAdLabelReturnValue();
			}
			else if (type == "AdGroupAdReturnValue")
			{
				return new AdGroupAdReturnValue();
			}
			else if (type == "AdGroupBidModifierReturnValue")
			{
				return new AdGroupBidModifierReturnValue();
			}
			else if (type == "AdGroupCriterionLabelReturnValue")
			{
				return new AdGroupCriterionLabelReturnValue();
			}
			else if (type == "AdGroupCriterionReturnValue")
			{
				return new AdGroupCriterionReturnValue();
			}
			else if (type == "AdGroupExtensionSettingReturnValue")
			{
				return new AdGroupExtensionSettingReturnValue();
			}
			else if (type == "AdGroupFeedReturnValue")
			{
				return new AdGroupFeedReturnValue();
			}
			else if (type == "AdGroupLabelReturnValue")
			{
				return new AdGroupLabelReturnValue();
			}
			else if (type == "AdGroupReturnValue")
			{
				return new AdGroupReturnValue();
			}
			else if (type == "BatchJobReturnValue")
			{
				return new BatchJobReturnValue();
			}
			else if (type == "BiddingStrategyReturnValue")
			{
				return new BiddingStrategyReturnValue();
			}
			else if (type == "BudgetOrderReturnValue")
			{
				return new BudgetOrderReturnValue();
			}
			else if (type == "BudgetReturnValue")
			{
				return new BudgetReturnValue();
			}
			else if (type == "CampaignCriterionReturnValue")
			{
				return new CampaignCriterionReturnValue();
			}
			else if (type == "CampaignExtensionSettingReturnValue")
			{
				return new CampaignExtensionSettingReturnValue();
			}
			else if (type == "CampaignFeedReturnValue")
			{
				return new CampaignFeedReturnValue();
			}
			else if (type == "CampaignLabelReturnValue")
			{
				return new CampaignLabelReturnValue();
			}
			else if (type == "CampaignReturnValue")
			{
				return new CampaignReturnValue();
			}
			else if (type == "CampaignSharedSetReturnValue")
			{
				return new CampaignSharedSetReturnValue();
			}
			else if (type == "ConversionTrackerReturnValue")
			{
				return new ConversionTrackerReturnValue();
			}
			else if (type == "CustomerExtensionSettingReturnValue")
			{
				return new CustomerExtensionSettingReturnValue();
			}
			else if (type == "CustomerFeedReturnValue")
			{
				return new CustomerFeedReturnValue();
			}
			else if (type == "DraftReturnValue")
			{
				return new DraftReturnValue();
			}
			else if (type == "FeedItemReturnValue")
			{
				return new FeedItemReturnValue();
			}
			else if (type == "FeedMappingReturnValue")
			{
				return new FeedMappingReturnValue();
			}
			else if (type == "FeedReturnValue")
			{
				return new FeedReturnValue();
			}
			else if (type == "LabelReturnValue")
			{
				return new LabelReturnValue();
			}
			else if (type == "OfflineCallConversionFeedReturnValue")
			{
				return new OfflineCallConversionFeedReturnValue();
			}
			else if (type == "OfflineConversionFeedReturnValue")
			{
				return new OfflineConversionFeedReturnValue();
			}
			else if (type == "SharedCriterionReturnValue")
			{
				return new SharedCriterionReturnValue();
			}
			else if (type == "SharedSetReturnValue")
			{
				return new SharedSetReturnValue();
			}
			else if (type == "TrialReturnValue")
			{
				return new TrialReturnValue();
			}
			else if (type == "UserListReturnValue")
			{
				return new UserListReturnValue();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Media CreateMedia(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "Audio")
			{
				return new Audio();
			}
			else if (type == "Image")
			{
				return new Image();
			}
			else if (type == "MediaBundle")
			{
				return new MediaBundle();
			}
			else if (type == "Video")
			{
				return new Video();
			}
			else
			{
				return new Media();
			}
		}
		public static NoStatsPage CreateNoStatsPage(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdGroupBidLandscapePage")
			{
				return new AdGroupBidLandscapePage();
			}
			else if (type == "ConversionTrackerPage")
			{
				return new ConversionTrackerPage();
			}
			else if (type == "CriterionBidLandscapePage")
			{
				return new CriterionBidLandscapePage();
			}
			else if (type == "LabelPage")
			{
				return new LabelPage();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static NullStatsPage CreateNullStatsPage(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdGroupFeedPage")
			{
				return new AdGroupFeedPage();
			}
			else if (type == "CampaignFeedPage")
			{
				return new CampaignFeedPage();
			}
			else if (type == "CampaignSharedSetPage")
			{
				return new CampaignSharedSetPage();
			}
			else if (type == "CustomerFeedPage")
			{
				return new CustomerFeedPage();
			}
			else if (type == "DraftPage")
			{
				return new DraftPage();
			}
			else if (type == "FeedItemPage")
			{
				return new FeedItemPage();
			}
			else if (type == "FeedMappingPage")
			{
				return new FeedMappingPage();
			}
			else if (type == "FeedPage")
			{
				return new FeedPage();
			}
			else if (type == "SharedSetPage")
			{
				return new SharedSetPage();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static NumberValue CreateNumberValue(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "DoubleValue")
			{
				return new DoubleValue();
			}
			else if (type == "LongValue")
			{
				return new LongValue();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Operation CreateOperation(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AccountLabelOperation")
			{
				return new AccountLabelOperation();
			}
			else if (type == "AdCustomizerFeedOperation")
			{
				return new AdCustomizerFeedOperation();
			}
			else if (type == "AdGroupAdLabelOperation")
			{
				return new AdGroupAdLabelOperation();
			}
			else if (type == "AdGroupAdOperation")
			{
				return new AdGroupAdOperation();
			}
			else if (type == "AdGroupBidModifierOperation")
			{
				return new AdGroupBidModifierOperation();
			}
			else if (type == "AdGroupCriterionLabelOperation")
			{
				return new AdGroupCriterionLabelOperation();
			}
			else if (type == "AdGroupCriterionOperation")
			{
				return new AdGroupCriterionOperation();
			}
			else if (type == "AdGroupExtensionSettingOperation")
			{
				return new AdGroupExtensionSettingOperation();
			}
			else if (type == "AdGroupFeedOperation")
			{
				return new AdGroupFeedOperation();
			}
			else if (type == "AdGroupLabelOperation")
			{
				return new AdGroupLabelOperation();
			}
			else if (type == "AdGroupOperation")
			{
				return new AdGroupOperation();
			}
			else if (type == "AdParamOperation")
			{
				return new AdParamOperation();
			}
			else if (type == "BatchJobOperation")
			{
				return new BatchJobOperation();
			}
			else if (type == "BiddingStrategyOperation")
			{
				return new BiddingStrategyOperation();
			}
			else if (type == "BudgetOperation")
			{
				return new BudgetOperation();
			}
			else if (type == "BudgetOrderOperation")
			{
				return new BudgetOrderOperation();
			}
			else if (type == "CampaignCriterionOperation")
			{
				return new CampaignCriterionOperation();
			}
			else if (type == "CampaignExtensionSettingOperation")
			{
				return new CampaignExtensionSettingOperation();
			}
			else if (type == "CampaignFeedOperation")
			{
				return new CampaignFeedOperation();
			}
			else if (type == "CampaignLabelOperation")
			{
				return new CampaignLabelOperation();
			}
			else if (type == "CampaignOperation")
			{
				return new CampaignOperation();
			}
			else if (type == "CampaignSharedSetOperation")
			{
				return new CampaignSharedSetOperation();
			}
			else if (type == "ConversionTrackerOperation")
			{
				return new ConversionTrackerOperation();
			}
			else if (type == "CustomerExtensionSettingOperation")
			{
				return new CustomerExtensionSettingOperation();
			}
			else if (type == "CustomerFeedOperation")
			{
				return new CustomerFeedOperation();
			}
			else if (type == "DraftOperation")
			{
				return new DraftOperation();
			}
			else if (type == "FeedItemOperation")
			{
				return new FeedItemOperation();
			}
			else if (type == "FeedMappingOperation")
			{
				return new FeedMappingOperation();
			}
			else if (type == "FeedOperation")
			{
				return new FeedOperation();
			}
			else if (type == "LabelOperation")
			{
				return new LabelOperation();
			}
			else if (type == "LinkOperation")
			{
				return new LinkOperation();
			}
			else if (type == "ManagedCustomerLabelOperation")
			{
				return new ManagedCustomerLabelOperation();
			}
			else if (type == "ManagedCustomerOperation")
			{
				return new ManagedCustomerOperation();
			}
			else if (type == "MoveOperation")
			{
				return new MoveOperation();
			}
			else if (type == "MutateMembersOperation")
			{
				return new MutateMembersOperation();
			}
			else if (type == "OfflineCallConversionFeedOperation")
			{
				return new OfflineCallConversionFeedOperation();
			}
			else if (type == "OfflineConversionFeedOperation")
			{
				return new OfflineConversionFeedOperation();
			}
			else if (type == "ServiceLinkOperation")
			{
				return new ServiceLinkOperation();
			}
			else if (type == "SharedCriterionOperation")
			{
				return new SharedCriterionOperation();
			}
			else if (type == "SharedSetOperation")
			{
				return new SharedSetOperation();
			}
			else if (type == "TrialOperation")
			{
				return new TrialOperation();
			}
			else if (type == "UserListOperation")
			{
				return new UserListOperation();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Page CreatePage(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "AdCustomizerFeedPage")
			{
				return new AdCustomizerFeedPage();
			}
			else if (type == "AdGroupAdPage")
			{
				return new AdGroupAdPage();
			}
			else if (type == "AdGroupBidLandscapePage")
			{
				return new AdGroupBidLandscapePage();
			}
			else if (type == "AdGroupBidModifierPage")
			{
				return new AdGroupBidModifierPage();
			}
			else if (type == "AdGroupCriterionPage")
			{
				return new AdGroupCriterionPage();
			}
			else if (type == "AdGroupExtensionSettingPage")
			{
				return new AdGroupExtensionSettingPage();
			}
			else if (type == "AdGroupFeedPage")
			{
				return new AdGroupFeedPage();
			}
			else if (type == "AdGroupPage")
			{
				return new AdGroupPage();
			}
			else if (type == "BatchJobPage")
			{
				return new BatchJobPage();
			}
			else if (type == "BiddingStrategyPage")
			{
				return new BiddingStrategyPage();
			}
			else if (type == "BudgetOrderPage")
			{
				return new BudgetOrderPage();
			}
			else if (type == "BudgetPage")
			{
				return new BudgetPage();
			}
			else if (type == "CampaignCriterionPage")
			{
				return new CampaignCriterionPage();
			}
			else if (type == "CampaignExtensionSettingPage")
			{
				return new CampaignExtensionSettingPage();
			}
			else if (type == "CampaignFeedPage")
			{
				return new CampaignFeedPage();
			}
			else if (type == "CampaignPage")
			{
				return new CampaignPage();
			}
			else if (type == "CampaignSharedSetPage")
			{
				return new CampaignSharedSetPage();
			}
			else if (type == "ConversionTrackerPage")
			{
				return new ConversionTrackerPage();
			}
			else if (type == "CriterionBidLandscapePage")
			{
				return new CriterionBidLandscapePage();
			}
			else if (type == "CustomerExtensionSettingPage")
			{
				return new CustomerExtensionSettingPage();
			}
			else if (type == "CustomerFeedPage")
			{
				return new CustomerFeedPage();
			}
			else if (type == "DomainCategoryPage")
			{
				return new DomainCategoryPage();
			}
			else if (type == "DraftAsyncErrorPage")
			{
				return new DraftAsyncErrorPage();
			}
			else if (type == "DraftPage")
			{
				return new DraftPage();
			}
			else if (type == "FeedItemPage")
			{
				return new FeedItemPage();
			}
			else if (type == "FeedMappingPage")
			{
				return new FeedMappingPage();
			}
			else if (type == "FeedPage")
			{
				return new FeedPage();
			}
			else if (type == "LabelPage")
			{
				return new LabelPage();
			}
			else if (type == "ManagedCustomerPage")
			{
				return new ManagedCustomerPage();
			}
			else if (type == "SharedCriterionPage")
			{
				return new SharedCriterionPage();
			}
			else if (type == "SharedSetPage")
			{
				return new SharedSetPage();
			}
			else if (type == "TrialAsyncErrorPage")
			{
				return new TrialAsyncErrorPage();
			}
			else if (type == "TrialPage")
			{
				return new TrialPage();
			}
			else if (type == "UserListPage")
			{
				return new UserListPage();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static PolicyData CreatePolicyData(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "FeedItemPolicyData")
			{
				return new FeedItemPolicyData();
			}
			else
			{
				return new PolicyData();
			}
		}
		public static ProductDimension CreateProductDimension(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "ProductAdwordsGrouping")
			{
				return new ProductAdwordsGrouping();
			}
			else if (type == "ProductAdwordsLabels")
			{
				return new ProductAdwordsLabels();
			}
			else if (type == "ProductBiddingCategory")
			{
				return new ProductBiddingCategory();
			}
			else if (type == "ProductBrand")
			{
				return new ProductBrand();
			}
			else if (type == "ProductCanonicalCondition")
			{
				return new ProductCanonicalCondition();
			}
			else if (type == "ProductChannel")
			{
				return new ProductChannel();
			}
			else if (type == "ProductChannelExclusivity")
			{
				return new ProductChannelExclusivity();
			}
			else if (type == "ProductCustomAttribute")
			{
				return new ProductCustomAttribute();
			}
			else if (type == "ProductLegacyCondition")
			{
				return new ProductLegacyCondition();
			}
			else if (type == "ProductOfferId")
			{
				return new ProductOfferId();
			}
			else if (type == "ProductType")
			{
				return new ProductType();
			}
			else if (type == "ProductTypeFull")
			{
				return new ProductTypeFull();
			}
			else if (type == "UnknownProductDimension")
			{
				return new UnknownProductDimension();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static RichMediaAd CreateRichMediaAd(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "ThirdPartyRedirectAd")
			{
				return new ThirdPartyRedirectAd();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static SearchParameter CreateSearchParameter(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "CategoryProductsAndServicesSearchParameter")
			{
				return new CategoryProductsAndServicesSearchParameter();
			}
			else if (type == "CompetitionSearchParameter")
			{
				return new CompetitionSearchParameter();
			}
			else if (type == "IdeaTextFilterSearchParameter")
			{
				return new IdeaTextFilterSearchParameter();
			}
			else if (type == "IncludeAdultContentSearchParameter")
			{
				return new IncludeAdultContentSearchParameter();
			}
			else if (type == "LanguageSearchParameter")
			{
				return new LanguageSearchParameter();
			}
			else if (type == "LocationSearchParameter")
			{
				return new LocationSearchParameter();
			}
			else if (type == "NetworkSearchParameter")
			{
				return new NetworkSearchParameter();
			}
			else if (type == "RelatedToQuerySearchParameter")
			{
				return new RelatedToQuerySearchParameter();
			}
			else if (type == "RelatedToUrlSearchParameter")
			{
				return new RelatedToUrlSearchParameter();
			}
			else if (type == "SearchVolumeSearchParameter")
			{
				return new SearchVolumeSearchParameter();
			}
			else if (type == "SeedAdGroupIdSearchParameter")
			{
				return new SeedAdGroupIdSearchParameter();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static Setting CreateSetting(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "DynamicSearchAdsSetting")
			{
				return new DynamicSearchAdsSetting();
			}
			else if (type == "ExplorerAutoOptimizerSetting")
			{
				return new ExplorerAutoOptimizerSetting();
			}
			else if (type == "GeoTargetTypeSetting")
			{
				return new GeoTargetTypeSetting();
			}
			else if (type == "RealTimeBiddingSetting")
			{
				return new RealTimeBiddingSetting();
			}
			else if (type == "ShoppingSetting")
			{
				return new ShoppingSetting();
			}
			else if (type == "TargetingSetting")
			{
				return new TargetingSetting();
			}
			else if (type == "TrackingSetting")
			{
				return new TrackingSetting();
			}
			else if (type == "UniversalAppCampaignSetting")
			{
				return new UniversalAppCampaignSetting();
			}
			throw new ArgumentException($"Unknown type {type}", "xElement");
		}
		public static SystemFeedGenerationData CreateSystemFeedGenerationData(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "PlacesLocationFeedData")
			{
				return new PlacesLocationFeedData();
			}
			else
			{
				return new SystemFeedGenerationData();
			}
		}
		public static UserList CreateUserList(XElement xElement)
		{
			var type = XmlUtility.GetXmlTypeLocalName(xElement);
			if (type == "BasicUserList")
			{
				return new BasicUserList();
			}
			else if (type == "CrmBasedUserList")
			{
				return new CrmBasedUserList();
			}
			else if (type == "LogicalUserList")
			{
				return new LogicalUserList();
			}
			else if (type == "RuleBasedUserList")
			{
				return new RuleBasedUserList();
			}
			else if (type == "SimilarUserList")
			{
				return new SimilarUserList();
			}
			else
			{
				return new UserList();
			}
		}
	}
}
