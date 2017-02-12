namespace Manychois.GoogleApis.AdWords.v201609
{
	/// <summary>
	/// This indicates the way the entity such as UserList is related to a user.
	/// </summary>
	public enum AccessReason
	{
		/// <summary>
		/// The entity is owned by the user.
		/// </summary>
		Owned,
		/// <summary>
		/// The entity is shared to the user.
		/// </summary>
		Shared,
		/// <summary>
		/// The entity is licensed to the user.
		/// </summary>
		Licensed,
		/// <summary>
		/// The user subscribed to the entity.
		/// </summary>
		Subscribed
	}
	
	/// <summary>
	/// Status in the AccountUserListStatus table. This indicates if the user list share or
	/// the licensing of the userlist is still active.
	/// </summary>
	public enum AccountUserListStatus
	{
		Active,
		Inactive
	}
	
	/// <summary>
	/// Ad customizer error reasons.
	/// </summary>
	public enum AdCustomizerErrorReason
	{
		/// <summary>
		/// Invalid date argument in countdown function.
		/// </summary>
		CountdownInvalidDateFormat,
		/// <summary>
		/// Countdown end date is in the past.
		/// </summary>
		CountdownDateInPast,
		/// <summary>
		/// Invalid locale string in countdown function.
		/// </summary>
		CountdownInvalidLocale,
		/// <summary>
		/// Days-before argument to countdown function is not positive.
		/// </summary>
		CountdownInvalidStartDaysBefore
	}
	
	/// <summary>
	/// Possible data types.
	/// </summary>
	public enum AdCustomizerFeedAttributeType
	{
		Integer,
		Price,
		DateTime,
		String,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Error reasons.
	/// </summary>
	public enum AdCustomizerFeedErrorReason
	{
		/// <summary>
		/// The key attribute cannot be added to an existing ad customizer feed.
		/// </summary>
		CannotAddKeyAttribute,
		/// <summary>
		/// The feed is not an ad customizer feed.
		/// </summary>
		NotAdCustomizerFeed,
		/// <summary>
		/// Name of AdCustomizerFeed is not allowed.
		/// </summary>
		InvalidFeedName,
		/// <summary>
		/// Too many AdCustomizerFeedAttributes for an AdCustomizerFeed.
		/// </summary>
		TooManyFeedAttributesForFeed,
		/// <summary>
		/// The names of the AdCustomizerFeedAttributes must be unique.
		/// </summary>
		AttributeNamesNotUnique,
		/// <summary>
		/// The given id refers to a removed Feed. Removed Feeds are immutable.
		/// </summary>
		FeedDeleted,
		/// <summary>
		/// Feed name matches that of another active Feed.
		/// </summary>
		DuplicateFeedName,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum AdErrorReason
	{
		/// <summary>
		/// Ad customizers are not supported for ad type.
		/// </summary>
		AdCustomizersNotSupportedForAdType,
		/// <summary>
		/// Estimating character sizes the string is too long.
		/// </summary>
		ApproximatelyTooLong,
		/// <summary>
		/// Estimating character sizes the string is too short.
		/// </summary>
		ApproximatelyTooShort,
		/// <summary>
		/// There is a problem with the snippet.
		/// </summary>
		BadSnippet,
		/// <summary>
		/// Cannot modify an ad.
		/// </summary>
		CannotModifyAd,
		/// <summary>
		/// business name and url cannot be set at the same time
		/// </summary>
		CannotSetBusinessNameIfUrlSet,
		/// <summary>
		/// The specified field is incompatible with this ad's type or settings.
		/// </summary>
		CannotSetField,
		/// <summary>
		/// Cannot set field when originAdId is set.
		/// </summary>
		CannotSetFieldWithOriginAdIdSet,
		/// <summary>
		/// Cannot set field when an existing ad id is set for sharing.
		/// </summary>
		CannotSetFieldWithAdIdSetForSharing,
		/// <summary>
		/// Cannot specify a url for the ad type
		/// </summary>
		CannotSetUrl,
		/// <summary>
		/// Cannot specify a tracking or mobile url without also setting final urls
		/// </summary>
		CannotSetWithoutFinalUrls,
		/// <summary>
		/// Cannot specify a legacy url and a final url simultaneously
		/// </summary>
		CannotSetWithFinalUrls,
		/// <summary>
		/// Cannot specify a legacy url and a tracking url template simultaneously in a DSA.
		/// </summary>
		CannotSetWithTrackingUrlTemplate,
		/// <summary>
		/// This operator cannot be used with a subclass of Ad.
		/// </summary>
		CannotUseAdSubclassForOperator,
		/// <summary>
		/// Customer is not approved for mobile ads.
		/// </summary>
		CustomerNotApprovedMobileads,
		/// <summary>
		/// Customer is not approved for 3PAS richmedia ads.
		/// </summary>
		CustomerNotApprovedThirdpartyAds,
		/// <summary>
		/// Customer is not approved for 3PAS redirect richmedia (Ad Exchange) ads.
		/// </summary>
		CustomerNotApprovedThirdpartyRedirectAds,
		/// <summary>
		/// Not an eligible customer
		/// </summary>
		CustomerNotEligible,
		/// <summary>
		/// Customer is not eligible for updating beacon url
		/// </summary>
		CustomerNotEligibleForUpdatingBeaconUrl,
		/// <summary>
		/// There already exists an ad with the same dimensions in the union.
		/// </summary>
		DimensionAlreadyInUnion,
		/// <summary>
		/// Ad's dimension must be set before setting union dimension.
		/// </summary>
		DimensionMustBeSet,
		/// <summary>
		/// Ad's dimension must be included in the union dimensions.
		/// </summary>
		DimensionNotInUnion,
		/// <summary>
		/// Display Url cannot be specified (applies to Ad Exchange Ads)
		/// </summary>
		DisplayUrlCannotBeSpecified,
		/// <summary>
		/// Telephone number contains invalid characters or invalid format.
		/// Please re-enter your number using digits (0-9), dashes (-), and parentheses only.
		/// </summary>
		DomesticPhoneNumberFormat,
		/// <summary>
		/// Emergency telephone numbers are not allowed.
		/// Please enter a valid domestic phone number to connect customers to your business.
		/// </summary>
		EmergencyPhoneNumber,
		/// <summary>
		/// A required field was not specified or is an empty string.
		/// </summary>
		EmptyField,
		/// <summary>
		/// A feed attribute referenced in an ad customizer tag is not in the ad customizer mapping for
		/// the feed.
		/// </summary>
		FeedAttributeMustHaveMappingForTypeId,
		/// <summary>
		/// The ad customizer field mapping for the feed attribute does not match the expected field
		/// type.
		/// </summary>
		FeedAttributeMappingTypeMismatch,
		/// <summary>
		/// The use of ad customizer tags in the ad text is disallowed. Details in trigger.
		/// </summary>
		IllegalAdCustomizerTagUse,
		/// <summary>
		/// The dimensions of the ad are specified or derived in multiple ways and are not consistent.
		/// </summary>
		InconsistentDimensions,
		/// <summary>
		/// The status cannot differ among template ads of the same union.
		/// </summary>
		InconsistentStatusInTemplateUnion,
		/// <summary>
		/// The length of the string is not valid.
		/// </summary>
		IncorrectLength,
		/// <summary>
		/// The ad is ineligible for upgrade.
		/// </summary>
		IneligibleForUpgrade,
		/// <summary>
		/// User cannot create mobile ad for countries targeted in specified campaign.
		/// </summary>
		InvalidAdAddressCampaignTarget,
		/// <summary>
		/// Invalid Ad type. A specific type of Ad is required.
		/// </summary>
		InvalidAdType,
		/// <summary>
		/// Headline, description or phone cannot be present when creating mobile image ad.
		/// </summary>
		InvalidAttributesForMobileImage,
		/// <summary>
		/// Image cannot be present when creating mobile text ad.
		/// </summary>
		InvalidAttributesForMobileText,
		/// <summary>
		/// Invalid character in URL.
		/// </summary>
		InvalidCharacterForUrl,
		/// <summary>
		/// Creative's country code is not valid.
		/// </summary>
		InvalidCountryCode,
		/// <summary>
		/// Invalid use of Dynamic Search Ads tags ({lpurl} etc.)
		/// </summary>
		InvalidDsaUrlTag,
		/// <summary>
		/// An input error whose real reason was not properly mapped (should not happen).
		/// </summary>
		InvalidInput,
		/// <summary>
		/// An invalid markup language was entered.
		/// </summary>
		InvalidMarkupLanguage,
		/// <summary>
		/// An invalid mobile carrier was entered.
		/// </summary>
		InvalidMobileCarrier,
		/// <summary>
		/// Specified mobile carriers target a country not targeted by the campaign.
		/// </summary>
		InvalidMobileCarrierTarget,
		/// <summary>
		/// Wrong number of elements for given element type
		/// </summary>
		InvalidNumberOfElements,
		/// <summary>
		/// The format of the telephone number is incorrect.
		/// Please re-enter the number using the correct format.
		/// </summary>
		InvalidPhoneNumberFormat,
		/// <summary>
		/// The certified vendor format id is incorrect.
		/// </summary>
		InvalidRichMediaCertifiedVendorFormatId,
		/// <summary>
		/// The template ad data contains validation errors.
		/// </summary>
		InvalidTemplateData,
		/// <summary>
		/// The template field doesn't have have the correct type.
		/// </summary>
		InvalidTemplateElementFieldType,
		/// <summary>
		/// Invalid template id.
		/// </summary>
		InvalidTemplateId,
		/// <summary>
		/// After substituting replacement strings, the line is too wide.
		/// </summary>
		LineTooWide,
		/// <summary>
		/// When entering a markup language the Destination URL must be entered.
		/// </summary>
		MarkupLanguagesPresent,
		/// <summary>
		/// The feed referenced must have ad customizer mapping to be used in a customizer tag.
		/// </summary>
		MissingAdCustomizerMapping,
		/// <summary>
		/// Missing address component in template element address field.
		/// </summary>
		MissingAddressComponent,
		/// <summary>
		/// An ad name must be entered.
		/// </summary>
		MissingAdvertisementName,
		/// <summary>
		/// Business name must be entered.
		/// </summary>
		MissingBusinessName,
		/// <summary>
		/// Description (line 2) must be entered.
		/// </summary>
		MissingDescription1,
		/// <summary>
		/// Description (line 3) must be entered.
		/// </summary>
		MissingDescription2,
		/// <summary>
		/// A destination URL must be entered.
		/// </summary>
		MissingDestinationUrl,
		/// <summary>
		/// The destination url must contain at least one tag (e.g. {lpurl})
		/// </summary>
		MissingDestinationUrlTag,
		/// <summary>
		/// A valid dimension must be specified for this ad.
		/// </summary>
		MissingDimension,
		/// <summary>
		/// A display URL must be entered.
		/// </summary>
		MissingDisplayUrl,
		/// <summary>
		/// Headline must be entered.
		/// </summary>
		MissingHeadline,
		/// <summary>
		/// A height must be entered.
		/// </summary>
		MissingHeight,
		/// <summary>
		/// An image must be entered.
		/// </summary>
		MissingImage,
		/// <summary>
		/// The markup language in which your site is written must be entered.
		/// </summary>
		MissingMarkupLanguages,
		/// <summary>
		/// A mobile carrier must be entered.
		/// </summary>
		MissingMobileCarrier,
		/// <summary>
		/// Phone number must be entered.
		/// </summary>
		MissingPhone,
		/// <summary>
		/// Missing required template fields
		/// </summary>
		MissingRequiredTemplateFields,
		/// <summary>
		/// Missing a required field value
		/// </summary>
		MissingTemplateFieldValue,
		/// <summary>
		/// The ad must have text.
		/// </summary>
		MissingText,
		/// <summary>
		/// Ad must link to a mobile web page or connect users to your business telephone, or both.
		/// Please enter a mobile Destination URL and/or a business telephone number.
		/// </summary>
		MissingUrlAndPhone,
		/// <summary>
		/// A visible URL must be entered.
		/// </summary>
		MissingVisibleUrl,
		/// <summary>
		/// A width must be entered.
		/// </summary>
		MissingWidth,
		/// <summary>
		/// Only 1 feed can be used as the source of ad customizer substitutions in a single ad.
		/// </summary>
		MultipleDistinctFeedsUnsupported,
		/// <summary>
		/// TempAdUnionId must be use when adding template ads.
		/// </summary>
		MustUseTempAdUnionIdOnAdd,
		/// <summary>
		/// The string has too many characters.
		/// </summary>
		TooLong,
		/// <summary>
		/// The string has too few characters.
		/// </summary>
		TooShort,
		/// <summary>
		/// Ad union dimensions cannot change for saved ads.
		/// </summary>
		UnionDimensionsCannotChange,
		/// <summary>
		/// Address component is not {country, lat, lng}.
		/// </summary>
		UnknownAddressComponent,
		/// <summary>
		/// Unknown unique field name
		/// </summary>
		UnknownFieldName,
		/// <summary>
		/// Unknown unique name (template element type specifier)
		/// </summary>
		UnknownUniqueName,
		/// <summary>
		/// Unsupported ad dimension
		/// </summary>
		UnsupportedDimensions,
		/// <summary>
		/// URL starts with an invalid scheme.
		/// </summary>
		UrlInvalidScheme,
		/// <summary>
		/// URL ends with an invalid top-level domain name.
		/// </summary>
		UrlInvalidTopLevelDomain,
		/// <summary>
		/// URL contains illegal characters.
		/// </summary>
		UrlMalformed,
		/// <summary>
		/// URL must contain a host name.
		/// </summary>
		UrlNoHost,
		/// <summary>
		/// URL not equivalent during upgrade.
		/// </summary>
		UrlNotEquivalent,
		/// <summary>
		/// URL host name too long to be stored as visible URL (applies to Ad Exchange ads)
		/// </summary>
		UrlHostNameTooLong,
		/// <summary>
		/// URL must start with a scheme.
		/// </summary>
		UrlNoScheme,
		/// <summary>
		/// URL should end in a valid domain extension, such as .com or .net.
		/// </summary>
		UrlNoTopLevelDomain,
		/// <summary>
		/// URL must not end with a path.
		/// </summary>
		UrlPathNotAllowed,
		/// <summary>
		/// URL must not specify a port.
		/// </summary>
		UrlPortNotAllowed,
		/// <summary>
		/// URL must not contain a query.
		/// </summary>
		UrlQueryNotAllowed,
		/// <summary>
		/// A url scheme is not allowed in front of tag in dest url (e.g. http://{lpurl})
		/// </summary>
		UrlSchemeBeforeDsaTag,
		/// <summary>
		/// The user does not have permissions to create a template ad for the given
		/// template.
		/// </summary>
		UserDoesNotHaveAccessToTemplate,
		/// <summary>
		/// Expandable setting is inconsistent/wrong. For example, an AdX ad is
		/// invalid if it has a expandable vendor format but no expanding directions
		/// specified, or expanding directions is specified, but the vendor format
		/// is not expandable.
		/// </summary>
		InconsistentExpandableSettings,
		/// <summary>
		/// Format is invalid
		/// </summary>
		InvalidFormat,
		/// <summary>
		/// The text of this field did not match a pattern of allowed values.
		/// </summary>
		InvalidFieldText,
		/// <summary>
		/// Template element is mising
		/// </summary>
		ElementNotPresent,
		/// <summary>
		/// Error occurred during image processing
		/// </summary>
		ImageError,
		/// <summary>
		/// The value is not within the valid range
		/// </summary>
		ValueNotInRange,
		/// <summary>
		/// Template element field is not present
		/// </summary>
		FieldNotPresent,
		/// <summary>
		/// Address is incomplete
		/// </summary>
		AddressNotComplete,
		/// <summary>
		/// Invalid address
		/// </summary>
		AddressInvalid,
		/// <summary>
		/// Error retrieving specified video
		/// </summary>
		VideoRetrievalError,
		/// <summary>
		/// Error processing audio
		/// </summary>
		AudioError,
		/// <summary>
		/// Display URL is incorrect for YouTube PYV ads
		/// </summary>
		InvalidYoutubeDisplayUrl,
		/// <summary>
		/// The device preference is not compatible with the ad type
		/// </summary>
		IncompatibleAdTypeAndDevicePreference,
		/// <summary>
		/// Call tracking is not supported for specified country.
		/// </summary>
		CalltrackingNotSupportedForCountry,
		/// <summary>
		/// Carrier specific short number is not allowed.
		/// </summary>
		CarrierSpecificShortNumberNotAllowed,
		/// <summary>
		/// Specified phone number type is disallowed.
		/// </summary>
		DisallowedNumberType,
		/// <summary>
		/// Phone number not supported for country.
		/// </summary>
		PhoneNumberNotSupportedForCountry,
		/// <summary>
		/// Phone number not supported with call tracking enabled for country.
		/// </summary>
		PhoneNumberNotSupportedWithCalltrackingForCountry,
		/// <summary>
		/// Premium rate phone number is not allowed.
		/// </summary>
		PremiumRateNumberNotAllowed,
		/// <summary>
		/// Vanity phone number is not allowed.
		/// </summary>
		VanityPhoneNumberNotAllowed,
		/// <summary>
		/// Invalid call conversion type id.
		/// </summary>
		InvalidCallConversionTypeId,
		CannotDisableCallConversionAndSetConversionTypeId,
		/// <summary>
		/// Cannot set path2 without path1.
		/// </summary>
		CannotSetPath2WithoutPath1,
		/// <summary>
		/// An unexpected or unknown error occurred.
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Represents the possible approval statuses.
	/// </summary>
	public enum AdGroupAdApprovalStatus
	{
		/// <summary>
		/// Approved
		/// </summary>
		Approved,
		/// <summary>
		/// Disapproved
		/// </summary>
		Disapproved,
		/// <summary>
		/// Approved - family safe
		/// </summary>
		FamilySafe,
		/// <summary>
		/// Approved - non-family safe
		/// </summary>
		NonFamilySafe,
		/// <summary>
		/// Approved - adult content
		/// </summary>
		Porn,
		/// <summary>
		/// Pending review
		/// </summary>
		Unchecked,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum AdGroupAdErrorReason
	{
		/// <summary>
		/// No link found between the adgroup ad and the label.
		/// </summary>
		AdGroupAdLabelDoesNotExist,
		/// <summary>
		/// The label has already been attached to the adgroup ad.
		/// </summary>
		AdGroupAdLabelAlreadyExists,
		/// <summary>
		/// The specified ad was not found in the adgroup
		/// </summary>
		AdNotUnderAdgroup,
		/// <summary>
		/// Removed ads may not be modified
		/// </summary>
		CannotOperateOnRemovedAdgroupad,
		/// <summary>
		/// An ad of this type is deprecated and cannot be created. Only deletions
		/// are permitted.
		/// </summary>
		CannotCreateDeprecatedAds,
		/// <summary>
		/// A required field was not specified or is an empty string.
		/// </summary>
		EmptyField,
		/// <summary>
		/// An ad may only be modified once per call
		/// </summary>
		EntityReferencedInMultipleOps,
		/// <summary>
		/// The specified operation is not supported.  Only ADD, SET, and REMOVE
		/// are supported
		/// </summary>
		UnsupportedOperation
	}
	
	/// <summary>
	/// The current status of an Ad.
	/// </summary>
	public enum AdGroupAdStatus
	{
		/// <summary>
		/// Enabled.
		/// </summary>
		Enabled,
		/// <summary>
		/// Paused.
		/// </summary>
		Paused,
		/// <summary>
		/// Disabled.
		/// </summary>
		Disabled
	}
	
	/// <summary>
	/// Used to specify the type of {@code AdGroupLandscape}
	/// </summary>
	public enum AdGroupBidLandscapeType
	{
		/// <summary>
		/// Signifies that the bid of this ad group was applied to all criteria under the ad group.
		/// Criteria with bid overrides are <em>included</em>, but the overrides on these criteria
		/// were ignored when generating the landscape.
		/// </summary>
		Uniform,
		/// <summary>
		/// Signifies that the bid of this ad group was only applied to the ad group itself.
		/// Criteria with bid overrides are <em>excluded</em>.
		/// </summary>
		Default,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum AdGroupCriterionErrorReason
	{
		/// <summary>
		/// No link found between the AdGroupCriterion and the label.
		/// </summary>
		AdGroupCriterionLabelDoesNotExist,
		/// <summary>
		/// The label has already been attached to the AdGroupCriterion.
		/// </summary>
		AdGroupCriterionLabelAlreadyExists,
		/// <summary>
		/// Negative AdGroupCriterion cannot have labels.
		/// </summary>
		CannotAddLabelToNegativeCriterion,
		/// <summary>
		/// Too many operations for a single call.
		/// </summary>
		TooManyOperations,
		/// <summary>
		/// Negative ad group criteria are not updateable.
		/// </summary>
		CantUpdateNegative,
		/// <summary>
		/// Concrete type of criterion (keyword v.s. placement) is required for
		/// ADD and SET operations.
		/// </summary>
		ConcreteTypeRequired,
		/// <summary>
		/// Bid is incompatible with ad group's bidding settings.
		/// </summary>
		BidIncompatibleWithAdgroup,
		/// <summary>
		/// Cannot target and exclude the same criterion at once.
		/// </summary>
		CannotTargetAndExclude,
		/// <summary>
		/// The URL of a placement is invalid.
		/// </summary>
		IllegalUrl,
		/// <summary>
		/// Keyword text was invalid.
		/// </summary>
		InvalidKeywordText,
		/// <summary>
		/// Destination URL was invalid.
		/// </summary>
		InvalidDestinationUrl,
		/// <summary>
		/// The destination url must contain at least one tag (e.g. {lpurl})
		/// </summary>
		MissingDestinationUrlTag,
		/// <summary>
		/// Keyword-level cpm bid is not supported
		/// </summary>
		KeywordLevelBidNotSupportedForManualcpm,
		/// <summary>
		/// For example, cannot add a biddable ad group criterion that had been removed.
		/// </summary>
		InvalidUserStatus,
		/// <summary>
		/// Criteria type cannot be targeted for the ad group. Either the account
		/// is restricted to keywords only, the criteria type is incompatible
		/// with the campaign's bidding strategy, or the criteria type can only
		/// be applied to campaigns.
		/// </summary>
		CannotAddCriteriaType,
		/// <summary>
		/// Criteria type cannot be excluded for the ad group. Refer to the
		/// documentation for a specific criterion to check if it is excludable.
		/// </summary>
		CannotExcludeCriteriaType,
		/// <summary>
		/// Ad group is invalid due to the product partitions it contains.
		/// </summary>
		InvalidProductPartitionHierarchy,
		/// <summary>
		/// Product partition unit cannot have children.
		/// </summary>
		ProductPartitionUnitCannotHaveChildren,
		/// <summary>
		/// Subdivided product partitions must have an "others" case.
		/// </summary>
		ProductPartitionSubdivisionRequiresOthersCase,
		/// <summary>
		/// Dimension type of product partition must be the same as that of its siblings.
		/// </summary>
		ProductPartitionRequiresSameDimensionTypeAsSiblings,
		/// <summary>
		/// Product partition cannot be added to the ad group because it already exists.
		/// </summary>
		ProductPartitionAlreadyExists,
		/// <summary>
		/// Product partition referenced in the operation was not found in the ad group.
		/// </summary>
		ProductPartitionDoesNotExist,
		/// <summary>
		/// Recursive removal failed because product partition subdivision is being created or modified
		/// in this request.
		/// </summary>
		ProductPartitionCannotBeRemoved,
		/// <summary>
		/// Product partition type is not allowed for specified AdGroupCriterion type.
		/// </summary>
		InvalidProductPartitionType,
		/// <summary>
		/// Product partition in an ADD operation specifies a non temporary CriterionId.
		/// </summary>
		ProductPartitionAddMayOnlyUseTempId,
		/// <summary>
		/// Partial failure is not supported for shopping campaign mutate operations.
		/// </summary>
		CampaignTypeNotCompatibleWithPartialFailure,
		/// <summary>
		/// Operations in the mutate request changes too many shopping ad groups. Please split
		/// requests for multiple shopping ad groups across multiple requests.
		/// </summary>
		OperationsForTooManyShoppingAdgroups,
		/// <summary>
		/// Not allowed to modify url fields of an ad group criterion if there are duplicate elements
		/// for that ad group criterion in the request.
		/// </summary>
		CannotModifyUrlFieldsWithDuplicateElements,
		/// <summary>
		/// Cannot set url fields without also setting final urls.
		/// </summary>
		CannotSetWithoutFinalUrls,
		/// <summary>
		/// Cannot clear final urls if final mobile urls exist.
		/// </summary>
		CannotClearFinalUrlsIfFinalMobileUrlsExist,
		/// <summary>
		/// Cannot clear final urls if final app urls exist.
		/// </summary>
		CannotClearFinalUrlsIfFinalAppUrlsExist,
		/// <summary>
		/// Cannot clear final urls if tracking url template exists.
		/// </summary>
		CannotClearFinalUrlsIfTrackingUrlTemplateExists,
		/// <summary>
		/// Cannot clear final urls if url custom parameters exist.
		/// </summary>
		CannotClearFinalUrlsIfUrlCustomParametersExist,
		/// <summary>
		/// Cannot set both destination url and final urls.
		/// </summary>
		CannotSetBothDestinationUrlAndFinalUrls,
		/// <summary>
		/// Cannot set both destination url and tracking url template.
		/// </summary>
		CannotSetBothDestinationUrlAndTrackingUrlTemplate,
		/// <summary>
		/// Final urls are not supported for this criterion type.
		/// </summary>
		FinalUrlsNotSupportedForCriterionType,
		/// <summary>
		/// Final mobile urls are not supported for this criterion type.
		/// </summary>
		FinalMobileUrlsNotSupportedForCriterionType,
		Unknown
	}
	
	/// <summary>
	/// The entity type that exceeded the limit.
	/// </summary>
	public enum AdGroupCriterionLimitExceededCriteriaLimitType
	{
		AdgroupKeyword,
		AdgroupWebsite,
		AdgroupCriterion,
		Unknown
	}
	
	/// <summary>
	/// Error reasons.
	/// </summary>
	public enum AdGroupFeedErrorReason
	{
		/// <summary>
		/// An active feed already exists for this adgroup and place holder type.
		/// </summary>
		FeedAlreadyExistsForPlaceholderType,
		/// <summary>
		/// The specified id does not exist.
		/// </summary>
		InvalidId,
		/// <summary>
		/// The specified feed is deleted.
		/// </summary>
		CannotAddForDeletedFeed,
		/// <summary>
		/// The AdGroupFeed already exists. SET should be used to modify the existing AdGroupFeed.
		/// </summary>
		CannotAddAlreadyExistingAdgroupFeed,
		/// <summary>
		/// Cannot operate on removed adgroup feed.
		/// </summary>
		CannotOperateOnRemovedAdgroupFeed,
		/// <summary>
		/// Invalid placeholder type ids.
		/// </summary>
		InvalidPlaceholderTypes,
		/// <summary>
		/// Feed mapping for this placeholder type does not exist.
		/// </summary>
		MissingFeedmappingForPlaceholderType,
		/// <summary>
		/// Location AdGroupFeeds cannot be created unless there is a location CustomerFeed
		/// for the specified feed.
		/// </summary>
		NoExistingLocationCustomerFeed,
		Unknown
	}
	
	/// <summary>
	/// Status of the AdGroupFeed.
	/// </summary>
	public enum AdGroupFeedStatus
	{
		/// <summary>
		/// This AdGroupFeed's data is currently being used.
		/// </summary>
		Enabled,
		/// <summary>
		/// This AdGroupFeed's data is not used anymore.
		/// </summary>
		Removed,
		/// <summary>
		/// Unknown status.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The reasons for the adgroup service error.
	/// </summary>
	public enum AdGroupServiceErrorReason
	{
		/// <summary>
		/// AdGroup with the same name already exists for the campaign.
		/// </summary>
		DuplicateAdgroupName,
		/// <summary>
		/// AdGroup name is not valid.
		/// </summary>
		InvalidAdgroupName,
		/// <summary>
		/// Cannot remove an adgroup, adgroup status can be marked removed
		/// using set operator.
		/// </summary>
		UseSetOperatorAndMarkStatusToRemoved,
		/// <summary>
		/// Advertiser is not allowed to target sites or set site bids that are
		/// not on the Google Search Network.
		/// </summary>
		AdvertiserNotOnContentNetwork,
		/// <summary>
		/// Bid amount is too big.
		/// </summary>
		BidTooBig,
		/// <summary>
		/// AdGroup bid does not match the campaign's bidding strategy.
		/// </summary>
		BidTypeAndBiddingStrategyMismatch,
		/// <summary>
		/// AdGroup name is required for Add.
		/// </summary>
		MissingAdgroupName,
		/// <summary>
		/// No link found between the ad group and the label.
		/// </summary>
		AdgroupLabelDoesNotExist,
		/// <summary>
		/// The label has already been attached to the ad group.
		/// </summary>
		AdgroupLabelAlreadyExists,
		/// <summary>
		/// The CriterionTypeGroup is not supported for the content bid dimension.
		/// </summary>
		InvalidContentBidCriterionTypeGroup
	}
	
	/// <summary>
	/// Status of this ad group.
	/// </summary>
	public enum AdGroupStatus
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Active.
		/// </summary>
		Enabled,
		/// <summary>
		/// Paused.
		/// </summary>
		Paused,
		/// <summary>
		/// Removed.
		/// </summary>
		Removed
	}
	
	public enum AdParamErrorReason
	{
		/// <summary>
		/// The same ad param cannot be specified in multiple operations
		/// </summary>
		AdParamCannotBeSpecifiedMultipleTimes,
		/// <summary>
		/// Specified AdParam does not exist
		/// </summary>
		AdParamDoesNotExist,
		/// <summary>
		/// Specified criterion is not a keyword
		/// </summary>
		CriterionSpecifiedMustBeKeyword,
		/// <summary>
		/// The (AdGroupId,CriterionId) is invalid
		/// </summary>
		InvalidAdgroupCriterionSpecified,
		/// <summary>
		/// The insertion text is invalid
		/// </summary>
		InvalidInsertionTextFormat,
		/// <summary>
		/// Must specify AdGroupId in selector
		/// </summary>
		MustSpecifyAdgroupId,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Ad serving status of campaign.
	/// </summary>
	public enum AdServingOptimizationStatus
	{
		/// <summary>
		/// Ad serving is optimized based on CTR for the campaign.
		/// </summary>
		Optimize,
		/// <summary>
		/// Ad serving is optimized based on CTR * Conversion for the campaign. If the campaign is not in
		/// the conversion optimizer bidding strategy, it will default to OPTIMIZED.
		/// </summary>
		ConversionOptimize,
		/// <summary>
		/// Ads are rotated evenly for 90 days, then optimized for clicks.
		/// </summary>
		Rotate,
		/// <summary>
		/// Show lower performing ads more evenly with higher performing ads, and do not optimize.
		/// </summary>
		RotateIndefinitely,
		/// <summary>
		/// Ad serving optimization status is not available.
		/// </summary>
		Unavailable,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The types of ads.
	/// </summary>
	public enum AdType
	{
		DeprecatedAd,
		ImageAd,
		ProductAd,
		TemplateAd,
		TextAd,
		ThirdPartyRedirectAd,
		DynamicSearchAd,
		CallOnlyAd,
		ExpandedTextAd,
		ResponsiveDisplayAd,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// A non-mutable specialization of an Advertising Channel.
	/// </summary>
	public enum AdvertisingChannelSubType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Mobile App Campaigns for Search
		/// </summary>
		SearchMobileApp,
		/// <summary>
		/// Mobile App Campaigns for Display
		/// </summary>
		DisplayMobileApp,
		/// <summary>
		/// AdWords Express campaigns for search.
		/// </summary>
		SearchExpress,
		/// <summary>
		/// AdWords Express campaigns for display.
		/// </summary>
		DisplayExpress,
		/// <summary>
		/// Campaigns specialized for advertising mobile app installations, that targets
		/// multiple advertising channels across search, display and youtube.  Google
		/// manages the keywords and ads for these campaigns.
		/// </summary>
		UniversalAppCampaign
	}
	
	/// <summary>
	/// The channel type a campaign may target to serve on.
	/// </summary>
	public enum AdvertisingChannelType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Search Network. Includes display bundled, and Search+ campaigns.
		/// </summary>
		Search,
		/// <summary>
		/// Google Display Network only.
		/// </summary>
		Display,
		/// <summary>
		/// Shopping campaigns serve on the shopping property and on google.com search
		/// results.
		/// </summary>
		Shopping,
		/// <summary>
		/// Universal app campaigns that target multiple channels across search, display,
		/// youtube, etc.
		/// </summary>
		MultiChannel
	}
	
	/// <summary>
	/// Text format to display on the conversion page.
	/// </summary>
	public enum AdWordsConversionTrackerTextFormat
	{
		/// <summary>
		/// The text will be displayed on one line.
		/// </summary>
		OneLine,
		/// <summary>
		/// The text will be displayed on two lines.
		/// </summary>
		TwoLine,
		/// <summary>
		/// The text will be hidden.
		/// </summary>
		Hidden
	}
	
	/// <summary>
	/// Type of snippet code to generate.
	/// </summary>
	public enum AdWordsConversionTrackerTrackingCodeType
	{
		/// <summary>
		/// The snippet that is fired as a result of a website page loading.
		/// </summary>
		Webpage,
		/// <summary>
		/// The snippet contains a JavaScript function which fires the tag. This function is typically
		/// called from an onClick handler added to a link or button element on the page.
		/// </summary>
		WebpageOnclick,
		/// <summary>
		/// For embedding on a (mobile) webpage. The snippet contains a JavaScript function which fires
		/// the tag. This function is typically called from an onClick handler added to a link or button
		/// element on the page that also instructs a mobile device to dial the advertiser's phone
		/// number.
		/// </summary>
		ClickToCall
	}
	
	/// <summary>
	/// The reasons for the AdX error.
	/// </summary>
	public enum AdxErrorReason
	{
		/// <summary>
		/// Attempt to use non-AdX feature by AdX customer.
		/// </summary>
		UnsupportedFeature
	}
	
	public enum AgeRangeAgeRangeType
	{
		AgeRange1824,
		AgeRange2534,
		AgeRange3544,
		AgeRange4554,
		AgeRange5564,
		AgeRange65Up,
		AgeRangeUndetermined,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	public enum AppConversionAppConversionType
	{
		None,
		Download,
		InAppPurchase,
		FirstOpen
	}
	
	/// <summary>
	/// App platform for the AppConversionTracker.
	/// </summary>
	public enum AppConversionAppPlatform
	{
		None,
		Itunes,
		AndroidMarket,
		MobileAppChannel
	}
	
	/// <summary>
	/// The available application stores for app extensions.
	/// </summary>
	public enum AppFeedItemAppStore
	{
		AppleItunes,
		GooglePlay,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The possible types of App Payment Model.
	/// </summary>
	public enum AppPaymentModelAppPaymentModelType
	{
		/// <summary>
		/// Represents paid-for apps.
		/// </summary>
		AppPaymentModelPaid,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	public enum AppPostbackUrlErrorReason
	{
		/// <summary>
		/// Invalid Url format.
		/// </summary>
		InvalidUrlFormat,
		/// <summary>
		/// Invalid domain.
		/// </summary>
		InvalidDomain,
		/// <summary>
		/// Some of the required macros were not found.
		/// </summary>
		RequiredMacroNotFound
	}
	
	/// <summary>
	/// Approval status for the criterion.
	/// Note: there are more states involved but we only expose two to users.
	/// </summary>
	public enum ApprovalStatus
	{
		/// <summary>
		/// Criterion with no reportable policy problems.
		/// </summary>
		Approved,
		/// <summary>
		/// Criterion that is yet to be reviewed.
		/// </summary>
		PendingReview,
		/// <summary>
		/// Criterion that is under review.
		/// </summary>
		UnderReview,
		/// <summary>
		/// Criterion disapproved due to policy violation.
		/// </summary>
		Disapproved
	}
	
	/// <summary>
	/// The possible os types for an AppUrl
	/// </summary>
	public enum AppUrlOsType
	{
		/// <summary>
		/// The Apple IOS operating system,
		/// </summary>
		OsTypeIos,
		/// <summary>
		/// The Android operating system.
		/// </summary>
		OsTypeAndroid,
		Unknown
	}
	
	/// <summary>
	/// Represents the type of {@link Attribute}.
	/// <p><b>{@link IdeaType} KEYWORD supports the following {@link AttributeType}s:</b><br/>
	/// <ul><li>{@link #AVERAGE_CPC}</li>
	/// <li>{@link #CATEGORY_PRODUCTS_AND_SERVICES}</li>
	/// <li>{@link #COMPETITION}</li>
	/// <li>{@link #EXTRACTED_FROM_WEBPAGE}</li>
	/// <li>{@link #IDEA_TYPE}</li>
	/// <li>{@link #KEYWORD_TEXT}</li>
	/// <li>{@link #SEARCH_VOLUME}</li>
	/// <li>{@link #TARGETED_MONTHLY_SEARCHES}</li>
	/// </ul>
	/// </summary>
	public enum AttributeType
	{
		/// <summary>
		/// Value substituted in when the actual value is not available in the Web API
		/// version being used.  (Please upgrade to the latest published WSDL.)
		/// <p>This element is not supported directly by any {@link IdeaType}.
		/// </summary>
		Unknown,
		/// <summary>
		/// Represents a category ID in the "Products and Services" taxonomy.
		///
		/// <p>Resulting attribute is {@link IntegerSetAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		CategoryProductsAndServices,
		/// <summary>
		/// Represents the relative amount of competition associated with the given keyword idea,
		/// relative to other keywords. This value will be between 0 and 1 (inclusive).
		///
		/// <p>Resulting attribute is {@link DoubleAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		Competition,
		/// <summary>
		/// Represents the webpage from which this keyword idea was extracted (if applicable.)
		///
		/// <p>Resulting attribute is {@link WebpageDescriptorAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		ExtractedFromWebpage,
		/// <summary>
		/// Represents the type of the given idea.
		///
		/// <p>Resulting attribute is {@link IdeaTypeAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		IdeaType,
		/// <summary>
		/// Represents the keyword text for the given keyword idea.
		///
		/// <p>Resulting attribute is {@link StringAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		KeywordText,
		/// <summary>
		/// Represents either the (approximate) number of searches for the given keyword idea on google.com
		/// or google.com and partners, depending on the user's targeting.
		///
		/// <p>Resulting attribute is {@link LongAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		SearchVolume,
		/// <summary>
		/// Represents the average cost per click historically paid for the keyword.
		///
		/// <p>Resulting attribute is {@link MoneyAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		AverageCpc,
		/// <summary>
		/// Represents the (approximated) number of searches on this keyword idea (as available for the
		/// past twelve months), targeted to the specified geographies.
		///
		/// <p>Resulting attribute is {@link MonthlySearchVolumeAttribute}.
		/// <p>This element is supported by following {@link IdeaType}s: KEYWORD.
		/// </summary>
		TargetedMonthlySearches
	}
	
	/// <summary>
	/// Attribution models describing how to distribute credit for a particular
	/// conversion across potentially many prior interactions. See
	/// https://support.google.com/adwords/answer/6259715 for more information about
	/// attribution modeling in AdWords.
	/// </summary>
	public enum AttributionModelType
	{
		Unknown,
		/// <summary>
		/// Attributes all credit for a conversion to its last click.
		/// </summary>
		LastClick,
		/// <summary>
		/// Attributes all credit for a conversion to its first click.
		/// </summary>
		FirstClick,
		/// <summary>
		/// Attributes credit for a conversion equally across all of its clicks.
		/// </summary>
		Linear,
		/// <summary>
		/// Attributes exponentially more credit for a conversion to its more recent clicks
		/// (half-life is 1 week).
		/// </summary>
		TimeDecay,
		/// <summary>
		/// Attributes 40% of the credit for a conversion to its first and last clicks.
		/// Remaining 20% is evenly distributed across all other clicks.
		/// </summary>
		UShaped,
		/// <summary>
		/// Flexible model that uses machine learning to determine the appropriate
		/// distribution of credit among clicks.
		/// </summary>
		DataDriven
	}
	
	public enum AudioErrorReason
	{
		InvalidAudio,
		ProblemReadingAudioFile,
		ErrorStoringAudio,
		FileTooLarge,
		UnsupportedAudio,
		ErrorGeneratingStreamingUrl
	}
	
	/// <summary>
	/// The single reason for the authentication failure.
	/// </summary>
	public enum AuthenticationErrorReason
	{
		/// <summary>
		/// Authentication of the request failed.
		/// </summary>
		AuthenticationFailed,
		/// <summary>
		/// Client Customer Id is required if CustomerIdMode is set to CLIENT_EXTERNAL_CUSTOMER_ID.
		/// Starting version V201409 ClientCustomerId will be required for all requests except
		/// for {@link CustomerService#get}
		/// </summary>
		ClientCustomerIdIsRequired,
		/// <summary>
		/// Client Email is required if CustomerIdMode is set to CLIENT_EXTERNAL_EMAIL_FIELD.
		/// </summary>
		ClientEmailRequired,
		/// <summary>
		/// Client customer Id is not a number.
		/// </summary>
		ClientCustomerIdInvalid,
		/// <summary>
		/// Client customer Id is not a number.
		/// </summary>
		ClientEmailInvalid,
		/// <summary>
		/// Client email is not a valid customer email.
		/// </summary>
		ClientEmailFailedToAuthenticate,
		/// <summary>
		/// No customer found for the customer id provided in the header.
		/// </summary>
		CustomerNotFound,
		/// <summary>
		/// Client's Google Account is deleted.
		/// </summary>
		GoogleAccountDeleted,
		/// <summary>
		/// Google account login token in the cookie is invalid.
		/// </summary>
		GoogleAccountCookieInvalid,
		/// <summary>
		/// problem occurred during Google account authentication.
		/// </summary>
		FailedToAuthenticateGoogleAccount,
		/// <summary>
		/// The user in the google account login token does not match the UserId in the cookie.
		/// </summary>
		GoogleAccountUserAndAdsUserMismatch,
		/// <summary>
		/// Login cookie is required for authentication.
		/// </summary>
		LoginCookieRequired,
		/// <summary>
		/// User in the cookie is not a valid Ads user.
		/// </summary>
		NotAdsUser,
		/// <summary>
		/// Oauth token in the header is not valid.
		/// </summary>
		OauthTokenInvalid,
		/// <summary>
		/// Oauth token in the header has expired.
		/// </summary>
		OauthTokenExpired,
		/// <summary>
		/// Oauth token in the header has been disabled.
		/// </summary>
		OauthTokenDisabled,
		/// <summary>
		/// Oauth token in the header has been revoked.
		/// </summary>
		OauthTokenRevoked,
		/// <summary>
		/// Oauth token HTTP header is malformed.
		/// </summary>
		OauthTokenHeaderInvalid,
		/// <summary>
		/// Login cookie is not valid.
		/// </summary>
		LoginCookieInvalid,
		/// <summary>
		/// Failed to decrypt the login cookie.
		/// </summary>
		FailedToRetrieveLoginCookie,
		/// <summary>
		/// User Id in the header is not a valid id.
		/// </summary>
		UserIdInvalid
	}
	
	/// <summary>
	/// The reasons for the database error.
	/// </summary>
	public enum AuthorizationErrorReason
	{
		/// <summary>
		/// Could not complete authorization due to an internal problem.
		/// </summary>
		UnableToAuthorize,
		/// <summary>
		/// Customer has no AdWords account.
		/// </summary>
		NoAdwordsAccountForCustomer,
		/// <summary>
		/// User doesn't have permission to access customer.
		/// </summary>
		UserPermissionDenied,
		/// <summary>
		/// Effective user doesn't have permission to access this customer.
		/// </summary>
		EffectiveUserPermissionDenied,
		/// <summary>
		/// User has read-only permission cannot mutate.
		/// </summary>
		UserHasReadonlyPermission,
		/// <summary>
		/// No customer found.
		/// </summary>
		NoCustomerFound,
		/// <summary>
		/// Developer doesn't have permission to access service.
		/// </summary>
		ServiceAccessDenied
	}
	
	/// <summary>
	/// The reason for the error.
	/// </summary>
	public enum BatchJobErrorReason
	{
		Unknown,
		/// <summary>
		/// The user exceeded allowed disk quota for in-flight jobs.
		/// </summary>
		DiskQuotaExceeded,
		/// <summary>
		/// An internal error resulted in a failure to create the job.
		/// </summary>
		FailedToCreateJob,
		/// <summary>
		/// The requested state change was invalid.
		/// </summary>
		InvalidStateChange
	}
	
	/// <summary>
	/// The reason for the error.
	/// </summary>
	public enum BatchJobProcessingErrorReason
	{
		Unknown,
		/// <summary>
		/// The input file was corrupted.
		/// </summary>
		InputFileCorruption,
		/// <summary>
		/// An internal API error occurred while processing the batch.
		/// </summary>
		InternalError,
		/// <summary>
		/// Unable to complete a batch in the allotted time.
		/// </summary>
		DeadlineExceeded,
		/// <summary>
		/// The input file had a format error.
		/// </summary>
		FileFormatError
	}
	
	/// <summary>
	/// The current status of a BatchJob.
	/// </summary>
	public enum BatchJobStatus
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Initial state of a BatchJob. While a job has this status, it is awaiting a file
		/// upload to Google Cloud Storage.
		/// </summary>
		AwaitingFile,
		/// <summary>
		/// Indicates that a job has an associated file and is being executed.
		/// </summary>
		Active,
		/// <summary>
		/// Indicates that a job is being canceled. It will remain in this status until any
		/// partial results are written, and then will be marked CANCELED. Send this status
		/// in a SET operation to cancel a job that is in progress. This is the only status
		/// that can be explicitly set.
		/// </summary>
		Canceling,
		/// <summary>
		/// Indicates that a job has been canceled. It will be garbage-collected 30 days
		/// after cancellation.
		/// </summary>
		Canceled,
		/// <summary>
		/// Indicates that a job has completed. It will be garbage-collected 30 days after
		/// completion.
		/// </summary>
		Done
	}
	
	public enum BiddingErrorsReason
	{
		/// <summary>
		/// Cannot transition to new bidding strategy.
		/// </summary>
		BiddingStrategyTransitionNotAllowed,
		/// <summary>
		/// Bidding strategy cannot be overridden by current ad group bidding strategy.
		/// </summary>
		BiddingStrategyNotCompatibleWithAdgroupOverrides,
		/// <summary>
		/// Bidding strategy cannot be overridden by current criteria bidding strategy.
		/// </summary>
		BiddingStrategyNotCompatibleWithAdgroupCriteriaOverrides,
		/// <summary>
		/// Cannot override campaign bidding strategy.
		/// </summary>
		CampaignBiddingStrategyCannotBeOverridden,
		/// <summary>
		/// Cannot override ad group bidding strategy.
		/// </summary>
		AdgroupBiddingStrategyCannotBeOverridden,
		/// <summary>
		/// Cannot attach bidding strategy to campaign.
		/// </summary>
		CannotAttachBiddingStrategyToCampaign,
		/// <summary>
		/// Cannot attach bidding strategy to ad group.
		/// </summary>
		CannotAttachBiddingStrategyToAdgroup,
		/// <summary>
		/// Cannot attach bidding strategy to criteria.
		/// </summary>
		CannotAttachBiddingStrategyToAdgroupCriteria,
		/// <summary>
		/// Bidding strategy is not supported or cannot be used as anonymous.
		/// </summary>
		InvalidAnonymousBiddingStrategyType,
		/// <summary>
		/// No bids may be set. The bid list must be null or empty.
		/// </summary>
		BidsNotAlllowed,
		/// <summary>
		/// The bid list contains two or more bids of the same type.
		/// </summary>
		DuplicateBids,
		/// <summary>
		/// The bidding scheme does not match the bidding strategy type.
		/// </summary>
		InvalidBiddingScheme,
		/// <summary>
		/// The type does not match the named strategy's type.
		/// </summary>
		InvalidBiddingStrategyType,
		/// <summary>
		/// The bidding strategy type is missing.
		/// </summary>
		MissingBiddingStrategyType,
		/// <summary>
		/// The bid list contains a null entry.
		/// </summary>
		NullBid,
		/// <summary>
		/// The bid is invalid.
		/// </summary>
		InvalidBid,
		/// <summary>
		/// Bidding strategy is not available for the account type.
		/// </summary>
		BiddingStrategyNotAvailableForAccountType,
		/// <summary>
		/// Conversion tracking is not enabled for the campaign for VBB transition.
		/// </summary>
		ConversionTrackingNotEnabled,
		/// <summary>
		/// Not enough conversions tracked for VBB transitions.
		/// </summary>
		NotEnoughConversions,
		/// <summary>
		/// Campaign can not be created with given bidding strategy. It can be transitioned to the
		/// strategy, once eligible.
		/// </summary>
		CannotCreateCampaignWithBiddingStrategy,
		/// <summary>
		/// Cannot target content network only as ad group uses Page One Promoted bidding strategy.
		/// </summary>
		CannotTargetContentNetworkOnlyWithAdGroupLevelPopBiddingStrategy,
		/// <summary>
		/// Cannot target content network only as campaign uses Page One Promoted bidding strategy.
		/// </summary>
		CannotTargetContentNetworkOnlyWithCampaignLevelPopBiddingStrategy,
		/// <summary>
		/// Budget Optimizer and Target Spend bidding strategies are not supported for campaigns with
		/// AdSchedule targeting.
		/// </summary>
		BiddingStrategyNotSupportedWithAdSchedule,
		/// <summary>
		/// Pay per conversion is not available to all the customer, only few whitelisted customers
		/// can use this.
		/// </summary>
		PayPerConversionNotAvailableForCustomer,
		/// <summary>
		/// Pay per conversion is not allowed with Target CPA.
		/// </summary>
		PayPerConversionNotAllowedWithTargetCpa,
		/// <summary>
		/// Cannot set bidding strategy to Manual CPM for search network only campaigns.
		/// </summary>
		BiddingStrategyNotAllowedForSearchOnlyCampaigns,
		/// <summary>
		/// The bidding strategy is not supported for use in drafts or experiments.
		/// </summary>
		BiddingStrategyNotSupportedInDraftsOrExperiments,
		/// <summary>
		/// Bidding strategy type does not support product type ad group criterion.
		/// </summary>
		BiddingStrategyTypeDoesNotSupportProductTypeAdgroupCriterion,
		/// <summary>
		/// Bid amount is too small.
		/// </summary>
		BidTooSmall,
		/// <summary>
		/// Bid amount is too big.
		/// </summary>
		BidTooBig,
		/// <summary>
		/// Bid has too many fractional digit precision.
		/// </summary>
		BidTooManyFractionalDigits,
		Unknown
	}
	
	public enum BiddingStrategyErrorReason
	{
		/// <summary>
		/// Each bidding strategy must have a unique name.
		/// </summary>
		DuplicateName,
		/// <summary>
		/// Bidding strategy type is immutable.
		/// </summary>
		CannotChangeBiddingStrategyType,
		/// <summary>
		/// Only bidding strategies not linked to campaigns, adgroups or adgroup criteria can be
		/// removed.
		/// </summary>
		CannotRemoveAssociatedStrategy,
		/// <summary>
		/// The specified bidding strategy is not supported.
		/// </summary>
		BiddingStrategyNotSupported,
		Unknown
	}
	
	/// <summary>
	/// Indicates where bidding strategy came from: campaign, adgroup or criterion.
	/// </summary>
	public enum BiddingStrategySource
	{
		/// <summary>
		/// Bidding strategy is defined on campaign level.
		/// </summary>
		Campaign,
		/// <summary>
		/// Bidding strategy is defined on adgroup level.
		/// </summary>
		Adgroup,
		/// <summary>
		/// Bidding strategy is defined on criterion level.
		/// </summary>
		Criterion
	}
	
	/// <summary>
	/// The status of the bid strategy, with respect to circumstances that could affect
	/// the automation system.
	/// </summary>
	public enum BiddingStrategySystemStatus
	{
		Unknown,
		/// <summary>
		/// The bid strategy is active, and AdWords cannot find any specific issues with the
		/// strategy.
		/// </summary>
		Unconstrained,
		/// <summary>
		/// The bid strategy is learning because it has been recently created or recently
		/// reactivated.
		/// </summary>
		LearningNew,
		/// <summary>
		/// The bid strategy is learning because of a recent setting change.
		/// </summary>
		LearningSettingChange,
		/// <summary>
		/// The bid strategy is learning because of a recent budget change.
		/// </summary>
		LearningBudgetChange,
		/// <summary>
		/// The bid strategy is learning because of recent change in number of campaigns, ad
		/// groups or keywords attached to it.
		/// </summary>
		LearningCompositionChange,
		/// <summary>
		/// The bid strategy depends on conversion reporting and the customer recently
		/// modified conversion types that were relevant to the bid strategy.
		/// </summary>
		LearningConversionTypeChange,
		/// <summary>
		/// The bid strategy depends on conversion reporting and the customer recently
		/// changed their conversion settings.
		/// </summary>
		LearningConversionSettingChange,
		/// <summary>
		/// The bid strategy is limited by its bid constraints (bid floor, ceiling, or
		/// both). Deprecated for the specific LIMITED_BY_*_LIMIT statuses.
		/// </summary>
		LimitedByBidConstraints,
		/// <summary>
		/// The bid strategy is limited by its bid ceiling.
		/// </summary>
		LimitedByMaxBidLimit,
		/// <summary>
		/// The bid strategy is limited by its bid floor.
		/// </summary>
		LimitedByMinBidLimit,
		/// <summary>
		/// The bid strategy is limited by its ROAS floor.
		/// </summary>
		LimitedByMinRoasLimit,
		/// <summary>
		/// The bid strategy is limited because there was not enough conversion traffic over
		/// the past weeks.
		/// </summary>
		LimitedByData,
		/// <summary>
		/// A significant fraction of keywords in this bid strategy are limited by budget.
		/// </summary>
		LimitedByBudget,
		/// <summary>
		/// The bid strategy cannot reach its target spend because its spend has been
		/// de-prioritized.
		/// </summary>
		LimitedByLowPrioritySpend,
		/// <summary>
		/// A significant fraction of keywords in this bid strategy have a low Quality
		/// Score.
		/// </summary>
		LimitedByLowQuality,
		/// <summary>
		/// The bid strategy depends on conversion reporting and the customer is lacking
		/// conversion types that might be reported against this strategy.
		/// </summary>
		MisconfiguredConversionTypes,
		/// <summary>
		/// The bid strategy depends on conversion reporting and the customer's conversion
		/// settings are misconfigured.
		/// </summary>
		MisconfiguredConversionSettings,
		/// <summary>
		/// The bid strategy is not active. Either there are no active campaigns, ad groups
		/// or keywords attached to the bid strategy. Or there are no active budgets
		/// connected to the bid strategy.
		/// </summary>
		Inactive,
		/// <summary>
		/// The system status is not currently available for this bid strategy.
		/// </summary>
		Unavailable,
		/// <summary>
		/// There were multiple LEARNING_* statuses for this bid strategy during the time in
		/// question.
		/// </summary>
		MultipleLearning,
		/// <summary>
		/// There were multiple LIMITED_* statuses for this bid strategy during the time in
		/// question.
		/// </summary>
		MultipleLimited,
		/// <summary>
		/// There were multiple MISCONFIGURED_* system statuses for this bid strategy during
		/// the time in question.
		/// </summary>
		MultipleMisconfigured,
		/// <summary>
		/// There were multiple system statuses for this bid strategy during the time in
		/// question.
		/// </summary>
		Multiple
	}
	
	/// <summary>
	/// The bidding strategy type. See {@linkplain BiddingStrategyConfiguration}
	/// for additional information.
	/// </summary>
	public enum BiddingStrategyType
	{
		/// <summary>
		/// Replaced by TARGET_SPEND. Kept only for legacy support.
		/// </summary>
		BudgetOptimizer,
		/// <summary>
		/// Replaced by TARGET_CPA. Kept only for legacy support.
		/// </summary>
		ConversionOptimizer,
		/// <summary>
		/// Manual click based bidding where user pays per click. See
		/// {@linkplain ManualCpcBiddingScheme} for more details.
		/// </summary>
		ManualCpc,
		/// <summary>
		/// Manual impression based bidding where user pays per thousand
		/// impressions. See {@linkplain ManualCpmBiddingScheme} for more
		/// details.
		/// </summary>
		ManualCpm,
		/// <summary>
		/// Page-One Promoted is an automated bid strategy that sets max CPC bids
		/// to target impressions on page one or page one promoted slots on
		/// google.com. See {@linkplain PageOnePromotedBiddingScheme} for
		/// more details.
		/// </summary>
		PageOnePromoted,
		/// <summary>
		/// Target Spend (Maximize Clicks) is an automated bid strategy that sets
		/// your bids to help get as many clicks as possible within your budget.
		/// See {@linkplain TargetSpendBiddingScheme} for more details.
		/// </summary>
		TargetSpend,
		/// <summary>
		/// Enhanced CPC is a bidding strategy that raises your bids for clicks
		/// that seem more likely to lead to a conversion and lowers them for clicks
		/// where they seem less likely. See {@linkplain EnhancedCpcBiddingScheme}
		/// for more details.
		/// </summary>
		EnhancedCpc,
		/// <summary>
		/// Target CPA is an automated bid strategy that sets bids to help get
		/// as many conversions as possible at the target cost per acquisition
		/// (CPA) you set. See {@linkplain TargetCpaBiddingScheme}
		/// for more details.
		/// </summary>
		TargetCpa,
		/// <summary>
		/// Target ROAS is an automated bidding strategy that helps you maximize
		/// revenue while averaging a specific target Return On Average Spend (ROAS).
		/// See {@linkplain TargetRoasBiddingScheme} for more details.
		/// </summary>
		TargetRoas,
		/// <summary>
		/// Target Outrank Share is an automated bidding strategy that sets bids
		/// based on the target fraction of auctions where the advertiser should
		/// outrank a specific competitor. See {@linkplain TargetOutrankShareBiddingScheme}
		/// for more details.
		/// </summary>
		TargetOutrankShare,
		/// <summary>
		/// Special bidding strategy type used to reset the bidding strategy at AdGroup and
		/// AdGroupCriterion.
		/// </summary>
		None,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Enumerates possible sources for bid modifier.
	/// </summary>
	public enum BidModifierSource
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The bid modifier is specified at the campaign level, on the campaign level
		/// criterion.
		/// </summary>
		Campaign,
		/// <summary>
		/// The bid modifier is specified (overridden) at the ad group level.
		/// </summary>
		AdGroup
	}
	
	/// <summary>
	/// Indicate where a criterion's bid came from: criterion or the adgroup it
	/// belongs to.
	/// </summary>
	public enum BidSource
	{
		/// <summary>
		/// Effective Bid is Adgroup level bid
		/// </summary>
		Adgroup,
		/// <summary>
		/// Effective Bid is Keyword level bid
		/// </summary>
		Criterion,
		/// <summary>
		/// Effective Bid is inherited from Adgroup Bidding Strategy
		/// </summary>
		AdgroupBiddingStrategy,
		/// <summary>
		/// Effective Bid is inherited from Campaign Bidding Strategy
		/// </summary>
		CampaignBiddingStrategy
	}
	
	/// <summary>
	/// Budget delivery methods.
	/// </summary>
	public enum BudgetBudgetDeliveryMethod
	{
		/// <summary>
		/// The budget server will throttle serving evenly across the entire time period.
		/// </summary>
		Standard,
		/// <summary>
		/// The budget server will not throttle serving, and ads will serve as fast as possible.
		/// </summary>
		Accelerated,
		Unknown
	}
	
	public enum BudgetBudgetStatus
	{
		Enabled,
		Removed,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the budget error.
	/// </summary>
	public enum BudgetErrorReason
	{
		/// <summary>
		/// The requested budget no longer exists.
		/// </summary>
		BudgetRemoved,
		/// <summary>
		/// Default budget error.
		/// </summary>
		BudgetError,
		/// <summary>
		/// The budget is associated with at least one campaign, and so the budget cannot be removed.
		/// </summary>
		BudgetInUse,
		/// <summary>
		/// Customer is not whitelisted for this budget period.
		/// </summary>
		BudgetPeriodNotAvailable,
		/// <summary>
		/// Customer cannot use CampaignService to edit a shared budget.
		/// </summary>
		CannotEditSharedBudget,
		/// <summary>
		/// This field is not mutable on implicitly shared budgets
		/// </summary>
		CannotModifyFieldOfImplicitlySharedBudget,
		/// <summary>
		/// Cannot change explicitly shared budgets back to implicitly shared ones.
		/// </summary>
		CannotUpdateBudgetToImplicitlyShared,
		/// <summary>
		/// An implicit budget without a name cannot be changed to explicitly shared budget.
		/// </summary>
		CannotUpdateBudgetToExplicitlySharedWithoutName,
		/// <summary>
		/// Only explicitly shared budgets can be used with multiple campaigns.
		/// </summary>
		CannotUseImplicitlySharedBudgetWithMultipleCampaigns,
		/// <summary>
		/// A budget with this name already exists.
		/// </summary>
		DuplicateName,
		/// <summary>
		/// A money amount was not in the expected currency.
		/// </summary>
		MoneyAmountInWrongCurrency,
		/// <summary>
		/// A money amount was less than the minimum CPC for currency.
		/// </summary>
		MoneyAmountLessThanCurrencyMinimumCpc,
		/// <summary>
		/// A money amount was greater than the maximum allowed.
		/// </summary>
		MoneyAmountTooLarge,
		/// <summary>
		/// A money amount was negative.
		/// </summary>
		NegativeMoneyAmount,
		/// <summary>
		/// A money amount was not a multiple of a minimum unit.
		/// </summary>
		NonMultipleOfMinimumCurrencyUnit
	}
	
	public enum BudgetOrderErrorReason
	{
		/// <summary>
		/// Existing pending request is being approved.
		/// </summary>
		BudgetApprovalInProgress,
		/// <summary>
		/// A server backend was not available.
		/// </summary>
		ServiceUnavailable,
		/// <summary>
		/// The request contains a field that is only available if the manager account
		/// is whitelisted for new billing backend.
		/// </summary>
		FieldNotEligibleForCurrentBilling,
		/// <summary>
		/// The billing account was invalid.
		/// </summary>
		InvalidBillingAccount,
		/// <summary>
		/// Unspecified billing service error.
		/// </summary>
		GenericBillingError,
		/// <summary>
		/// The billing account ID format was invalid.
		/// </summary>
		InvalidBillingAccountIdFormat,
		/// <summary>
		/// Budget date range was invalid.
		/// </summary>
		InvalidBudgetDateRange,
		/// <summary>
		/// Customer's currency is different from what is in the billing system.
		/// </summary>
		IncompatibleCurrency,
		/// <summary>
		/// User does not have permission to update this budget.
		/// </summary>
		BudgetUpdateDenied,
		/// <summary>
		/// User attempted to cancel a started budget.
		/// </summary>
		BudgetAlreadyStarted,
		/// <summary>
		/// User attempted to change an ended budget.
		/// </summary>
		BudgetAlreadyEnded,
		/// <summary>
		/// Invalid amount, start date or end date specified.
		/// </summary>
		InvalidConstraint,
		/// <summary>
		/// The bid is too high.
		/// </summary>
		InvalidBidTooLarge,
		/// <summary>
		/// Budget was not found.
		/// </summary>
		NoSuchBudgetFound,
		/// <summary>
		/// The budget cannot be lowered below the amount which has already been spent.
		/// </summary>
		InvalidBudgetAlreadySpent,
		/// <summary>
		/// Time zone from user input is different from user's account time zone.
		/// </summary>
		InvalidTimezoneInDate,
		/// <summary>
		/// The BudgetOrder's ID was set in an add operation.
		/// </summary>
		AccountBudgetIdSetInAdd,
		/// <summary>
		/// We don't support more than one operation per mutate call.
		/// </summary>
		MoreThanOneOperations,
		/// <summary>
		/// Manager account not found.
		/// </summary>
		InvalidManagerAccount,
		Unknown
	}
	
	public enum BudgetOrderRequestStatus
	{
		/// <summary>
		/// The budget request is under review.
		/// </summary>
		UnderReview,
		/// <summary>
		/// The budget request has been approved.
		/// </summary>
		Approved,
		/// <summary>
		/// The budget request has been rejected.
		/// </summary>
		Rejected,
		/// <summary>
		/// The budget request has been cancelled.
		/// </summary>
		Cancelled,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The status of the campaign criteria.
	/// </summary>
	public enum CampaignCriterionCampaignCriterionStatus
	{
		Active,
		Removed,
		Paused
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum CampaignCriterionErrorReason
	{
		/// <summary>
		/// Concrete type of criterion (keyword v.s. placement) is required for
		/// ADD and SET operations.
		/// </summary>
		ConcreteTypeRequired,
		/// <summary>
		/// Invalid placement URL.
		/// </summary>
		InvalidPlacementUrl,
		/// <summary>
		/// Criteria type can not be excluded for the campaign by the customer.
		/// like AOL account type cannot target site type criteria
		/// </summary>
		CannotExcludeCriteriaType,
		/// <summary>
		/// Cannot set the campaign criterion status for this criteria type.
		/// </summary>
		CannotSetStatusForCriteriaType,
		/// <summary>
		/// Cannot set the campaign criterion status for an excluded criteria.
		/// </summary>
		CannotSetStatusForExcludedCriteria,
		/// <summary>
		/// Cannot target and exclude the same criterion.
		/// </summary>
		CannotTargetAndExclude,
		/// <summary>
		/// The #mutate operation contained too many operations.
		/// </summary>
		TooManyOperations,
		/// <summary>
		/// This operator cannot be applied to a criterion of this type.
		/// </summary>
		OperatorNotSupportedForCriterionType,
		/// <summary>
		/// The Shopping campaign sales country is not supported for ProductSalesChannel targeting.
		/// </summary>
		ShoppingCampaignSalesCountryNotSupportedForSalesChannel,
		Unknown,
		/// <summary>
		/// The existing field can't be updated with ADD operation. It can be updated with
		/// SET operation only.
		/// </summary>
		CannotAddExistingField
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum CampaignErrorReason
	{
		/// <summary>
		/// A complete campaign cannot go back to being incomplete
		/// </summary>
		CannotGoBackToIncomplete,
		/// <summary>
		/// Cannot target content network.
		/// </summary>
		CannotTargetContentNetwork,
		/// <summary>
		/// Cannot target search network.
		/// </summary>
		CannotTargetSearchNetwork,
		/// <summary>
		/// Cannot cover search network without google search network.
		/// </summary>
		CannotTargetSearchNetworkWithoutGoogleSearch,
		/// <summary>
		/// Cannot target Google Search network for a CPM campaign.
		/// </summary>
		CannotTargetGoogleSearchForCpmCampaign,
		/// <summary>
		/// Must target at least one network.
		/// </summary>
		CampaignMustTargetAtLeastOneNetwork,
		/// <summary>
		/// Only some Google partners are allowed to target partner search network.
		/// </summary>
		CannotTargetPartnerSearchNetwork,
		/// <summary>
		/// Cannot target content network only as campaign has criteria-level bidding strategy.
		/// </summary>
		CannotTargetContentNetworkOnlyWithCriteriaLevelBiddingStrategy,
		/// <summary>
		/// Cannot modify the start or end date such that the campaign duration would not contain the
		/// durations of all runnable trials.
		/// </summary>
		CampaignDurationMustContainAllRunnableTrials,
		/// <summary>
		/// Cannot modify dates, budget or campaign name of a trial campaign.
		/// </summary>
		CannotModifyForTrialCampaign,
		/// <summary>
		/// Trying to modify the name of an active or paused campaign, where the name is already
		/// assigned to another active or paused campaign.
		/// </summary>
		DuplicateCampaignName,
		/// <summary>
		/// Two fields are in conflicting modes.
		/// </summary>
		IncompatibleCampaignField,
		/// <summary>
		/// Campaign name cannot be used.
		/// </summary>
		InvalidCampaignName,
		/// <summary>
		/// Given status is invalid.
		/// </summary>
		InvalidAdServingOptimizationStatus,
		/// <summary>
		/// Error in the campaign level tracking url.
		/// </summary>
		InvalidTrackingUrl,
		/// <summary>
		/// Cannot set both tracking url template and tracking setting. An user has to clear legacy
		/// tracking setting in order to add tracking url template.
		/// </summary>
		CannotSetBothTrackingUrlTemplateAndTrackingSetting,
		/// <summary>
		/// The maximum number of impressions for Frequency Cap should be an integer greater than 0.
		/// </summary>
		MaxImpressionsNotInRange,
		/// <summary>
		/// Only the Day, Week and Month time units are supported.
		/// </summary>
		TimeUnitNotSupported,
		/// <summary>
		/// Operation not allowed on a campaign whose serving status has ended
		/// </summary>
		InvalidOperationIfServingStatusHasEnded,
		/// <summary>
		/// This budget is exclusively linked to a Campaign that is using @link{Experiment}s
		/// so it cannot be shared.
		/// </summary>
		BudgetCannotBeShared,
		/// <summary>
		/// Campaigns using @link{Experiment}s cannot use a shared budget.
		/// </summary>
		CampaignCannotUseSharedBudget,
		/// <summary>
		/// A different budget cannot be assigned to a campaign when there are running or scheduled
		/// trials.
		/// </summary>
		CannotChangeBudgetOnCampaignWithTrials,
		/// <summary>
		/// No link found between the campaign and the label.
		/// </summary>
		CampaignLabelDoesNotExist,
		/// <summary>
		/// The label has already been attached to the campaign.
		/// </summary>
		CampaignLabelAlreadyExists,
		/// <summary>
		/// A ShoppingSetting was not found when creating a shopping campaign.
		/// </summary>
		MissingShoppingSetting,
		/// <summary>
		/// The country in shopping setting is not an allowed country.
		/// </summary>
		InvalidShoppingSalesCountry,
		/// <summary>
		/// A Campaign with channel sub type UNIVERSAL_APP_CAMPAIGN must have a
		/// UniversalAppCampaignSetting specified.
		/// </summary>
		MissingUniversalAppCampaignSetting,
		/// <summary>
		/// The requested channel type is not available according to the customer's account setting.
		/// </summary>
		AdvertisingChannelTypeNotAvailableForAccountType,
		/// <summary>
		/// The AdvertisingChannelSubType is not a valid subtype of the primary channel type.
		/// </summary>
		InvalidAdvertisingChannelSubType,
		/// <summary>
		/// At least one conversion must be selected.
		/// </summary>
		AtLeastOneConversionMustBeSelected,
		/// <summary>
		/// Default error
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Error reasons.
	/// </summary>
	public enum CampaignFeedErrorReason
	{
		/// <summary>
		/// An active feed already exists for this campaign and place holder type.
		/// </summary>
		FeedAlreadyExistsForPlaceholderType,
		/// <summary>
		/// The specified id does not exist.
		/// </summary>
		InvalidId,
		/// <summary>
		/// The specified feed is deleted.
		/// </summary>
		CannotAddForDeletedFeed,
		/// <summary>
		/// The CampaignFeed already exists. SET should be used to modify the existing CampaignFeed.
		/// </summary>
		CannotAddAlreadyExistingCampaignFeed,
		/// <summary>
		/// Cannot operate on deleted campaign feed.
		/// </summary>
		CannotOperateOnRemovedCampaignFeed,
		/// <summary>
		/// Invalid placeholder type ids.
		/// </summary>
		InvalidPlaceholderTypes,
		/// <summary>
		/// Feed mapping for this placeholder type does not exist.
		/// </summary>
		MissingFeedmappingForPlaceholderType,
		/// <summary>
		/// Location CampaignFeeds cannot be created unless there is a location CustomerFeed
		/// for the specified feed.
		/// </summary>
		NoExistingLocationCustomerFeed,
		Unknown
	}
	
	/// <summary>
	/// Status of the CampaignFeed.
	/// </summary>
	public enum CampaignFeedStatus
	{
		/// <summary>
		/// This CampaignFeed's data is currently being used.
		/// </summary>
		Enabled,
		/// <summary>
		/// This CampaignFeed's data is not used anymore.
		/// </summary>
		Removed,
		/// <summary>
		/// Unknown status.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	public enum CampaignPreferenceErrorReason
	{
		/// <summary>
		/// A campaign cannot have two preferences with the same preference key.
		/// </summary>
		PreferenceAlreadyExists,
		/// <summary>
		/// No preference matched the given preference key.
		/// </summary>
		PreferenceNotFound,
		Unknown
	}
	
	/// <summary>
	/// Error reasons
	/// </summary>
	public enum CampaignSharedSetErrorReason
	{
		CampaignSharedSetDoesNotExist,
		SharedSetNotActive,
		Unknown
	}
	
	/// <summary>
	/// Status of association between campaign and shared set.
	/// </summary>
	public enum CampaignSharedSetStatus
	{
		Enabled,
		Removed,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Campaign status.
	/// </summary>
	public enum CampaignStatus
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Campaign is currently serving ads depending on budget information.
		/// </summary>
		Enabled,
		/// <summary>
		/// Campaign has been paused by the user.
		/// </summary>
		Paused,
		/// <summary>
		/// Campaign has been removed.
		/// </summary>
		Removed
	}
	
	/// <summary>
	/// This enum is used to indicate if this campaign is a normal campaign, a draft
	/// campaign, or a trial campaign.
	/// </summary>
	public enum CampaignTrialType
	{
		/// <summary>
		/// Invalid type. Should not be used except for detecting values that are incorrect,
		/// or values that are not yet known to the user.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// This is a regular campaign created by the advertiser.
		/// </summary>
		Base,
		/// <summary>
		/// This is a draft version of a campaign. It has some modifications from a base
		/// campaign, but it does not serve or accrue stats.
		/// </summary>
		Draft,
		/// <summary>
		/// This is a trial version of a campaign. It has some modifications from a base
		/// campaign, and a percentage of traffic is being diverted from the BASE campaign
		/// to this trial campaign.
		/// </summary>
		Trial
	}
	
	/// <summary>
	/// An enum used to classify the types of changes that have been made to an adgroup/campaign during a
	/// specified date range. This only refers to the field of the entity itself, and not its children.
	///
	/// <p>For example, if an AdGroup name changed, this status would be FIELDS_CHANGED, but if only bids
	/// on keywords belonging an AdGroup were changed this status would be FIELDS_UNCHANGED.
	/// </summary>
	public enum ChangeStatus
	{
		/// <summary>
		/// The fields of this entity have not changed, but there may still be changes to its children.
		/// </summary>
		FieldsUnchanged,
		/// <summary>
		/// The fields of this entity have changed, for example the name of an adgroup.
		/// </summary>
		FieldsChanged,
		/// <summary>
		/// This entity was created during the time frame we're looking at. We will not enumerate all of
		/// the individual changes to this entity and its children. Instead it should be loaded from the
		/// appropriate service.
		/// </summary>
		New
	}
	
	/// <summary>
	/// Enums for the various reasons an error can be thrown as a result of
	/// ClientTerms violation.
	/// </summary>
	public enum ClientTermsErrorReason
	{
		/// <summary>
		/// Customer has not agreed to the latest AdWords Terms & Conditions
		/// </summary>
		IncompleteSignupCurrentAdwordsTncNotAgreed
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum CollectionSizeErrorReason
	{
		TooFew,
		TooMany
	}
	
	/// <summary>
	/// An enumeration of possible values to be used in conjunction with the
	/// {@link CompetitionSearchParameter} to specify the granularity of
	/// competition to be filtered.
	/// </summary>
	public enum CompetitionSearchParameterLevel
	{
		/// <summary>
		/// Low - competition rate [0.0000, 0.3333]
		/// </summary>
		Low,
		/// <summary>
		/// Medium - competition rate (0.3333, 0.6667]
		/// </summary>
		Medium,
		/// <summary>
		/// High - competition rate (0.6667, 1.0000]
		/// </summary>
		High
	}
	
	/// <summary>
	/// An enumeration of possible user interest taxonomy types.
	/// </summary>
	public enum ConstantDataServiceUserInterestTaxonomyType
	{
		/// <summary>
		/// The brand for this user interest.
		/// </summary>
		Brand,
		/// <summary>
		/// The market for this user interest.
		/// </summary>
		InMarket,
		/// <summary>
		/// Users known to have installed applications in the specified categories.
		/// </summary>
		MobileAppInstallUser,
		/// <summary>
		/// The geographical location of the interest-based vertical.
		/// </summary>
		VerticalGeo,
		/// <summary>
		/// User interest criteria for new smart phone users.
		/// </summary>
		NewSmartPhoneUser
	}
	
	/// <summary>
	/// The types of constant operands.
	/// </summary>
	public enum ConstantOperandConstantType
	{
		/// <summary>
		/// Boolean constant type. booleanValue should be set for this type.
		/// </summary>
		Boolean,
		/// <summary>
		/// Double constant type. doubleValue should be set for this type.
		/// </summary>
		Double,
		/// <summary>
		/// Long constant type. longValue should be set for this type.
		/// </summary>
		Long,
		/// <summary>
		/// String constant type. stringValue should be set for this type.
		/// </summary>
		String
	}
	
	/// <summary>
	/// The units of constant operands, if applicable.
	/// </summary>
	public enum ConstantOperandUnit
	{
		/// <summary>
		/// Meters.
		/// </summary>
		Meters,
		/// <summary>
		/// Miles.
		/// </summary>
		Miles,
		None
	}
	
	/// <summary>
	/// Content label type.
	/// </summary>
	public enum ContentLabelType
	{
		/// <summary>
		/// Sexually suggestive content
		/// </summary>
		Adultish,
		/// <summary>
		/// Error pages
		/// </summary>
		Afe,
		/// <summary>
		/// Below the fold placements
		/// </summary>
		BelowTheFold,
		/// <summary>
		/// Military & international conflict
		/// </summary>
		Conflict,
		/// <summary>
		/// Parked domains
		/// </summary>
		Dp,
		/// <summary>
		/// Embedded video
		/// </summary>
		EmbeddedVideo,
		/// <summary>
		/// Games
		/// </summary>
		Games,
		/// <summary>
		/// Juvenile, gross & bizarre content
		/// </summary>
		Juvenile,
		/// <summary>
		/// Profanity & rough language
		/// </summary>
		Profanity,
		/// <summary>
		/// Forums
		/// </summary>
		UgcForums,
		/// <summary>
		/// Image-sharing pages
		/// </summary>
		UgcImages,
		/// <summary>
		/// Social networks
		/// </summary>
		UgcSocial,
		/// <summary>
		/// Video-sharing pages
		/// </summary>
		UgcVideos,
		/// <summary>
		/// Crime, police & emergency
		/// </summary>
		Sirens,
		/// <summary>
		/// Death & tragedy
		/// </summary>
		Tragedy,
		/// <summary>
		/// Video
		/// </summary>
		Video,
		/// <summary>
		/// Content rating: G
		/// </summary>
		VideoRatingDvG,
		/// <summary>
		/// Content rating: PG
		/// </summary>
		VideoRatingDvPg,
		/// <summary>
		/// Content rating: T
		/// </summary>
		VideoRatingDvT,
		/// <summary>
		/// Content rating: MA
		/// </summary>
		VideoRatingDvMa,
		/// <summary>
		/// Content rating: not yet rated
		/// </summary>
		VideoNotYetRated,
		/// <summary>
		/// Live streaming video
		/// </summary>
		LiveStreamingVideo,
		/// <summary>
		/// Allowed gambling content.
		/// </summary>
		AllowedGamblingContent,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Conversion deduplication mode for Conversion Optimizer. That is, whether to
	/// optimize for number of clicks that get at least one conversion, or total number
	/// of conversions per click.
	/// </summary>
	public enum ConversionDeduplicationMode
	{
		/// <summary>
		/// Number of clicks that get at least one conversion.
		/// </summary>
		OnePerClick,
		/// <summary>
		/// Total number of conversions per click.
		/// </summary>
		ManyPerClick
	}
	
	public enum ConversionOptimizerBiddingSchemeBidType
	{
		/// <summary>
		/// Average cost-per-acquisition (targetCPA) bid type.
		/// </summary>
		TargetCpa
	}
	
	public enum ConversionOptimizerBiddingSchemePricingMode
	{
		Clicks,
		Conversions
	}
	
	public enum ConversionOptimizerEligibilityRejectionReason
	{
		/// <summary>
		/// Campaign is not active
		/// </summary>
		CampaignIsNotActive,
		/// <summary>
		/// Conversion optimizer is available to only Manual CPC campaign
		/// </summary>
		NotCpcCampaign,
		/// <summary>
		/// Conversion tracking is not enabled for the Campaign
		/// </summary>
		ConversionTrackingNotEnabled,
		/// <summary>
		/// The campaign does not meet the requirement to have a sufficient count
		/// of conversions.
		/// </summary>
		NotEnoughConversions,
		Unknown
	}
	
	/// <summary>
	/// The category of conversion tracker that is being tracked.
	/// </summary>
	public enum ConversionTrackerCategory
	{
		Default,
		PageView,
		Purchase,
		Signup,
		Lead,
		Remarketing,
		/// <summary>
		/// Download is applicable only to {@link AppConversion} types,
		/// and is an error to use in conjunction with other types.
		/// AppConversions must use download only if they also specify
		/// {@link AppConversion#appConversionType} as DOWNLOAD or FIRST_OPEN.
		/// If any other appConversionType is used, then some other category besides
		/// DOWNLOAD must be used.
		/// </summary>
		Download
	}
	
	/// <summary>
	/// Status of the conversion tracker. The user cannot ADD or SET the
	/// status to {@code HIDDEN}.
	/// </summary>
	public enum ConversionTrackerStatus
	{
		/// <summary>
		/// Visits to the conversion page will be recorded.
		/// </summary>
		Enabled,
		/// <summary>
		/// Visits to the conversion page will not be recorded.
		/// </summary>
		Disabled,
		/// <summary>
		/// Conversions will be recorded, but the conversion tracker will not appear in the UI.
		/// </summary>
		Hidden
	}
	
	/// <summary>
	/// Enumerates all the possible reasons for a ConversionTypeError.
	/// </summary>
	public enum ConversionTrackingErrorReason
	{
		/// <summary>
		/// An attempt to make a forked conversion type from a global conversion type was made,
		/// but there already exists a conversion type forked from this global conversion type.
		/// </summary>
		AlreadyCreatedCustomConversionType,
		/// <summary>
		/// This user is not whitelisted for the import of Analytics goals and profiles, and yet
		/// requested to mutate an Analytics conversion type.
		/// </summary>
		AnalyticsNotAllowed,
		/// <summary>
		/// Cannot execute an ADD operation on this subclass of ConversionType (currently, only
		/// instances of AdWordsConversionType may be added).
		/// </summary>
		CannotAddConversionTypeSubclass,
		/// <summary>
		/// AppConversions cannot change app conversion types once it has been set.
		/// </summary>
		CannotChangeAppConversionType,
		/// <summary>
		/// AppConversions cannot change app platforms once it has been set.
		/// </summary>
		CannotChangeAppPlatform,
		/// <summary>
		/// Cannot change between subclasses of ConversionType
		/// </summary>
		CannnotChangeConversionSubclass,
		/// <summary>
		/// If a conversion type's status is initially non-hidden, it may not be changed to Hidden;
		/// nor may hidden conversion types be created through the API. Hidden conversion types are
		/// typically created by backend processes.
		/// </summary>
		CannotSetHiddenStatus,
		/// <summary>
		/// The user attempted to change the Category when it was uneditable.
		/// </summary>
		CategoryIsUneditable,
		/// <summary>
		/// The attribution model of the conversion type is uneditable.
		/// </summary>
		AttributionModelIsUneditable,
		/// <summary>
		/// The attribution model cannot be set to DATA_DRIVEN because a data-driven model has never been
		/// generated.
		/// </summary>
		DataDrivenModelWasNeverGenerated,
		/// <summary>
		/// The attribution model cannot be set to DATA_DRIVEN because the data-driven model is expired.
		/// </summary>
		DataDrivenModelIsExpired,
		/// <summary>
		/// The attribution model cannot be set to DATA_DRIVEN because the data-driven model is stale.
		/// </summary>
		DataDrivenModelIsStale,
		/// <summary>
		/// The attribution model cannot be set to DATA_DRIVEN because the data-driven model is
		/// unavailable or the conversion type was newly added.
		/// </summary>
		DataDrivenModelIsUnknown,
		/// <summary>
		/// An attempt to access a conversion type failed because no conversion type with this ID
		/// exists for this account.
		/// </summary>
		ConversionTypeNotFound,
		/// <summary>
		/// The user attempted to change the click-through conversion (ctc) lookback window when it is
		/// not editable.
		/// </summary>
		CtcLookbackWindowIsUneditable,
		/// <summary>
		/// An exception occurred in the domain layer during an attempt to process a
		/// ConversionTypeOperation.
		/// </summary>
		DomainException,
		/// <summary>
		/// An attempt was made to set a counting type inconsistent with other properties.
		/// Currently, AppConversion with appConversionType = DOWNLOAD and appPlatform = ANDROID_MARKET
		/// cannot have a countingType of MANY_PER_CLICK
		/// </summary>
		InconsistentCountingType,
		/// <summary>
		/// The user specified two identical app ids when attempting to create or modify a
		/// conversion type.
		/// </summary>
		DuplicateAppId,
		/// <summary>
		/// The user specified two identical names when attempting to create or rename multiple
		/// conversion types.
		/// </summary>
		DuplicateName,
		/// <summary>
		/// An error occurred while the server was sending the email.
		/// </summary>
		EmailFailed,
		/// <summary>
		/// The maximum number of active conversion types for this account has been exceeded.
		/// </summary>
		ExceededConversionTypeLimit,
		/// <summary>
		/// The user requested to modify an existing conversion type, but did not supply an ID.
		/// </summary>
		IdIsNull,
		/// <summary>
		/// App ids must adhere to valid Java package naming requirements.
		/// </summary>
		InvalidAppId,
		/// <summary>
		/// App id can not be set to forked system-defined Android download conversion type.
		/// </summary>
		CannotSetAppId,
		/// <summary>
		/// The user entered an invalid background color. The background color must be a valid
		/// HTML hex color code, such as "99ccff".
		/// </summary>
		InvalidColor,
		/// <summary>
		/// The date range specified in the stats selector is invalid.
		/// </summary>
		InvalidDateRange,
		/// <summary>
		/// The email address of the sender or the recipient of a snippet email was invalid.
		/// </summary>
		InvalidEmailAddress,
		/// <summary>
		/// When providing a global conversion type id to fork from in an ADD operation,
		/// the global conversion type id is not acceptable (i.e.: we don't allow this global conversion
		/// type to be forked from)
		/// </summary>
		InvalidOriginalConversionTypeId,
		/// <summary>
		/// The AppPlatform and AppConversionType must be set at the same time. It is an error to set
		/// just one or the other.
		/// </summary>
		MustSetAppPlatformAndAppConversionTypeTogether,
		/// <summary>
		/// The user attempted to create a new conversion type, or to rename an existing conversion type,
		/// whose new name matches one of the other conversion types for his account.
		/// </summary>
		NameAlreadyExists,
		/// <summary>
		/// The user asked to send a notification email, but specified no recipients.
		/// </summary>
		NoRecipients,
		/// <summary>
		/// The requested conversion type has no snippet, and thus its snippet email cannot be sent.
		/// </summary>
		NoSnippet,
		/// <summary>
		/// The requested date range contains too many webpages to be processed.
		/// </summary>
		TooManyWebpages,
		/// <summary>
		/// An unknown sorting type was specified in the selector.
		/// </summary>
		UnknownSortingType,
		/// <summary>
		/// AppConversionType cannot be set to DOWNLOAD when AppPlatform is ITUNES.
		/// </summary>
		UnsupportedAppConversionType
	}
	
	public enum CriterionErrorReason
	{
		/// <summary>
		/// Concrete type of criterion is required for ADD and SET operations.
		/// </summary>
		ConcreteTypeRequired,
		/// <summary>
		/// The category requested for exclusion is invalid.
		/// </summary>
		InvalidExcludedCategory,
		/// <summary>
		/// Invalid keyword criteria text.
		/// </summary>
		InvalidKeywordText,
		/// <summary>
		/// Keyword text should be less than 80 chars.
		/// </summary>
		KeywordTextTooLong,
		/// <summary>
		/// Keyword text has too many words.
		/// </summary>
		KeywordHasTooManyWords,
		/// <summary>
		/// Keyword text has invalid characters or symbols.
		/// </summary>
		KeywordHasInvalidChars,
		/// <summary>
		/// Invalid placement URL.
		/// </summary>
		InvalidPlacementUrl,
		/// <summary>
		/// Invalid user list criterion.
		/// </summary>
		InvalidUserList,
		/// <summary>
		/// Invalid user interest criterion.
		/// </summary>
		InvalidUserInterest,
		/// <summary>
		/// Placement URL has wrong format.
		/// </summary>
		InvalidFormatForPlacementUrl,
		/// <summary>
		/// Placement URL is too long.
		/// </summary>
		PlacementUrlIsTooLong,
		/// <summary>
		/// Indicates the URL contains an illegal character.
		/// </summary>
		PlacementUrlHasIllegalChar,
		/// <summary>
		/// Indicates the URL contains multiple comma separated URLs.
		/// </summary>
		PlacementUrlHasMultipleSitesInLine,
		/// <summary>
		/// Indicates the domain is blacklisted.
		/// </summary>
		PlacementIsNotAvailableForTargetingOrExclusion,
		/// <summary>
		/// Invalid vertical path.
		/// </summary>
		InvalidVerticalPath,
		/// <summary>
		/// Indicates the placement is a YouTube vertical channel, which is no longer supported.
		/// </summary>
		YoutubeVerticalChannelDeprecated,
		/// <summary>
		/// Indicates the placement is a YouTube demographic channel, which is no longer supported.
		/// </summary>
		YoutubeDemographicChannelDeprecated,
		/// <summary>
		/// YouTube urls are not supported in Placement criterion. Use YouTubeChannel and
		/// YouTubeVideo criterion instead.
		/// </summary>
		YoutubeUrlUnsupported,
		/// <summary>
		/// Criteria type can not be excluded by the customer,
		/// like AOL account type cannot target site type criteria.
		/// </summary>
		CannotExcludeCriteriaType,
		/// <summary>
		/// Criteria type can not be targeted.
		/// </summary>
		CannotAddCriteriaType,
		/// <summary>
		/// Product filter in the product criteria has invalid characters.
		/// Operand and the argument in the filter can not have "==" or "&+".
		/// </summary>
		InvalidProductFilter,
		/// <summary>
		/// Product filter in the product criteria is translated to a string as
		/// operand1==argument1&+operand2==argument2, maximum allowed length for
		/// the string is 255 chars.
		/// </summary>
		ProductFilterTooLong,
		/// <summary>
		/// Not allowed to exclude similar user list.
		/// </summary>
		CannotExcludeSimilarUserList,
		/// <summary>
		/// Not allowed to add display only UserLists to search only campaigns.
		/// </summary>
		CannotAddDisplayOnlyListsToSearchOnlyCampaigns,
		/// <summary>
		/// Not allowed to add display only UserLists to search plus campaigns.
		/// </summary>
		CannotAddDisplayOnlyListsToSearchCampaigns,
		/// <summary>
		/// Not allowed to add User interests to search only campaigns.
		/// </summary>
		CannotAddUserInterestsToSearchCampaigns,
		/// <summary>
		/// Not allowed to set bids for this criterion type in search campaigns
		/// </summary>
		CannotSetBidsOnCriterionTypeInSearchCampaigns,
		/// <summary>
		/// Destination URL cannot be set for the criterion types of Gender, AgeRange,
		/// UserList, Placement, MobileApp, and MobileAppCategory in search campaigns.
		/// </summary>
		CannotAddDestinationUrlToCriterionTypeInSearchCampaigns,
		/// <summary>
		/// IP address is not valid.
		/// </summary>
		InvalidIpAddress,
		/// <summary>
		/// IP format is not valid.
		/// </summary>
		InvalidIpFormat,
		/// <summary>
		/// Mobile application is not valid.
		/// </summary>
		InvalidMobileApp,
		/// <summary>
		/// Mobile application category is not valid.
		/// </summary>
		InvalidMobileAppCategory,
		/// <summary>
		/// The CriterionId does not exist or is of the incorrect type.
		/// </summary>
		InvalidCriterionId,
		/// <summary>
		/// The Criterion is not allowed to be targeted.
		/// </summary>
		CannotTargetCriterion,
		/// <summary>
		/// The criterion is not allowed to be targeted as it is deprecated.
		/// </summary>
		CannotTargetObsoleteCriterion,
		/// <summary>
		/// The CriterionId is not valid for the type.
		/// </summary>
		CriterionIdAndTypeMismatch,
		/// <summary>
		/// Distance for the radius for the proximity criterion is invalid.
		/// </summary>
		InvalidProximityRadius,
		/// <summary>
		/// Units for the distance for the radius for the proximity criterion is invalid.
		/// </summary>
		InvalidProximityRadiusUnits,
		/// <summary>
		/// Street address is too short.
		/// </summary>
		InvalidStreetaddressLength,
		/// <summary>
		/// City name in the address is too short.
		/// </summary>
		InvalidCitynameLength,
		/// <summary>
		/// Region code in the address is too short.
		/// </summary>
		InvalidRegioncodeLength,
		/// <summary>
		/// Region name in the address is not valid.
		/// </summary>
		InvalidRegionnameLength,
		/// <summary>
		/// Postal code in the address is not valid.
		/// </summary>
		InvalidPostalcodeLength,
		/// <summary>
		/// Country code in the address is not valid.
		/// </summary>
		InvalidCountryCode,
		/// <summary>
		/// Latitude for the GeoPoint is not valid.
		/// </summary>
		InvalidLatitude,
		/// <summary>
		/// Longitude for the GeoPoint is not valid.
		/// </summary>
		InvalidLongitude,
		/// <summary>
		/// The Proximity input is not valid. Both address and geoPoint cannot be null.
		/// </summary>
		ProximityGeopointAndAddressBothCannotBeNull,
		/// <summary>
		/// The Proximity address cannot be geocoded to a valid lat/long.
		/// </summary>
		InvalidProximityAddress,
		/// <summary>
		/// User domain name is not valid.
		/// </summary>
		InvalidUserDomainName,
		/// <summary>
		/// Length of serialized criterion parameter exceeded size limit.
		/// </summary>
		CriterionParameterTooLong,
		/// <summary>
		/// Time interval in the AdSchedule overlaps with another AdSchedule.
		/// </summary>
		AdScheduleTimeIntervalsOverlap,
		/// <summary>
		/// AdSchedule time interval cannot span multiple days.
		/// </summary>
		AdScheduleIntervalCannotSpanMultipleDays,
		/// <summary>
		/// AdSchedule time interval specified is invalid,
		/// endTime cannot be earlier than startTime.
		/// </summary>
		AdScheduleInvalidTimeInterval,
		/// <summary>
		/// The number of AdSchedule entries in a day exceeds the limit.
		/// </summary>
		AdScheduleExceededIntervalsPerDayLimit,
		/// <summary>
		/// CriteriaId does not match the interval of the AdSchedule specified.
		/// </summary>
		AdScheduleCriterionIdMismatchingFields,
		/// <summary>
		/// Cannot set bid modifier for this criterion type.
		/// </summary>
		CannotBidModifyCriterionType,
		/// <summary>
		/// Cannot bid modify criterion, since it is opted out of the campaign.
		/// </summary>
		CannotBidModifyCriterionCampaignOptedOut,
		/// <summary>
		/// Cannot set bid modifier for a negative criterion.
		/// </summary>
		CannotBidModifyNegativeCriterion,
		/// <summary>
		/// Bid Modifier already exists. Use SET operation to update.
		/// </summary>
		BidModifierAlreadyExists,
		/// <summary>
		/// Feed Id is not allowed in these Location Groups.
		/// </summary>
		FeedIdNotAllowed,
		/// <summary>
		/// The account may not use the requested criteria type. For example, some
		/// accounts are restricted to keywords only.
		/// </summary>
		AccountIneligibleForCriteriaType,
		/// <summary>
		/// The requested criteria type cannot be used with campaign or ad group bidding strategy.
		/// </summary>
		CriteriaTypeInvalidForBiddingStrategy,
		/// <summary>
		/// The Criterion is not allowed to be excluded.
		/// </summary>
		CannotExcludeCriterion,
		/// <summary>
		/// The criterion is not allowed to be removed. For example, we cannot remove any
		/// of the platform criterion.
		/// </summary>
		CannotRemoveCriterion,
		/// <summary>
		/// The combined length of product dimension values of the product scope criterion is too long.
		/// </summary>
		ProductScopeTooLong,
		/// <summary>
		/// Product scope contains too many dimensions.
		/// </summary>
		ProductScopeTooManyDimensions,
		/// <summary>
		/// The combined length of product dimension values of the product partition criterion is too
		/// long.
		/// </summary>
		ProductPartitionTooLong,
		/// <summary>
		/// Product partition contains too many dimensions.
		/// </summary>
		ProductPartitionTooManyDimensions,
		/// <summary>
		/// The product dimension is invalid (e.g. dimension contains illegal value, dimension type is
		/// represented with wrong class, etc). Product dimension value can not contain "==" or "&+".
		/// </summary>
		InvalidProductDimension,
		/// <summary>
		/// Product dimension type is either invalid for campaigns of this type or cannot be used in the
		/// current context. BIDDING_CATEGORY_Lx and PRODUCT_TYPE_Lx product dimensions must be used in
		/// ascending order of their levels: L1, L2, L3, L4, L5... The levels must be specified
		/// sequentially and start from L1. Furthermore, an "others" product partition cannot be
		/// subdivided with a dimension of the same type but of a higher level ("others"
		/// BIDDING_CATEGORY_L3 can be subdivided with BRAND but not with BIDDING_CATEGORY_L4).
		/// </summary>
		InvalidProductDimensionType,
		/// <summary>
		/// Bidding categories do not form a valid path in the Shopping bidding category taxonomy.
		/// </summary>
		InvalidProductBiddingCategory,
		/// <summary>
		/// ShoppingSetting must be added to the campaign before ProductScope criteria can be added.
		/// </summary>
		MissingShoppingSetting,
		/// <summary>
		/// Matching function is invalid.
		/// </summary>
		InvalidMatchingFunction,
		/// <summary>
		/// Filter parameters not allowed for location groups targeting.
		/// </summary>
		LocationFilterNotAllowed,
		/// <summary>
		/// Given location filter parameter is invalid for location groups targeting.
		/// </summary>
		LocationFilterInvalid,
		/// <summary>
		/// Criteria type cannot be associated with a campaign and its ad group(s) simultaneously.
		/// </summary>
		CannotAttachCriteriaAtCampaignAndAdgroup,
		Unknown
	}
	
	/// <summary>
	/// The types of criteria.
	/// </summary>
	public enum CriterionType
	{
		/// <summary>
		/// Content label for exclusion.
		/// </summary>
		ContentLabel,
		/// <summary>
		/// Keyword. e.g. 'mars cruise'
		/// </summary>
		Keyword,
		/// <summary>
		/// Placement. aka Website. e.g. 'www.flowers4sale.com'
		/// </summary>
		Placement,
		/// <summary>
		/// Vertical, e.g. 'category::Animals>Pets'  This is for vertical targeting on the content
		/// network.
		/// </summary>
		Vertical,
		/// <summary>
		/// User lists, are links to sets of users defined by the advertiser.
		/// </summary>
		UserList,
		/// <summary>
		/// User interests, categories of interests the user is interested in.
		/// </summary>
		UserInterest,
		/// <summary>
		/// Mobile applications to target.
		/// </summary>
		MobileApplication,
		/// <summary>
		/// Mobile application categories to target.
		/// </summary>
		MobileAppCategory,
		/// <summary>
		/// Product partition (product group) in a shopping campaign.
		/// </summary>
		ProductPartition,
		/// <summary>
		/// IP addresses to exclude.
		/// </summary>
		IpBlock,
		/// <summary>
		/// Webpages of an advertiser's website to target.
		/// </summary>
		Webpage,
		/// <summary>
		/// Languages to target.
		/// </summary>
		Language,
		/// <summary>
		/// Geographic regions to target.
		/// </summary>
		Location,
		/// <summary>
		/// Age Range to exclude.
		/// </summary>
		AgeRange,
		/// <summary>
		/// Mobile carriers to target.
		/// </summary>
		Carrier,
		/// <summary>
		/// Mobile operating system versions to target.
		/// </summary>
		OperatingSystemVersion,
		/// <summary>
		/// Mobile devices to target.
		/// </summary>
		MobileDevice,
		/// <summary>
		/// Gender to exclude.
		/// </summary>
		Gender,
		/// <summary>
		/// Parent to target and exclude.
		/// </summary>
		Parent,
		/// <summary>
		/// Proximity (area within a radius) to target.
		/// </summary>
		Proximity,
		/// <summary>
		/// Platforms to target.
		/// </summary>
		Platform,
		/// <summary>
		/// Representing preferred content bid modifier.
		/// </summary>
		PreferredContent,
		/// <summary>
		/// AdSchedule or specific days and time intervals to target.
		/// </summary>
		AdSchedule,
		/// <summary>
		/// Targeting based on location groups.
		/// </summary>
		LocationGroups,
		/// <summary>
		/// Scope of products. Contains a list of product dimensions, all of which a product has to match
		/// to be included in the campaign.
		/// </summary>
		ProductScope,
		/// <summary>
		/// YouTube video to target.
		/// </summary>
		YoutubeVideo,
		/// <summary>
		/// YouTube channel to target.
		/// </summary>
		YoutubeChannel,
		/// <summary>
		/// Enables advertisers to target paid apps.
		/// </summary>
		AppPaymentModel,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The list of groupings of criteria types.
	/// </summary>
	public enum CriterionTypeGroup
	{
		/// <summary>
		/// Criteria for targeting keywords. e.g. 'mars cruise'
		/// KEYWORD may be used as a content bid dimension. Keywords are always a targeting dimension,
		/// so may not be set as a target "ALL" dimension with {@link TargetRestriction}.
		/// </summary>
		Keyword,
		/// <summary>
		/// Criteria for targeting lists of users.  Lists may represent users with particular
		/// interests, or they may represent users who have interacted with an advertiser's site in
		/// particular ways.
		/// </summary>
		UserInterestAndList,
		/// <summary>
		/// Criteria for targeting similar categories of placements, e.g. 'category::Animals>Pets'
		/// Used only for content network targeting.
		/// </summary>
		Vertical,
		/// <summary>
		/// Criteria for targeting gender.
		/// </summary>
		Gender,
		/// <summary>
		/// Criteria for targeting age ranges.
		/// </summary>
		AgeRange,
		/// <summary>
		/// Criteria for targeting placements. aka Website. e.g. 'www.flowers4sale.com'
		/// This group also includes mobile applications and mobile app categories.
		/// </summary>
		Placement,
		/// <summary>
		/// Criteria for parental status targeting.
		/// </summary>
		Parent,
		/// <summary>
		/// Special criteria type group used to reset the existing value.
		/// </summary>
		None,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The way a criterion is used - biddable or negative.
	/// </summary>
	public enum CriterionUse
	{
		/// <summary>
		/// Biddable (positive) criterion
		/// </summary>
		Biddable,
		/// <summary>
		/// Negative criterion
		/// </summary>
		Negative
	}
	
	/// <summary>
	/// Membership status of the user list.
	/// </summary>
	public enum CriterionUserListMembershipStatus
	{
		/// <summary>
		/// Open status - list is accruing members and can be targeted to.
		/// </summary>
		Open,
		/// <summary>
		/// Closed status - No new members being added. Can not be used for targeting.
		/// </summary>
		Closed
	}
	
	/// <summary>
	/// Encodes the reason (cause) of a particular {@link CurrencyCodeError}.
	/// </summary>
	public enum CurrencyCodeErrorReason
	{
		UnsupportedCurrencyCode
	}
	
	/// <summary>
	/// The ApiErrorReason for a CustomerError.
	/// </summary>
	public enum CustomerErrorReason
	{
		/// <summary>
		/// Referenced service link does not exist
		/// </summary>
		InvalidServiceLink,
		/// <summary>
		/// An {@code ACTIVE} link cannot be made {@code PENDING}
		/// </summary>
		InvalidStatus,
		/// <summary>
		/// A temporary server error. The request can be retried.
		/// </summary>
		Temporary,
		/// <summary>
		/// CustomerService cannot {@link CustomerService#get() get} an account that is not fully set
		/// up.
		/// </summary>
		AccountNotSetUp
	}
	
	/// <summary>
	/// Error reasons.
	/// </summary>
	public enum CustomerFeedErrorReason
	{
		/// <summary>
		/// An active feed already exists for this customer and place holder type.
		/// </summary>
		FeedAlreadyExistsForPlaceholderType,
		/// <summary>
		/// The specified id does not exist.
		/// </summary>
		InvalidId,
		/// <summary>
		/// The specified feed is deleted.
		/// </summary>
		CannotAddForDeletedFeed,
		/// <summary>
		/// The CustomerFeed already exists. SET should be used to modify the existing CustomerFeed.
		/// </summary>
		CannotAddAlreadyExistingCustomerFeed,
		/// <summary>
		/// Cannot modify removed customer feed.
		/// </summary>
		CannotModifyRemovedCustomerFeed,
		/// <summary>
		/// Invalid placeholder types.
		/// </summary>
		InvalidPlaceholderTypes,
		/// <summary>
		/// Feed mapping for this placeholder type does not exist.
		/// </summary>
		MissingFeedmappingForPlaceholderType,
		/// <summary>
		/// Placeholder not allowed at the account level.
		/// </summary>
		PlaceholderTypeNotAllowedOnCustomerFeed,
		Unknown
	}
	
	/// <summary>
	/// Status of the CustomerFeed.
	/// </summary>
	public enum CustomerFeedStatus
	{
		/// <summary>
		/// Indicates that the feed is currently being used.
		/// </summary>
		Enabled,
		/// <summary>
		/// Indicates that the feed is not used anymore.
		/// </summary>
		Removed,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Enums for all the reasons an error can be thrown to the user during a CustomerOrderLine mutate
	/// operation.
	/// </summary>
	public enum CustomerOrderLineErrorReason
	{
		/// <summary>
		/// Order Line Id does not exist.
		/// </summary>
		InvalidOrderLineId,
		/// <summary>
		/// End date must be later than start date
		/// </summary>
		EndDateBeforeStartDate,
		/// <summary>
		/// Spending limit must be positive
		/// </summary>
		NegativeSpend,
		/// <summary>
		/// Cannot create order line with start date in the past
		/// </summary>
		CreateInPast,
		/// <summary>
		/// Cannot change start date after the order line has started
		/// </summary>
		AlreadyStarted,
		/// <summary>
		/// Cannot set spending limit below what has already been spent
		/// </summary>
		AlreadySpent,
		/// <summary>
		/// Cannot move end date into the past
		/// </summary>
		FinishedInThePast,
		/// <summary>
		/// Cannot cancel active order line
		/// </summary>
		CancelActive,
		/// <summary>
		/// Cannot make overlapping order lines.
		/// </summary>
		OverlapDateRange,
		/// <summary>
		/// Cannot make a COS order line non-COS.
		/// </summary>
		CosChange,
		/// <summary>
		/// Cannot create an order line on a non-adwords account
		/// </summary>
		NonAdwords,
		/// <summary>
		/// Cannot set contract start date to be after actual start date
		/// </summary>
		StartDateAfterActual,
		/// <summary>
		/// Cannot set contract start date to be after actual start date
		/// </summary>
		EndDatePastMax,
		/// <summary>
		/// only cancelled order lines may have themselves as parent
		/// </summary>
		ParentIsSelf,
		/// <summary>
		/// Cannot cancel new order line
		/// </summary>
		CannotCancelNew,
		/// <summary>
		/// Cannot cancel started order line
		/// </summary>
		CannotCancelStarted,
		/// <summary>
		/// Cannot promote an order line that is not pending.
		/// </summary>
		CannotPromoteNonPendingOrderline,
		/// <summary>
		/// Updating order line will shift current order line.
		/// </summary>
		UpdateOrderlineWillShiftCurrent,
		/// <summary>
		/// Only Order lines in normal or pending state can be modified.
		/// </summary>
		OrderlineBeingModifiedIsNotNormalOrPending,
		/// <summary>
		/// Invalid Status Change by client.
		/// </summary>
		InvalidStatusChange,
		/// <summary>
		/// More than one operation not permitted per call.
		/// </summary>
		MoreThanOneOperationNotPermitted,
		/// <summary>
		/// StartDate and EndDate should pass in the customer's account timeZone.
		/// </summary>
		InvalidTimezoneInDateRanges,
		Unknown
	}
	
	public enum CustomerSyncErrorReason
	{
		/// <summary>
		/// The request attempted to access a campaign that either does not exist or belongs to a
		/// different account.
		/// </summary>
		InvalidCampaignId,
		/// <summary>
		/// The request attempted to access a feed that either does not exist or belongs to a different
		/// account.
		/// </summary>
		InvalidFeedId,
		/// <summary>
		/// The request asked for an invalid date range
		/// </summary>
		InvalidDateRange,
		/// <summary>
		/// There have been too many changes to sync the campaign over the requested date/time range. To
		/// avoid this error, try specifying a smaller date/time range. If this does not work, you should
		/// assume that everything has changed and retrieve the objects using their respective services.
		/// </summary>
		TooManyChanges
	}
	
	/// <summary>
	/// The reasons for the database error.
	/// </summary>
	public enum DatabaseErrorReason
	{
		/// <summary>
		/// A concurrency problem occurred as two threads were attempting to modify same object.
		/// </summary>
		ConcurrentModification,
		/// <summary>
		/// The permission was denied to access an object.
		/// </summary>
		PermissionDenied,
		/// <summary>
		/// The user's access to an object has been prohibited.
		/// </summary>
		AccessProhibited,
		/// <summary>
		/// Requested campaign belongs to a product that is not supported by the api.
		/// </summary>
		CampaignProductNotSupported,
		/// <summary>
		/// a duplicate key was detected upon insertion
		/// </summary>
		DuplicateKey,
		/// <summary>
		/// a database error has occurred
		/// </summary>
		DatabaseError,
		/// <summary>
		/// an unknown error has occurred
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Enumerates data driven model statuses.
	/// </summary>
	public enum DataDrivenModelStatus
	{
		Unknown,
		Available,
		Stale,
		Expired,
		NeverGenerated
	}
	
	/// <summary>
	/// Reasons for error.
	/// </summary>
	public enum DataErrorReason
	{
		CannotCreateTableEntry,
		NoTableEntryClassForViewType,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		TableServiceError
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum DateErrorReason
	{
		/// <summary>
		/// Given field values do not correspond to a valid date.
		/// </summary>
		InvalidFieldValuesInDate,
		/// <summary>
		/// Given field values do not correspond to a valid date time.
		/// </summary>
		InvalidFieldValuesInDateTime,
		/// <summary>
		/// The string date's format should be yyyymmdd.
		/// </summary>
		InvalidStringDate,
		/// <summary>
		/// The string date range's format should be yyyymmdd yyyymmdd.
		/// </summary>
		InvalidStringDateRange,
		/// <summary>
		/// The string date time's format should be yyyymmdd hhmmss [tz].
		/// </summary>
		InvalidStringDateTime,
		/// <summary>
		/// Date is before allowed minimum.
		/// </summary>
		EarlierThanMinimumDate,
		/// <summary>
		/// Date is after allowed maximum.
		/// </summary>
		LaterThanMaximumDate,
		/// <summary>
		/// Date range bounds are not in order.
		/// </summary>
		DateRangeMinimumDateLaterThanMaximumDate,
		/// <summary>
		/// Both dates in range are null.
		/// </summary>
		DateRangeMinimumAndMaximumDatesBothNull
	}
	
	/// <summary>
	/// The reasons for the date range error.
	/// </summary>
	public enum DateRangeErrorReason
	{
		DateRangeError,
		/// <summary>
		/// Invalid date.
		/// </summary>
		InvalidDate,
		/// <summary>
		/// The start date was after the end date.
		/// </summary>
		StartDateAfterEndDate,
		/// <summary>
		/// Cannot set date to past time
		/// </summary>
		CannotSetDateToPast,
		/// <summary>
		/// A date was used that is past the system "last" date.
		/// </summary>
		AfterMaximumAllowableDate,
		/// <summary>
		/// Trying to change start date on a campaign that has started.
		/// </summary>
		CannotModifyStartDateIfAlreadyStarted
	}
	
	/// <summary>
	/// Supported rule operator for date type.
	/// </summary>
	public enum DateRuleItemDateOperator
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		Equals,
		NotEqual,
		Before,
		After
	}
	
	/// <summary>
	/// Days of the week.
	/// </summary>
	public enum DayOfWeek
	{
		/// <summary>
		/// The day of week named Monday.
		/// </summary>
		Monday,
		/// <summary>
		/// The day of week named Tuesday.
		/// </summary>
		Tuesday,
		/// <summary>
		/// The day of week named Wednesday.
		/// </summary>
		Wednesday,
		/// <summary>
		/// The day of week named Thursday.
		/// </summary>
		Thursday,
		/// <summary>
		/// The day of week named Friday.
		/// </summary>
		Friday,
		/// <summary>
		/// The day of week named Saturday.
		/// </summary>
		Saturday,
		/// <summary>
		/// The day of week named Sunday.
		/// </summary>
		Sunday
	}
	
	public enum DeprecatedAdType
	{
		/// <summary>
		/// Video ad.
		/// </summary>
		Video,
		/// <summary>
		/// Click to call ad.
		/// </summary>
		ClickToCall,
		/// <summary>
		/// Instream video ad.
		/// </summary>
		InStreamVideo,
		/// <summary>
		/// Froogle ad.
		/// </summary>
		Froogle,
		/// <summary>
		/// Text link ad.
		/// </summary>
		TextLink,
		/// <summary>
		/// Gadget ad.
		/// </summary>
		Gadget,
		/// <summary>
		/// Print ad.
		/// </summary>
		Print,
		/// <summary>
		/// Wide text ad.
		/// </summary>
		TextWide,
		/// <summary>
		/// Gadget template ad.
		/// </summary>
		GadgetTemplate,
		/// <summary>
		/// Text ad with video.
		/// </summary>
		TextWithVideo,
		/// <summary>
		/// Audio ad.
		/// </summary>
		Audio,
		/// <summary>
		/// Local business ads.
		/// </summary>
		LocalBusinessAd,
		/// <summary>
		/// Audio based template ads.
		/// </summary>
		AudioTemplate,
		/// <summary>
		/// Mobile ads
		/// </summary>
		MobileAd,
		/// <summary>
		/// Mobile image ads
		/// </summary>
		MobileImageAd,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the validation error.
	/// </summary>
	public enum DistinctErrorReason
	{
		DuplicateElement,
		DuplicateType
	}
	
	public enum DownloadFormat
	{
		Csvforexcel,
		Csv,
		Tsv,
		Xml,
		GzippedCsv,
		GzippedXml
	}
	
	public enum DraftErrorReason
	{
		/// <summary>
		/// The draft is archived and cannot be modified further.
		/// </summary>
		CannotChangeArchivedDraft,
		/// <summary>
		/// The draft has been promoted and cannot be modified further.
		/// </summary>
		CannotChangePromotedDraft,
		/// <summary>
		/// The draft has failed to be promoted and cannot be modified further.
		/// </summary>
		CannotChangePromoteFailedDraft,
		/// <summary>
		/// This customer is not allowed to create drafts.
		/// </summary>
		CustomerCannotCreateDraft,
		/// <summary>
		/// This campaign is not allowed to create drafts.
		/// </summary>
		CampaignCannotCreateDraft,
		/// <summary>
		/// A draft with this name already exists.
		/// </summary>
		DuplicateDraftName,
		/// <summary>
		/// This modification cannot be made on a draft.
		/// </summary>
		InvalidDraftChange,
		/// <summary>
		/// The draft cannot be transitioned to the specified status from the its current status.
		/// </summary>
		InvalidStatusTransition,
		/// <summary>
		/// The campaign has reached the maximum number of drafts that can be created for a campaign
		/// throughout its lifetime. No additional drafts can be created for this campaign. Archived
		/// drafts also count towards this limit.
		/// </summary>
		MaxNumberOfDraftsPerCampaignReached,
		DraftError
	}
	
	/// <summary>
	/// Status diagram available at go/adsapi-commander
	/// </summary>
	public enum DraftStatus
	{
		/// <summary>
		/// Invalid status. Should not be used except for detecting values that are
		/// incorrect, or values that are not yet known to the user.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Initial state of the draft, the advertiser can start adding changes with no
		/// effect on serving.
		/// </summary>
		Proposed,
		/// <summary>
		/// The process to merge changes in the draft back to the original campaign has
		/// completedly successfully. The advertiser cannot set this status directly. To
		/// move the draft to this status, set the draft to status PROMOTING and the status
		/// will be updated to PROMOTED when the changes are applied to the original
		/// campaign.
		/// </summary>
		Promoted,
		/// <summary>
		/// The advertiser requested to merge changes in the draft back into the original
		/// campaigns. The update to the original campaign will be kicked off asynchronously
		/// and the status will be updated to PROMOTED or PROMOTE_FAILED upon completion.
		/// </summary>
		Promoting,
		/// <summary>
		/// The advertiser has archived the draft.
		/// </summary>
		Archived,
		/// <summary>
		/// The promotion failed after it was partially applied. Promote cannot be attempted
		/// again safely, so the issue must be corrected in the original campaign. More
		/// details about the errors are available through getErrors in the DraftService
		/// API.The advertiser cannot set this status directly. To promote the draft, set
		/// the draft in state PROMOTING and the status will be updated to PROMOTE_FAILED if
		/// errors are encountered while applying changes to the original campaign.
		/// </summary>
		PromoteFailed
	}
	
	public enum EntityAccessDeniedReason
	{
		/// <summary>
		/// User did not have read access.
		/// </summary>
		ReadAccessDenied,
		/// <summary>
		/// User did not have write access.
		/// </summary>
		WriteAccessDenied
	}
	
	/// <summary>
	/// Limits at various levels of the account.
	/// </summary>
	public enum EntityCountLimitExceededReason
	{
		/// <summary>
		/// Indicates that this request would exceed the number of allowed entities for the AdWords
		/// account. The exact entity type and limit being checked can be inferred from
		/// {@link #accountLimitType}.
		/// </summary>
		AccountLimit,
		/// <summary>
		/// Indicates that this request would exceed the number of allowed entities in a Campaign.
		/// The exact entity type and limit being checked can be inferred from
		/// {@link #accountLimitType}, and the numeric id of the Campaign involved is given by
		/// {@link #enclosingId}.
		/// </summary>
		CampaignLimit,
		/// <summary>
		/// Indicates that this request would exceed the number of allowed entities in
		/// an ad group.  The exact entity type and limit being checked can be
		/// inferred from {@link #accountLimitType}, and the numeric id of the ad group
		/// involved is given by {@link #enclosingId}.
		/// </summary>
		AdgroupLimit,
		/// <summary>
		/// Indicates that this request would exceed the number of allowed entities in an ad group ad.
		/// The exact entity type and limit being checked can be inferred from {@link #accountLimitType},
		/// and the {@link #enclosingId} contains the ad group id followed by the ad id, separated by a
		/// single comma (,).
		/// </summary>
		AdGroupAdLimit,
		/// <summary>
		/// Indicates that this request would exceed the number of allowed entities in an ad group
		/// criterion.  The exact entity type and limit being checked can be inferred from
		/// {@link #accountLimitType}, and the {@link #enclosingId} contains the ad group id followed by
		/// the criterion id, separated by a single comma (,).
		/// </summary>
		AdGroupCriterionLimit,
		/// <summary>
		/// Indicates that this request would exceed the number of allowed entities in
		/// this shared set.  The exact entity type and limit being checked can be
		/// inferred from {@link #accountLimitType}, and the numeric id of the shared
		/// set involved is given by {@link #enclosingId}.
		/// </summary>
		SharedSetLimit,
		/// <summary>
		/// Exceeds a limit related to a matching function.
		/// </summary>
		MatchingFunctionLimit,
		/// <summary>
		/// Specific limit that has been exceeded is unknown (the client may be of an
		/// older version than the server).
		/// </summary>
		Unknown
	}
	
	public enum EntityNotFoundReason
	{
		/// <summary>
		/// The specified id refered to an entity which either doesn't exist or is not accessible to the
		/// customer. e.g. campaign belongs to another customer.
		/// </summary>
		InvalidId
	}
	
	/// <summary>
	/// Error reasons.
	/// </summary>
	public enum ExtensionSettingErrorReason
	{
		/// <summary>
		/// A platform restriction was provided without input extensions or existing extensions.
		/// </summary>
		ExtensionsRequired,
		/// <summary>
		/// The provided feed type does not correspond to the provided extensions.
		/// </summary>
		FeedTypeExtensionTypeMismatch,
		/// <summary>
		/// The provided feed type cannot be used.
		/// </summary>
		InvalidFeedType,
		/// <summary>
		/// The provided feed type cannot be used at the customer level.
		/// </summary>
		InvalidFeedTypeForCustomerExtensionSetting,
		/// <summary>
		/// Can not change a feed item field on an ADD operation.
		/// </summary>
		CannotChangeFeedItemOnAdd,
		/// <summary>
		/// Cannot have a geo targeting restriction without having geo targeting.
		/// </summary>
		CannotHaveRestrictionOnEmptyGeoTargeting,
		/// <summary>
		/// Can not update an extension that is not already in this setting.
		/// </summary>
		CannotUpdateNewlyAddedExtension,
		/// <summary>
		/// There is no existing AdGroupExtensionSetting for this type.
		/// </summary>
		NoExistingAdGroupExtensionSettingForType,
		/// <summary>
		/// There is no existing CampaignExtensionSetting for this type.
		/// </summary>
		NoExistingCampaignExtensionSettingForType,
		/// <summary>
		/// There is no existing CustomerExtensionSetting for this type.
		/// </summary>
		NoExistingCustomerExtensionSettingForType,
		/// <summary>
		/// The AdGroupExtensionSetting already exists. SET should be used to modify the existing
		/// AdGroupExtensionSetting.
		/// </summary>
		AdGroupExtensionSettingAlreadyExists,
		/// <summary>
		/// The CampaignExtensionSetting already exists. SET should be used to modify the existing
		/// CampaignExtensionSetting.
		/// </summary>
		CampaignExtensionSettingAlreadyExists,
		/// <summary>
		/// The CustomerExtensionSetting already exists. SET should be used to modify the existing
		/// CustomerExtensionSetting.
		/// </summary>
		CustomerExtensionSettingAlreadyExists,
		/// <summary>
		/// An active ad group feed already exists for this place holder type.
		/// </summary>
		AdGroupFeedAlreadyExistsForPlaceholderType,
		/// <summary>
		/// An active campaign feed already exists for this place holder type.
		/// </summary>
		CampaignFeedAlreadyExistsForPlaceholderType,
		/// <summary>
		/// An active customer feed already exists for this place holder type.
		/// </summary>
		CustomerFeedAlreadyExistsForPlaceholderType,
		/// <summary>
		/// Value is not within the accepted range.
		/// </summary>
		ValueOutOfRange,
		/// <summary>
		/// Cannot simultaneously set sitelink field with final urls.
		/// </summary>
		CannotSetWithFinalUrls,
		/// <summary>
		/// Must set field with final urls.
		/// </summary>
		CannotSetWithoutFinalUrls,
		/// <summary>
		/// Cannot simultaneously set sitelink url field with tracking url template.
		/// </summary>
		CannotSetBothDestinationUrlAndTrackingUrlTemplate,
		/// <summary>
		/// Phone number for a call extension is invalid.
		/// </summary>
		InvalidPhoneNumber,
		/// <summary>
		/// Phone number for a call extension is not supported for the given country code.
		/// </summary>
		PhoneNumberNotSupportedForCountry,
		/// <summary>
		/// A carrier specific number in short format is not allowed for call extensions.
		/// </summary>
		CarrierSpecificShortNumberNotAllowed,
		/// <summary>
		/// Premium rate numbers are not allowed for call extensions.
		/// </summary>
		PremiumRateNumberNotAllowed,
		/// <summary>
		/// Phone number type for a call extension is not allowed.
		/// </summary>
		DisallowedNumberType,
		/// <summary>
		/// Phone number for a call extension does not meet domestic format requirements.
		/// </summary>
		InvalidDomesticPhoneNumberFormat,
		/// <summary>
		/// Vanity phone numbers (i.e. those including letters) are not allowed for call extensions.
		/// </summary>
		VanityPhoneNumberNotAllowed,
		/// <summary>
		/// Country code provided for a call extension is invalid.
		/// </summary>
		InvalidCountryCode,
		/// <summary>
		/// Call conversion type id provided for a call extension is invalid.
		/// </summary>
		InvalidCallConversionTypeId,
		/// <summary>
		/// For a call extension, the customer is not whitelisted for call tracking.
		/// </summary>
		CustomerNotWhitelistedForCalltracking,
		/// <summary>
		/// Call tracking is not supported for the given country for a call extension.
		/// </summary>
		CalltrackingNotSupportedForCountry,
		/// <summary>
		/// App id provided for an app extension is invalid.
		/// </summary>
		InvalidAppId,
		/// <summary>
		/// Quotation marks present in the review text for a review extension.
		/// </summary>
		QuotesInReviewExtensionSnippet,
		/// <summary>
		/// Hyphen character present in the review text for a review extension.
		/// </summary>
		HyphensInReviewExtensionSnippet,
		/// <summary>
		/// A blacklisted review source name or url was provided for a review extension.
		/// </summary>
		ReviewExtensionSourceIneligible,
		/// <summary>
		/// Review source name should not be found in the review text.
		/// </summary>
		SourceNameInReviewExtensionText,
		/// <summary>
		/// Field must be set.
		/// </summary>
		MissingField,
		/// <summary>
		/// Inconsistent currency codes.
		/// </summary>
		InconsistentCurrencyCodes,
		/// <summary>
		/// Price extension cannot have duplicated headers.
		/// </summary>
		PriceExtensionHasDuplicatedHeaders,
		/// <summary>
		/// Price item cannot have duplicated header and description.
		/// </summary>
		PriceItemHasDuplicatedHeaderAndDescription,
		/// <summary>
		/// Price extension has too few items
		/// </summary>
		PriceExtensionHasTooFewItems,
		/// <summary>
		/// Price extension has too many items
		/// </summary>
		PriceExtensionHasTooManyItems,
		/// <summary>
		/// The input value is not currently supported.
		/// </summary>
		UnsupportedValue,
		/// <summary>
		/// Unknown or unsupported device preference.
		/// </summary>
		InvalidDevicePreference,
		/// <summary>
		/// Invalid feed item schedule end time (i.e., endHour = 24 and endMinute != 0).
		/// </summary>
		InvalidScheduleEnd,
		/// <summary>
		/// Date time zone does not match the account's time zone.
		/// </summary>
		DateTimeMustBeInAccountTimeZone,
		/// <summary>
		/// Overlapping feed item schedule times (e.g., 7-10AM and 8-11AM) are not allowed.
		/// </summary>
		OverlappingSchedules,
		/// <summary>
		/// Feed item schedule end time must be after start time.
		/// </summary>
		ScheduleEndNotAfterStart,
		/// <summary>
		/// There are too many feed item schedules per day.
		/// </summary>
		TooManySchedulesPerDay,
		/// <summary>
		/// Cannot edit the same extension feed item id twice.
		/// </summary>
		DuplicateExtensionFeedItemEdit,
		/// <summary>
		/// Invalid structured snippet header.
		/// </summary>
		InvalidSnippetsHeader,
		/// <summary>
		/// Phone number not supported with call tracking enabled for country.
		/// </summary>
		PhoneNumberNotSupportedWithCalltrackingForCountry,
		/// <summary>
		/// Targeted adgroup's campaign does not match the targeted campaign.
		/// </summary>
		CampaignTargetingMismatch,
		/// <summary>
		/// The feed used by the ExtensionSetting is deleted and cannot be operated on. Remove the
		/// ExtensionSetting to allow a new one to be created using an active feed.
		/// </summary>
		CannotOperateOnDeletedFeed,
		/// <summary>
		/// Concrete sub type of ExtensionFeedItem is required for this operation.
		/// </summary>
		ConcreteExtensionTypeRequired,
		/// <summary>
		/// The matching function that links the extension feed to the customer, campaign, or ad group
		/// is not compatible with the ExtensionSetting services.
		/// </summary>
		IncompatibleUnderlyingMatchingFunction,
		Unknown
	}
	
	/// <summary>
	/// Different levels of platform restrictions.
	/// </summary>
	public enum ExtensionSettingPlatform
	{
		/// <summary>
		/// Desktop only.
		/// </summary>
		Desktop,
		/// <summary>
		/// Mobile only.
		/// </summary>
		Mobile,
		/// <summary>
		/// No restriction.
		/// </summary>
		None
	}
	
	/// <summary>
	/// Feed attribute reference error reasons.
	/// </summary>
	public enum FeedAttributeReferenceErrorReason
	{
		/// <summary>
		/// A feed referenced by ID has been deleted.
		/// </summary>
		CannotReferenceDeletedFeed,
		/// <summary>
		/// There is no active feed with the given name.
		/// </summary>
		InvalidFeedName,
		/// <summary>
		/// There is no feed attribute in an active feed with the given name.
		/// </summary>
		InvalidFeedAttributeName
	}
	
	/// <summary>
	/// Possible data types.
	/// </summary>
	public enum FeedAttributeType
	{
		Int64,
		Float,
		String,
		Boolean,
		Url,
		DateTime,
		Int64List,
		FloatList,
		StringList,
		BooleanList,
		UrlList,
		DateTimeList,
		Price,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Error reasons.
	/// </summary>
	public enum FeedErrorReason
	{
		/// <summary>
		/// The names of the FeedAttributes must be unique.
		/// </summary>
		AttributeNamesNotUnique,
		/// <summary>
		/// The attribute list must be an exact copy of the existing list if the attribute id's are
		/// present.
		/// </summary>
		AttributesDoNotMatchExistingAttributes,
		/// <summary>
		/// Origin can only be set during Feed creation.
		/// </summary>
		CannotChangeOrigin,
		/// <summary>
		/// Cannot specify USER origin for a system generated feed.
		/// </summary>
		CannotSpecifyUserOriginForSystemFeed,
		/// <summary>
		/// Cannot specify ADWORDS origin for a non-system generated feed.
		/// </summary>
		CannotSpecifyAdwordsOriginForNonSystemFeed,
		/// <summary>
		/// Cannot specify feed attributes for system feed.
		/// </summary>
		CannotSpecifyFeedAttributesForSystemFeed,
		/// <summary>
		/// Cannot update FeedAttributes on feed with origin adwords.
		/// </summary>
		CannotUpdateFeedAttributesWithOriginAdwords,
		/// <summary>
		/// The given id refers to a removed Feed. Removed Feeds are immutable.
		/// </summary>
		FeedRemoved,
		/// <summary>
		/// The origin of the feed is not valid for the client.
		/// </summary>
		InvalidOriginValue,
		/// <summary>
		/// A user can only create and modify feeds with user origin.
		/// </summary>
		FeedOriginIsNotUser,
		/// <summary>
		/// Feed name matches that of another active Feed.
		/// </summary>
		DuplicateFeedName,
		/// <summary>
		/// Name of feed is not allowed.
		/// </summary>
		InvalidFeedName,
		/// <summary>
		/// Missing OAuthInfo
		/// </summary>
		MissingOauthInfo,
		/// <summary>
		/// New FeedAttributes must not effect the unique key.
		/// </summary>
		NewAttributeCannotBePartOfUniqueKey,
		/// <summary>
		/// Too many FeedAttributes for a Feed.
		/// </summary>
		TooManyFeedAttributesForFeed,
		/// <summary>
		/// The business account is not valid.
		/// </summary>
		InvalidBusinessAccount,
		/// <summary>
		/// Business account cannot access Google My Business account.
		/// </summary>
		BusinessAccountCannotAccessLocationAccount,
		Unknown
	}
	
	/// <summary>
	/// Feed item approval status.
	/// </summary>
	public enum FeedItemApprovalStatus
	{
		/// <summary>
		/// Pending review
		/// </summary>
		Unchecked,
		/// <summary>
		/// Approved
		/// </summary>
		Approved,
		/// <summary>
		/// Disapproved
		/// </summary>
		Disapproved
	}
	
	/// <summary>
	/// The reasons for the error.
	/// </summary>
	public enum FeedItemErrorReason
	{
		/// <summary>
		/// Targeted adgroup's campaign does not match the targeted campaign.
		/// </summary>
		CampaignTargetingMismatch,
		/// <summary>
		/// Cannot convert the feed attribute value from string to its real type.
		/// </summary>
		CannotConvertAttributeValueFromString,
		/// <summary>
		/// Cannot have a geo targeting restriction without having geo targeting.
		/// </summary>
		CannotHaveRestrictionOnEmptyGeoTargeting,
		/// <summary>
		/// Cannot operate on removed feed item.
		/// </summary>
		CannotOperateOnRemovedFeedItem,
		/// <summary>
		/// Date time zone does not match the account's time zone.
		/// </summary>
		DateTimeMustBeInAccountTimeZone,
		/// <summary>
		/// Feed item with the key attributes could not be found.
		/// </summary>
		KeyAttributesNotFound,
		/// <summary>
		/// Unknown or unsupported device preference.
		/// </summary>
		InvalidDevicePreference,
		/// <summary>
		/// Invalid feed item schedule end time (i.e., endHour = 24 and endMinute != 0).
		/// </summary>
		InvalidScheduleEnd,
		/// <summary>
		/// Url feed attribute value is not valid.
		/// </summary>
		InvalidUrl,
		/// <summary>
		/// Some key attributes are missing.
		/// </summary>
		MissingKeyAttributes,
		/// <summary>
		/// Feed item has same key attributes as another feed item.
		/// </summary>
		KeyAttributesNotUnique,
		/// <summary>
		/// Cannot modify key attributes on an existing feed item.
		/// </summary>
		CannotModifyKeyAttributeValue,
		/// <summary>
		/// Overlapping feed item schedule times (e.g., 7-10AM and 8-11AM) are not allowed.
		/// </summary>
		OverlappingSchedules,
		/// <summary>
		/// Feed item schedule end time must be after start time.
		/// </summary>
		ScheduleEndNotAfterStart,
		/// <summary>
		/// There are too many feed item schedules per day.
		/// </summary>
		TooManySchedulesPerDay,
		/// <summary>
		/// The feed attribute value is too large.
		/// </summary>
		SizeTooLargeForMultiValueAttribute,
		/// <summary>
		/// Unknown error.
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Feed item quality evaluation approval status.
	/// </summary>
	public enum FeedItemQualityApprovalStatus
	{
		/// <summary>
		/// Quality evaluation pending
		/// </summary>
		Unknown,
		/// <summary>
		/// Approved for quality
		/// </summary>
		Approved,
		/// <summary>
		/// Disapproved for quality
		/// </summary>
		Disapproved
	}
	
	/// <summary>
	/// Feed item quality evaluation disapproval reasons.
	/// </summary>
	public enum FeedItemQualityDisapprovalReasons
	{
		Unknown,
		/// <summary>
		/// Price contains repetitive headers
		/// </summary>
		TableRepetitiveHeaders,
		/// <summary>
		/// Price contains repetitive description
		/// </summary>
		TableRepetitiveDescription,
		/// <summary>
		/// Price contains inconsistent items
		/// </summary>
		TableInconsistentRows,
		/// <summary>
		/// Price qualifiers in description
		/// </summary>
		DescriptionHasPriceQualifiers,
		/// <summary>
		/// Unsupported language
		/// </summary>
		UnsupportedLanguage,
		/// <summary>
		/// Price item header is not relevant to the price type
		/// </summary>
		TableRowHeaderTableTypeMismatch,
		/// <summary>
		/// Price item header has promotional text
		/// </summary>
		TableRowHeaderHasPromotionalText,
		/// <summary>
		/// Price item description is not relevant to the item header
		/// </summary>
		TableRowDescriptionNotRelevant,
		/// <summary>
		/// Price item description contains promotional text
		/// </summary>
		TableRowDescriptionHasPromotionalText,
		/// <summary>
		/// Price item header and description are repetitive
		/// </summary>
		TableRowHeaderDescriptionRepetitive,
		/// <summary>
		/// Price item is in a foreign language, nonsense, or can't be rated
		/// </summary>
		TableRowUnrateable,
		/// <summary>
		/// Price item price is invalid or inaccurate
		/// </summary>
		TableRowPriceInvalid,
		/// <summary>
		/// Price item url is invalid or irrelevant
		/// </summary>
		TableRowUrlInvalid,
		/// <summary>
		/// Header or description has price
		/// </summary>
		HeaderOrDescriptionHasPrice,
		/// <summary>
		/// Snippet values do not match the header
		/// </summary>
		StructuredSnippetsHeaderPolicyViolated,
		/// <summary>
		/// Snippet values are repeated
		/// </summary>
		StructuredSnippetsRepeatedValues,
		/// <summary>
		/// Snippet values violate editorial guidelines like punctuation
		/// </summary>
		StructuredSnippetsEditorialGuidelines,
		/// <summary>
		/// Snippets contain promotional text
		/// </summary>
		StructuredSnippetsHasPromotionalText
	}
	
	public enum FeedItemStatus
	{
		/// <summary>
		/// Feed item is active
		/// </summary>
		Enabled,
		/// <summary>
		/// Feed item is removed
		/// </summary>
		Removed,
		/// <summary>
		/// Unknown status
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Validation status of a FeedItem.
	/// </summary>
	public enum FeedItemValidationStatus
	{
		/// <summary>
		/// Validation pending.
		/// </summary>
		Unchecked,
		/// <summary>
		/// An error was found.
		/// </summary>
		Error,
		/// <summary>
		/// FeedItem is semantically well-formed.
		/// </summary>
		Valid
	}
	
	public enum FeedMappingErrorReason
	{
		/// <summary>
		/// The given placeholder field does not exist.
		/// </summary>
		InvalidPlaceholderField,
		/// <summary>
		/// The given criterion field does not exist.
		/// </summary>
		InvalidCriterionField,
		/// <summary>
		/// The given placeholder type does not exist.
		/// </summary>
		InvalidPlaceholderType,
		/// <summary>
		/// The given criterion type does not exist.
		/// </summary>
		InvalidCriterionType,
		/// <summary>
		/// Cannot specify both placeholder type and criterion type.
		/// </summary>
		CannotSetPlaceholderTypeAndCriterionType,
		/// <summary>
		/// A feed mapping must contain at least one attribute field mapping.
		/// </summary>
		NoAttributeFieldMappings,
		/// <summary>
		/// The type of the feed attribute referenced in the attribute field mapping must match
		/// the type of the placeholder field.
		/// </summary>
		FeedAttributeTypeMismatch,
		/// <summary>
		/// A feed mapping for a system generated feed cannot be operated on.
		/// </summary>
		CannotOperateOnMappingsForSystemGeneratedFeed,
		/// <summary>
		/// Only one feed mapping for a placeholder type is allowed per feed or customer
		/// (depending on the placeholder type).
		/// </summary>
		MultipleMappingsForPlaceholderType,
		/// <summary>
		/// Only one feed mapping for a criterion type is allowed per customer.
		/// </summary>
		MultipleMappingsForCriterionType,
		/// <summary>
		/// Only one feed attribute mapping for a placeholder field is allowed
		/// (depending on the placeholder type).
		/// </summary>
		MultipleMappingsForPlaceholderField,
		/// <summary>
		/// Only one feed attribute mapping for a criterion field is allowed
		/// (depending on the criterion type).
		/// </summary>
		MultipleMappingsForCriterionField,
		/// <summary>
		/// This feed mapping may not contain any explicit attribute field mappings.
		/// </summary>
		UnexpectedAttributeFieldMappings,
		/// <summary>
		/// Location placeholder feedmappings can only be created for Places feeds.
		/// </summary>
		LocationPlaceholderOnlyForPlacesFeeds,
		/// <summary>
		/// Mappings for typed feeds cannot be modified.
		/// </summary>
		CannotModifyMappingsForTypedFeed,
		Unknown
	}
	
	public enum FeedMappingStatus
	{
		/// <summary>
		/// This mapping is used in feeds.
		/// </summary>
		Enabled,
		/// <summary>
		/// This mapping is not used anymore.
		/// </summary>
		Removed,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Used to Specify who manages the {@link FeedAttribute}s for the {@link Feed}.
	/// </summary>
	public enum FeedOrigin
	{
		/// <summary>
		/// The {@link FeedAttribute}s for this {@link Feed} are managed by the user.
		/// Users can add {@link FeedAttribute}s to this {@link Feed}.
		/// </summary>
		User,
		/// <summary>
		/// The {@link FeedAttribute}s for an ADWORDS {@link Feed} are created
		/// by ADWORDS. Occasionally the attributes defined for a particular type
		/// of {@link Feed} is expanded. In this case, older {@link Feed}s of this
		/// type can be mutated to add the expanded attributes.
		/// </summary>
		Adwords,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Status of the Feed.
	/// </summary>
	public enum FeedStatus
	{
		/// <summary>
		/// This Feed's data can be used in placeholders.
		/// </summary>
		Enabled,
		/// <summary>
		/// This Feed's data is not used anymore.
		/// </summary>
		Removed,
		/// <summary>
		/// Unknown status.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Feed hard type. Values coincide with placeholder type id.
	/// </summary>
	public enum FeedType
	{
		None,
		/// <summary>
		/// Sitelink placeholder typed
		/// </summary>
		Sitelink,
		/// <summary>
		/// Call placeholder typed
		/// </summary>
		Call,
		/// <summary>
		/// App placeholder typed
		/// </summary>
		App,
		/// <summary>
		/// Review placeholder typed
		/// </summary>
		Review,
		/// <summary>
		/// AdCustomizer placeholder typed
		/// </summary>
		AdCustomizer,
		/// <summary>
		/// Callout placeholder typed
		/// </summary>
		Callout,
		/// <summary>
		/// Structured snippets placeholder typed
		/// </summary>
		StructuredSnippet,
		/// <summary>
		/// Price placeholder typed
		/// </summary>
		Price
	}
	
	/// <summary>
	/// The reason for the error.
	/// </summary>
	public enum ForwardCompatibilityErrorReason
	{
		/// <summary>
		/// Invalid value specified for a key in the forward compatibility map.
		/// </summary>
		InvalidForwardCompatibilityMapValue,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum FunctionErrorReason
	{
		/// <summary>
		/// The format of the function is not recognized as a supported function format.
		/// </summary>
		InvalidFunctionFormat,
		/// <summary>
		/// Operand data types do not match.
		/// </summary>
		DataTypeMismatch,
		/// <summary>
		/// The operands cannot be used together in a conjunction.
		/// </summary>
		InvalidConjunctionOperands,
		/// <summary>
		/// Invalid numer of Operands.
		/// </summary>
		InvalidNumberOfOperands,
		/// <summary>
		/// Operand Type not supported.
		/// </summary>
		InvalidOperandType,
		/// <summary>
		/// Operator not supported.
		/// </summary>
		InvalidOperator,
		/// <summary>
		/// Request context type not supported.
		/// </summary>
		InvalidRequestContextType,
		/// <summary>
		/// The matching function is not allowed for call placeholders
		/// </summary>
		InvalidFunctionForCallPlaceholder,
		/// <summary>
		/// The matching function is not allowed for the specified placeholder
		/// </summary>
		InvalidFunctionForPlaceholder,
		/// <summary>
		/// Invalid operand.
		/// </summary>
		InvalidOperand,
		/// <summary>
		/// Missing value for the constant operand.
		/// </summary>
		MissingConstantOperandValue,
		/// <summary>
		/// The value of the constant operand is invalid.
		/// </summary>
		InvalidConstantOperandValue,
		/// <summary>
		/// Invalid function nesting.
		/// </summary>
		InvalidNesting,
		/// <summary>
		/// The Feed ID was different from another Feed ID in the same function.
		/// </summary>
		MultipleFeedIdsNotSupported,
		/// <summary>
		/// The matching function is invalid for use with a feed with a fixed schema.
		/// </summary>
		InvalidFunctionForFeedWithFixedSchema,
		/// <summary>
		/// Invalid attribute name.
		/// </summary>
		InvalidAttributeName,
		Unknown
	}
	
	/// <summary>
	/// Operators that can be used in functions.
	/// </summary>
	public enum FunctionOperator
	{
		/// <summary>
		/// The IN operator.
		/// </summary>
		In,
		/// <summary>
		/// The IDENTITY operator.
		/// </summary>
		Identity,
		/// <summary>
		/// The EQUALS operator
		/// </summary>
		Equals,
		/// <summary>
		/// Operator that takes two or more operands that are of type FunctionOperand
		/// and checks that all the operands evaluate to true.
		/// For functions related to ad formats, all the operands must be in lhsOperand.
		/// Return ConstantOperand with Bool type.
		/// </summary>
		And,
		/// <summary>
		/// Operator that returns true if the elements in lhsOperand contains any of the elements
		/// in rhsOperands. Otherwise, return false.
		/// </summary>
		ContainsAny,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Function parsing error reason.
	/// </summary>
	public enum FunctionParsingErrorReason
	{
		/// <summary>
		/// Unexpected end of function string.
		/// </summary>
		NoMoreInput,
		/// <summary>
		/// Could not find an expected character.
		/// </summary>
		ExpectedCharacter,
		/// <summary>
		/// Unexpected separator character.
		/// </summary>
		UnexpectedSeparator,
		/// <summary>
		/// Unmatched left bracket or parenthesis.
		/// </summary>
		UnmatchedLeftBracket,
		/// <summary>
		/// Unmatched right bracket or parenthesis.
		/// </summary>
		UnmatchedRightBracket,
		/// <summary>
		/// Functions are nested too deeply.
		/// </summary>
		TooManyNestedFunctions,
		/// <summary>
		/// Missing right-hand-side operand.
		/// </summary>
		MissingRightHandOperand,
		/// <summary>
		/// Invalid operator/function name.
		/// </summary>
		InvalidOperatorName,
		/// <summary>
		/// Feed attribute operand's argument is not an integer.
		/// </summary>
		FeedAttributeOperandArgumentNotInteger,
		/// <summary>
		/// Missing function operands.
		/// </summary>
		NoOperands,
		/// <summary>
		/// Function had too many operands.
		/// </summary>
		TooManyOperands,
		Unknown
	}
	
	public enum GenderGenderType
	{
		GenderMale,
		GenderFemale,
		GenderUndetermined
	}
	
	/// <summary>
	/// A restriction used to determine if the request context's geo should be matched.
	/// </summary>
	public enum GeoRestriction
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Indicates that request context should match the physical location of the user.
		/// </summary>
		LocationOfPresence
	}
	
	/// <summary>
	/// The various signals a negative location target may use.
	/// </summary>
	public enum GeoTargetTypeSettingNegativeGeoTargetType
	{
		/// <summary>
		/// Specifies that a user is excluded from seeing the ad
		/// if either their AOI or their LOP matches the geo target.
		/// </summary>
		DontCare,
		/// <summary>
		/// Specifies that a user is excluded from seeing the ad
		/// only if their LOP matches the geo target.
		/// </summary>
		LocationOfPresence
	}
	
	/// <summary>
	/// The various signals a positive location target may use.
	/// </summary>
	public enum GeoTargetTypeSettingPositiveGeoTargetType
	{
		/// <summary>
		/// Specifies that either AOI or LOP may trigger the ad.
		/// </summary>
		DontCare,
		/// <summary>
		/// Specifies that the ad is triggered only if the user's AOI matches.
		/// </summary>
		AreaOfInterest,
		/// <summary>
		/// Specifies that the ad is triggered only if the user's LOP matches.
		/// </summary>
		LocationOfPresence
	}
	
	/// <summary>
	/// Represents the type of idea.
	/// <span class="constraint AdxEnabled">This is disabled for AdX.</span>
	/// </summary>
	public enum IdeaType
	{
		/// <summary>
		/// Keyword idea.
		/// </summary>
		Keyword
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum IdErrorReason
	{
		/// <summary>
		/// Id not found
		/// </summary>
		NotFound
	}
	
	public enum ImageErrorReason
	{
		/// <summary>
		/// The image is not valid.
		/// </summary>
		InvalidImage,
		/// <summary>
		/// The image could not be stored.
		/// </summary>
		StorageError,
		/// <summary>
		/// There was a problem with the request.
		/// </summary>
		BadRequest,
		/// <summary>
		/// The image is not of legal dimensions.
		/// </summary>
		UnexpectedSize,
		/// <summary>
		/// Animated image are not permitted.
		/// </summary>
		AnimatedNotAllowed,
		/// <summary>
		/// Animation is too long.
		/// </summary>
		AnimationTooLong,
		/// <summary>
		/// There was an error on the server.
		/// </summary>
		ServerError,
		/// <summary>
		/// Image cannot be in CMYK color format.
		/// </summary>
		CmykJpegNotAllowed,
		/// <summary>
		/// Flash images are not permitted.
		/// </summary>
		FlashNotAllowed,
		/// <summary>
		/// Flash images must support clickTag.
		/// </summary>
		FlashWithoutClicktag,
		/// <summary>
		/// A flash error has occurred after fixing the click tag.
		/// </summary>
		FlashErrorAfterFixingClickTag,
		/// <summary>
		/// Unacceptable visual effects.
		/// </summary>
		AnimatedVisualEffect,
		/// <summary>
		/// There was a problem with the flash image.
		/// </summary>
		FlashError,
		/// <summary>
		/// Incorrect image layout.
		/// </summary>
		LayoutProblem,
		/// <summary>
		/// There was a problem reading the image file.
		/// </summary>
		ProblemReadingImageFile,
		/// <summary>
		/// There was an error storing the image.
		/// </summary>
		ErrorStoringImage,
		/// <summary>
		/// The aspect ratio of the image is not allowed.
		/// </summary>
		AspectRatioNotAllowed,
		/// <summary>
		/// Flash cannot have network objects.
		/// </summary>
		FlashHasNetworkObjects,
		/// <summary>
		/// Flash cannot have network methods.
		/// </summary>
		FlashHasNetworkMethods,
		/// <summary>
		/// Flash cannot have a Url.
		/// </summary>
		FlashHasUrl,
		/// <summary>
		/// Flash cannot use mouse tracking.
		/// </summary>
		FlashHasMouseTracking,
		/// <summary>
		/// Flash cannot have a random number.
		/// </summary>
		FlashHasRandomNum,
		/// <summary>
		/// Ad click target cannot be '_self'.
		/// </summary>
		FlashSelfTargets,
		/// <summary>
		/// GetUrl method should only use '_blank'.
		/// </summary>
		FlashBadGeturlTarget,
		/// <summary>
		/// Flash version is not supported.
		/// </summary>
		FlashVersionNotSupported,
		/// <summary>
		/// Flash movies need to have hard coded click URL or clickTAG
		/// </summary>
		FlashWithoutHardCodedClickUrl,
		/// <summary>
		/// Uploaded flash file is corrupted.
		/// </summary>
		InvalidFlashFile,
		/// <summary>
		/// Uploaded flash file can be parsed, but the click tag can not be fixed properly.
		/// </summary>
		FailedToFixClickTagInFlash,
		/// <summary>
		/// Flash movie accesses network resources
		/// </summary>
		FlashAccessesNetworkResources,
		/// <summary>
		/// Flash movie attempts to call external javascript code
		/// </summary>
		FlashExternalJsCall,
		/// <summary>
		/// Flash movie attempts to call flash system commands
		/// </summary>
		FlashExternalFsCall,
		/// <summary>
		/// Image file is too large.
		/// </summary>
		FileTooLarge,
		/// <summary>
		/// Image data is too large.
		/// </summary>
		ImageDataTooLarge,
		/// <summary>
		/// Error while processing the image.
		/// </summary>
		ImageProcessingError,
		/// <summary>
		/// Image is too small.
		/// </summary>
		ImageTooSmall,
		/// <summary>
		/// Input was invalid.
		/// </summary>
		InvalidInput,
		/// <summary>
		/// There was a problem reading the image file.
		/// </summary>
		ProblemReadingFile
	}
	
	/// <summary>
	/// Income tiers that specify the income bracket a household falls under. TIER_1
	/// belongs to the highest income bracket. The income bracket range associated with
	/// each tier is defined per country and computed based on income percentiles.
	/// </summary>
	public enum IncomeTier
	{
		Unknown,
		Tier1,
		Tier2,
		Tier3,
		Tier4,
		Tier5,
		/// <summary>
		/// Bucket consisting of the bottom 5 tiers, specifying the bottom 50% of household
		/// income zip codes.
		/// </summary>
		Tier6To10
	}
	
	/// <summary>
	/// The single reason for the internal API error.
	/// </summary>
	public enum InternalApiErrorReason
	{
		/// <summary>
		/// API encountered an unexpected internal error.
		/// </summary>
		UnexpectedInternalApiError,
		/// <summary>
		/// A temporary error occurred during the request. Please retry.
		/// </summary>
		TransientError,
		/// <summary>
		/// The cause of the error is not known or only defined in newer versions.
		/// </summary>
		Unknown,
		/// <summary>
		/// The API is currently unavailable for a planned downtime.
		/// </summary>
		Downtime
	}
	
	/// <summary>
	/// Match type of a keyword. i.e. the way we match a keyword string with
	/// search queries.
	/// </summary>
	public enum KeywordMatchType
	{
		/// <summary>
		/// Exact match
		/// </summary>
		Exact,
		/// <summary>
		/// Phrase match
		/// </summary>
		Phrase,
		/// <summary>
		/// Broad match
		/// </summary>
		Broad
	}
	
	/// <summary>
	/// The reasons for the label error.
	/// </summary>
	public enum LabelErrorReason
	{
		/// <summary>
		/// Label name must be unique.
		/// </summary>
		DuplicateName,
		/// <summary>
		/// Label names cannot be empty
		/// </summary>
		InvalidLabelName,
		/// <summary>
		/// Invalid Label type. A specific type of Label is required.
		/// </summary>
		InvalidLabelType,
		/// <summary>
		/// Default error.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	public enum LabelServiceErrorReason
	{
		/// <summary>
		/// The label name is empty.
		/// </summary>
		EmptyLabelName,
		/// <summary>
		/// The label name is longer than max allowed size.
		/// </summary>
		LabelNameTooLong,
		/// <summary>
		/// The customer already has an active label with the same name.
		/// </summary>
		DuplicateLabelName,
		/// <summary>
		/// The label name is reserved by the system.
		/// </summary>
		ReservedLabelName,
		/// <summary>
		/// The label cannot be deleted
		/// </summary>
		CannotBeDeleted,
		/// <summary>
		/// A customer cannot own more than 200 labels.
		/// </summary>
		TooManyLabels,
		/// <summary>
		/// Label id was not found.
		/// </summary>
		InvalidLabelId,
		/// <summary>
		/// This customer cannot create labels.  Only manager customers may create labels.
		/// </summary>
		CustomerCannotCreateLabels,
		/// <summary>
		/// An unknown enum value has been given for this error reason.
		/// </summary>
		ServerClientVersionMismatch
	}
	
	public enum LabelStatus
	{
		/// <summary>
		/// The label is enabled.
		/// </summary>
		Enabled,
		/// <summary>
		/// The label has been removed.
		/// </summary>
		Removed,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The level on which the cap is to be applied.
	/// </summary>
	public enum Level
	{
		/// <summary>
		/// The cap is applied at the creative level.
		/// </summary>
		Creative,
		/// <summary>
		/// The cap is applied at the ad group level.
		/// </summary>
		Adgroup,
		/// <summary>
		/// The cap is applied at the campaign level.
		/// </summary>
		Campaign,
		/// <summary>
		/// This value cannot be set by the user and sent to the AdWords API servers,
		/// as it would generate a RejectedError.
		/// It can only be received by the user from the AdWords API servers and it
		/// means that a new value available in a newer API release version is not
		/// known in the current API release version.
		/// If the user encounters this value, it means an upgrade is required
		/// in order to take advantage of the latest AdWords API functionality.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// These status values match the values in the ServicedAccounts.Status column.
	/// </summary>
	public enum LinkStatus
	{
		/// <summary>
		/// An active relationship.
		/// </summary>
		Active,
		/// <summary>
		/// A former active relationship.
		/// </summary>
		Inactive,
		/// <summary>
		/// An invitation that is active or has expired.
		/// </summary>
		Pending,
		/// <summary>
		/// An invitation that was refused by the invitee.
		/// </summary>
		Refused,
		/// <summary>
		/// An invitation that was cancelled by the invitor.
		/// </summary>
		Cancelled,
		Unknown
	}
	
	/// <summary>
	/// The reason for the error.
	/// </summary>
	public enum ListErrorReason
	{
		/// <summary>
		/// A request attempted to clear a list that does not support being cleared.
		/// </summary>
		ClearUnsupported,
		/// <summary>
		/// The operator is invalid for the list or list element the operator was applied to.
		/// </summary>
		InvalidOperator,
		/// <summary>
		/// An UPDATE or REMOVE was requested for a list element that does not exist.
		/// </summary>
		InvalidElement,
		/// <summary>
		/// The operator list has different a size compared to the element list.
		/// </summary>
		ListLengthMismatch,
		/// <summary>
		/// Duplicate elements inside list.
		/// </summary>
		DuplicateElement,
		/// <summary>
		/// The API operator of the mutate being performed on the entity containing this list is not
		/// supported.
		/// </summary>
		MutateUnsupported,
		Unknown
	}
	
	/// <summary>
	/// Specifies the intended behavior for a list element.
	/// </summary>
	public enum ListOperationsListOperator
	{
		/// <summary>
		/// Adds to a list, or overrides an existing element if it exists.
		/// </summary>
		Put,
		/// <summary>
		/// Removes this element from the list.
		/// </summary>
		Remove,
		/// <summary>
		/// Updates this element with the existing behavior of null fields inside the list element being
		/// a no-op. If the element doesn't exist it is added.
		/// </summary>
		Update,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Reasons for error.
	/// </summary>
	public enum LocationCriterionServiceErrorReason
	{
		RequiredLocationCriterionPredicateMissing,
		TooManyLocationCriterionPredicatesSpecified,
		InvalidCountryCode,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		LocationCriterionServiceError
	}
	
	/// <summary>
	/// Enum that represents the different Targeting Status values for a Location criterion.
	/// </summary>
	public enum LocationTargetingStatus
	{
		/// <summary>
		/// The location is active.
		/// </summary>
		Active,
		/// <summary>
		/// The location is not available for targeting.
		/// </summary>
		Obsolete,
		/// <summary>
		/// The location is phasing out, it will marked obsolete soon.
		/// </summary>
		PhasingOut
	}
	
	public enum ManagedCustomerServiceErrorReason
	{
		/// <summary>
		/// Unknown.
		/// </summary>
		Unknown,
		/// <summary>
		/// The user is not authorized to perform the action.
		/// </summary>
		NotAuthorized,
		/// <summary>
		/// Invalid selector
		/// </summary>
		InvalidSelector,
		/// <summary>
		/// Can't process the passed in timezone.
		/// </summary>
		InvalidTimezone,
		/// <summary>
		/// Can't process the passed in currency code.
		/// </summary>
		InvalidCurrency,
		/// <summary>
		/// Can't process the passed in descriptive name.
		/// </summary>
		InvalidDescriptiveName,
		/// <summary>
		/// Generic error during add customer process.
		/// </summary>
		AddCustomerFailure,
		/// <summary>
		/// There was a problem saving the modified customers, and some of the customers may not
		/// have been saved successfully.
		/// </summary>
		SaveCustomersFailure,
		/// <summary>
		/// Attempt to establish a link with a client that is already managed by the manager.
		/// </summary>
		AlreadyManagedByThisManager,
		/// <summary>
		/// Attempt to invite a client that has already been invited by the manager.
		/// </summary>
		AlreadyInvitedByThisManager,
		/// <summary>
		/// Already managed by some other manager in the hierarchy.
		/// </summary>
		AlreadyManagedInHierarchy,
		/// <summary>
		/// Client is managed by another manager for UI access already.
		/// </summary>
		AlreadyManagedForUiAccess,
		/// <summary>
		/// Attempt to exceed the maximum hierarchy depth.
		/// </summary>
		MaxLinkDepthExceeded,
		/// <summary>
		/// Attempt to accept an invitation that doesn't exist.
		/// </summary>
		NoPendingInvitation,
		/// <summary>
		/// Manager account has the maximum number of linked accounts.
		/// </summary>
		TooManyAccounts,
		/// <summary>
		/// Your manager's account has the maximum number of linked accounts.
		/// </summary>
		TooManyAccountsAtManager,
		/// <summary>
		/// The invitee has already linked with max allowed number of UI and API managers.
		/// </summary>
		TooManyUiApiManagers,
		/// <summary>
		/// Error involving test accounts (mixed types) or too many child accounts.
		/// </summary>
		TestAccountLinkError,
		/// <summary>
		/// Label id was not found, or is not owned by the requesting customer.
		/// </summary>
		InvalidLabelId,
		/// <summary>
		/// Deleted labels cannot be applied to customers.
		/// </summary>
		CannotApplyInactiveLabel,
		/// <summary>
		/// A label cannot be applied to more than 1000 customers.
		/// </summary>
		AppliedLabelToTooManyAccounts
	}
	
	/// <summary>
	/// Enumeration of the reasons for the {@link MediaBundleError}
	/// </summary>
	public enum MediaBundleErrorReason
	{
		/// <summary>
		/// The entryPoint field cannot be set using the <code>MediaService</code>.
		/// </summary>
		EntryPointCannotBeSetUsingMediaService,
		/// <summary>
		/// There was a problem with the request.
		/// </summary>
		BadRequest,
		/// <summary>
		/// HTML5 ads using DoubleClick Studio created ZIP files are not supported.
		/// </summary>
		DoubleclickBundleNotAllowed,
		/// <summary>
		/// Cannot reference URL external to the media bundle.
		/// </summary>
		ExternalUrlNotAllowed,
		/// <summary>
		/// Media bundle file is too large.
		/// </summary>
		FileTooLarge,
		/// <summary>
		/// ZIP file from Google Web Designer is not published.
		/// </summary>
		GoogleWebDesignerZipFileNotPublished,
		/// <summary>
		/// Input was invalid.
		/// </summary>
		InvalidInput,
		/// <summary>
		/// There was a problem with the media bundle.
		/// </summary>
		InvalidMediaBundle,
		/// <summary>
		/// There was a problem with one or more of the media bundle entries.
		/// </summary>
		InvalidMediaBundleEntry,
		/// <summary>
		/// The media bundle contains a file with an unknown mime type
		/// </summary>
		InvalidMimeType,
		/// <summary>
		/// The media bundle contain an invalid asset path.
		/// </summary>
		InvalidPath,
		/// <summary>
		/// HTML5 ad is trying to reference an asset not in .ZIP file
		/// </summary>
		InvalidUrlReference,
		/// <summary>
		/// Media data is too large.
		/// </summary>
		MediaDataTooLarge,
		/// <summary>
		/// The media bundle contains no primary entry.
		/// </summary>
		MissingPrimaryMediaBundleEntry,
		/// <summary>
		/// There was an error on the server.
		/// </summary>
		ServerError,
		/// <summary>
		/// The image could not be stored.
		/// </summary>
		StorageError,
		/// <summary>
		/// Media bundle created with the Swiffy tool is not allowed.
		/// </summary>
		SwiffyBundleNotAllowed,
		/// <summary>
		/// The media bundle contains too many files.
		/// </summary>
		TooManyFiles,
		/// <summary>
		/// The media bundle is not of legal dimensions.
		/// </summary>
		UnexpectedSize,
		/// <summary>
		/// Google Web Designer not created for "AdWords" environment.
		/// </summary>
		UnsupportedGoogleWebDesignerEnvironment,
		/// <summary>
		/// Unsupported HTML5 feature in HTML5 asset.
		/// </summary>
		UnsupportedHtml5Feature,
		/// <summary>
		/// URL in HTML5 entry is not ssl compliant.
		/// </summary>
		UrlInMediaBundleNotSslCompliant
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum MediaErrorReason
	{
		/// <summary>
		/// Cannot add a standard icon type
		/// </summary>
		CannotAddStandardIcon,
		/// <summary>
		/// May only select Standard Icons alone
		/// </summary>
		CannotSelectStandardIconWithOtherTypes,
		/// <summary>
		/// Image contains both a media ID and media data.
		/// </summary>
		CannotSpecifyMediaIdAndData,
		/// <summary>
		/// A media with given type and reference id already exists
		/// </summary>
		DuplicateMedia,
		/// <summary>
		/// A required field was not specified or is an empty string.
		/// </summary>
		EmptyField,
		/// <summary>
		/// A media may only be modified once per call
		/// </summary>
		EntityReferencedInMultipleOps,
		/// <summary>
		/// Field is not supported for the media sub type.
		/// </summary>
		FieldNotSupportedForMediaSubType,
		/// <summary>
		/// The media id is invalid
		/// </summary>
		InvalidMediaId,
		/// <summary>
		/// The media subtype is invalid
		/// </summary>
		InvalidMediaSubType,
		/// <summary>
		/// The media type is invalid
		/// </summary>
		InvalidMediaType,
		/// <summary>
		/// The mimetype is invalid
		/// </summary>
		InvalidMimeType,
		/// <summary>
		/// The media reference id is invalid
		/// </summary>
		InvalidReferenceId,
		/// <summary>
		/// The YouTube video id is invalid
		/// </summary>
		InvalidYouTubeId,
		/// <summary>
		/// Media has failed transcoding
		/// </summary>
		MediaFailedTranscoding,
		/// <summary>
		/// Media has not been transcoded
		/// </summary>
		MediaNotTranscoded,
		/// <summary>
		/// The MediaType does not match the actual media object's type
		/// </summary>
		MediaTypeDoesNotMatchObjectType,
		/// <summary>
		/// None of the fields have been specified.
		/// </summary>
		NoFieldsSpecified,
		/// <summary>
		/// One of reference Id or media Id must be specified
		/// </summary>
		NullReferenceIdAndMediaId,
		/// <summary>
		/// The string has too many characters.
		/// </summary>
		TooLong,
		/// <summary>
		/// The specified operation is not supported.  Only ADD, SET, and REMOVE
		/// are supported
		/// </summary>
		UnsupportedOperation,
		/// <summary>
		/// The specified type is not supported.
		/// </summary>
		UnsupportedType,
		/// <summary>
		/// YouTube is unavailable for requesting video data.
		/// </summary>
		YouTubeServiceUnavailable,
		/// <summary>
		/// The YouTube video has a non positive duration.
		/// </summary>
		YouTubeVideoHasNonPositiveDuration,
		/// <summary>
		/// The YouTube video id is syntactically valid but the video was not found.
		/// </summary>
		YouTubeVideoNotFound
	}
	
	/// <summary>
	/// Media types
	/// </summary>
	public enum MediaMediaType
	{
		/// <summary>
		/// Audio file.
		/// </summary>
		Audio,
		/// <summary>
		/// Animated image, such as animated GIF.
		/// </summary>
		DynamicImage,
		/// <summary>
		/// Small image; used for map ad.
		/// </summary>
		Icon,
		/// <summary>
		/// Static image; for image ad.
		/// </summary>
		Image,
		/// <summary>
		/// Predefined standard icon; used for map ads.
		/// </summary>
		StandardIcon,
		/// <summary>
		/// Video file.
		/// </summary>
		Video,
		/// <summary>
		/// ZIP file; used in fields of template ads.
		/// </summary>
		MediaBundle
	}
	
	/// <summary>
	/// Mime types
	/// </summary>
	public enum MediaMimeType
	{
		/// <summary>
		/// MIME type of image/jpeg
		/// </summary>
		ImageJpeg,
		/// <summary>
		/// MIME type of image/gif
		/// </summary>
		ImageGif,
		/// <summary>
		/// MIME type of image/png
		/// </summary>
		ImagePng,
		/// <summary>
		/// MIME type of application/x-shockwave-flash
		/// </summary>
		Flash,
		/// <summary>
		/// MIME type of text/html
		/// </summary>
		TextHtml,
		/// <summary>
		/// MIME type of application/pdf
		/// </summary>
		Pdf,
		/// <summary>
		/// MIME type of application/msword
		/// </summary>
		Msword,
		/// <summary>
		/// MIME type of application/vnd.ms-excel
		/// </summary>
		Msexcel,
		/// <summary>
		/// MIME type of application/rtf
		/// </summary>
		Rtf,
		/// <summary>
		/// MIME type of audio/wav
		/// </summary>
		AudioWav,
		/// <summary>
		/// MIME type of audio/mp3
		/// </summary>
		AudioMp3,
		/// <summary>
		/// MIME type of application/x-html5-ad-zip
		/// </summary>
		Html5AdZip
	}
	
	/// <summary>
	/// Sizes for retrieving the original media
	/// </summary>
	public enum MediaSize
	{
		/// <summary>
		/// Full size of Media.
		/// </summary>
		Full,
		/// <summary>
		/// Shunken size of media.
		/// </summary>
		Shrunken,
		/// <summary>
		/// Preview size of media.
		/// </summary>
		Preview,
		/// <summary>
		/// Video thumbnail size of Media.
		/// </summary>
		VideoThumbnail
	}
	
	/// <summary>
	/// Minutes in an hour.  Currently only 0, 15, 30, and 45 are supported
	/// </summary>
	public enum MinuteOfHour
	{
		/// <summary>
		/// Zero minutes past hour.
		/// </summary>
		Zero,
		/// <summary>
		/// Fifteen minutes past hour.
		/// </summary>
		Fifteen,
		/// <summary>
		/// Thirty minutes past hour.
		/// </summary>
		Thirty,
		/// <summary>
		/// Forty-five minutes past hour.
		/// </summary>
		FortyFive
	}
	
	public enum MobileDeviceDeviceType
	{
		DeviceTypeMobile,
		DeviceTypeTablet
	}
	
	/// <summary>
	/// Reason for bidding error.
	/// </summary>
	public enum MultiplierErrorReason
	{
		/// <summary>
		/// Multiplier value is too high
		/// </summary>
		MultiplierTooHigh,
		/// <summary>
		/// Multiplier value is too low
		/// </summary>
		MultiplierTooLow,
		/// <summary>
		/// Too many fractional digits
		/// </summary>
		TooManyFractionalDigits,
		/// <summary>
		/// A multiplier cannot be set for this bidding strategy
		/// </summary>
		MultiplierNotAllowedForBiddingStrategy,
		/// <summary>
		/// A multiplier cannot be set when there is no base bid (e.g., content max cpc)
		/// </summary>
		MultiplierNotAllowedWhenBaseBidIsMissing,
		/// <summary>
		/// A bid multiplier must be specified
		/// </summary>
		NoMultiplierSpecified,
		/// <summary>
		/// Multiplier causes bid to exceed daily budget
		/// </summary>
		MultiplierCausesBidToExceedDailyBudget,
		/// <summary>
		/// Multiplier causes bid to exceed monthly budget
		/// </summary>
		MultiplierCausesBidToExceedMonthlyBudget,
		/// <summary>
		/// Multiplier causes bid to exceed custom budget
		/// </summary>
		MultiplierCausesBidToExceedCustomBudget,
		/// <summary>
		/// Multiplier causes bid to exceed maximum allowed bid
		/// </summary>
		MultiplierCausesBidToExceedMaxAllowedBid,
		/// <summary>
		/// Multiplier causes bid to become less than the minimum bid allowed
		/// </summary>
		BidLessThanMinAllowedBidWithMultiplier,
		/// <summary>
		/// Multiplier type (cpc vs. cpm) needs to match campaign's bidding strategy
		/// </summary>
		MultiplierAndBiddingStrategyTypeMismatch,
		MultiplierError
	}
	
	/// <summary>
	/// Reasons
	/// </summary>
	public enum MutateMembersErrorReason
	{
		Unknown,
		UnsupportedMethod,
		InvalidUserListId,
		InvalidUserListType,
		InvalidDataType,
		InvalidSha256Format,
		OperatorConflictForSameUserListId,
		InvalidRemoveallOperation,
		InvalidOperationOrder
	}
	
	/// <summary>
	/// Represents the different type of the member data entity.
	/// </summary>
	public enum MutateMembersOperandDataType
	{
		/// <summary>
		/// Indicates each member is a hashed email address using SHA-256
		/// hash function.
		/// </summary>
		EmailSha256
	}
	
	public enum NewEntityCreationErrorReason
	{
		/// <summary>
		/// Do not set the id field while creating new entities.
		/// </summary>
		CannotSetIdForAdd,
		/// <summary>
		/// Creating more than one entity with the same temp ID is not allowed.
		/// </summary>
		DuplicateTempIds,
		/// <summary>
		/// Parent object with specified temp id failed validation, so no deep
		/// validation will be done for this child entity.
		/// </summary>
		TempIdEntityHadErrors
	}
	
	/// <summary>
	/// The reasons for the validation error.
	/// </summary>
	public enum NotEmptyErrorReason
	{
		EmptyList
	}
	
	/// <summary>
	/// The single reason for the whitelist error.
	/// </summary>
	public enum NotWhitelistedErrorReason
	{
		/// <summary>
		/// Customer is not whitelisted for accessing the API.
		/// </summary>
		CustomerNotWhitelistedForApi
	}
	
	/// <summary>
	/// The reasons for the validation error.
	/// </summary>
	public enum NullErrorReason
	{
		/// <summary>
		/// Specified list/container must not contain any null elements
		/// </summary>
		NullContent
	}
	
	/// <summary>
	/// Supported operator for numbers.
	/// </summary>
	public enum NumberRuleItemNumberOperator
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		GreaterThan,
		GreaterThanOrEqual,
		Equals,
		NotEqual,
		LessThan,
		LessThanOrEqual
	}
	
	/// <summary>
	/// The reasons for an OfflineCallConversionError.
	/// </summary>
	public enum OfflineCallConversionErrorReason
	{
		/// <summary>
		/// The conversion time cannot precede the call time.
		/// </summary>
		ConversionPrecedesCall,
		/// <summary>
		/// You cannot set a future call start time.
		/// </summary>
		FutureCallStartTime,
		/// <summary>
		/// You cannot set a future conversion time.
		/// </summary>
		FutureConversionTime,
		/// <summary>
		/// The click that initiated the call is too old for this conversion to be imported.
		/// </summary>
		ExpiredCall,
		/// <summary>
		/// We are still processing this call's information, please re-upload this conversion in 4-6
		/// hours.
		/// </summary>
		TooRecentCall,
		/// <summary>
		/// The caller?s phone number cannot be parsed. Please re-upload in one of the supported formats.
		/// It should be formatted either as E.164 "+16502531234", International "+64 3-331 6005" or as
		/// a US national number ?6502531234?.
		/// </summary>
		UnparseableCallersPhoneNumber,
		/// <summary>
		/// We are unable to import a conversion for this call, since either this call or the click
		/// leading to the call was not found in our system.
		/// </summary>
		InvalidCall,
		/// <summary>
		/// This call belongs to an account that you are not authorized to access.
		/// </summary>
		UnauthorizedUser,
		/// <summary>
		/// We cannot find an import conversion type with this name in the target account.
		/// </summary>
		InvalidConversionType,
		/// <summary>
		/// This conversion action was created too recently. Please wait for 4 hours and try uploading
		/// again.
		/// </summary>
		TooRecentConversionType,
		/// <summary>
		/// Unable to upload. No AdWords call import conversion types were defined when this call
		/// occurred. Please make sure you create at least one such conversion type before uploading.
		/// </summary>
		ConversionTrackingNotEnabledAtCallTime,
		/// <summary>
		/// We can't count calls from ads made by computer or tablet users as conversions.
		/// </summary>
		DesktopCallNotSupported,
		/// <summary>
		/// An internal server error occurred, please try again.
		/// </summary>
		InternalError,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The reasons for an OfflineConversionError.
	/// </summary>
	public enum OfflineConversionErrorReason
	{
		/// <summary>
		/// This google click ID could not be decoded.
		/// </summary>
		UnparseableGclid,
		/// <summary>
		/// This conversion is reported to have happened before the click.
		/// </summary>
		ConversionPrecedesClick,
		/// <summary>
		/// You cannot set a future conversion time.
		/// </summary>
		FutureConversionTime,
		/// <summary>
		/// This click is either too old to be imported or occurred before the conversion window for the
		/// specified combination of conversion date and conversion name (default is 90 days).
		/// </summary>
		ExpiredClick,
		/// <summary>
		/// This click occurred less than 24 hours ago, please try again after a day or so.
		/// </summary>
		TooRecentClick,
		/// <summary>
		/// This click does not exist in the system. This can occur if google click ids are collected
		/// for non AdWords clicks (e.g. dart search).
		/// </summary>
		InvalidClick,
		/// <summary>
		/// This customer is trying to upload conversions for a different customer that it does not
		/// manage.
		/// </summary>
		UnauthorizedUser,
		/// <summary>
		/// This customer does not have an import conversion with a name that matches the label
		/// of this conversion.
		/// </summary>
		InvalidConversionType,
		/// <summary>
		/// This conversion action was created too recently. Please wait for 4 hours and try uploading
		/// again.
		/// </summary>
		TooRecentConversionType,
		/// <summary>
		/// Cannot process clicks that occurred when none of the effective conversion types in the
		/// account were enabled, to generate conversions.
		/// </summary>
		ClickMissingConversionLabel,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The operator type.
	/// </summary>
	public enum OperatingSystemVersionOperatorType
	{
		GreaterThanEqualTo,
		EqualTo,
		Unknown
	}
	
	/// <summary>
	/// The reasons for the operation access error.
	/// </summary>
	public enum OperationAccessDeniedReason
	{
		/// <summary>
		/// Unauthorized invocation of a service's method (get, mutate, etc.)
		/// </summary>
		ActionNotPermitted,
		/// <summary>
		/// Unauthorized ADD operation in invoking a service's mutate method.
		/// </summary>
		AddOperationNotPermitted,
		/// <summary>
		/// Unauthorized REMOVE operation in invoking a service's mutate method.
		/// </summary>
		RemoveOperationNotPermitted,
		/// <summary>
		/// Unauthorized SET operation in invoking a service's mutate method.
		/// </summary>
		SetOperationNotPermitted,
		/// <summary>
		/// A mutate action is not allowed on this campaign, from this client.
		/// </summary>
		MutateActionNotPermittedForClient,
		/// <summary>
		/// This operation is not permitted on this campaign type
		/// </summary>
		OperationNotPermittedForCampaignType,
		/// <summary>
		/// An ADD operation may not set status to REMOVED.
		/// </summary>
		AddAsRemovedNotPermitted,
		/// <summary>
		/// This operation is not allowed because the campaign or adgroup is removed.
		/// </summary>
		OperationNotPermittedForRemovedEntity,
		/// <summary>
		/// The reason the invoked method or operation is prohibited is not known
		/// (the client may be of an older version than the server).
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// This represents an operator that may be presented to an adsapi service.
	/// </summary>
	public enum Operator
	{
		/// <summary>
		/// The ADD operator.
		/// </summary>
		Add,
		/// <summary>
		/// The REMOVE operator.
		/// </summary>
		Remove,
		/// <summary>
		/// The SET operator (used for updates).
		/// </summary>
		Set
	}
	
	/// <summary>
	/// The reasons for the validation error.
	/// </summary>
	public enum OperatorErrorReason
	{
		OperatorNotSupported
	}
	
	public enum PageOnePromotedBiddingSchemeStrategyGoal
	{
		/// <summary>
		/// First page on google.com.
		/// </summary>
		PageOne,
		/// <summary>
		/// Top slots of the first page on google.com.
		/// </summary>
		PageOnePromoted
	}
	
	/// <summary>
	/// The reasons for errors when using pagination.
	/// </summary>
	public enum PagingErrorReason
	{
		/// <summary>
		/// The start index value cannot be a negative number.
		/// </summary>
		StartIndexCannotBeNegative,
		/// <summary>
		/// The number of results cannot be a negative number.
		/// </summary>
		NumberOfResultsCannotBeNegative,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The possible types of parents.
	/// </summary>
	public enum ParentParentType
	{
		ParentParent,
		ParentNotAParent,
		ParentUndetermined,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Categories to identify places of interest.
	/// </summary>
	public enum PlacesOfInterestOperandCategory
	{
		Airport,
		Downtown,
		University,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The summarized nature of a policy entry.
	/// </summary>
	public enum PolicyTopicEntryType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Will never serve.
		/// </summary>
		Prohibited,
		/// <summary>
		/// Constrained for at least one value.
		/// </summary>
		Limited
	}
	
	/// <summary>
	/// Describes the type of evidence inside the policy topic evidence.
	/// </summary>
	public enum PolicyTopicEvidenceType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		AdText,
		HttpCode
	}
	
	/// <summary>
	/// Defines the valid set of operators.
	/// </summary>
	public enum PredicateOperator
	{
		/// <summary>
		/// Checks if the field is equal to the given value.
		///
		/// <p>This operator is used with integers, dates, booleans, strings,
		/// enums, and sets.
		/// </summary>
		Equals,
		/// <summary>
		/// Checks if the field does not equal the given value.
		///
		/// <p>This operator is used with integers, booleans, strings, enums,
		/// and sets.
		/// </summary>
		NotEquals,
		/// <summary>
		/// Checks if the field is equal to one of the given values.
		///
		/// <p>This operator accepts multiple operands and is used with
		/// integers, booleans, strings, and enums.
		/// </summary>
		In,
		/// <summary>
		/// Checks if the field does not equal any of the given values.
		///
		/// <p>This operator accepts multiple operands and is used with
		/// integers, booleans, strings, and enums.
		/// </summary>
		NotIn,
		/// <summary>
		/// Checks if the field is greater than the given value.
		///
		/// <p>This operator is used with numbers and dates.
		/// </summary>
		GreaterThan,
		/// <summary>
		/// Checks if the field is greater or equal to the given value.
		///
		/// <p>This operator is used with numbers and dates.
		/// </summary>
		GreaterThanEquals,
		/// <summary>
		/// Checks if the field is less than the given value.
		///
		/// <p>This operator is used with numbers and dates.
		/// </summary>
		LessThan,
		/// <summary>
		/// Checks if the field is less or equal to than the given value.
		///
		/// <p>This operator is used with numbers and dates.
		/// </summary>
		LessThanEquals,
		/// <summary>
		/// Checks if the field starts with the given value.
		///
		/// <p>This operator is used with strings.
		/// </summary>
		StartsWith,
		/// <summary>
		/// Checks if the field starts with the given value, ignoring case.
		///
		/// <p>This operator is used with strings.
		/// </summary>
		StartsWithIgnoreCase,
		/// <summary>
		/// Checks if the field contains the given value as a substring.
		///
		/// <p>This operator is used with strings.
		/// </summary>
		Contains,
		/// <summary>
		/// Checks if the field contains the given value as a substring, ignoring
		/// case.
		///
		/// <p>This operator is used with strings.
		/// </summary>
		ContainsIgnoreCase,
		/// <summary>
		/// Checks if the field does not contain the given value as a substring.
		///
		/// <p>This operator is used with strings.
		/// </summary>
		DoesNotContain,
		/// <summary>
		/// Checks if the field does not contain the given value as a substring,
		/// ignoring case.
		///
		/// <p>This operator is used with strings.
		/// </summary>
		DoesNotContainIgnoreCase,
		/// <summary>
		/// Checks if the field contains <em>any</em> of the given values.
		///
		/// <p>This operator accepts multiple values and is used on sets of numbers
		/// or strings.
		/// </summary>
		ContainsAny,
		/// <summary>
		/// Checks if the field contains <em>all</em> of the given values.
		///
		/// <p>This operator accepts multiple values and is used on sets of numbers
		/// or strings.
		/// </summary>
		ContainsAll,
		/// <summary>
		/// Checks if the field contains <em>none</em> of the given values.
		///
		/// <p>This operator accepts multiple values and is used on sets of numbers
		/// or strings.
		/// </summary>
		ContainsNone,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// The qualifier on the price for all Price items.
	/// </summary>
	public enum PriceExtensionPriceQualifier
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// 'From' qualifier for the price.
		/// </summary>
		From,
		/// <summary>
		/// 'Up to' qualifier for the price.
		/// </summary>
		UpTo,
		/// <summary>
		/// None is used for clearing the qualifier.
		/// </summary>
		None
	}
	
	/// <summary>
	/// The price unit for a Price table item.
	/// </summary>
	public enum PriceExtensionPriceUnit
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Per hour.
		/// </summary>
		PerHour,
		/// <summary>
		/// Per day.
		/// </summary>
		PerDay,
		/// <summary>
		/// Per week.
		/// </summary>
		PerWeek,
		/// <summary>
		/// Per month.
		/// </summary>
		PerMonth,
		/// <summary>
		/// Per year.
		/// </summary>
		PerYear,
		/// <summary>
		/// None is used for clearing the unit.
		/// </summary>
		None
	}
	
	/// <summary>
	/// The type of a price extension represents.
	/// </summary>
	public enum PriceExtensionType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The type for showing a list of brands.
		/// </summary>
		Brands,
		/// <summary>
		/// The type for showing a list of events.
		/// </summary>
		Events,
		/// <summary>
		/// The type for showing locations relevant to your business.
		/// </summary>
		Locations,
		/// <summary>
		/// The type for showing sub-regions or districts within a city or region.
		/// </summary>
		Neighborhoods,
		/// <summary>
		/// The type for showing a collection of product categories.
		/// </summary>
		ProductCategories,
		/// <summary>
		/// The type for showing a collection of related product tiers.
		/// </summary>
		ProductTiers,
		/// <summary>
		/// The type for showing a collection of services offered by your business.
		/// </summary>
		Services,
		/// <summary>
		/// The type for showing a collection of service categories.
		/// </summary>
		ServiceCategories,
		/// <summary>
		/// The type for showing a collection of related service tiers.
		/// </summary>
		ServiceTiers
	}
	
	/// <summary>
	/// A canonical product condition.
	/// </summary>
	public enum ProductCanonicalConditionCondition
	{
		New,
		Used,
		Refurbished,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Type of product dimension.
	/// </summary>
	public enum ProductDimensionType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		BiddingCategoryL1,
		BiddingCategoryL2,
		BiddingCategoryL3,
		BiddingCategoryL4,
		BiddingCategoryL5,
		Brand,
		CanonicalCondition,
		CustomAttribute0,
		CustomAttribute1,
		CustomAttribute2,
		CustomAttribute3,
		CustomAttribute4,
		OfferId,
		ProductTypeL1,
		ProductTypeL2,
		ProductTypeL3,
		ProductTypeL4,
		ProductTypeL5,
		Channel,
		ChannelExclusivity
	}
	
	/// <summary>
	/// Type of a product partition in a shopping campaign.
	/// </summary>
	public enum ProductPartitionType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Subdivision of products along some product dimension.
		/// </summary>
		Subdivision,
		/// <summary>
		/// Unit which either defines a bid or delegates bidding to other campaigns.
		/// </summary>
		Unit
	}
	
	/// <summary>
	/// The radius distance is expressed in either kilometers or miles.
	/// </summary>
	public enum ProximityDistanceUnits
	{
		/// <summary>
		/// The unit of distance is kilometer.
		/// </summary>
		Kilometers,
		/// <summary>
		/// The unit of distance is mile.
		/// </summary>
		Miles
	}
	
	/// <summary>
	/// The reason for the query error.
	/// </summary>
	public enum QueryErrorReason
	{
		/// <summary>
		/// Exception that happens when trying to parse a query that doesn't match the AWQL grammar.
		/// </summary>
		ParsingFailed,
		/// <summary>
		/// The provided query is an empty string.
		/// </summary>
		MissingQuery,
		/// <summary>
		/// The query does not contain the required SELECT clause or it is not in the
		/// correct location.
		/// </summary>
		MissingSelectClause,
		/// <summary>
		/// The query does not contain the required FROM clause or it is not in the correct location.
		/// </summary>
		MissingFromClause,
		/// <summary>
		/// The SELECT clause could not be parsed.
		/// </summary>
		InvalidSelectClause,
		/// <summary>
		/// The FROM clause could not be parsed.
		/// </summary>
		InvalidFromClause,
		/// <summary>
		/// The WHERE clause could not be parsed.
		/// </summary>
		InvalidWhereClause,
		/// <summary>
		/// The ORDER BY clause could not be parsed.
		/// </summary>
		InvalidOrderByClause,
		/// <summary>
		/// The LIMIT clause could not be parsed.
		/// </summary>
		InvalidLimitClause,
		/// <summary>
		/// The startIndex in the LIMIT clause does not contain a valid integer.
		/// </summary>
		InvalidStartIndexInLimitClause,
		/// <summary>
		/// The pageSize in the LIMIT clause does not contain a valid integer.
		/// </summary>
		InvalidPageSizeInLimitClause,
		/// <summary>
		/// The DURING clause could not be parsed.
		/// </summary>
		InvalidDuringClause,
		/// <summary>
		/// The minimum date in the DURING clause is not a valid date in YYYYMMDD format.
		/// </summary>
		InvalidMinDateInDuringClause,
		/// <summary>
		/// The maximum date in the DURING clause is not a valid date in YYYYMMDD format.
		/// </summary>
		InvalidMaxDateInDuringClause,
		/// <summary>
		/// The minimum date in the DURING is after the maximum date.
		/// </summary>
		MaxLessThanMinInDuringClause,
		/// <summary>
		/// The query matched the grammar, but is invalid in some way such as using a service that
		/// isn't supported.
		/// </summary>
		ValidationFailed
	}
	
	/// <summary>
	/// Enums for all the reasons an error can be thrown to the user during
	/// billing quota checks.
	/// </summary>
	public enum QuotaCheckErrorReason
	{
		/// <summary>
		/// Customer passed in an invalid token in the header.
		/// </summary>
		InvalidTokenHeader,
		/// <summary>
		/// Customer is marked delinquent.
		/// </summary>
		AccountDelinquent,
		/// <summary>
		/// Customer is a fraudulent.
		/// </summary>
		AccountInaccessible,
		/// <summary>
		/// Inactive Account.
		/// </summary>
		AccountInactive,
		/// <summary>
		/// Signup not complete
		/// </summary>
		IncompleteSignup,
		/// <summary>
		/// Developer token is not approved for production access, and the customer
		/// is attempting to access a production account.
		/// </summary>
		DeveloperTokenNotApproved,
		/// <summary>
		/// Terms and conditions are not signed.
		/// </summary>
		TermsAndConditionsNotSigned,
		/// <summary>
		/// Monthly budget quota reached.
		/// </summary>
		MonthlyBudgetReached,
		/// <summary>
		/// Monthly budget quota exceeded.
		/// </summary>
		QuotaExceeded
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum RangeErrorReason
	{
		TooLow,
		TooHigh
	}
	
	/// <summary>
	/// The reason for the rate exceeded error.
	/// </summary>
	public enum RateExceededErrorReason
	{
		/// <summary>
		/// Rate exceeded.
		/// </summary>
		RateExceeded
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum ReadOnlyErrorReason
	{
		ReadOnly
	}
	
	/// <summary>
	/// The reasons for the validation error.
	/// </summary>
	public enum RegionCodeErrorReason
	{
		InvalidRegionCode
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum RejectedErrorReason
	{
		/// <summary>
		/// Unknown value encountered
		/// </summary>
		UnknownValue
	}
	
	public enum ReportDefinitionDateRangeType
	{
		Today,
		Yesterday,
		Last7Days,
		LastWeek,
		LastBusinessWeek,
		ThisMonth,
		LastMonth,
		AllTime,
		CustomDate,
		Last14Days,
		Last30Days,
		ThisWeekSunToday,
		ThisWeekMonToday,
		LastWeekSunSat
	}
	
	/// <summary>
	/// Enums for all the reasons an error can be thrown to the user during
	/// a {@link ReportDefinitionService#mutate(java.util.List)} operation.
	/// </summary>
	public enum ReportDefinitionErrorReason
	{
		/// <summary>
		/// Customer passed in invalid date range for a report type.
		/// </summary>
		InvalidDateRangeForReport,
		/// <summary>
		/// Customer passed in invalid field name for a report type
		/// </summary>
		InvalidFieldNameForReport,
		/// <summary>
		/// Unable to locate a field mapping for this report type.
		/// </summary>
		UnableToFindMappingForThisReport,
		/// <summary>
		/// Customer passed in invalid column name for a report type
		/// </summary>
		InvalidColumnNameForReport,
		/// <summary>
		/// Customer passed in invalid report definition id.
		/// </summary>
		InvalidReportDefinitionId,
		/// <summary>
		/// Report selector cannot be null.
		/// </summary>
		ReportSelectorCannotBeNull,
		/// <summary>
		/// No Enums exist for this column name.
		/// </summary>
		NoEnumsForThisColumnName,
		/// <summary>
		/// Invalid view name.
		/// </summary>
		InvalidView,
		/// <summary>
		/// Sorting is not supported for reports.
		/// </summary>
		SortingNotSupported,
		/// <summary>
		/// Paging is not supported for reports.
		/// </summary>
		PagingNotSupported,
		/// <summary>
		/// Customer can not create report of a selected type.
		/// </summary>
		CustomerServingTypeReportMismatch,
		/// <summary>
		/// Cross client report has an client selector without any valid identifier
		/// for a customer.
		/// </summary>
		ClientSelectorNoCustomerIdentifier,
		/// <summary>
		/// Cross client report has an invalid external customer ID in the client
		/// selector.
		/// </summary>
		ClientSelectorInvalidCustomerId,
		ReportDefinitionError
	}
	
	/// <summary>
	/// Enums for report types.
	/// </summary>
	public enum ReportDefinitionReportType
	{
		/// <summary>
		/// Reports performance data for your keywords.
		/// </summary>
		KeywordsPerformanceReport,
		/// <summary>
		/// Reports performance data for your ads.
		/// </summary>
		AdPerformanceReport,
		/// <summary>
		/// Reports performance data for URLs which triggered your ad and
		/// received clicks.
		/// </summary>
		UrlPerformanceReport,
		/// <summary>
		/// Reports ad group performance data for one or more of your campaigns.
		/// </summary>
		AdgroupPerformanceReport,
		/// <summary>
		/// Reports performance data for your campaigns.
		/// </summary>
		CampaignPerformanceReport,
		/// <summary>
		/// Reports performance data for your entire account.
		/// </summary>
		AccountPerformanceReport,
		/// <summary>
		/// Reports performance data by geographic origin.
		/// </summary>
		GeoPerformanceReport,
		/// <summary>
		/// Reports performance data for search queries which triggered your ad and
		/// received clicks.
		/// </summary>
		SearchQueryPerformanceReport,
		/// <summary>
		/// Reports performance data for automatic placements on the content network.
		/// </summary>
		AutomaticPlacementsPerformanceReport,
		/// <summary>
		/// Reports performance data for negative keywords at the campaign level.
		/// </summary>
		CampaignNegativeKeywordsPerformanceReport,
		/// <summary>
		/// Reports performance data for the negative placements at the campaign
		/// level.
		/// </summary>
		CampaignNegativePlacementsPerformanceReport,
		/// <summary>
		/// Reports performance data for destination urls.
		/// </summary>
		DestinationUrlReport,
		/// <summary>
		/// Reports data for shared sets.
		/// </summary>
		SharedSetReport,
		/// <summary>
		/// Reports data for campaign shared sets.
		/// </summary>
		CampaignSharedSetReport,
		/// <summary>
		/// Provides a downloadable snapshot of shared set criteria.
		/// </summary>
		SharedSetCriteriaReport,
		/// <summary>
		/// Reports performance data for creative conversions (e.g. free clicks).
		/// </summary>
		CreativeConversionReport,
		/// <summary>
		/// Reports per-phone-call details for calls tracked using call metrics.
		/// </summary>
		CallMetricsCallDetailsReport,
		/// <summary>
		/// Reports performance data for keywordless ads.
		/// </summary>
		KeywordlessQueryReport,
		/// <summary>
		/// Reports performance data for keywordless ads.
		/// </summary>
		KeywordlessCategoryReport,
		/// <summary>
		/// Reports performance data for all published criteria types including keywords,
		/// placements, topics, user-lists in a single report.
		/// </summary>
		CriteriaPerformanceReport,
		/// <summary>
		/// Reports performance data for clicks.
		/// </summary>
		ClickPerformanceReport,
		/// <summary>
		/// Reports performance data for budgets.
		/// </summary>
		BudgetPerformanceReport,
		/// <summary>
		/// Reports performance data for your (shared) bid strategies.
		/// </summary>
		BidGoalPerformanceReport,
		/// <summary>
		/// Reports performance data for your display keywords.
		/// </summary>
		DisplayKeywordPerformanceReport,
		/// <summary>
		/// Reports performance data for your placeholder feed items
		/// </summary>
		PlaceholderFeedItemReport,
		/// <summary>
		/// Reports performance data for your placements.
		/// </summary>
		PlacementPerformanceReport,
		/// <summary>
		/// Reports performance data for negative location targets at campaign level.
		/// </summary>
		CampaignNegativeLocationsReport,
		/// <summary>
		/// Reports performance data for managed and automatic genders in a combined report.
		/// </summary>
		GenderPerformanceReport,
		/// <summary>
		/// Reports performance data for managed and automatic age ranges in a combined report.
		/// </summary>
		AgeRangePerformanceReport,
		/// <summary>
		/// Reports performance data for campaign level location targets.
		/// </summary>
		CampaignLocationTargetReport,
		/// <summary>
		/// Reports performance data for campaign level ad schedule targets.
		/// </summary>
		CampaignAdScheduleTargetReport,
		/// <summary>
		/// Paid & organic report
		/// </summary>
		PaidOrganicQueryReport,
		/// <summary>
		/// Reports performance data for your audience criteria.
		/// </summary>
		AudiencePerformanceReport,
		/// <summary>
		/// Reports performance data for your topic criteria.
		/// </summary>
		DisplayTopicsPerformanceReport,
		/// <summary>
		/// Distance report
		/// </summary>
		UserAdDistanceReport,
		/// <summary>
		/// Performance data for shopping campaigns.
		/// </summary>
		ShoppingPerformanceReport,
		/// <summary>
		/// Performance data for product partitions in shopping campaigns.
		/// </summary>
		ProductPartitionReport,
		/// <summary>
		/// Reports performance data for managed and automatic parental statuses in a combined report.
		/// </summary>
		ParentalStatusPerformanceReport,
		/// <summary>
		/// Performance data for Extension placeholders
		/// </summary>
		PlaceholderReport,
		/// <summary>
		/// Reports performance of ad placeholders when instantiated with specific FeedItems.
		/// </summary>
		AdCustomizersFeedItemReport,
		/// <summary>
		/// Reports stats and settings details for labels.
		/// </summary>
		LabelReport,
		/// <summary>
		/// Reports performance data for final urls.
		/// </summary>
		FinalUrlReport,
		/// <summary>
		/// Video performance report.
		/// </summary>
		VideoPerformanceReport,
		/// <summary>
		/// Reports performance data for top content bid modifier criteria.
		/// </summary>
		TopContentPerformanceReport,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	public enum RequestContextOperandContextType
	{
		/// <summary>
		/// Feed item id in the request context.
		/// </summary>
		FeedItemId,
		/// <summary>
		/// The device's platform (possible values are 'Desktop' or 'Mobile').
		/// </summary>
		DevicePlatform,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	public enum RequestErrorReason
	{
		/// <summary>
		/// Error reason is unknown.
		/// </summary>
		Unknown,
		/// <summary>
		/// Invalid input.
		/// </summary>
		InvalidInput,
		/// <summary>
		/// The api version in the request has been discontinued. Please update
		/// to the new AdWords API version.
		/// </summary>
		UnsupportedVersion
	}
	
	/// <summary>
	/// Represents the type of the request.
	/// </summary>
	public enum RequestType
	{
		/// <summary>
		/// Request for new ideas based on other entries in selector.
		/// This {@link RequestType} can be used to request other ideas
		/// using keyword/placements that the user already has.
		/// </summary>
		Ideas,
		/// <summary>
		/// Request for stats for entries in selector.
		/// This {@link RequestType} can be used to request
		/// the stats for keywords/placements that the user already has.
		///
		/// <p>Stats are generated once a month (typically on the last week of the
		/// month) from the historical data of previous months.</p>
		/// </summary>
		Stats
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum RequiredErrorReason
	{
		/// <summary>
		/// Missing required field.
		/// </summary>
		Required
	}
	
	/// <summary>
	/// A set of attributes that describe the rich media ad capabilities.
	/// </summary>
	public enum RichMediaAdAdAttribute
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Indicates that the ad supports mouse roll over to expand.
		/// </summary>
		RollOverToExpand,
		/// <summary>
		/// Indicates that the ad supports SSL.
		/// </summary>
		Ssl
	}
	
	/// <summary>
	/// Different types of rich media ad that are available to customers.
	/// </summary>
	public enum RichMediaAdRichMediaAdType
	{
		/// <summary>
		/// Standard.
		/// </summary>
		Standard,
		/// <summary>
		/// In stream video ad.
		/// </summary>
		InStreamVideo
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum SelectorErrorReason
	{
		/// <summary>
		/// The field name is not valid.
		/// </summary>
		InvalidFieldName,
		/// <summary>
		/// The list of fields is null or empty.
		/// </summary>
		MissingFields,
		/// <summary>
		/// The list of predicates is null or empty.
		/// </summary>
		MissingPredicates,
		/// <summary>
		/// Predicate operator does not support multiple values. Multiple values are
		/// supported only for {@link Predicate.Operator#IN} and {@link Predicate.Operator#NOT_IN}.
		/// </summary>
		OperatorDoesNotSupportMultipleValues,
		/// <summary>
		/// The predicate enum value is not valid.
		/// </summary>
		InvalidPredicateEnumValue,
		/// <summary>
		/// The predicate operator is empty.
		/// </summary>
		MissingPredicateOperator,
		/// <summary>
		/// The predicate values are empty.
		/// </summary>
		MissingPredicateValues,
		/// <summary>
		/// The predicate field name is not valid.
		/// </summary>
		InvalidPredicateFieldName,
		/// <summary>
		/// The predicate operator is not valid.
		/// </summary>
		InvalidPredicateOperator,
		/// <summary>
		/// Invalid selection of fields.
		/// </summary>
		InvalidFieldSelection,
		/// <summary>
		/// The predicate value is not valid.
		/// </summary>
		InvalidPredicateValue,
		/// <summary>
		/// The sort field name is not valid or the field is not sortable.
		/// </summary>
		InvalidSortFieldName,
		/// <summary>
		/// Standard error.
		/// </summary>
		SelectorError,
		/// <summary>
		/// Filtering by date range is not supported.
		/// </summary>
		FilterByDateRangeNotSupported,
		/// <summary>
		/// Selector paging start index is too high.
		/// </summary>
		StartIndexIsTooHigh,
		/// <summary>
		/// The values list in a predicate was too long.
		/// </summary>
		TooManyPredicateValues,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		UnknownError
	}
	
	/// <summary>
	/// Status of the link
	/// </summary>
	public enum ServiceLinkLinkStatus
	{
		/// <summary>
		/// Link is enabled and data sharing is allowed.
		/// </summary>
		Active,
		/// <summary>
		/// Link was requested from the other service and is awaiting approval. To approve the link,
		/// change the status to {@code ACTIVE} via a {@code SET} operation.
		/// </summary>
		Pending,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Services whose links to AdWords accounts are visible in {@link CustomerServicee}
	/// </summary>
	public enum ServiceType
	{
		/// <summary>
		/// Data from Google Merchant Center accounts can be linked for use in shopping campaigns.
		/// For more information, visit this <a
		/// href="https://support.google.com/adwords/answer/6159060">Help Center article</a>.
		/// </summary>
		MerchantCenter,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Campaign serving status.
	/// </summary>
	public enum ServingStatus
	{
		/// <summary>
		/// The campaign is currently serving ads.
		/// </summary>
		Serving,
		/// <summary>
		/// This is the catch-all if none of the other statuses make sense.
		/// Such a campaign is not serving, but none of the other statuses
		/// are sensible options.
		/// </summary>
		None,
		/// <summary>
		/// The campaign end date has been past.
		/// </summary>
		Ended,
		/// <summary>
		/// The campaign start date has not yet been reached.
		/// </summary>
		Pending,
		/// <summary>
		/// The campaign has been suspended probably from lack of allocated funds.
		/// </summary>
		Suspended
	}
	
	/// <summary>
	/// The reasons for the setting error.
	/// </summary>
	public enum SettingErrorReason
	{
		/// <summary>
		/// The campaign already has a setting of the type that is being added.
		/// </summary>
		DuplicateSettingType,
		/// <summary>
		/// The campaign setting is not available for this AdWords account.
		/// </summary>
		SettingTypeIsNotAvailable,
		/// <summary>
		/// The setting is not compatible with the campaign.
		/// </summary>
		SettingTypeIsNotCompatibleWithCampaign,
		/// <summary>
		/// The supplied TargetingSetting contains an invalid CriterionTypeGroup. See
		/// {@link CriterionTypeGroup} documentation for CriterionTypeGroups allowed in Campaign or
		/// AdGroup TargetingSettings.
		/// </summary>
		TargetingSettingContainsInvalidCriterionTypeGroup,
		/// <summary>
		/// The supplied DynamicSearchAdsSetting contains an invalid domain name.
		/// </summary>
		DynamicSearchAdsSettingContainsInvalidDomainName,
		/// <summary>
		/// The supplied DynamicSearchAdsSetting contains an invalid language code.
		/// </summary>
		DynamicSearchAdsSettingContainsInvalidLanguageCode,
		/// <summary>
		/// TargetingSettings in search campaigns should not have CriterionTypeGroup.PLACEMENT
		/// set to targetAll.
		/// </summary>
		TargetAllIsNotAllowedForPlacementInSearchCampaign,
		/// <summary>
		/// Duplicate description in universal app setting description field.
		/// </summary>
		UniversalAppCampaignSettingDuplicateDescription,
		/// <summary>
		/// Description line width is too long in universal app setting description field.
		/// </summary>
		UniversalAppCampaignSettingDescriptionLineWidthTooLong,
		/// <summary>
		/// Universal app setting appId field cannot be modified for COMPLETE campaigns.
		/// </summary>
		UniversalAppCampaignSettingAppIdCannotBeModified,
		/// <summary>
		/// YoutubeVideoMediaIds in universal app setting cannot exceed size limit.
		/// </summary>
		TooManyYoutubeMediaIdsInUniversalAppCampaign,
		/// <summary>
		/// ImageMediaIds in universal app setting cannot exceed size limit.
		/// </summary>
		TooManyImageMediaIdsInUniversalAppCampaign,
		/// <summary>
		/// Media is incompatible for universal app campaign.
		/// </summary>
		MediaIncompatibleForUniversalAppCampaign,
		/// <summary>
		/// Unspecified campaign setting error.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Status of the bidding strategy.
	/// </summary>
	public enum SharedBiddingStrategyBiddingStrategyStatus
	{
		Enabled,
		Removed,
		Unknown
	}
	
	/// <summary>
	/// Error reasons
	/// </summary>
	public enum SharedCriterionErrorReason
	{
		ExceedsCriteriaLimit,
		IncorrectCriterionType,
		/// <summary>
		/// Cannot add the same crietrion as positive and negative in the same shared set.
		/// </summary>
		CannotTargetAndExclude,
		/// <summary>
		/// Negative shared set type requires a negative shared set criterion.
		/// </summary>
		NegativeCriterionRequired,
		/// <summary>
		/// Concrete type of criterion (e.g., keyword and placement) is required for ADD operations.
		/// </summary>
		ConcreteTypeRequired,
		Unknown
	}
	
	/// <summary>
	/// Error reasons
	/// </summary>
	public enum SharedSetErrorReason
	{
		CustomerCannotCreateSharedSetOfThisType,
		DuplicateName,
		SharedSetRemoved,
		SharedSetInUse,
		Unknown
	}
	
	public enum SharedSetStatus
	{
		Enabled,
		Removed,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Enumerates the different types of shared sets.
	/// </summary>
	public enum SharedSetType
	{
		NegativeKeywords,
		NegativePlacements,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Status of a bidding dimension (category) in a bidding taxonomy.
	/// </summary>
	public enum ShoppingBiddingDimensionStatus
	{
		/// <summary>
		/// Default status. Should not be used.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The dimension is active and it can be used for bidding.
		/// </summary>
		Active,
		/// <summary>
		/// The dimension is deprecated and should not be used for bidding.
		/// </summary>
		Obsolete
	}
	
	/// <summary>
	/// Channel specifies where the item is sold: online or in local stores.
	/// </summary>
	public enum ShoppingProductChannel
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The item is sold online.
		/// </summary>
		Online,
		/// <summary>
		/// The item is sold in local stores.
		/// </summary>
		Local
	}
	
	/// <summary>
	/// Channel exclusivity specifies whether an item is sold exclusively in one channel
	/// or through multiple channels.
	/// </summary>
	public enum ShoppingProductChannelExclusivity
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The item is sold through one channel only, either local stores or online as
		/// indicated by its ShoppingProductChannel.
		/// </summary>
		SingleChannel,
		/// <summary>
		/// The item is matched to its online or local stores counterpart, indicating it is
		/// available for purchase in both ShoppingProductChannels.
		/// </summary>
		MultiChannel
	}
	
	/// <summary>
	/// The reasons for Ad Scheduling errors.
	/// </summary>
	public enum SizeLimitErrorReason
	{
		/// <summary>
		/// The number of entries in the request exceeds the system limit.
		/// </summary>
		RequestSizeLimitExceeded,
		/// <summary>
		/// The number of entries in the response exceeds the system limit.
		/// </summary>
		ResponseSizeLimitExceeded,
		/// <summary>
		/// The account is too large to load.
		/// </summary>
		InternalStorageError,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Size range in terms of number of users of a UserList/UserInterest.
	/// </summary>
	public enum SizeRange
	{
		LessThanFiveHundred,
		LessThanOneThousand,
		OneThousandToTenThousand,
		TenThousandToFiftyThousand,
		FiftyThousandToOneHundredThousand,
		OneHundredThousandToThreeHundredThousand,
		ThreeHundredThousandToFiveHundredThousand,
		FiveHundredThousandToOneMillion,
		OneMillionToTwoMillion,
		TwoMillionToThreeMillion,
		ThreeMillionToFiveMillion,
		FiveMillionToTenMillion,
		TenMillionToTwentyMillion,
		TwentyMillionToThirtyMillion,
		ThirtyMillionToFiftyMillion,
		OverFiftyMillion
	}
	
	/// <summary>
	/// Possible orders of sorting.
	/// </summary>
	public enum SortOrder
	{
		Ascending,
		Descending
	}
	
	/// <summary>
	/// The reasons for errors when querying for stats.
	/// </summary>
	public enum StatsQueryErrorReason
	{
		/// <summary>
		/// Date is outside of allowed range.
		/// </summary>
		DateNotInValidRange
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum StringFormatErrorReason
	{
		Unknown,
		/// <summary>
		/// The input string value contains disallowed characters.
		/// </summary>
		IllegalChars,
		/// <summary>
		/// The input string value is invalid for the associated field.
		/// </summary>
		InvalidFormat
	}
	
	/// <summary>
	/// The reasons for the target error.
	/// </summary>
	public enum StringLengthErrorReason
	{
		TooShort,
		TooLong
	}
	
	/// <summary>
	/// Supported operators for strings.
	/// </summary>
	public enum StringRuleItemStringOperator
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		Contains,
		Equals,
		StartsWith,
		EndsWith,
		NotEqual,
		NotContain,
		NotStartWith,
		NotEndWith
	}
	
	/// <summary>
	/// Reported by system to reflect the criterion's serving status.
	/// </summary>
	public enum SystemServingStatus
	{
		/// <summary>
		/// Criterion is eligible to serve.
		/// </summary>
		Eligible,
		/// <summary>
		/// Indicates low search volume.
		/// <p>For more information, visit
		/// <a href="https://support.google.com/adwords/answer/2616014">Low Search Volume</a>.</p>
		/// </summary>
		RarelyServed
	}
	
	/// <summary>
	/// An enumeration of {@link TargetingIdeaService} specific errors.
	/// </summary>
	public enum TargetingIdeaErrorReason
	{
		/// <summary>
		/// Error returned when there are multiple instance of same type of {@link SearchParameter}s.
		/// </summary>
		DuplicateSearchFilterTypesPresent,
		/// <summary>
		/// Error returned when the {@link TargetingIdeaSelector} doesn't have enough
		/// {@link SearchParameter}s to execute request.
		/// </summary>
		InsufficientSearchParameters,
		/// <summary>
		/// Error returned when an {@link AttributeType} doesn't match the {@link IdeaType} specified in
		/// the {@link TargetingIdeaSelector}. For example, if the {@code KEYWORD} {@code IDEAS} selector
		/// contains an {@code STATS} only AttributeType, this error will be returned.
		/// </summary>
		InvalidAttributeType,
		/// <summary>
		/// Error returned when a {@link SearchParameter} doesn't match the {@link IdeaType} specified in
		/// the {@link TargetingIdeaSelector} or is otherwise invalid.  Error trigger usually contains
		/// the parameter name, and error details contain a more detailed explanation.
		/// </summary>
		InvalidSearchParameters,
		/// <summary>
		/// Error returned when the {@link TargetingIdeaSelector} contains a
		/// {@link DomainSuffixSearchParameter}s that contains an invalid domain suffix.
		/// </summary>
		InvalidDomainSuffix,
		/// <summary>
		/// Error returned when a selector contains mutually exclusive parameters.
		/// </summary>
		MutuallyExclusiveSearchParametersInQuery,
		/// <summary>
		/// Error returned when the {@link TargetingIdeaService} is not available.
		/// </summary>
		ServiceUnavailable,
		/// <summary>
		/// Error returned when the URL value specified in the {@link TargetingIdeaSelector}, such as
		/// {@link RelatedToUrlSearchParameter}, is not a valid URL.
		/// </summary>
		InvalidUrlInSearchParameter,
		/// <summary>
		/// Error returned when the requested number of entries in {@link TargetingIdeaSelector}'s
		/// {@link Paging} is greater than the maximum allowed.
		/// </summary>
		TooManyResultsRequested,
		/// <summary>
		/// Error returned when the requested {@link Paging} is missing from the
		/// {@link TargetingIdeaSelector} when required.
		/// </summary>
		NoPagingInSelector,
		/// <summary>
		/// Error returned when included keywords and excluded keywords in
		/// {@link IdeaTextFilterSearchParameter}, {@link IdeaTextMatchesSearchParameter}
		/// or {@link ExcludedKeywordSearchParameter} are overlapped.
		/// </summary>
		InvalidIncludedExcludedKeywords
	}
	
	/// <summary>
	/// Possible field types of template element fields.
	/// </summary>
	public enum TemplateElementFieldType
	{
		/// <summary>
		/// Address field type (text).
		/// </summary>
		Address,
		/// <summary>
		/// Audio field type (Media).
		/// </summary>
		Audio,
		/// <summary>
		/// Enum field type (text).
		/// </summary>
		Enum,
		/// <summary>
		/// Image field type (Media).
		/// </summary>
		Image,
		/// <summary>
		/// Background Image field type (Media).
		/// </summary>
		BackgroundImage,
		/// <summary>
		/// Number field type (text).
		/// </summary>
		Number,
		/// <summary>
		/// Text field type (text).
		/// </summary>
		Text,
		/// <summary>
		/// URL field type (text).
		/// </summary>
		Url,
		/// <summary>
		/// Video field type (Media).
		/// </summary>
		Video,
		/// <summary>
		/// Visible URL field type (text).
		/// </summary>
		VisibleUrl,
		/// <summary>
		/// A ZIP file containing HTML5 assets.
		/// </summary>
		MediaBundle,
		/// <summary>
		/// UNKNOWN type can not be passed as input.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Allowed expanding directions for ads that are expandable.
	/// </summary>
	public enum ThirdPartyRedirectAdExpandingDirection
	{
		/// <summary>
		/// Whether the ad can be expanded is unknown.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The ad is allowed to expand upward.
		/// </summary>
		ExpandingUp,
		/// <summary>
		/// The ad is allowed to expand downward.
		/// </summary>
		ExpandingDown,
		/// <summary>
		/// The ad is allowed to expand leftward.
		/// </summary>
		ExpandingLeft,
		/// <summary>
		/// The ad is allowed to expand rightward.
		/// </summary>
		ExpandingRight,
		/// <summary>
		/// The ad is allowed to expand toward the up-left corner.
		/// </summary>
		ExpandingUpleft,
		/// <summary>
		/// The ad is allowed to expand toward the up-right corner.
		/// </summary>
		ExpandingUpright,
		/// <summary>
		/// The ad is allowed to expand toward the down-left corner.
		/// </summary>
		ExpandingDownleft,
		/// <summary>
		/// The ad is allowed to expand toward the down-right corner.
		/// </summary>
		ExpandingDownright
	}
	
	/// <summary>
	/// Unit of time the cap is defined at.
	/// </summary>
	public enum TimeUnit
	{
		Minute,
		Hour,
		Day,
		Week,
		Month,
		Lifetime
	}
	
	public enum TrafficEstimatorErrorReason
	{
		/// <summary>
		/// When the request with {@code null} campaign ID in {@link CampaignEstimateRequest} contains an
		/// {@link AdGroupEstimateRequest} with an ID.
		/// </summary>
		NoCampaignForAdGroupEstimateRequest,
		/// <summary>
		/// When the request with {@code null} adgroup ID in {@link AdGroupEstimateRequest} contains a
		/// {@link KeywordEstimateRequest} with an ID.
		/// </summary>
		NoAdGroupForKeywordEstimateRequest,
		/// <summary>
		/// All {@link KeywordEstimateRequest} items should have maxCpc associated with them.
		/// </summary>
		NoMaxCpcForKeywordEstimateRequest,
		/// <summary>
		/// When there are more {@link KeywordEstimateRequest}s in the request than
		/// TrafficEstimatorService allows.
		/// </summary>
		TooManyKeywordEstimateRequests,
		/// <summary>
		/// When there are more {@link CampaignEstimateRequest}s in the request than
		/// TrafficEstimatorService allows.
		/// </summary>
		TooManyCampaignEstimateRequests,
		/// <summary>
		/// When there are more {@link AdGroupEstimateRequest}s in the request than
		/// TrafficEstimatorService allows.
		/// </summary>
		TooManyAdgroupEstimateRequests,
		/// <summary>
		/// When there are more targets in the request than TrafficEstimatorService allows. See
		/// documentation on {@link CampaignEstimateRequest} for more information about this error.
		/// </summary>
		TooManyTargets,
		/// <summary>
		/// Request contains a keyword that is too long for backends to handle.
		/// </summary>
		KeywordTooLong,
		/// <summary>
		/// Request contains a keyword that contains broad match modifiers.
		/// </summary>
		KeywordContainsBroadMatchModifiers,
		/// <summary>
		/// When an unexpected error occurs.
		/// </summary>
		InvalidInput,
		/// <summary>
		/// When backend service calls fail.
		/// </summary>
		ServiceUnavailable
	}
	
	/// <summary>
	/// Error codes defined by {@link TrialError}.
	/// </summary>
	public enum TrialErrorReason
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Trial status cannot be updated from the current status to the requested target status.
		/// </summary>
		InvalidStatusTransition,
		/// <summary>
		/// Cannot create a trial from a campaign using an explicitly shared budget.
		/// </summary>
		CannotUseTrialWithSharedBudget,
		/// <summary>
		/// Cannot create a trial as long as the campaign has a running or scheduled Advertiser Campaign
		/// Experiment.
		/// </summary>
		CannotCreateTrialWhenCampaignHasActiveExperiments,
		/// <summary>
		/// Cannot create a trial for a base campaign, which is deleted.
		/// </summary>
		CannotCreateTrialForDeletedBaseCampaign,
		/// <summary>
		/// Cannot create a trial from a draft, which has a status other than proposed.
		/// </summary>
		CannotCreateTrialForNonProposedDraft,
		/// <summary>
		/// This customer is not allowed to create a trial.
		/// </summary>
		CustomerCannotCreateTrial,
		/// <summary>
		/// This campaign is not allowed to create a trial.
		/// </summary>
		CampaignCannotCreateTrial,
		/// <summary>
		/// Trying to use a trial name which is already assigned to another campaign or trial.
		/// </summary>
		NameAlreadyInUse,
		/// <summary>
		/// Trying to set a trial duration which overlaps with another trial.
		/// </summary>
		TrialDurationsMustNotOverlap,
		/// <summary>
		/// All non-archived trials must start end end within their campaign's duration.
		/// </summary>
		TrialDurationMustBeWithinCampaignDuration
	}
	
	/// <summary>
	/// Status diagram available at go/adsapi-commander
	/// </summary>
	public enum TrialStatus
	{
		/// <summary>
		/// Invalid status. Should not be used except for detecting values that are
		/// incorrect, or values that are not yet known to the user.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The trial campaign is being created.
		/// </summary>
		Creating,
		/// <summary>
		/// The trial campaign is fully created. The trial is currently running, scheduled
		/// to run in the future or has ended based on its end date.The advertiser cannot
		/// set this status directly. A trial with the status CREATING will be updated to
		/// ACTIVE when it is fully created.
		/// </summary>
		Active,
		/// <summary>
		/// The advertiser requested to merge changes in the trial back into the original
		/// campaigns. The update to the original campaign will be kicked off asynchronously
		/// and the status will be updated to PROMOTED or PROMOTE_FAILED upon completion.
		/// </summary>
		Promoting,
		/// <summary>
		/// The process to merge changes in the trial back to the original campaign has
		/// completedly successfully. The advertiser cannot set this status directly. To
		/// move the trial to this status, set the trial to status PROMOTING and the status
		/// will be updated to PROMOTED when the changes are applied to the original
		/// campaign.
		/// </summary>
		Promoted,
		/// <summary>
		/// The advertiser archived the campaign trial.
		/// </summary>
		Archived,
		/// <summary>
		/// The materializer failed to create the materialized campaign. More details about
		/// the errors are available through getErrors in the TrialService API.The
		/// advertiser cannot set this status directly.
		/// </summary>
		CreationFailed,
		/// <summary>
		/// The promotion failed after it was partially applied. Promote cannot be attempted
		/// again safely, so the issue must be corrected in the original campaign. More
		/// details about the errors are available through getErrors in the TrialService
		/// API.The advertiser cannot set this status directly. To promote the trial, set
		/// the trial in state PROMOTING and the status will be updated to PROMOTE_FAILED if
		/// errors are encountered while applying changes to the original campaign.
		/// </summary>
		PromoteFailed,
		/// <summary>
		/// The advertiser has graduated the trial campaign to a standalone campaign,
		/// existing independently of the trial.
		/// </summary>
		Graduated,
		/// <summary>
		/// The advertiser has halted the trial.
		/// </summary>
		Halted
	}
	
	/// <summary>
	/// Represents the goal towards which the bidding strategy, of a universal app
	/// campaign, should optimize for. See go/walnut-pie-apdr for more.
	/// </summary>
	public enum UniversalAppBiddingStrategyGoalType
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// The bidding strategy of the universal app campaign should aim to maximize
		/// installation of the app.
		/// </summary>
		OptimizeForInstallConversionVolume,
		/// <summary>
		/// The bidding strategy of the universal app campaign should aim to maximize the
		/// selected in-app conversions' volume.
		/// </summary>
		OptimizeForInAppConversionVolume,
		/// <summary>
		/// The bidding strategy of the universal app campaign should aim to maximize all
		/// conversions' value, i.e., install + selected in-app conversions.NOTE: This value
		/// cannot be set by external clients.
		/// </summary>
		OptimizeForTotalConversionValue
	}
	
	/// <summary>
	/// Represents the individual assets that are utilized as part of the campaign.
	/// </summary>
	public enum UniversalAppCampaignAsset
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Identifies a combination of assets.
		/// </summary>
		Combination,
		/// <summary>
		/// Identifies the app destination.
		/// </summary>
		AppDestination,
		/// <summary>
		/// Identifies the app related data, like app name, app icon, developer name
		/// including translations of the content.
		/// </summary>
		AppAssets,
		/// <summary>
		/// Identifies the campaign setting's description1 field.
		/// </summary>
		Description1,
		/// <summary>
		/// Identifies the campaign setting's description2 field.
		/// </summary>
		Description2,
		/// <summary>
		/// Identifies the campaign setting's description3 field.
		/// </summary>
		Description3,
		/// <summary>
		/// Identifies the campaign setting's description4 field.
		/// </summary>
		Description4,
		/// <summary>
		/// Identifies the campaign setting's video fields.
		/// </summary>
		Video,
		/// <summary>
		/// Identifies the campaign setting's image fields.
		/// </summary>
		Image
	}
	
	/// <summary>
	/// The reasons for the url error.
	/// </summary>
	public enum UrlErrorReason
	{
		/// <summary>
		/// The tracking url template is invalid.
		/// </summary>
		InvalidTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template contains invalid tag.
		/// </summary>
		InvalidTagInTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template must contain at least one tag (e.g. {lpurl}),
		/// This applies only to tracking url template associated with website ads or product ads.
		/// </summary>
		MissingTrackingUrlTemplateTag,
		/// <summary>
		/// The tracking url template must start with a valid protocol (or lpurl tag).
		/// </summary>
		MissingProtocolInTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template starts with an invalid protocol.
		/// </summary>
		InvalidProtocolInTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template  contains illegal characters.
		/// </summary>
		MalformedTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template must contain a host name (or lpurl tag).
		/// </summary>
		MissingHostInTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template has an invalid or missing top level domain extension.
		/// </summary>
		InvalidTldInTrackingUrlTemplate,
		/// <summary>
		/// The tracking url template contains nested occurrences of the same conditional tag
		/// (i.e. {ifmobile:{ifmobile:x}}).
		/// </summary>
		RedundantNestedTrackingUrlTemplateTag,
		/// <summary>
		/// The final url is invalid.
		/// </summary>
		InvalidFinalUrl,
		/// <summary>
		/// The final url contains invalid tag.
		/// </summary>
		InvalidTagInFinalUrl,
		/// <summary>
		/// The final url contains nested occurrences of the same conditional tag
		/// (i.e. {ifmobile:{ifmobile:x}}).
		/// </summary>
		RedundantNestedFinalUrlTag,
		/// <summary>
		/// The final url must start with a valid protocol.
		/// </summary>
		MissingProtocolInFinalUrl,
		/// <summary>
		/// The final url starts with an invalid protocol.
		/// </summary>
		InvalidProtocolInFinalUrl,
		/// <summary>
		/// The final url  contains illegal characters.
		/// </summary>
		MalformedFinalUrl,
		/// <summary>
		/// The final url must contain a host name.
		/// </summary>
		MissingHostInFinalUrl,
		/// <summary>
		/// The tracking url template has an invalid or missing top level domain extension.
		/// </summary>
		InvalidTldInFinalUrl,
		/// <summary>
		/// The final mobile url is invalid.
		/// </summary>
		InvalidFinalMobileUrl,
		/// <summary>
		/// The final mobile url contains invalid tag.
		/// </summary>
		InvalidTagInFinalMobileUrl,
		/// <summary>
		/// The final mobile url contains nested occurrences of the same conditional tag
		/// (i.e. {ifmobile:{ifmobile:x}}).
		/// </summary>
		RedundantNestedFinalMobileUrlTag,
		/// <summary>
		/// The final mobile url must start with a valid protocol.
		/// </summary>
		MissingProtocolInFinalMobileUrl,
		/// <summary>
		/// The final mobile url starts with an invalid protocol.
		/// </summary>
		InvalidProtocolInFinalMobileUrl,
		/// <summary>
		/// The final mobile url  contains illegal characters.
		/// </summary>
		MalformedFinalMobileUrl,
		/// <summary>
		/// The final mobile url must contain a host name.
		/// </summary>
		MissingHostInFinalMobileUrl,
		/// <summary>
		/// The tracking url template has an invalid or missing top level domain extension.
		/// </summary>
		InvalidTldInFinalMobileUrl,
		/// <summary>
		/// The final app url is invalid.
		/// </summary>
		InvalidFinalAppUrl,
		/// <summary>
		/// The final app url contains invalid tag.
		/// </summary>
		InvalidTagInFinalAppUrl,
		/// <summary>
		/// The final app url contains nested occurrences of the same conditional tag
		/// (i.e. {ifmobile:{ifmobile:x}}).
		/// </summary>
		RedundantNestedFinalAppUrlTag,
		/// <summary>
		/// More than one app url found for the same OS type.
		/// </summary>
		MultipleAppUrlsForOstype,
		/// <summary>
		/// The OS type given for an app url is not valid.
		/// </summary>
		InvalidOstype,
		/// <summary>
		/// The protocol given for an app url is not valid. (E.g. "android-app://")
		/// </summary>
		InvalidProtocolForAppUrl,
		/// <summary>
		/// The package id (app id) given for an app url is not valid.
		/// </summary>
		InvalidPackageIdForAppUrl,
		/// <summary>
		/// The number of url custom parameters for an entity exceeds the maximum limit allowed.
		/// </summary>
		UrlCustomParametersCountExceedsLimit,
		/// <summary>
		/// The parameter has isRemove set to true but a value that is non-null.
		/// </summary>
		UrlCustomParameterRemovalWithNonNullValue,
		/// <summary>
		/// For add operations, there will not be any existing parameters to delete.
		/// </summary>
		CannotRemoveUrlCustomParameterInAddOperation,
		/// <summary>
		/// When the doReplace flag is set to true, individual parameters cannot be deleted.
		/// </summary>
		CannotRemoveUrlCustomParameterDuringFullReplacement,
		/// <summary>
		/// For ADD operations and when the doReplace flag is set to true, custom parameter values
		/// cannot be null.
		/// </summary>
		NullCustomParameterValueDuringAddOrFullReplacement,
		/// <summary>
		/// An invalid character appears in the parameter key.
		/// </summary>
		InvalidCharactersInUrlCustomParameterKey,
		/// <summary>
		/// An invalid character appears in the parameter value.
		/// </summary>
		InvalidCharactersInUrlCustomParameterValue,
		/// <summary>
		/// The url custom parameter value fails url tag validation.
		/// </summary>
		InvalidTagInUrlCustomParameterValue,
		/// <summary>
		/// The custom parameter contains nested occurrences of the same conditional tag
		/// (i.e. {ifmobile:{ifmobile:x}}).
		/// </summary>
		RedundantNestedUrlCustomParameterTag,
		/// <summary>
		/// The protocol (http:// or https://) is missing.
		/// </summary>
		MissingProtocol,
		/// <summary>
		/// The url is invalid.
		/// </summary>
		InvalidUrl,
		/// <summary>
		/// Destination Url is deprecated.
		/// </summary>
		DestinationUrlDeprecated,
		/// <summary>
		/// The url contains invalid tag.
		/// </summary>
		InvalidTagInUrl,
		/// <summary>
		/// The url must contain at least one tag (e.g. {lpurl}),
		/// This applies only to urls associated with website ads or product ads.
		/// </summary>
		MissingUrlTag,
		UrlError
	}
	
	/// <summary>
	/// User can create only BOOMERANG_EVENT conversion types. For all other types
	/// UserListService service will return OTHER.
	/// </summary>
	public enum UserListConversionTypeCategory
	{
		BoomerangEvent,
		Other
	}
	
	public enum UserListErrorReason
	{
		/// <summary>
		/// Creating and updating external remarketing user lists is not supported.
		/// </summary>
		ExternalRemarketingUserListMutateNotSupported,
		/// <summary>
		/// Concrete type of user list (logical v.s. remarketing) is required for
		/// ADD and SET operations.
		/// </summary>
		ConcreteTypeRequired,
		/// <summary>
		/// Adding/updating user list conversion types requires specifying the conversion
		/// type id.
		/// </summary>
		ConversionTypeIdRequired,
		/// <summary>
		/// Remarketing user list cannot have duplicate conversion types.
		/// </summary>
		DuplicateConversionTypes,
		/// <summary>
		/// Conversion type is invalid/unknown.
		/// </summary>
		InvalidConversionType,
		/// <summary>
		/// User list description is empty or invalid
		/// </summary>
		InvalidDescription,
		/// <summary>
		/// User list name is empty or invalid.
		/// </summary>
		InvalidName,
		/// <summary>
		/// Type of the UserList does not match.
		/// </summary>
		InvalidType,
		/// <summary>
		/// User list rule operand is invalid.
		/// </summary>
		InvalidUserListLogicalRuleOperand,
		/// <summary>
		/// Name is already being used for another user list for the account.
		/// </summary>
		NameAlreadyUsed,
		/// <summary>
		/// Name is required when creating a new conversion type.
		/// </summary>
		NewConversionTypeNameRequired,
		/// <summary>
		/// Only an owner account may edit a user list.
		/// </summary>
		OwnershipRequiredForSet,
		/// <summary>
		/// Removing user lists is not supported.
		/// </summary>
		RemoveNotSupported,
		/// <summary>
		/// The user list of the type is not mutable
		/// </summary>
		UserListMutateNotSupported,
		/// <summary>
		/// Rule is invalid.
		/// </summary>
		InvalidRule,
		/// <summary>
		/// The specified date range is empty.
		/// </summary>
		InvalidDateRange,
		/// <summary>
		/// A userlist which is privacy sensitive or legal rejected cannot be mutated by external users.
		/// </summary>
		CanNotMutateSensitiveUserlist,
		/// <summary>
		/// Maximum number of rulebased user lists a customer can have.
		/// </summary>
		MaxNumRulebasedUserlists,
		/// <summary>
		/// BasicUserList's billable record field cannot be modified once it is set.
		/// </summary>
		CannotModifyBillableRecordCount,
		/// <summary>
		/// Default generic error.
		/// </summary>
		UserListServiceError
	}
	
	public enum UserListLogicalRuleOperator
	{
		/// <summary>
		/// And - all of the operands.
		/// </summary>
		All,
		/// <summary>
		/// Or - at least one of the operands.
		/// </summary>
		Any,
		/// <summary>
		/// Not - none of the operands.
		/// </summary>
		None,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
	/// <summary>
	/// Membership status of the user list. This status indicates whether a user list
	/// can accumulate more users and may be targeted to.
	/// </summary>
	public enum UserListMembershipStatus
	{
		/// <summary>
		/// Open status - list is accruing members and can be targeted to.
		/// </summary>
		Open,
		/// <summary>
		/// Closed status - No new members being added. Can not be used for targeting.
		/// </summary>
		Closed
	}
	
	/// <summary>
	/// The user list types
	/// </summary>
	public enum UserListType
	{
		/// <summary>
		/// UNKNOWN value can not be passed as input.
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// UserList represented as a collection of conversion types.
		/// </summary>
		Remarketing,
		/// <summary>
		/// UserList represented as a combination of other user lists/interests.
		/// </summary>
		Logical,
		/// <summary>
		/// UserList created in the DoubleClick platform.
		/// </summary>
		ExternalRemarketing,
		/// <summary>
		/// UserList associated with a rule.
		/// </summary>
		RuleBased,
		/// <summary>
		/// UserList with users similar to users of another UserList.
		/// </summary>
		Similar,
		/// <summary>
		/// UserList of first party CRM data provided by advertiser in the form of emails or
		/// other formats.
		/// </summary>
		CrmBased
	}
	
	/// <summary>
	/// Specified by user to pause or unpause a criterion.
	/// </summary>
	public enum UserStatus
	{
		/// <summary>
		/// Default state of a criterion (e.g. not paused).
		/// </summary>
		Enabled,
		/// <summary>
		/// Criterion is removed.
		/// </summary>
		Removed,
		/// <summary>
		/// Criterion is paused. Also used to pause a criterion.
		/// </summary>
		Paused
	}
	
	/// <summary>
	/// Mode of display URL for pharma related text ads.
	/// </summary>
	public enum VanityPharmaDisplayUrlMode
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Replace vanity pharma URL with manufacturer website url.
		/// </summary>
		ManufacturerWebsiteUrl,
		/// <summary>
		/// Replace vanity pharma URL with description of the website.
		/// </summary>
		WebsiteDescription
	}
	
	/// <summary>
	/// Static text for Vanity Pharma URLs. This text with website descriptions will be
	/// shown in the display URL when website description option for vanity pharma URLs
	/// is selected.
	/// </summary>
	public enum VanityPharmaText
	{
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown,
		/// <summary>
		/// Prescription treatment website
		/// </summary>
		PrescriptionTreatmentWebsiteEn,
		/// <summary>
		/// Sitio de tratamientos con receta
		/// </summary>
		PrescriptionTreatmentWebsiteEs,
		/// <summary>
		/// Prescription device website
		/// </summary>
		PrescriptionDeviceWebsiteEn,
		/// <summary>
		/// Sitio de dispositivos con receta
		/// </summary>
		PrescriptionDeviceWebsiteEs,
		/// <summary>
		/// Medical device website
		/// </summary>
		MedicalDeviceWebsiteEn,
		/// <summary>
		/// Sitio de dispositivos m?dicos
		/// </summary>
		MedicalDeviceWebsiteEs,
		/// <summary>
		/// Preventative treatment website
		/// </summary>
		PreventativeTreatmentWebsiteEn,
		/// <summary>
		/// Sitio de tratamientos preventivos
		/// </summary>
		PreventativeTreatmentWebsiteEs,
		/// <summary>
		/// Prescription contraception website
		/// </summary>
		PrescriptionContraceptionWebsiteEn,
		/// <summary>
		/// Sitio de anticonceptivos con receta
		/// </summary>
		PrescriptionContraceptionWebsiteEs,
		/// <summary>
		/// Prescription vaccine website
		/// </summary>
		PrescriptionVaccineWebsiteEn,
		/// <summary>
		/// Sitio de vacunas con receta
		/// </summary>
		PrescriptionVaccineWebsiteEs
	}
	
	public enum VideoErrorReason
	{
		/// <summary>
		/// Invalid video.
		/// </summary>
		InvalidVideo,
		/// <summary>
		/// Storage error.
		/// </summary>
		StorageError,
		/// <summary>
		/// Bad request.
		/// </summary>
		BadRequest,
		/// <summary>
		/// Server error.
		/// </summary>
		ErrorGeneratingStreamingUrl,
		/// <summary>
		/// Unexpected size.
		/// </summary>
		UnexpectedSize,
		/// <summary>
		/// Server error.
		/// </summary>
		ServerError,
		/// <summary>
		/// File too large.
		/// </summary>
		FileTooLarge,
		/// <summary>
		/// Video processing error.
		/// </summary>
		VideoProcessingError,
		/// <summary>
		/// Invalid input.
		/// </summary>
		InvalidInput,
		/// <summary>
		/// Problem reading file.
		/// </summary>
		ProblemReadingFile,
		/// <summary>
		/// Invalid ISCI.
		/// </summary>
		InvalidIsci,
		/// <summary>
		/// Invalid AD-ID.
		/// </summary>
		InvalidAdId
	}
	
	/// <summary>
	/// VideoType enum values that are permitted for video filterable
	/// creative attribute IDs.
	/// </summary>
	public enum VideoType
	{
		/// <summary>
		/// The Adobe Flash video format (.swf).
		/// </summary>
		Adobe,
		/// <summary>
		/// The RealVideo format (.rm or .ram).
		/// </summary>
		Realplayer,
		/// <summary>
		/// The QuickTime format (.mov).
		/// </summary>
		Quicktime,
		/// <summary>
		/// The Windows Media format (.wmv).
		/// </summary>
		Windowsmedia
	}
	
	/// <summary>
	/// Operand value of {@link WebpageCondition}.
	/// </summary>
	public enum WebpageConditionOperand
	{
		/// <summary>
		/// Operand denoting a webpage URL targeting condition.
		/// The operator {@link StringConditionOperator#CONTAINS} will be used for
		/// such conditions.
		/// </summary>
		Url,
		/// <summary>
		/// Operand denoting a webpage category targeting condition.
		/// The operator {@link StringConditionOperator#EQUALS} will be used for
		/// such conditions.
		/// </summary>
		Category,
		/// <summary>
		/// Operand denoting a webpage title targeting condition.
		/// The operator {@link StringConditionOperator#CONTAINS} will be used for
		/// such conditions.
		/// </summary>
		PageTitle,
		/// <summary>
		/// Operand denoting a webpage content targeting condition.
		/// The operator {@link StringConditionOperator#CONTAINS} will be used for
		/// such conditions.
		/// </summary>
		PageContent,
		/// <summary>
		/// <span class="constraint Rejected">Used for return value only. An enumeration could not be processed, typically due to incompatibility with your WSDL version.</span>
		/// </summary>
		Unknown
	}
	
}
