namespace Manychois.GoogleApis.AdWords.v201609
{
	public enum AccountLabelServiceField
	{
		LabelId,
		LabelName
	}
	
	public enum AdCustomizerFeedServiceField
	{
		FeedAttributes,
		FeedId,
		FeedName,
		FeedStatus
	}
	
	public enum AdGroupAdServiceField
	{
		AdGroupAdDisapprovalReasons,
		AdGroupAdTrademarkDisapproved,
		AdGroupCreativeApprovalStatus,
		AdGroupId,
		AdType,
		AdvertisingId,
		BaseAdGroupId,
		BaseCampaignId,
		BusinessName,
		CallOnlyAdBusinessName,
		CallOnlyAdCallTracked,
		CallOnlyAdConversionTypeId,
		CallOnlyAdCountryCode,
		CallOnlyAdDescription1,
		CallOnlyAdDescription2,
		CallOnlyAdDisableCallConversion,
		CallOnlyAdPhoneNumber,
		CallOnlyAdPhoneNumberVerificationUrl,
		CreationTime,
		CreativeFinalAppUrls,
		CreativeFinalMobileUrls,
		CreativeFinalUrls,
		CreativeTrackingUrlTemplate,
		CreativeUrlCustomParameters,
		Description,
		Description1,
		Description2,
		DevicePreference,
		Dimensions,
		DisplayUrl,
		DurationMillis,
		ExpandingDirections,
		FileSize,
		Headline,
		HeadlinePart1,
		HeadlinePart2,
		Height,
		Id,
		ImageCreativeName,
		IndustryStandardCommercialIdentifier,
		IsCookieTargeted,
		IsTagged,
		IsUserInterestTargeted,
		Labels,
		LogoImage,
		LongHeadline,
		MarketingImage,
		MediaId,
		MimeType,
		Name,
		Path1,
		Path2,
		ReadyToPlayOnTheWeb,
		ReferenceId,
		RichMediaAdCertifiedVendorFormatId,
		RichMediaAdDuration,
		RichMediaAdImpressionBeaconUrl,
		RichMediaAdName,
		RichMediaAdSnippet,
		RichMediaAdSourceUrl,
		RichMediaAdType,
		ShortHeadline,
		SourceUrl,
		Status,
		StreamingUrl,
		TemplateAdDuration,
		TemplateAdName,
		TemplateAdUnionId,
		TemplateElementFieldName,
		TemplateElementFieldText,
		TemplateElementFieldType,
		TemplateId,
		TemplateOriginAdId,
		Trademarks,
		Type,
		UniqueName,
		Url,
		Urls,
		VideoTypes,
		Width,
		YouTubeVideoIdString
	}
	
	public enum AdGroupBidModifierServiceField
	{
		AdGroupId,
		BaseAdGroupId,
		BidModifier,
		BidModifierSource,
		CampaignId,
		CriteriaType,
		Id,
		PlatformName
	}
	
	public enum AdGroupCriterionServiceField
	{
		AdGroupId,
		AgeRangeType,
		AppId,
		AppPaymentModelType,
		ApprovalStatus,
		BaseAdGroupId,
		BaseCampaignId,
		BiddingStrategyId,
		BiddingStrategyName,
		BiddingStrategySource,
		BiddingStrategyType,
		BidModifier,
		BidType,
		CaseValue,
		ChannelId,
		ChannelName,
		CpcBid,
		CpcBidSource,
		CpmBid,
		CpmBidSource,
		CriteriaCoverage,
		CriteriaSamples,
		CriteriaType,
		CriterionUse,
		DestinationUrl,
		DisapprovalReasons,
		DisplayName,
		EnhancedCpcEnabled,
		FinalAppUrls,
		FinalMobileUrls,
		FinalUrls,
		FirstPageCpc,
		FirstPositionCpc,
		GenderType,
		Id,
		KeywordMatchType,
		KeywordText,
		Labels,
		MobileAppCategoryId,
		Parameter,
		ParentCriterionId,
		ParentType,
		PartitionType,
		Path,
		PlacementUrl,
		QualityScore,
		Status,
		SystemServingStatus,
		TopOfPageCpc,
		TrackingUrlTemplate,
		UrlCustomParameters,
		UserInterestId,
		UserInterestName,
		UserInterestParentId,
		UserListEligibleForDisplay,
		UserListEligibleForSearch,
		UserListId,
		UserListMembershipStatus,
		UserListName,
		VerticalId,
		VerticalParentId,
		VideoId,
		VideoName
	}
	
	public enum AdGroupExtensionSettingServiceField
	{
		AdGroupId,
		Extensions,
		ExtensionType,
		PlatformRestrictions
	}
	
	public enum AdGroupFeedServiceField
	{
		AdGroupId,
		BaseAdGroupId,
		BaseCampaignId,
		FeedId,
		MatchingFunction,
		PlaceholderTypes,
		Status
	}
	
	public enum AdGroupServiceField
	{
		BaseAdGroupId,
		BaseCampaignId,
		BiddingStrategyId,
		BiddingStrategyName,
		BiddingStrategySource,
		BiddingStrategyType,
		BidType,
		CampaignId,
		CampaignName,
		ContentBidCriterionTypeGroup,
		CpcBid,
		CpmBid,
		EnhancedCpcEnabled,
		Id,
		Labels,
		Name,
		Settings,
		Status,
		TargetCpa,
		TargetCpaBid,
		TargetCpaBidSource,
		TrackingUrlTemplate,
		UrlCustomParameters
	}
	
	public enum AdParamServiceField
	{
		AdGroupId,
		CriterionId,
		InsertionText,
		ParamIndex
	}
	
	public enum AdwordsUserListServiceField
	{
		AccessReason,
		AccountUserListStatus,
		ConversionTypes,
		DateSpecificListEndDate,
		DateSpecificListRule,
		DateSpecificListStartDate,
		Description,
		ExpressionListRule,
		Id,
		IntegrationCode,
		IsEligibleForDisplay,
		IsEligibleForSearch,
		IsReadOnly,
		ListType,
		MembershipLifeSpan,
		Name,
		Rules,
		SeedListSize,
		SeedUserListDescription,
		SeedUserListId,
		SeedUserListName,
		SeedUserListStatus,
		Size,
		SizeForSearch,
		SizeRange,
		SizeRangeForSearch,
		Status
	}
	
	public enum BatchJobServiceField
	{
		DownloadUrl,
		Id,
		ProcessingErrors,
		ProgressStats,
		Status
	}
	
	public enum BiddingStrategyServiceField
	{
		BiddingScheme,
		EnhancedCpcEnabled,
		Id,
		Name,
		PageOnePromotedBidCeiling,
		PageOnePromotedBidChangesForRaisesOnly,
		PageOnePromotedBidModifier,
		PageOnePromotedRaiseBidWhenBudgetConstrained,
		PageOnePromotedRaiseBidWhenLowQualityScore,
		PageOnePromotedStrategyGoal,
		Status,
		SystemStatus,
		TargetCpa,
		TargetCpaMaxCpcBidCeiling,
		TargetCpaMaxCpcBidFloor,
		TargetOutrankShare,
		TargetOutrankShareBidChangesForRaisesOnly,
		TargetOutrankShareCompetitorDomain,
		TargetOutrankShareMaxCpcBidCeiling,
		TargetOutrankShareRaiseBidWhenLowQualityScore,
		TargetRoas,
		TargetRoasBidCeiling,
		TargetRoasBidFloor,
		TargetSpendBidCeiling,
		TargetSpendSpendTarget,
		Type
	}
	
	public enum BudgetOrderServiceField
	{
		BillingAccountId,
		BillingAccountName,
		BudgetOrderName,
		EndDateTime,
		Id,
		LastRequest,
		PoNumber,
		PrimaryBillingId,
		SecondaryBillingId,
		SpendingLimit,
		StartDateTime,
		TotalAdjustments
	}
	
	public enum BudgetServiceField
	{
		Amount,
		BudgetId,
		BudgetName,
		BudgetReferenceCount,
		BudgetStatus,
		DeliveryMethod,
		IsBudgetExplicitlyShared
	}
	
	public enum CampaignCriterionServiceField
	{
		Address,
		AgeRangeType,
		AppId,
		BaseCampaignId,
		BidModifier,
		CampaignCriterionStatus,
		CampaignId,
		CarrierCountryCode,
		CarrierName,
		ChannelId,
		ChannelName,
		ContentLabelType,
		CriteriaType,
		DayOfWeek,
		DeviceName,
		DeviceType,
		Dimensions,
		DisplayName,
		DisplayType,
		EndHour,
		EndMinute,
		FeedId,
		GenderType,
		GeoPoint,
		Id,
		IpAddress,
		IsNegative,
		KeywordMatchType,
		KeywordText,
		LanguageCode,
		LanguageName,
		LocationName,
		ManufacturerName,
		MatchingFunction,
		MobileAppCategoryId,
		OperatingSystemName,
		OperatorType,
		OsMajorVersion,
		OsMinorVersion,
		Parameter,
		ParentLocations,
		ParentType,
		Path,
		PlacementUrl,
		PlatformName,
		RadiusDistanceUnits,
		RadiusInUnits,
		StartHour,
		StartMinute,
		TargetingStatus,
		UserInterestId,
		UserInterestName,
		UserInterestParentId,
		UserListEligibleForDisplay,
		UserListEligibleForSearch,
		UserListId,
		UserListMembershipStatus,
		UserListName,
		VerticalId,
		VerticalParentId,
		VideoId,
		VideoName
	}
	
	public enum CampaignExtensionSettingServiceField
	{
		CampaignId,
		Extensions,
		ExtensionType,
		PlatformRestrictions
	}
	
	public enum CampaignFeedServiceField
	{
		BaseCampaignId,
		CampaignId,
		FeedId,
		MatchingFunction,
		PlaceholderTypes,
		Status
	}
	
	public enum CampaignServiceField
	{
		AdServingOptimizationStatus,
		AdvertisingChannelSubType,
		AdvertisingChannelType,
		Amount,
		BaseCampaignId,
		BidCeiling,
		BiddingStrategyId,
		BiddingStrategyName,
		BiddingStrategyType,
		BidType,
		BudgetId,
		BudgetName,
		BudgetReferenceCount,
		BudgetStatus,
		CampaignTrialType,
		DeliveryMethod,
		Eligible,
		EndDate,
		EnhancedCpcEnabled,
		FrequencyCapMaxImpressions,
		Id,
		IsBudgetExplicitlyShared,
		Labels,
		Level,
		Name,
		PricingMode,
		RejectionReasons,
		SelectiveOptimization,
		ServingStatus,
		Settings,
		StartDate,
		Status,
		TargetContentNetwork,
		TargetCpa,
		TargetCpaMaxCpcBidCeiling,
		TargetCpaMaxCpcBidFloor,
		TargetGoogleSearch,
		TargetPartnerSearchNetwork,
		TargetRoas,
		TargetRoasBidCeiling,
		TargetRoasBidFloor,
		TargetSearchNetwork,
		TargetSpendBidCeiling,
		TargetSpendSpendTarget,
		TimeUnit,
		TrackingUrlTemplate,
		UrlCustomParameters,
		VanityPharmaDisplayUrlMode,
		VanityPharmaText
	}
	
	public enum CampaignSharedSetServiceField
	{
		CampaignId,
		CampaignName,
		SharedSetId,
		SharedSetName,
		SharedSetType,
		Status
	}
	
	public enum ConstantDataServiceField
	{
		BiddingCategoryStatus,
		Country,
		OperatingSystemName
	}
	
	public enum ConversionTrackerServiceField
	{
		AlwaysUseDefaultRevenueValue,
		AppId,
		AppPlatform,
		AppPostbackUrl,
		AttributionModelType,
		BackgroundColor,
		Category,
		ConversionPageLanguage,
		ConversionTypeOwnerCustomerId,
		CountingType,
		CtcLookbackWindow,
		DataDrivenModelStatus,
		DefaultRevenueCurrencyCode,
		DefaultRevenueValue,
		ExcludeFromBidding,
		Id,
		LastReceivedRequestTime,
		MostRecentConversionDate,
		Name,
		OriginalConversionTypeId,
		PhoneCallDuration,
		Status,
		TextFormat,
		TrackingCodeType,
		ViewthroughLookbackWindow,
		WebsitePhoneCallDuration
	}
	
	public enum CustomerExtensionSettingServiceField
	{
		Extensions,
		ExtensionType,
		PlatformRestrictions
	}
	
	public enum CustomerFeedServiceField
	{
		FeedId,
		MatchingFunction,
		PlaceholderTypes,
		Status
	}
	
	public enum DataServiceField
	{
		AdGroupId,
		Bid,
		BidModifier,
		CampaignId,
		Category,
		CategoryRank,
		Coverage,
		CriterionId,
		DomainName,
		EndDate,
		HasChild,
		IsoLanguage,
		LandscapeCurrent,
		LandscapeType,
		LocalClicks,
		LocalCost,
		LocalImpressions,
		PromotedImpressions,
		RecommendedCpc,
		RequiredBudget,
		StartDate,
		TotalLocalClicks,
		TotalLocalCost,
		TotalLocalImpressions,
		TotalLocalPromotedImpressions
	}
	
	public enum DraftAsyncErrorServiceField
	{
		AsyncError,
		BaseAdGroupId,
		BaseCampaignId,
		DraftAdGroupId,
		DraftCampaignId,
		DraftId
	}
	
	public enum DraftServiceField
	{
		BaseCampaignId,
		DraftCampaignId,
		DraftId,
		DraftName,
		DraftStatus,
		HasRunningTrial
	}
	
	public enum FeedItemServiceField
	{
		AttributeValues,
		DevicePreference,
		EndTime,
		FeedId,
		FeedItemId,
		GeoTargetingCriterionId,
		GeoTargetingDisplayType,
		GeoTargetingLocationName,
		GeoTargetingParentLocations,
		GeoTargetingRestriction,
		GeoTargetingStatus,
		KeywordMatchType,
		KeywordTargetingCriterionId,
		KeywordText,
		PolicyData,
		Scheduling,
		StartTime,
		Status,
		TargetingAdGroupId,
		TargetingCampaignId,
		UrlCustomParameters
	}
	
	public enum FeedMappingServiceField
	{
		AttributeFieldMappings,
		CriterionType,
		FeedId,
		FeedMappingId,
		PlaceholderType,
		Status
	}
	
	public enum FeedServiceField
	{
		Attributes,
		FeedStatus,
		Id,
		Name,
		Origin,
		SystemFeedGenerationData
	}
	
	public enum LabelServiceField
	{
		LabelAttribute,
		LabelId,
		LabelName,
		LabelStatus
	}
	
	public enum LocationCriterionServiceField
	{
		CanonicalName,
		Reach
	}
	
	public enum ManagedCustomerServiceField
	{
		AccountLabels,
		CanManageClients,
		CurrencyCode,
		CustomerId,
		DateTimeZone,
		LabelId,
		LabelName,
		Name,
		TestAccount
	}
	
	public enum MediaServiceField
	{
		AdvertisingId,
		CreationTime,
		Dimensions,
		DurationMillis,
		FileSize,
		Height,
		IndustryStandardCommercialIdentifier,
		MediaId,
		MimeType,
		Name,
		ReadyToPlayOnTheWeb,
		ReferenceId,
		SourceUrl,
		StreamingUrl,
		Type,
		Urls,
		Width,
		YouTubeVideoIdString
	}
	
	public enum OfflineConversionFeedServiceField
	{
		ConversionCurrencyCode,
		ConversionName,
		ConversionTime,
		ConversionValue,
		GoogleClickId
	}
	
	public enum SharedCriterionServiceField
	{
		AppId,
		ChannelId,
		ChannelName,
		CriteriaType,
		DisplayName,
		Id,
		KeywordMatchType,
		KeywordText,
		Negative,
		PlacementUrl,
		SharedSetId,
		VideoId,
		VideoName
	}
	
	public enum SharedSetServiceField
	{
		MemberCount,
		Name,
		ReferenceCount,
		SharedSetId,
		Status,
		Type
	}
	
	public enum TargetingIdeaServiceField
	{
		AppId,
		CriteriaType,
		DisplayName,
		Id,
		KeywordMatchType,
		KeywordText,
		MobileAppCategoryId,
		Path,
		PlacementUrl,
		UserInterestId,
		UserInterestName,
		UserInterestParentId,
		UserListEligibleForDisplay,
		UserListEligibleForSearch,
		UserListId,
		UserListMembershipStatus,
		UserListName,
		VerticalId,
		VerticalParentId
	}
	
	public enum TrafficEstimatorServiceField
	{
		AppId,
		CriteriaType,
		DisplayName,
		Id,
		KeywordMatchType,
		KeywordText,
		MobileAppCategoryId,
		Path,
		PlacementUrl,
		UserInterestId,
		UserInterestName,
		UserInterestParentId,
		UserListEligibleForDisplay,
		UserListEligibleForSearch,
		UserListId,
		UserListMembershipStatus,
		UserListName,
		VerticalId,
		VerticalParentId
	}
	
	public enum TrialAsyncErrorServiceField
	{
		AsyncError,
		BaseAdGroupId,
		BaseCampaignId,
		TrialAdGroupId,
		TrialCampaignId,
		TrialId
	}
	
	public enum TrialServiceField
	{
		BaseCampaignId,
		DraftId,
		EndDate,
		Id,
		Name,
		StartDate,
		Status,
		TrafficSplitPercent,
		TrialCampaignId
	}
	
}
