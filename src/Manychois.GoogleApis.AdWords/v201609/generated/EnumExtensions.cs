using System;

namespace Manychois.GoogleApis.AdWords.v201609
{
	public static class AccessReasonExtensions
	{
		public static string ToXmlValue(this AccessReason enumValue)
		{
			switch (enumValue)
			{
				case AccessReason.Owned: return "OWNED";
				case AccessReason.Shared: return "SHARED";
				case AccessReason.Licensed: return "LICENSED";
				case AccessReason.Subscribed: return "SUBSCRIBED";
				default: return null;
			}
		}
		public static AccessReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "OWNED": return AccessReason.Owned;
				case "SHARED": return AccessReason.Shared;
				case "LICENSED": return AccessReason.Licensed;
				case "SUBSCRIBED": return AccessReason.Subscribed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AccessReason.", nameof(xmlValue));
			}
		}
	}
	public static class AccountUserListStatusExtensions
	{
		public static string ToXmlValue(this AccountUserListStatus enumValue)
		{
			switch (enumValue)
			{
				case AccountUserListStatus.Active: return "ACTIVE";
				case AccountUserListStatus.Inactive: return "INACTIVE";
				default: return null;
			}
		}
		public static AccountUserListStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACTIVE": return AccountUserListStatus.Active;
				case "INACTIVE": return AccountUserListStatus.Inactive;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AccountUserListStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AdCustomizerErrorReasonExtensions
	{
		public static string ToXmlValue(this AdCustomizerErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdCustomizerErrorReason.CountdownInvalidDateFormat: return "COUNTDOWN_INVALID_DATE_FORMAT";
				case AdCustomizerErrorReason.CountdownDateInPast: return "COUNTDOWN_DATE_IN_PAST";
				case AdCustomizerErrorReason.CountdownInvalidLocale: return "COUNTDOWN_INVALID_LOCALE";
				case AdCustomizerErrorReason.CountdownInvalidStartDaysBefore: return "COUNTDOWN_INVALID_START_DAYS_BEFORE";
				default: return null;
			}
		}
		public static AdCustomizerErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "COUNTDOWN_INVALID_DATE_FORMAT": return AdCustomizerErrorReason.CountdownInvalidDateFormat;
				case "COUNTDOWN_DATE_IN_PAST": return AdCustomizerErrorReason.CountdownDateInPast;
				case "COUNTDOWN_INVALID_LOCALE": return AdCustomizerErrorReason.CountdownInvalidLocale;
				case "COUNTDOWN_INVALID_START_DAYS_BEFORE": return AdCustomizerErrorReason.CountdownInvalidStartDaysBefore;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdCustomizerErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdCustomizerFeedAttributeTypeExtensions
	{
		public static string ToXmlValue(this AdCustomizerFeedAttributeType enumValue)
		{
			switch (enumValue)
			{
				case AdCustomizerFeedAttributeType.Integer: return "INTEGER";
				case AdCustomizerFeedAttributeType.Price: return "PRICE";
				case AdCustomizerFeedAttributeType.DateTime: return "DATE_TIME";
				case AdCustomizerFeedAttributeType.String: return "STRING";
				case AdCustomizerFeedAttributeType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdCustomizerFeedAttributeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INTEGER": return AdCustomizerFeedAttributeType.Integer;
				case "PRICE": return AdCustomizerFeedAttributeType.Price;
				case "DATE_TIME": return AdCustomizerFeedAttributeType.DateTime;
				case "STRING": return AdCustomizerFeedAttributeType.String;
				case "UNKNOWN": return AdCustomizerFeedAttributeType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdCustomizerFeedAttributeType.", nameof(xmlValue));
			}
		}
	}
	public static class AdCustomizerFeedErrorReasonExtensions
	{
		public static string ToXmlValue(this AdCustomizerFeedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdCustomizerFeedErrorReason.CannotAddKeyAttribute: return "CANNOT_ADD_KEY_ATTRIBUTE";
				case AdCustomizerFeedErrorReason.NotAdCustomizerFeed: return "NOT_AD_CUSTOMIZER_FEED";
				case AdCustomizerFeedErrorReason.InvalidFeedName: return "INVALID_FEED_NAME";
				case AdCustomizerFeedErrorReason.TooManyFeedAttributesForFeed: return "TOO_MANY_FEED_ATTRIBUTES_FOR_FEED";
				case AdCustomizerFeedErrorReason.AttributeNamesNotUnique: return "ATTRIBUTE_NAMES_NOT_UNIQUE";
				case AdCustomizerFeedErrorReason.FeedDeleted: return "FEED_DELETED";
				case AdCustomizerFeedErrorReason.DuplicateFeedName: return "DUPLICATE_FEED_NAME";
				case AdCustomizerFeedErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdCustomizerFeedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_ADD_KEY_ATTRIBUTE": return AdCustomizerFeedErrorReason.CannotAddKeyAttribute;
				case "NOT_AD_CUSTOMIZER_FEED": return AdCustomizerFeedErrorReason.NotAdCustomizerFeed;
				case "INVALID_FEED_NAME": return AdCustomizerFeedErrorReason.InvalidFeedName;
				case "TOO_MANY_FEED_ATTRIBUTES_FOR_FEED": return AdCustomizerFeedErrorReason.TooManyFeedAttributesForFeed;
				case "ATTRIBUTE_NAMES_NOT_UNIQUE": return AdCustomizerFeedErrorReason.AttributeNamesNotUnique;
				case "FEED_DELETED": return AdCustomizerFeedErrorReason.FeedDeleted;
				case "DUPLICATE_FEED_NAME": return AdCustomizerFeedErrorReason.DuplicateFeedName;
				case "UNKNOWN": return AdCustomizerFeedErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdCustomizerFeedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdErrorReasonExtensions
	{
		public static string ToXmlValue(this AdErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdErrorReason.AdCustomizersNotSupportedForAdType: return "AD_CUSTOMIZERS_NOT_SUPPORTED_FOR_AD_TYPE";
				case AdErrorReason.ApproximatelyTooLong: return "APPROXIMATELY_TOO_LONG";
				case AdErrorReason.ApproximatelyTooShort: return "APPROXIMATELY_TOO_SHORT";
				case AdErrorReason.BadSnippet: return "BAD_SNIPPET";
				case AdErrorReason.CannotModifyAd: return "CANNOT_MODIFY_AD";
				case AdErrorReason.CannotSetBusinessNameIfUrlSet: return "CANNOT_SET_BUSINESS_NAME_IF_URL_SET";
				case AdErrorReason.CannotSetField: return "CANNOT_SET_FIELD";
				case AdErrorReason.CannotSetFieldWithOriginAdIdSet: return "CANNOT_SET_FIELD_WITH_ORIGIN_AD_ID_SET";
				case AdErrorReason.CannotSetFieldWithAdIdSetForSharing: return "CANNOT_SET_FIELD_WITH_AD_ID_SET_FOR_SHARING";
				case AdErrorReason.CannotSetUrl: return "CANNOT_SET_URL";
				case AdErrorReason.CannotSetWithoutFinalUrls: return "CANNOT_SET_WITHOUT_FINAL_URLS";
				case AdErrorReason.CannotSetWithFinalUrls: return "CANNOT_SET_WITH_FINAL_URLS";
				case AdErrorReason.CannotSetWithTrackingUrlTemplate: return "CANNOT_SET_WITH_TRACKING_URL_TEMPLATE";
				case AdErrorReason.CannotUseAdSubclassForOperator: return "CANNOT_USE_AD_SUBCLASS_FOR_OPERATOR";
				case AdErrorReason.CustomerNotApprovedMobileads: return "CUSTOMER_NOT_APPROVED_MOBILEADS";
				case AdErrorReason.CustomerNotApprovedThirdpartyAds: return "CUSTOMER_NOT_APPROVED_THIRDPARTY_ADS";
				case AdErrorReason.CustomerNotApprovedThirdpartyRedirectAds: return "CUSTOMER_NOT_APPROVED_THIRDPARTY_REDIRECT_ADS";
				case AdErrorReason.CustomerNotEligible: return "CUSTOMER_NOT_ELIGIBLE";
				case AdErrorReason.CustomerNotEligibleForUpdatingBeaconUrl: return "CUSTOMER_NOT_ELIGIBLE_FOR_UPDATING_BEACON_URL";
				case AdErrorReason.DimensionAlreadyInUnion: return "DIMENSION_ALREADY_IN_UNION";
				case AdErrorReason.DimensionMustBeSet: return "DIMENSION_MUST_BE_SET";
				case AdErrorReason.DimensionNotInUnion: return "DIMENSION_NOT_IN_UNION";
				case AdErrorReason.DisplayUrlCannotBeSpecified: return "DISPLAY_URL_CANNOT_BE_SPECIFIED";
				case AdErrorReason.DomesticPhoneNumberFormat: return "DOMESTIC_PHONE_NUMBER_FORMAT";
				case AdErrorReason.EmergencyPhoneNumber: return "EMERGENCY_PHONE_NUMBER";
				case AdErrorReason.EmptyField: return "EMPTY_FIELD";
				case AdErrorReason.FeedAttributeMustHaveMappingForTypeId: return "FEED_ATTRIBUTE_MUST_HAVE_MAPPING_FOR_TYPE_ID";
				case AdErrorReason.FeedAttributeMappingTypeMismatch: return "FEED_ATTRIBUTE_MAPPING_TYPE_MISMATCH";
				case AdErrorReason.IllegalAdCustomizerTagUse: return "ILLEGAL_AD_CUSTOMIZER_TAG_USE";
				case AdErrorReason.InconsistentDimensions: return "INCONSISTENT_DIMENSIONS";
				case AdErrorReason.InconsistentStatusInTemplateUnion: return "INCONSISTENT_STATUS_IN_TEMPLATE_UNION";
				case AdErrorReason.IncorrectLength: return "INCORRECT_LENGTH";
				case AdErrorReason.IneligibleForUpgrade: return "INELIGIBLE_FOR_UPGRADE";
				case AdErrorReason.InvalidAdAddressCampaignTarget: return "INVALID_AD_ADDRESS_CAMPAIGN_TARGET";
				case AdErrorReason.InvalidAdType: return "INVALID_AD_TYPE";
				case AdErrorReason.InvalidAttributesForMobileImage: return "INVALID_ATTRIBUTES_FOR_MOBILE_IMAGE";
				case AdErrorReason.InvalidAttributesForMobileText: return "INVALID_ATTRIBUTES_FOR_MOBILE_TEXT";
				case AdErrorReason.InvalidCharacterForUrl: return "INVALID_CHARACTER_FOR_URL";
				case AdErrorReason.InvalidCountryCode: return "INVALID_COUNTRY_CODE";
				case AdErrorReason.InvalidDsaUrlTag: return "INVALID_DSA_URL_TAG";
				case AdErrorReason.InvalidInput: return "INVALID_INPUT";
				case AdErrorReason.InvalidMarkupLanguage: return "INVALID_MARKUP_LANGUAGE";
				case AdErrorReason.InvalidMobileCarrier: return "INVALID_MOBILE_CARRIER";
				case AdErrorReason.InvalidMobileCarrierTarget: return "INVALID_MOBILE_CARRIER_TARGET";
				case AdErrorReason.InvalidNumberOfElements: return "INVALID_NUMBER_OF_ELEMENTS";
				case AdErrorReason.InvalidPhoneNumberFormat: return "INVALID_PHONE_NUMBER_FORMAT";
				case AdErrorReason.InvalidRichMediaCertifiedVendorFormatId: return "INVALID_RICH_MEDIA_CERTIFIED_VENDOR_FORMAT_ID";
				case AdErrorReason.InvalidTemplateData: return "INVALID_TEMPLATE_DATA";
				case AdErrorReason.InvalidTemplateElementFieldType: return "INVALID_TEMPLATE_ELEMENT_FIELD_TYPE";
				case AdErrorReason.InvalidTemplateId: return "INVALID_TEMPLATE_ID";
				case AdErrorReason.LineTooWide: return "LINE_TOO_WIDE";
				case AdErrorReason.MarkupLanguagesPresent: return "MARKUP_LANGUAGES_PRESENT";
				case AdErrorReason.MissingAdCustomizerMapping: return "MISSING_AD_CUSTOMIZER_MAPPING";
				case AdErrorReason.MissingAddressComponent: return "MISSING_ADDRESS_COMPONENT";
				case AdErrorReason.MissingAdvertisementName: return "MISSING_ADVERTISEMENT_NAME";
				case AdErrorReason.MissingBusinessName: return "MISSING_BUSINESS_NAME";
				case AdErrorReason.MissingDescription1: return "MISSING_DESCRIPTION1";
				case AdErrorReason.MissingDescription2: return "MISSING_DESCRIPTION2";
				case AdErrorReason.MissingDestinationUrl: return "MISSING_DESTINATION_URL";
				case AdErrorReason.MissingDestinationUrlTag: return "MISSING_DESTINATION_URL_TAG";
				case AdErrorReason.MissingDimension: return "MISSING_DIMENSION";
				case AdErrorReason.MissingDisplayUrl: return "MISSING_DISPLAY_URL";
				case AdErrorReason.MissingHeadline: return "MISSING_HEADLINE";
				case AdErrorReason.MissingHeight: return "MISSING_HEIGHT";
				case AdErrorReason.MissingImage: return "MISSING_IMAGE";
				case AdErrorReason.MissingMarkupLanguages: return "MISSING_MARKUP_LANGUAGES";
				case AdErrorReason.MissingMobileCarrier: return "MISSING_MOBILE_CARRIER";
				case AdErrorReason.MissingPhone: return "MISSING_PHONE";
				case AdErrorReason.MissingRequiredTemplateFields: return "MISSING_REQUIRED_TEMPLATE_FIELDS";
				case AdErrorReason.MissingTemplateFieldValue: return "MISSING_TEMPLATE_FIELD_VALUE";
				case AdErrorReason.MissingText: return "MISSING_TEXT";
				case AdErrorReason.MissingUrlAndPhone: return "MISSING_URL_AND_PHONE";
				case AdErrorReason.MissingVisibleUrl: return "MISSING_VISIBLE_URL";
				case AdErrorReason.MissingWidth: return "MISSING_WIDTH";
				case AdErrorReason.MultipleDistinctFeedsUnsupported: return "MULTIPLE_DISTINCT_FEEDS_UNSUPPORTED";
				case AdErrorReason.MustUseTempAdUnionIdOnAdd: return "MUST_USE_TEMP_AD_UNION_ID_ON_ADD";
				case AdErrorReason.TooLong: return "TOO_LONG";
				case AdErrorReason.TooShort: return "TOO_SHORT";
				case AdErrorReason.UnionDimensionsCannotChange: return "UNION_DIMENSIONS_CANNOT_CHANGE";
				case AdErrorReason.UnknownAddressComponent: return "UNKNOWN_ADDRESS_COMPONENT";
				case AdErrorReason.UnknownFieldName: return "UNKNOWN_FIELD_NAME";
				case AdErrorReason.UnknownUniqueName: return "UNKNOWN_UNIQUE_NAME";
				case AdErrorReason.UnsupportedDimensions: return "UNSUPPORTED_DIMENSIONS";
				case AdErrorReason.UrlInvalidScheme: return "URL_INVALID_SCHEME";
				case AdErrorReason.UrlInvalidTopLevelDomain: return "URL_INVALID_TOP_LEVEL_DOMAIN";
				case AdErrorReason.UrlMalformed: return "URL_MALFORMED";
				case AdErrorReason.UrlNoHost: return "URL_NO_HOST";
				case AdErrorReason.UrlNotEquivalent: return "URL_NOT_EQUIVALENT";
				case AdErrorReason.UrlHostNameTooLong: return "URL_HOST_NAME_TOO_LONG";
				case AdErrorReason.UrlNoScheme: return "URL_NO_SCHEME";
				case AdErrorReason.UrlNoTopLevelDomain: return "URL_NO_TOP_LEVEL_DOMAIN";
				case AdErrorReason.UrlPathNotAllowed: return "URL_PATH_NOT_ALLOWED";
				case AdErrorReason.UrlPortNotAllowed: return "URL_PORT_NOT_ALLOWED";
				case AdErrorReason.UrlQueryNotAllowed: return "URL_QUERY_NOT_ALLOWED";
				case AdErrorReason.UrlSchemeBeforeDsaTag: return "URL_SCHEME_BEFORE_DSA_TAG";
				case AdErrorReason.UserDoesNotHaveAccessToTemplate: return "USER_DOES_NOT_HAVE_ACCESS_TO_TEMPLATE";
				case AdErrorReason.InconsistentExpandableSettings: return "INCONSISTENT_EXPANDABLE_SETTINGS";
				case AdErrorReason.InvalidFormat: return "INVALID_FORMAT";
				case AdErrorReason.InvalidFieldText: return "INVALID_FIELD_TEXT";
				case AdErrorReason.ElementNotPresent: return "ELEMENT_NOT_PRESENT";
				case AdErrorReason.ImageError: return "IMAGE_ERROR";
				case AdErrorReason.ValueNotInRange: return "VALUE_NOT_IN_RANGE";
				case AdErrorReason.FieldNotPresent: return "FIELD_NOT_PRESENT";
				case AdErrorReason.AddressNotComplete: return "ADDRESS_NOT_COMPLETE";
				case AdErrorReason.AddressInvalid: return "ADDRESS_INVALID";
				case AdErrorReason.VideoRetrievalError: return "VIDEO_RETRIEVAL_ERROR";
				case AdErrorReason.AudioError: return "AUDIO_ERROR";
				case AdErrorReason.InvalidYoutubeDisplayUrl: return "INVALID_YOUTUBE_DISPLAY_URL";
				case AdErrorReason.IncompatibleAdTypeAndDevicePreference: return "INCOMPATIBLE_AD_TYPE_AND_DEVICE_PREFERENCE";
				case AdErrorReason.CalltrackingNotSupportedForCountry: return "CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY";
				case AdErrorReason.CarrierSpecificShortNumberNotAllowed: return "CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED";
				case AdErrorReason.DisallowedNumberType: return "DISALLOWED_NUMBER_TYPE";
				case AdErrorReason.PhoneNumberNotSupportedForCountry: return "PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY";
				case AdErrorReason.PhoneNumberNotSupportedWithCalltrackingForCountry: return "PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY";
				case AdErrorReason.PremiumRateNumberNotAllowed: return "PREMIUM_RATE_NUMBER_NOT_ALLOWED";
				case AdErrorReason.VanityPhoneNumberNotAllowed: return "VANITY_PHONE_NUMBER_NOT_ALLOWED";
				case AdErrorReason.InvalidCallConversionTypeId: return "INVALID_CALL_CONVERSION_TYPE_ID";
				case AdErrorReason.CannotDisableCallConversionAndSetConversionTypeId: return "CANNOT_DISABLE_CALL_CONVERSION_AND_SET_CONVERSION_TYPE_ID";
				case AdErrorReason.CannotSetPath2WithoutPath1: return "CANNOT_SET_PATH2_WITHOUT_PATH1";
				case AdErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AD_CUSTOMIZERS_NOT_SUPPORTED_FOR_AD_TYPE": return AdErrorReason.AdCustomizersNotSupportedForAdType;
				case "APPROXIMATELY_TOO_LONG": return AdErrorReason.ApproximatelyTooLong;
				case "APPROXIMATELY_TOO_SHORT": return AdErrorReason.ApproximatelyTooShort;
				case "BAD_SNIPPET": return AdErrorReason.BadSnippet;
				case "CANNOT_MODIFY_AD": return AdErrorReason.CannotModifyAd;
				case "CANNOT_SET_BUSINESS_NAME_IF_URL_SET": return AdErrorReason.CannotSetBusinessNameIfUrlSet;
				case "CANNOT_SET_FIELD": return AdErrorReason.CannotSetField;
				case "CANNOT_SET_FIELD_WITH_ORIGIN_AD_ID_SET": return AdErrorReason.CannotSetFieldWithOriginAdIdSet;
				case "CANNOT_SET_FIELD_WITH_AD_ID_SET_FOR_SHARING": return AdErrorReason.CannotSetFieldWithAdIdSetForSharing;
				case "CANNOT_SET_URL": return AdErrorReason.CannotSetUrl;
				case "CANNOT_SET_WITHOUT_FINAL_URLS": return AdErrorReason.CannotSetWithoutFinalUrls;
				case "CANNOT_SET_WITH_FINAL_URLS": return AdErrorReason.CannotSetWithFinalUrls;
				case "CANNOT_SET_WITH_TRACKING_URL_TEMPLATE": return AdErrorReason.CannotSetWithTrackingUrlTemplate;
				case "CANNOT_USE_AD_SUBCLASS_FOR_OPERATOR": return AdErrorReason.CannotUseAdSubclassForOperator;
				case "CUSTOMER_NOT_APPROVED_MOBILEADS": return AdErrorReason.CustomerNotApprovedMobileads;
				case "CUSTOMER_NOT_APPROVED_THIRDPARTY_ADS": return AdErrorReason.CustomerNotApprovedThirdpartyAds;
				case "CUSTOMER_NOT_APPROVED_THIRDPARTY_REDIRECT_ADS": return AdErrorReason.CustomerNotApprovedThirdpartyRedirectAds;
				case "CUSTOMER_NOT_ELIGIBLE": return AdErrorReason.CustomerNotEligible;
				case "CUSTOMER_NOT_ELIGIBLE_FOR_UPDATING_BEACON_URL": return AdErrorReason.CustomerNotEligibleForUpdatingBeaconUrl;
				case "DIMENSION_ALREADY_IN_UNION": return AdErrorReason.DimensionAlreadyInUnion;
				case "DIMENSION_MUST_BE_SET": return AdErrorReason.DimensionMustBeSet;
				case "DIMENSION_NOT_IN_UNION": return AdErrorReason.DimensionNotInUnion;
				case "DISPLAY_URL_CANNOT_BE_SPECIFIED": return AdErrorReason.DisplayUrlCannotBeSpecified;
				case "DOMESTIC_PHONE_NUMBER_FORMAT": return AdErrorReason.DomesticPhoneNumberFormat;
				case "EMERGENCY_PHONE_NUMBER": return AdErrorReason.EmergencyPhoneNumber;
				case "EMPTY_FIELD": return AdErrorReason.EmptyField;
				case "FEED_ATTRIBUTE_MUST_HAVE_MAPPING_FOR_TYPE_ID": return AdErrorReason.FeedAttributeMustHaveMappingForTypeId;
				case "FEED_ATTRIBUTE_MAPPING_TYPE_MISMATCH": return AdErrorReason.FeedAttributeMappingTypeMismatch;
				case "ILLEGAL_AD_CUSTOMIZER_TAG_USE": return AdErrorReason.IllegalAdCustomizerTagUse;
				case "INCONSISTENT_DIMENSIONS": return AdErrorReason.InconsistentDimensions;
				case "INCONSISTENT_STATUS_IN_TEMPLATE_UNION": return AdErrorReason.InconsistentStatusInTemplateUnion;
				case "INCORRECT_LENGTH": return AdErrorReason.IncorrectLength;
				case "INELIGIBLE_FOR_UPGRADE": return AdErrorReason.IneligibleForUpgrade;
				case "INVALID_AD_ADDRESS_CAMPAIGN_TARGET": return AdErrorReason.InvalidAdAddressCampaignTarget;
				case "INVALID_AD_TYPE": return AdErrorReason.InvalidAdType;
				case "INVALID_ATTRIBUTES_FOR_MOBILE_IMAGE": return AdErrorReason.InvalidAttributesForMobileImage;
				case "INVALID_ATTRIBUTES_FOR_MOBILE_TEXT": return AdErrorReason.InvalidAttributesForMobileText;
				case "INVALID_CHARACTER_FOR_URL": return AdErrorReason.InvalidCharacterForUrl;
				case "INVALID_COUNTRY_CODE": return AdErrorReason.InvalidCountryCode;
				case "INVALID_DSA_URL_TAG": return AdErrorReason.InvalidDsaUrlTag;
				case "INVALID_INPUT": return AdErrorReason.InvalidInput;
				case "INVALID_MARKUP_LANGUAGE": return AdErrorReason.InvalidMarkupLanguage;
				case "INVALID_MOBILE_CARRIER": return AdErrorReason.InvalidMobileCarrier;
				case "INVALID_MOBILE_CARRIER_TARGET": return AdErrorReason.InvalidMobileCarrierTarget;
				case "INVALID_NUMBER_OF_ELEMENTS": return AdErrorReason.InvalidNumberOfElements;
				case "INVALID_PHONE_NUMBER_FORMAT": return AdErrorReason.InvalidPhoneNumberFormat;
				case "INVALID_RICH_MEDIA_CERTIFIED_VENDOR_FORMAT_ID": return AdErrorReason.InvalidRichMediaCertifiedVendorFormatId;
				case "INVALID_TEMPLATE_DATA": return AdErrorReason.InvalidTemplateData;
				case "INVALID_TEMPLATE_ELEMENT_FIELD_TYPE": return AdErrorReason.InvalidTemplateElementFieldType;
				case "INVALID_TEMPLATE_ID": return AdErrorReason.InvalidTemplateId;
				case "LINE_TOO_WIDE": return AdErrorReason.LineTooWide;
				case "MARKUP_LANGUAGES_PRESENT": return AdErrorReason.MarkupLanguagesPresent;
				case "MISSING_AD_CUSTOMIZER_MAPPING": return AdErrorReason.MissingAdCustomizerMapping;
				case "MISSING_ADDRESS_COMPONENT": return AdErrorReason.MissingAddressComponent;
				case "MISSING_ADVERTISEMENT_NAME": return AdErrorReason.MissingAdvertisementName;
				case "MISSING_BUSINESS_NAME": return AdErrorReason.MissingBusinessName;
				case "MISSING_DESCRIPTION1": return AdErrorReason.MissingDescription1;
				case "MISSING_DESCRIPTION2": return AdErrorReason.MissingDescription2;
				case "MISSING_DESTINATION_URL": return AdErrorReason.MissingDestinationUrl;
				case "MISSING_DESTINATION_URL_TAG": return AdErrorReason.MissingDestinationUrlTag;
				case "MISSING_DIMENSION": return AdErrorReason.MissingDimension;
				case "MISSING_DISPLAY_URL": return AdErrorReason.MissingDisplayUrl;
				case "MISSING_HEADLINE": return AdErrorReason.MissingHeadline;
				case "MISSING_HEIGHT": return AdErrorReason.MissingHeight;
				case "MISSING_IMAGE": return AdErrorReason.MissingImage;
				case "MISSING_MARKUP_LANGUAGES": return AdErrorReason.MissingMarkupLanguages;
				case "MISSING_MOBILE_CARRIER": return AdErrorReason.MissingMobileCarrier;
				case "MISSING_PHONE": return AdErrorReason.MissingPhone;
				case "MISSING_REQUIRED_TEMPLATE_FIELDS": return AdErrorReason.MissingRequiredTemplateFields;
				case "MISSING_TEMPLATE_FIELD_VALUE": return AdErrorReason.MissingTemplateFieldValue;
				case "MISSING_TEXT": return AdErrorReason.MissingText;
				case "MISSING_URL_AND_PHONE": return AdErrorReason.MissingUrlAndPhone;
				case "MISSING_VISIBLE_URL": return AdErrorReason.MissingVisibleUrl;
				case "MISSING_WIDTH": return AdErrorReason.MissingWidth;
				case "MULTIPLE_DISTINCT_FEEDS_UNSUPPORTED": return AdErrorReason.MultipleDistinctFeedsUnsupported;
				case "MUST_USE_TEMP_AD_UNION_ID_ON_ADD": return AdErrorReason.MustUseTempAdUnionIdOnAdd;
				case "TOO_LONG": return AdErrorReason.TooLong;
				case "TOO_SHORT": return AdErrorReason.TooShort;
				case "UNION_DIMENSIONS_CANNOT_CHANGE": return AdErrorReason.UnionDimensionsCannotChange;
				case "UNKNOWN_ADDRESS_COMPONENT": return AdErrorReason.UnknownAddressComponent;
				case "UNKNOWN_FIELD_NAME": return AdErrorReason.UnknownFieldName;
				case "UNKNOWN_UNIQUE_NAME": return AdErrorReason.UnknownUniqueName;
				case "UNSUPPORTED_DIMENSIONS": return AdErrorReason.UnsupportedDimensions;
				case "URL_INVALID_SCHEME": return AdErrorReason.UrlInvalidScheme;
				case "URL_INVALID_TOP_LEVEL_DOMAIN": return AdErrorReason.UrlInvalidTopLevelDomain;
				case "URL_MALFORMED": return AdErrorReason.UrlMalformed;
				case "URL_NO_HOST": return AdErrorReason.UrlNoHost;
				case "URL_NOT_EQUIVALENT": return AdErrorReason.UrlNotEquivalent;
				case "URL_HOST_NAME_TOO_LONG": return AdErrorReason.UrlHostNameTooLong;
				case "URL_NO_SCHEME": return AdErrorReason.UrlNoScheme;
				case "URL_NO_TOP_LEVEL_DOMAIN": return AdErrorReason.UrlNoTopLevelDomain;
				case "URL_PATH_NOT_ALLOWED": return AdErrorReason.UrlPathNotAllowed;
				case "URL_PORT_NOT_ALLOWED": return AdErrorReason.UrlPortNotAllowed;
				case "URL_QUERY_NOT_ALLOWED": return AdErrorReason.UrlQueryNotAllowed;
				case "URL_SCHEME_BEFORE_DSA_TAG": return AdErrorReason.UrlSchemeBeforeDsaTag;
				case "USER_DOES_NOT_HAVE_ACCESS_TO_TEMPLATE": return AdErrorReason.UserDoesNotHaveAccessToTemplate;
				case "INCONSISTENT_EXPANDABLE_SETTINGS": return AdErrorReason.InconsistentExpandableSettings;
				case "INVALID_FORMAT": return AdErrorReason.InvalidFormat;
				case "INVALID_FIELD_TEXT": return AdErrorReason.InvalidFieldText;
				case "ELEMENT_NOT_PRESENT": return AdErrorReason.ElementNotPresent;
				case "IMAGE_ERROR": return AdErrorReason.ImageError;
				case "VALUE_NOT_IN_RANGE": return AdErrorReason.ValueNotInRange;
				case "FIELD_NOT_PRESENT": return AdErrorReason.FieldNotPresent;
				case "ADDRESS_NOT_COMPLETE": return AdErrorReason.AddressNotComplete;
				case "ADDRESS_INVALID": return AdErrorReason.AddressInvalid;
				case "VIDEO_RETRIEVAL_ERROR": return AdErrorReason.VideoRetrievalError;
				case "AUDIO_ERROR": return AdErrorReason.AudioError;
				case "INVALID_YOUTUBE_DISPLAY_URL": return AdErrorReason.InvalidYoutubeDisplayUrl;
				case "INCOMPATIBLE_AD_TYPE_AND_DEVICE_PREFERENCE": return AdErrorReason.IncompatibleAdTypeAndDevicePreference;
				case "CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY": return AdErrorReason.CalltrackingNotSupportedForCountry;
				case "CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED": return AdErrorReason.CarrierSpecificShortNumberNotAllowed;
				case "DISALLOWED_NUMBER_TYPE": return AdErrorReason.DisallowedNumberType;
				case "PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY": return AdErrorReason.PhoneNumberNotSupportedForCountry;
				case "PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY": return AdErrorReason.PhoneNumberNotSupportedWithCalltrackingForCountry;
				case "PREMIUM_RATE_NUMBER_NOT_ALLOWED": return AdErrorReason.PremiumRateNumberNotAllowed;
				case "VANITY_PHONE_NUMBER_NOT_ALLOWED": return AdErrorReason.VanityPhoneNumberNotAllowed;
				case "INVALID_CALL_CONVERSION_TYPE_ID": return AdErrorReason.InvalidCallConversionTypeId;
				case "CANNOT_DISABLE_CALL_CONVERSION_AND_SET_CONVERSION_TYPE_ID": return AdErrorReason.CannotDisableCallConversionAndSetConversionTypeId;
				case "CANNOT_SET_PATH2_WITHOUT_PATH1": return AdErrorReason.CannotSetPath2WithoutPath1;
				case "UNKNOWN": return AdErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupAdApprovalStatusExtensions
	{
		public static string ToXmlValue(this AdGroupAdApprovalStatus enumValue)
		{
			switch (enumValue)
			{
				case AdGroupAdApprovalStatus.Approved: return "APPROVED";
				case AdGroupAdApprovalStatus.Disapproved: return "DISAPPROVED";
				case AdGroupAdApprovalStatus.FamilySafe: return "FAMILY_SAFE";
				case AdGroupAdApprovalStatus.NonFamilySafe: return "NON_FAMILY_SAFE";
				case AdGroupAdApprovalStatus.Porn: return "PORN";
				case AdGroupAdApprovalStatus.Unchecked: return "UNCHECKED";
				case AdGroupAdApprovalStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdGroupAdApprovalStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "APPROVED": return AdGroupAdApprovalStatus.Approved;
				case "DISAPPROVED": return AdGroupAdApprovalStatus.Disapproved;
				case "FAMILY_SAFE": return AdGroupAdApprovalStatus.FamilySafe;
				case "NON_FAMILY_SAFE": return AdGroupAdApprovalStatus.NonFamilySafe;
				case "PORN": return AdGroupAdApprovalStatus.Porn;
				case "UNCHECKED": return AdGroupAdApprovalStatus.Unchecked;
				case "UNKNOWN": return AdGroupAdApprovalStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupAdApprovalStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupAdErrorReasonExtensions
	{
		public static string ToXmlValue(this AdGroupAdErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdGroupAdErrorReason.AdGroupAdLabelDoesNotExist: return "AD_GROUP_AD_LABEL_DOES_NOT_EXIST";
				case AdGroupAdErrorReason.AdGroupAdLabelAlreadyExists: return "AD_GROUP_AD_LABEL_ALREADY_EXISTS";
				case AdGroupAdErrorReason.AdNotUnderAdgroup: return "AD_NOT_UNDER_ADGROUP";
				case AdGroupAdErrorReason.CannotOperateOnRemovedAdgroupad: return "CANNOT_OPERATE_ON_REMOVED_ADGROUPAD";
				case AdGroupAdErrorReason.CannotCreateDeprecatedAds: return "CANNOT_CREATE_DEPRECATED_ADS";
				case AdGroupAdErrorReason.EmptyField: return "EMPTY_FIELD";
				case AdGroupAdErrorReason.EntityReferencedInMultipleOps: return "ENTITY_REFERENCED_IN_MULTIPLE_OPS";
				case AdGroupAdErrorReason.UnsupportedOperation: return "UNSUPPORTED_OPERATION";
				default: return null;
			}
		}
		public static AdGroupAdErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AD_GROUP_AD_LABEL_DOES_NOT_EXIST": return AdGroupAdErrorReason.AdGroupAdLabelDoesNotExist;
				case "AD_GROUP_AD_LABEL_ALREADY_EXISTS": return AdGroupAdErrorReason.AdGroupAdLabelAlreadyExists;
				case "AD_NOT_UNDER_ADGROUP": return AdGroupAdErrorReason.AdNotUnderAdgroup;
				case "CANNOT_OPERATE_ON_REMOVED_ADGROUPAD": return AdGroupAdErrorReason.CannotOperateOnRemovedAdgroupad;
				case "CANNOT_CREATE_DEPRECATED_ADS": return AdGroupAdErrorReason.CannotCreateDeprecatedAds;
				case "EMPTY_FIELD": return AdGroupAdErrorReason.EmptyField;
				case "ENTITY_REFERENCED_IN_MULTIPLE_OPS": return AdGroupAdErrorReason.EntityReferencedInMultipleOps;
				case "UNSUPPORTED_OPERATION": return AdGroupAdErrorReason.UnsupportedOperation;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupAdErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupAdStatusExtensions
	{
		public static string ToXmlValue(this AdGroupAdStatus enumValue)
		{
			switch (enumValue)
			{
				case AdGroupAdStatus.Enabled: return "ENABLED";
				case AdGroupAdStatus.Paused: return "PAUSED";
				case AdGroupAdStatus.Disabled: return "DISABLED";
				default: return null;
			}
		}
		public static AdGroupAdStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return AdGroupAdStatus.Enabled;
				case "PAUSED": return AdGroupAdStatus.Paused;
				case "DISABLED": return AdGroupAdStatus.Disabled;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupAdStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupBidLandscapeTypeExtensions
	{
		public static string ToXmlValue(this AdGroupBidLandscapeType enumValue)
		{
			switch (enumValue)
			{
				case AdGroupBidLandscapeType.Uniform: return "UNIFORM";
				case AdGroupBidLandscapeType.Default: return "DEFAULT";
				case AdGroupBidLandscapeType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdGroupBidLandscapeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNIFORM": return AdGroupBidLandscapeType.Uniform;
				case "DEFAULT": return AdGroupBidLandscapeType.Default;
				case "UNKNOWN": return AdGroupBidLandscapeType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupBidLandscapeType.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupCriterionErrorReasonExtensions
	{
		public static string ToXmlValue(this AdGroupCriterionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdGroupCriterionErrorReason.AdGroupCriterionLabelDoesNotExist: return "AD_GROUP_CRITERION_LABEL_DOES_NOT_EXIST";
				case AdGroupCriterionErrorReason.AdGroupCriterionLabelAlreadyExists: return "AD_GROUP_CRITERION_LABEL_ALREADY_EXISTS";
				case AdGroupCriterionErrorReason.CannotAddLabelToNegativeCriterion: return "CANNOT_ADD_LABEL_TO_NEGATIVE_CRITERION";
				case AdGroupCriterionErrorReason.TooManyOperations: return "TOO_MANY_OPERATIONS";
				case AdGroupCriterionErrorReason.CantUpdateNegative: return "CANT_UPDATE_NEGATIVE";
				case AdGroupCriterionErrorReason.ConcreteTypeRequired: return "CONCRETE_TYPE_REQUIRED";
				case AdGroupCriterionErrorReason.BidIncompatibleWithAdgroup: return "BID_INCOMPATIBLE_WITH_ADGROUP";
				case AdGroupCriterionErrorReason.CannotTargetAndExclude: return "CANNOT_TARGET_AND_EXCLUDE";
				case AdGroupCriterionErrorReason.IllegalUrl: return "ILLEGAL_URL";
				case AdGroupCriterionErrorReason.InvalidKeywordText: return "INVALID_KEYWORD_TEXT";
				case AdGroupCriterionErrorReason.InvalidDestinationUrl: return "INVALID_DESTINATION_URL";
				case AdGroupCriterionErrorReason.MissingDestinationUrlTag: return "MISSING_DESTINATION_URL_TAG";
				case AdGroupCriterionErrorReason.KeywordLevelBidNotSupportedForManualcpm: return "KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM";
				case AdGroupCriterionErrorReason.InvalidUserStatus: return "INVALID_USER_STATUS";
				case AdGroupCriterionErrorReason.CannotAddCriteriaType: return "CANNOT_ADD_CRITERIA_TYPE";
				case AdGroupCriterionErrorReason.CannotExcludeCriteriaType: return "CANNOT_EXCLUDE_CRITERIA_TYPE";
				case AdGroupCriterionErrorReason.InvalidProductPartitionHierarchy: return "INVALID_PRODUCT_PARTITION_HIERARCHY";
				case AdGroupCriterionErrorReason.ProductPartitionUnitCannotHaveChildren: return "PRODUCT_PARTITION_UNIT_CANNOT_HAVE_CHILDREN";
				case AdGroupCriterionErrorReason.ProductPartitionSubdivisionRequiresOthersCase: return "PRODUCT_PARTITION_SUBDIVISION_REQUIRES_OTHERS_CASE";
				case AdGroupCriterionErrorReason.ProductPartitionRequiresSameDimensionTypeAsSiblings: return "PRODUCT_PARTITION_REQUIRES_SAME_DIMENSION_TYPE_AS_SIBLINGS";
				case AdGroupCriterionErrorReason.ProductPartitionAlreadyExists: return "PRODUCT_PARTITION_ALREADY_EXISTS";
				case AdGroupCriterionErrorReason.ProductPartitionDoesNotExist: return "PRODUCT_PARTITION_DOES_NOT_EXIST";
				case AdGroupCriterionErrorReason.ProductPartitionCannotBeRemoved: return "PRODUCT_PARTITION_CANNOT_BE_REMOVED";
				case AdGroupCriterionErrorReason.InvalidProductPartitionType: return "INVALID_PRODUCT_PARTITION_TYPE";
				case AdGroupCriterionErrorReason.ProductPartitionAddMayOnlyUseTempId: return "PRODUCT_PARTITION_ADD_MAY_ONLY_USE_TEMP_ID";
				case AdGroupCriterionErrorReason.CampaignTypeNotCompatibleWithPartialFailure: return "CAMPAIGN_TYPE_NOT_COMPATIBLE_WITH_PARTIAL_FAILURE";
				case AdGroupCriterionErrorReason.OperationsForTooManyShoppingAdgroups: return "OPERATIONS_FOR_TOO_MANY_SHOPPING_ADGROUPS";
				case AdGroupCriterionErrorReason.CannotModifyUrlFieldsWithDuplicateElements: return "CANNOT_MODIFY_URL_FIELDS_WITH_DUPLICATE_ELEMENTS";
				case AdGroupCriterionErrorReason.CannotSetWithoutFinalUrls: return "CANNOT_SET_WITHOUT_FINAL_URLS";
				case AdGroupCriterionErrorReason.CannotClearFinalUrlsIfFinalMobileUrlsExist: return "CANNOT_CLEAR_FINAL_URLS_IF_FINAL_MOBILE_URLS_EXIST";
				case AdGroupCriterionErrorReason.CannotClearFinalUrlsIfFinalAppUrlsExist: return "CANNOT_CLEAR_FINAL_URLS_IF_FINAL_APP_URLS_EXIST";
				case AdGroupCriterionErrorReason.CannotClearFinalUrlsIfTrackingUrlTemplateExists: return "CANNOT_CLEAR_FINAL_URLS_IF_TRACKING_URL_TEMPLATE_EXISTS";
				case AdGroupCriterionErrorReason.CannotClearFinalUrlsIfUrlCustomParametersExist: return "CANNOT_CLEAR_FINAL_URLS_IF_URL_CUSTOM_PARAMETERS_EXIST";
				case AdGroupCriterionErrorReason.CannotSetBothDestinationUrlAndFinalUrls: return "CANNOT_SET_BOTH_DESTINATION_URL_AND_FINAL_URLS";
				case AdGroupCriterionErrorReason.CannotSetBothDestinationUrlAndTrackingUrlTemplate: return "CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE";
				case AdGroupCriterionErrorReason.FinalUrlsNotSupportedForCriterionType: return "FINAL_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE";
				case AdGroupCriterionErrorReason.FinalMobileUrlsNotSupportedForCriterionType: return "FINAL_MOBILE_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE";
				case AdGroupCriterionErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdGroupCriterionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AD_GROUP_CRITERION_LABEL_DOES_NOT_EXIST": return AdGroupCriterionErrorReason.AdGroupCriterionLabelDoesNotExist;
				case "AD_GROUP_CRITERION_LABEL_ALREADY_EXISTS": return AdGroupCriterionErrorReason.AdGroupCriterionLabelAlreadyExists;
				case "CANNOT_ADD_LABEL_TO_NEGATIVE_CRITERION": return AdGroupCriterionErrorReason.CannotAddLabelToNegativeCriterion;
				case "TOO_MANY_OPERATIONS": return AdGroupCriterionErrorReason.TooManyOperations;
				case "CANT_UPDATE_NEGATIVE": return AdGroupCriterionErrorReason.CantUpdateNegative;
				case "CONCRETE_TYPE_REQUIRED": return AdGroupCriterionErrorReason.ConcreteTypeRequired;
				case "BID_INCOMPATIBLE_WITH_ADGROUP": return AdGroupCriterionErrorReason.BidIncompatibleWithAdgroup;
				case "CANNOT_TARGET_AND_EXCLUDE": return AdGroupCriterionErrorReason.CannotTargetAndExclude;
				case "ILLEGAL_URL": return AdGroupCriterionErrorReason.IllegalUrl;
				case "INVALID_KEYWORD_TEXT": return AdGroupCriterionErrorReason.InvalidKeywordText;
				case "INVALID_DESTINATION_URL": return AdGroupCriterionErrorReason.InvalidDestinationUrl;
				case "MISSING_DESTINATION_URL_TAG": return AdGroupCriterionErrorReason.MissingDestinationUrlTag;
				case "KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM": return AdGroupCriterionErrorReason.KeywordLevelBidNotSupportedForManualcpm;
				case "INVALID_USER_STATUS": return AdGroupCriterionErrorReason.InvalidUserStatus;
				case "CANNOT_ADD_CRITERIA_TYPE": return AdGroupCriterionErrorReason.CannotAddCriteriaType;
				case "CANNOT_EXCLUDE_CRITERIA_TYPE": return AdGroupCriterionErrorReason.CannotExcludeCriteriaType;
				case "INVALID_PRODUCT_PARTITION_HIERARCHY": return AdGroupCriterionErrorReason.InvalidProductPartitionHierarchy;
				case "PRODUCT_PARTITION_UNIT_CANNOT_HAVE_CHILDREN": return AdGroupCriterionErrorReason.ProductPartitionUnitCannotHaveChildren;
				case "PRODUCT_PARTITION_SUBDIVISION_REQUIRES_OTHERS_CASE": return AdGroupCriterionErrorReason.ProductPartitionSubdivisionRequiresOthersCase;
				case "PRODUCT_PARTITION_REQUIRES_SAME_DIMENSION_TYPE_AS_SIBLINGS": return AdGroupCriterionErrorReason.ProductPartitionRequiresSameDimensionTypeAsSiblings;
				case "PRODUCT_PARTITION_ALREADY_EXISTS": return AdGroupCriterionErrorReason.ProductPartitionAlreadyExists;
				case "PRODUCT_PARTITION_DOES_NOT_EXIST": return AdGroupCriterionErrorReason.ProductPartitionDoesNotExist;
				case "PRODUCT_PARTITION_CANNOT_BE_REMOVED": return AdGroupCriterionErrorReason.ProductPartitionCannotBeRemoved;
				case "INVALID_PRODUCT_PARTITION_TYPE": return AdGroupCriterionErrorReason.InvalidProductPartitionType;
				case "PRODUCT_PARTITION_ADD_MAY_ONLY_USE_TEMP_ID": return AdGroupCriterionErrorReason.ProductPartitionAddMayOnlyUseTempId;
				case "CAMPAIGN_TYPE_NOT_COMPATIBLE_WITH_PARTIAL_FAILURE": return AdGroupCriterionErrorReason.CampaignTypeNotCompatibleWithPartialFailure;
				case "OPERATIONS_FOR_TOO_MANY_SHOPPING_ADGROUPS": return AdGroupCriterionErrorReason.OperationsForTooManyShoppingAdgroups;
				case "CANNOT_MODIFY_URL_FIELDS_WITH_DUPLICATE_ELEMENTS": return AdGroupCriterionErrorReason.CannotModifyUrlFieldsWithDuplicateElements;
				case "CANNOT_SET_WITHOUT_FINAL_URLS": return AdGroupCriterionErrorReason.CannotSetWithoutFinalUrls;
				case "CANNOT_CLEAR_FINAL_URLS_IF_FINAL_MOBILE_URLS_EXIST": return AdGroupCriterionErrorReason.CannotClearFinalUrlsIfFinalMobileUrlsExist;
				case "CANNOT_CLEAR_FINAL_URLS_IF_FINAL_APP_URLS_EXIST": return AdGroupCriterionErrorReason.CannotClearFinalUrlsIfFinalAppUrlsExist;
				case "CANNOT_CLEAR_FINAL_URLS_IF_TRACKING_URL_TEMPLATE_EXISTS": return AdGroupCriterionErrorReason.CannotClearFinalUrlsIfTrackingUrlTemplateExists;
				case "CANNOT_CLEAR_FINAL_URLS_IF_URL_CUSTOM_PARAMETERS_EXIST": return AdGroupCriterionErrorReason.CannotClearFinalUrlsIfUrlCustomParametersExist;
				case "CANNOT_SET_BOTH_DESTINATION_URL_AND_FINAL_URLS": return AdGroupCriterionErrorReason.CannotSetBothDestinationUrlAndFinalUrls;
				case "CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE": return AdGroupCriterionErrorReason.CannotSetBothDestinationUrlAndTrackingUrlTemplate;
				case "FINAL_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE": return AdGroupCriterionErrorReason.FinalUrlsNotSupportedForCriterionType;
				case "FINAL_MOBILE_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE": return AdGroupCriterionErrorReason.FinalMobileUrlsNotSupportedForCriterionType;
				case "UNKNOWN": return AdGroupCriterionErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupCriterionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupCriterionLimitExceededCriteriaLimitTypeExtensions
	{
		public static string ToXmlValue(this AdGroupCriterionLimitExceededCriteriaLimitType enumValue)
		{
			switch (enumValue)
			{
				case AdGroupCriterionLimitExceededCriteriaLimitType.AdgroupKeyword: return "ADGROUP_KEYWORD";
				case AdGroupCriterionLimitExceededCriteriaLimitType.AdgroupWebsite: return "ADGROUP_WEBSITE";
				case AdGroupCriterionLimitExceededCriteriaLimitType.AdgroupCriterion: return "ADGROUP_CRITERION";
				case AdGroupCriterionLimitExceededCriteriaLimitType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdGroupCriterionLimitExceededCriteriaLimitType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ADGROUP_KEYWORD": return AdGroupCriterionLimitExceededCriteriaLimitType.AdgroupKeyword;
				case "ADGROUP_WEBSITE": return AdGroupCriterionLimitExceededCriteriaLimitType.AdgroupWebsite;
				case "ADGROUP_CRITERION": return AdGroupCriterionLimitExceededCriteriaLimitType.AdgroupCriterion;
				case "UNKNOWN": return AdGroupCriterionLimitExceededCriteriaLimitType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupCriterionLimitExceededCriteriaLimitType.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupFeedErrorReasonExtensions
	{
		public static string ToXmlValue(this AdGroupFeedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdGroupFeedErrorReason.FeedAlreadyExistsForPlaceholderType: return "FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE";
				case AdGroupFeedErrorReason.InvalidId: return "INVALID_ID";
				case AdGroupFeedErrorReason.CannotAddForDeletedFeed: return "CANNOT_ADD_FOR_DELETED_FEED";
				case AdGroupFeedErrorReason.CannotAddAlreadyExistingAdgroupFeed: return "CANNOT_ADD_ALREADY_EXISTING_ADGROUP_FEED";
				case AdGroupFeedErrorReason.CannotOperateOnRemovedAdgroupFeed: return "CANNOT_OPERATE_ON_REMOVED_ADGROUP_FEED";
				case AdGroupFeedErrorReason.InvalidPlaceholderTypes: return "INVALID_PLACEHOLDER_TYPES";
				case AdGroupFeedErrorReason.MissingFeedmappingForPlaceholderType: return "MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE";
				case AdGroupFeedErrorReason.NoExistingLocationCustomerFeed: return "NO_EXISTING_LOCATION_CUSTOMER_FEED";
				case AdGroupFeedErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdGroupFeedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE": return AdGroupFeedErrorReason.FeedAlreadyExistsForPlaceholderType;
				case "INVALID_ID": return AdGroupFeedErrorReason.InvalidId;
				case "CANNOT_ADD_FOR_DELETED_FEED": return AdGroupFeedErrorReason.CannotAddForDeletedFeed;
				case "CANNOT_ADD_ALREADY_EXISTING_ADGROUP_FEED": return AdGroupFeedErrorReason.CannotAddAlreadyExistingAdgroupFeed;
				case "CANNOT_OPERATE_ON_REMOVED_ADGROUP_FEED": return AdGroupFeedErrorReason.CannotOperateOnRemovedAdgroupFeed;
				case "INVALID_PLACEHOLDER_TYPES": return AdGroupFeedErrorReason.InvalidPlaceholderTypes;
				case "MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE": return AdGroupFeedErrorReason.MissingFeedmappingForPlaceholderType;
				case "NO_EXISTING_LOCATION_CUSTOMER_FEED": return AdGroupFeedErrorReason.NoExistingLocationCustomerFeed;
				case "UNKNOWN": return AdGroupFeedErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupFeedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupFeedStatusExtensions
	{
		public static string ToXmlValue(this AdGroupFeedStatus enumValue)
		{
			switch (enumValue)
			{
				case AdGroupFeedStatus.Enabled: return "ENABLED";
				case AdGroupFeedStatus.Removed: return "REMOVED";
				case AdGroupFeedStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdGroupFeedStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return AdGroupFeedStatus.Enabled;
				case "REMOVED": return AdGroupFeedStatus.Removed;
				case "UNKNOWN": return AdGroupFeedStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupFeedStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupServiceErrorReasonExtensions
	{
		public static string ToXmlValue(this AdGroupServiceErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdGroupServiceErrorReason.DuplicateAdgroupName: return "DUPLICATE_ADGROUP_NAME";
				case AdGroupServiceErrorReason.InvalidAdgroupName: return "INVALID_ADGROUP_NAME";
				case AdGroupServiceErrorReason.UseSetOperatorAndMarkStatusToRemoved: return "USE_SET_OPERATOR_AND_MARK_STATUS_TO_REMOVED";
				case AdGroupServiceErrorReason.AdvertiserNotOnContentNetwork: return "ADVERTISER_NOT_ON_CONTENT_NETWORK";
				case AdGroupServiceErrorReason.BidTooBig: return "BID_TOO_BIG";
				case AdGroupServiceErrorReason.BidTypeAndBiddingStrategyMismatch: return "BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH";
				case AdGroupServiceErrorReason.MissingAdgroupName: return "MISSING_ADGROUP_NAME";
				case AdGroupServiceErrorReason.AdgroupLabelDoesNotExist: return "ADGROUP_LABEL_DOES_NOT_EXIST";
				case AdGroupServiceErrorReason.AdgroupLabelAlreadyExists: return "ADGROUP_LABEL_ALREADY_EXISTS";
				case AdGroupServiceErrorReason.InvalidContentBidCriterionTypeGroup: return "INVALID_CONTENT_BID_CRITERION_TYPE_GROUP";
				default: return null;
			}
		}
		public static AdGroupServiceErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DUPLICATE_ADGROUP_NAME": return AdGroupServiceErrorReason.DuplicateAdgroupName;
				case "INVALID_ADGROUP_NAME": return AdGroupServiceErrorReason.InvalidAdgroupName;
				case "USE_SET_OPERATOR_AND_MARK_STATUS_TO_REMOVED": return AdGroupServiceErrorReason.UseSetOperatorAndMarkStatusToRemoved;
				case "ADVERTISER_NOT_ON_CONTENT_NETWORK": return AdGroupServiceErrorReason.AdvertiserNotOnContentNetwork;
				case "BID_TOO_BIG": return AdGroupServiceErrorReason.BidTooBig;
				case "BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH": return AdGroupServiceErrorReason.BidTypeAndBiddingStrategyMismatch;
				case "MISSING_ADGROUP_NAME": return AdGroupServiceErrorReason.MissingAdgroupName;
				case "ADGROUP_LABEL_DOES_NOT_EXIST": return AdGroupServiceErrorReason.AdgroupLabelDoesNotExist;
				case "ADGROUP_LABEL_ALREADY_EXISTS": return AdGroupServiceErrorReason.AdgroupLabelAlreadyExists;
				case "INVALID_CONTENT_BID_CRITERION_TYPE_GROUP": return AdGroupServiceErrorReason.InvalidContentBidCriterionTypeGroup;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupServiceErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdGroupStatusExtensions
	{
		public static string ToXmlValue(this AdGroupStatus enumValue)
		{
			switch (enumValue)
			{
				case AdGroupStatus.Unknown: return "UNKNOWN";
				case AdGroupStatus.Enabled: return "ENABLED";
				case AdGroupStatus.Paused: return "PAUSED";
				case AdGroupStatus.Removed: return "REMOVED";
				default: return null;
			}
		}
		public static AdGroupStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return AdGroupStatus.Unknown;
				case "ENABLED": return AdGroupStatus.Enabled;
				case "PAUSED": return AdGroupStatus.Paused;
				case "REMOVED": return AdGroupStatus.Removed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdGroupStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AdParamErrorReasonExtensions
	{
		public static string ToXmlValue(this AdParamErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdParamErrorReason.AdParamCannotBeSpecifiedMultipleTimes: return "AD_PARAM_CANNOT_BE_SPECIFIED_MULTIPLE_TIMES";
				case AdParamErrorReason.AdParamDoesNotExist: return "AD_PARAM_DOES_NOT_EXIST";
				case AdParamErrorReason.CriterionSpecifiedMustBeKeyword: return "CRITERION_SPECIFIED_MUST_BE_KEYWORD";
				case AdParamErrorReason.InvalidAdgroupCriterionSpecified: return "INVALID_ADGROUP_CRITERION_SPECIFIED";
				case AdParamErrorReason.InvalidInsertionTextFormat: return "INVALID_INSERTION_TEXT_FORMAT";
				case AdParamErrorReason.MustSpecifyAdgroupId: return "MUST_SPECIFY_ADGROUP_ID";
				case AdParamErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdParamErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AD_PARAM_CANNOT_BE_SPECIFIED_MULTIPLE_TIMES": return AdParamErrorReason.AdParamCannotBeSpecifiedMultipleTimes;
				case "AD_PARAM_DOES_NOT_EXIST": return AdParamErrorReason.AdParamDoesNotExist;
				case "CRITERION_SPECIFIED_MUST_BE_KEYWORD": return AdParamErrorReason.CriterionSpecifiedMustBeKeyword;
				case "INVALID_ADGROUP_CRITERION_SPECIFIED": return AdParamErrorReason.InvalidAdgroupCriterionSpecified;
				case "INVALID_INSERTION_TEXT_FORMAT": return AdParamErrorReason.InvalidInsertionTextFormat;
				case "MUST_SPECIFY_ADGROUP_ID": return AdParamErrorReason.MustSpecifyAdgroupId;
				case "UNKNOWN": return AdParamErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdParamErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AdServingOptimizationStatusExtensions
	{
		public static string ToXmlValue(this AdServingOptimizationStatus enumValue)
		{
			switch (enumValue)
			{
				case AdServingOptimizationStatus.Optimize: return "OPTIMIZE";
				case AdServingOptimizationStatus.ConversionOptimize: return "CONVERSION_OPTIMIZE";
				case AdServingOptimizationStatus.Rotate: return "ROTATE";
				case AdServingOptimizationStatus.RotateIndefinitely: return "ROTATE_INDEFINITELY";
				case AdServingOptimizationStatus.Unavailable: return "UNAVAILABLE";
				case AdServingOptimizationStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdServingOptimizationStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "OPTIMIZE": return AdServingOptimizationStatus.Optimize;
				case "CONVERSION_OPTIMIZE": return AdServingOptimizationStatus.ConversionOptimize;
				case "ROTATE": return AdServingOptimizationStatus.Rotate;
				case "ROTATE_INDEFINITELY": return AdServingOptimizationStatus.RotateIndefinitely;
				case "UNAVAILABLE": return AdServingOptimizationStatus.Unavailable;
				case "UNKNOWN": return AdServingOptimizationStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdServingOptimizationStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AdTypeExtensions
	{
		public static string ToXmlValue(this AdType enumValue)
		{
			switch (enumValue)
			{
				case AdType.DeprecatedAd: return "DEPRECATED_AD";
				case AdType.ImageAd: return "IMAGE_AD";
				case AdType.ProductAd: return "PRODUCT_AD";
				case AdType.TemplateAd: return "TEMPLATE_AD";
				case AdType.TextAd: return "TEXT_AD";
				case AdType.ThirdPartyRedirectAd: return "THIRD_PARTY_REDIRECT_AD";
				case AdType.DynamicSearchAd: return "DYNAMIC_SEARCH_AD";
				case AdType.CallOnlyAd: return "CALL_ONLY_AD";
				case AdType.ExpandedTextAd: return "EXPANDED_TEXT_AD";
				case AdType.ResponsiveDisplayAd: return "RESPONSIVE_DISPLAY_AD";
				case AdType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AdType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DEPRECATED_AD": return AdType.DeprecatedAd;
				case "IMAGE_AD": return AdType.ImageAd;
				case "PRODUCT_AD": return AdType.ProductAd;
				case "TEMPLATE_AD": return AdType.TemplateAd;
				case "TEXT_AD": return AdType.TextAd;
				case "THIRD_PARTY_REDIRECT_AD": return AdType.ThirdPartyRedirectAd;
				case "DYNAMIC_SEARCH_AD": return AdType.DynamicSearchAd;
				case "CALL_ONLY_AD": return AdType.CallOnlyAd;
				case "EXPANDED_TEXT_AD": return AdType.ExpandedTextAd;
				case "RESPONSIVE_DISPLAY_AD": return AdType.ResponsiveDisplayAd;
				case "UNKNOWN": return AdType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdType.", nameof(xmlValue));
			}
		}
	}
	public static class AdvertisingChannelSubTypeExtensions
	{
		public static string ToXmlValue(this AdvertisingChannelSubType enumValue)
		{
			switch (enumValue)
			{
				case AdvertisingChannelSubType.Unknown: return "UNKNOWN";
				case AdvertisingChannelSubType.SearchMobileApp: return "SEARCH_MOBILE_APP";
				case AdvertisingChannelSubType.DisplayMobileApp: return "DISPLAY_MOBILE_APP";
				case AdvertisingChannelSubType.SearchExpress: return "SEARCH_EXPRESS";
				case AdvertisingChannelSubType.DisplayExpress: return "DISPLAY_EXPRESS";
				case AdvertisingChannelSubType.UniversalAppCampaign: return "UNIVERSAL_APP_CAMPAIGN";
				default: return null;
			}
		}
		public static AdvertisingChannelSubType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return AdvertisingChannelSubType.Unknown;
				case "SEARCH_MOBILE_APP": return AdvertisingChannelSubType.SearchMobileApp;
				case "DISPLAY_MOBILE_APP": return AdvertisingChannelSubType.DisplayMobileApp;
				case "SEARCH_EXPRESS": return AdvertisingChannelSubType.SearchExpress;
				case "DISPLAY_EXPRESS": return AdvertisingChannelSubType.DisplayExpress;
				case "UNIVERSAL_APP_CAMPAIGN": return AdvertisingChannelSubType.UniversalAppCampaign;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdvertisingChannelSubType.", nameof(xmlValue));
			}
		}
	}
	public static class AdvertisingChannelTypeExtensions
	{
		public static string ToXmlValue(this AdvertisingChannelType enumValue)
		{
			switch (enumValue)
			{
				case AdvertisingChannelType.Unknown: return "UNKNOWN";
				case AdvertisingChannelType.Search: return "SEARCH";
				case AdvertisingChannelType.Display: return "DISPLAY";
				case AdvertisingChannelType.Shopping: return "SHOPPING";
				case AdvertisingChannelType.MultiChannel: return "MULTI_CHANNEL";
				default: return null;
			}
		}
		public static AdvertisingChannelType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return AdvertisingChannelType.Unknown;
				case "SEARCH": return AdvertisingChannelType.Search;
				case "DISPLAY": return AdvertisingChannelType.Display;
				case "SHOPPING": return AdvertisingChannelType.Shopping;
				case "MULTI_CHANNEL": return AdvertisingChannelType.MultiChannel;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdvertisingChannelType.", nameof(xmlValue));
			}
		}
	}
	public static class AdWordsConversionTrackerTextFormatExtensions
	{
		public static string ToXmlValue(this AdWordsConversionTrackerTextFormat enumValue)
		{
			switch (enumValue)
			{
				case AdWordsConversionTrackerTextFormat.OneLine: return "ONE_LINE";
				case AdWordsConversionTrackerTextFormat.TwoLine: return "TWO_LINE";
				case AdWordsConversionTrackerTextFormat.Hidden: return "HIDDEN";
				default: return null;
			}
		}
		public static AdWordsConversionTrackerTextFormat Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ONE_LINE": return AdWordsConversionTrackerTextFormat.OneLine;
				case "TWO_LINE": return AdWordsConversionTrackerTextFormat.TwoLine;
				case "HIDDEN": return AdWordsConversionTrackerTextFormat.Hidden;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdWordsConversionTrackerTextFormat.", nameof(xmlValue));
			}
		}
	}
	public static class AdWordsConversionTrackerTrackingCodeTypeExtensions
	{
		public static string ToXmlValue(this AdWordsConversionTrackerTrackingCodeType enumValue)
		{
			switch (enumValue)
			{
				case AdWordsConversionTrackerTrackingCodeType.Webpage: return "WEBPAGE";
				case AdWordsConversionTrackerTrackingCodeType.WebpageOnclick: return "WEBPAGE_ONCLICK";
				case AdWordsConversionTrackerTrackingCodeType.ClickToCall: return "CLICK_TO_CALL";
				default: return null;
			}
		}
		public static AdWordsConversionTrackerTrackingCodeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "WEBPAGE": return AdWordsConversionTrackerTrackingCodeType.Webpage;
				case "WEBPAGE_ONCLICK": return AdWordsConversionTrackerTrackingCodeType.WebpageOnclick;
				case "CLICK_TO_CALL": return AdWordsConversionTrackerTrackingCodeType.ClickToCall;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdWordsConversionTrackerTrackingCodeType.", nameof(xmlValue));
			}
		}
	}
	public static class AdxErrorReasonExtensions
	{
		public static string ToXmlValue(this AdxErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AdxErrorReason.UnsupportedFeature: return "UNSUPPORTED_FEATURE";
				default: return null;
			}
		}
		public static AdxErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNSUPPORTED_FEATURE": return AdxErrorReason.UnsupportedFeature;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AdxErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AgeRangeAgeRangeTypeExtensions
	{
		public static string ToXmlValue(this AgeRangeAgeRangeType enumValue)
		{
			switch (enumValue)
			{
				case AgeRangeAgeRangeType.AgeRange1824: return "AGE_RANGE_18_24";
				case AgeRangeAgeRangeType.AgeRange2534: return "AGE_RANGE_25_34";
				case AgeRangeAgeRangeType.AgeRange3544: return "AGE_RANGE_35_44";
				case AgeRangeAgeRangeType.AgeRange4554: return "AGE_RANGE_45_54";
				case AgeRangeAgeRangeType.AgeRange5564: return "AGE_RANGE_55_64";
				case AgeRangeAgeRangeType.AgeRange65Up: return "AGE_RANGE_65_UP";
				case AgeRangeAgeRangeType.AgeRangeUndetermined: return "AGE_RANGE_UNDETERMINED";
				case AgeRangeAgeRangeType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AgeRangeAgeRangeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AGE_RANGE_18_24": return AgeRangeAgeRangeType.AgeRange1824;
				case "AGE_RANGE_25_34": return AgeRangeAgeRangeType.AgeRange2534;
				case "AGE_RANGE_35_44": return AgeRangeAgeRangeType.AgeRange3544;
				case "AGE_RANGE_45_54": return AgeRangeAgeRangeType.AgeRange4554;
				case "AGE_RANGE_55_64": return AgeRangeAgeRangeType.AgeRange5564;
				case "AGE_RANGE_65_UP": return AgeRangeAgeRangeType.AgeRange65Up;
				case "AGE_RANGE_UNDETERMINED": return AgeRangeAgeRangeType.AgeRangeUndetermined;
				case "UNKNOWN": return AgeRangeAgeRangeType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AgeRangeAgeRangeType.", nameof(xmlValue));
			}
		}
	}
	public static class AppConversionAppConversionTypeExtensions
	{
		public static string ToXmlValue(this AppConversionAppConversionType enumValue)
		{
			switch (enumValue)
			{
				case AppConversionAppConversionType.None: return "NONE";
				case AppConversionAppConversionType.Download: return "DOWNLOAD";
				case AppConversionAppConversionType.InAppPurchase: return "IN_APP_PURCHASE";
				case AppConversionAppConversionType.FirstOpen: return "FIRST_OPEN";
				default: return null;
			}
		}
		public static AppConversionAppConversionType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NONE": return AppConversionAppConversionType.None;
				case "DOWNLOAD": return AppConversionAppConversionType.Download;
				case "IN_APP_PURCHASE": return AppConversionAppConversionType.InAppPurchase;
				case "FIRST_OPEN": return AppConversionAppConversionType.FirstOpen;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AppConversionAppConversionType.", nameof(xmlValue));
			}
		}
	}
	public static class AppConversionAppPlatformExtensions
	{
		public static string ToXmlValue(this AppConversionAppPlatform enumValue)
		{
			switch (enumValue)
			{
				case AppConversionAppPlatform.None: return "NONE";
				case AppConversionAppPlatform.Itunes: return "ITUNES";
				case AppConversionAppPlatform.AndroidMarket: return "ANDROID_MARKET";
				case AppConversionAppPlatform.MobileAppChannel: return "MOBILE_APP_CHANNEL";
				default: return null;
			}
		}
		public static AppConversionAppPlatform Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NONE": return AppConversionAppPlatform.None;
				case "ITUNES": return AppConversionAppPlatform.Itunes;
				case "ANDROID_MARKET": return AppConversionAppPlatform.AndroidMarket;
				case "MOBILE_APP_CHANNEL": return AppConversionAppPlatform.MobileAppChannel;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AppConversionAppPlatform.", nameof(xmlValue));
			}
		}
	}
	public static class AppFeedItemAppStoreExtensions
	{
		public static string ToXmlValue(this AppFeedItemAppStore enumValue)
		{
			switch (enumValue)
			{
				case AppFeedItemAppStore.AppleItunes: return "APPLE_ITUNES";
				case AppFeedItemAppStore.GooglePlay: return "GOOGLE_PLAY";
				case AppFeedItemAppStore.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AppFeedItemAppStore Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "APPLE_ITUNES": return AppFeedItemAppStore.AppleItunes;
				case "GOOGLE_PLAY": return AppFeedItemAppStore.GooglePlay;
				case "UNKNOWN": return AppFeedItemAppStore.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AppFeedItemAppStore.", nameof(xmlValue));
			}
		}
	}
	public static class AppPaymentModelAppPaymentModelTypeExtensions
	{
		public static string ToXmlValue(this AppPaymentModelAppPaymentModelType enumValue)
		{
			switch (enumValue)
			{
				case AppPaymentModelAppPaymentModelType.AppPaymentModelPaid: return "APP_PAYMENT_MODEL_PAID";
				case AppPaymentModelAppPaymentModelType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AppPaymentModelAppPaymentModelType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "APP_PAYMENT_MODEL_PAID": return AppPaymentModelAppPaymentModelType.AppPaymentModelPaid;
				case "UNKNOWN": return AppPaymentModelAppPaymentModelType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AppPaymentModelAppPaymentModelType.", nameof(xmlValue));
			}
		}
	}
	public static class AppPostbackUrlErrorReasonExtensions
	{
		public static string ToXmlValue(this AppPostbackUrlErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AppPostbackUrlErrorReason.InvalidUrlFormat: return "INVALID_URL_FORMAT";
				case AppPostbackUrlErrorReason.InvalidDomain: return "INVALID_DOMAIN";
				case AppPostbackUrlErrorReason.RequiredMacroNotFound: return "REQUIRED_MACRO_NOT_FOUND";
				default: return null;
			}
		}
		public static AppPostbackUrlErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_URL_FORMAT": return AppPostbackUrlErrorReason.InvalidUrlFormat;
				case "INVALID_DOMAIN": return AppPostbackUrlErrorReason.InvalidDomain;
				case "REQUIRED_MACRO_NOT_FOUND": return AppPostbackUrlErrorReason.RequiredMacroNotFound;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AppPostbackUrlErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ApprovalStatusExtensions
	{
		public static string ToXmlValue(this ApprovalStatus enumValue)
		{
			switch (enumValue)
			{
				case ApprovalStatus.Approved: return "APPROVED";
				case ApprovalStatus.PendingReview: return "PENDING_REVIEW";
				case ApprovalStatus.UnderReview: return "UNDER_REVIEW";
				case ApprovalStatus.Disapproved: return "DISAPPROVED";
				default: return null;
			}
		}
		public static ApprovalStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "APPROVED": return ApprovalStatus.Approved;
				case "PENDING_REVIEW": return ApprovalStatus.PendingReview;
				case "UNDER_REVIEW": return ApprovalStatus.UnderReview;
				case "DISAPPROVED": return ApprovalStatus.Disapproved;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ApprovalStatus.", nameof(xmlValue));
			}
		}
	}
	public static class AppUrlOsTypeExtensions
	{
		public static string ToXmlValue(this AppUrlOsType enumValue)
		{
			switch (enumValue)
			{
				case AppUrlOsType.OsTypeIos: return "OS_TYPE_IOS";
				case AppUrlOsType.OsTypeAndroid: return "OS_TYPE_ANDROID";
				case AppUrlOsType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static AppUrlOsType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "OS_TYPE_IOS": return AppUrlOsType.OsTypeIos;
				case "OS_TYPE_ANDROID": return AppUrlOsType.OsTypeAndroid;
				case "UNKNOWN": return AppUrlOsType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AppUrlOsType.", nameof(xmlValue));
			}
		}
	}
	public static class AttributeTypeExtensions
	{
		public static string ToXmlValue(this AttributeType enumValue)
		{
			switch (enumValue)
			{
				case AttributeType.Unknown: return "UNKNOWN";
				case AttributeType.CategoryProductsAndServices: return "CATEGORY_PRODUCTS_AND_SERVICES";
				case AttributeType.Competition: return "COMPETITION";
				case AttributeType.ExtractedFromWebpage: return "EXTRACTED_FROM_WEBPAGE";
				case AttributeType.IdeaType: return "IDEA_TYPE";
				case AttributeType.KeywordText: return "KEYWORD_TEXT";
				case AttributeType.SearchVolume: return "SEARCH_VOLUME";
				case AttributeType.AverageCpc: return "AVERAGE_CPC";
				case AttributeType.TargetedMonthlySearches: return "TARGETED_MONTHLY_SEARCHES";
				default: return null;
			}
		}
		public static AttributeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return AttributeType.Unknown;
				case "CATEGORY_PRODUCTS_AND_SERVICES": return AttributeType.CategoryProductsAndServices;
				case "COMPETITION": return AttributeType.Competition;
				case "EXTRACTED_FROM_WEBPAGE": return AttributeType.ExtractedFromWebpage;
				case "IDEA_TYPE": return AttributeType.IdeaType;
				case "KEYWORD_TEXT": return AttributeType.KeywordText;
				case "SEARCH_VOLUME": return AttributeType.SearchVolume;
				case "AVERAGE_CPC": return AttributeType.AverageCpc;
				case "TARGETED_MONTHLY_SEARCHES": return AttributeType.TargetedMonthlySearches;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AttributeType.", nameof(xmlValue));
			}
		}
	}
	public static class AttributionModelTypeExtensions
	{
		public static string ToXmlValue(this AttributionModelType enumValue)
		{
			switch (enumValue)
			{
				case AttributionModelType.Unknown: return "UNKNOWN";
				case AttributionModelType.LastClick: return "LAST_CLICK";
				case AttributionModelType.FirstClick: return "FIRST_CLICK";
				case AttributionModelType.Linear: return "LINEAR";
				case AttributionModelType.TimeDecay: return "TIME_DECAY";
				case AttributionModelType.UShaped: return "U_SHAPED";
				case AttributionModelType.DataDriven: return "DATA_DRIVEN";
				default: return null;
			}
		}
		public static AttributionModelType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return AttributionModelType.Unknown;
				case "LAST_CLICK": return AttributionModelType.LastClick;
				case "FIRST_CLICK": return AttributionModelType.FirstClick;
				case "LINEAR": return AttributionModelType.Linear;
				case "TIME_DECAY": return AttributionModelType.TimeDecay;
				case "U_SHAPED": return AttributionModelType.UShaped;
				case "DATA_DRIVEN": return AttributionModelType.DataDriven;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AttributionModelType.", nameof(xmlValue));
			}
		}
	}
	public static class AudioErrorReasonExtensions
	{
		public static string ToXmlValue(this AudioErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AudioErrorReason.InvalidAudio: return "INVALID_AUDIO";
				case AudioErrorReason.ProblemReadingAudioFile: return "PROBLEM_READING_AUDIO_FILE";
				case AudioErrorReason.ErrorStoringAudio: return "ERROR_STORING_AUDIO";
				case AudioErrorReason.FileTooLarge: return "FILE_TOO_LARGE";
				case AudioErrorReason.UnsupportedAudio: return "UNSUPPORTED_AUDIO";
				case AudioErrorReason.ErrorGeneratingStreamingUrl: return "ERROR_GENERATING_STREAMING_URL";
				default: return null;
			}
		}
		public static AudioErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_AUDIO": return AudioErrorReason.InvalidAudio;
				case "PROBLEM_READING_AUDIO_FILE": return AudioErrorReason.ProblemReadingAudioFile;
				case "ERROR_STORING_AUDIO": return AudioErrorReason.ErrorStoringAudio;
				case "FILE_TOO_LARGE": return AudioErrorReason.FileTooLarge;
				case "UNSUPPORTED_AUDIO": return AudioErrorReason.UnsupportedAudio;
				case "ERROR_GENERATING_STREAMING_URL": return AudioErrorReason.ErrorGeneratingStreamingUrl;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AudioErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AuthenticationErrorReasonExtensions
	{
		public static string ToXmlValue(this AuthenticationErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AuthenticationErrorReason.AuthenticationFailed: return "AUTHENTICATION_FAILED";
				case AuthenticationErrorReason.ClientCustomerIdIsRequired: return "CLIENT_CUSTOMER_ID_IS_REQUIRED";
				case AuthenticationErrorReason.ClientEmailRequired: return "CLIENT_EMAIL_REQUIRED";
				case AuthenticationErrorReason.ClientCustomerIdInvalid: return "CLIENT_CUSTOMER_ID_INVALID";
				case AuthenticationErrorReason.ClientEmailInvalid: return "CLIENT_EMAIL_INVALID";
				case AuthenticationErrorReason.ClientEmailFailedToAuthenticate: return "CLIENT_EMAIL_FAILED_TO_AUTHENTICATE";
				case AuthenticationErrorReason.CustomerNotFound: return "CUSTOMER_NOT_FOUND";
				case AuthenticationErrorReason.GoogleAccountDeleted: return "GOOGLE_ACCOUNT_DELETED";
				case AuthenticationErrorReason.GoogleAccountCookieInvalid: return "GOOGLE_ACCOUNT_COOKIE_INVALID";
				case AuthenticationErrorReason.FailedToAuthenticateGoogleAccount: return "FAILED_TO_AUTHENTICATE_GOOGLE_ACCOUNT";
				case AuthenticationErrorReason.GoogleAccountUserAndAdsUserMismatch: return "GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH";
				case AuthenticationErrorReason.LoginCookieRequired: return "LOGIN_COOKIE_REQUIRED";
				case AuthenticationErrorReason.NotAdsUser: return "NOT_ADS_USER";
				case AuthenticationErrorReason.OauthTokenInvalid: return "OAUTH_TOKEN_INVALID";
				case AuthenticationErrorReason.OauthTokenExpired: return "OAUTH_TOKEN_EXPIRED";
				case AuthenticationErrorReason.OauthTokenDisabled: return "OAUTH_TOKEN_DISABLED";
				case AuthenticationErrorReason.OauthTokenRevoked: return "OAUTH_TOKEN_REVOKED";
				case AuthenticationErrorReason.OauthTokenHeaderInvalid: return "OAUTH_TOKEN_HEADER_INVALID";
				case AuthenticationErrorReason.LoginCookieInvalid: return "LOGIN_COOKIE_INVALID";
				case AuthenticationErrorReason.FailedToRetrieveLoginCookie: return "FAILED_TO_RETRIEVE_LOGIN_COOKIE";
				case AuthenticationErrorReason.UserIdInvalid: return "USER_ID_INVALID";
				default: return null;
			}
		}
		public static AuthenticationErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AUTHENTICATION_FAILED": return AuthenticationErrorReason.AuthenticationFailed;
				case "CLIENT_CUSTOMER_ID_IS_REQUIRED": return AuthenticationErrorReason.ClientCustomerIdIsRequired;
				case "CLIENT_EMAIL_REQUIRED": return AuthenticationErrorReason.ClientEmailRequired;
				case "CLIENT_CUSTOMER_ID_INVALID": return AuthenticationErrorReason.ClientCustomerIdInvalid;
				case "CLIENT_EMAIL_INVALID": return AuthenticationErrorReason.ClientEmailInvalid;
				case "CLIENT_EMAIL_FAILED_TO_AUTHENTICATE": return AuthenticationErrorReason.ClientEmailFailedToAuthenticate;
				case "CUSTOMER_NOT_FOUND": return AuthenticationErrorReason.CustomerNotFound;
				case "GOOGLE_ACCOUNT_DELETED": return AuthenticationErrorReason.GoogleAccountDeleted;
				case "GOOGLE_ACCOUNT_COOKIE_INVALID": return AuthenticationErrorReason.GoogleAccountCookieInvalid;
				case "FAILED_TO_AUTHENTICATE_GOOGLE_ACCOUNT": return AuthenticationErrorReason.FailedToAuthenticateGoogleAccount;
				case "GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH": return AuthenticationErrorReason.GoogleAccountUserAndAdsUserMismatch;
				case "LOGIN_COOKIE_REQUIRED": return AuthenticationErrorReason.LoginCookieRequired;
				case "NOT_ADS_USER": return AuthenticationErrorReason.NotAdsUser;
				case "OAUTH_TOKEN_INVALID": return AuthenticationErrorReason.OauthTokenInvalid;
				case "OAUTH_TOKEN_EXPIRED": return AuthenticationErrorReason.OauthTokenExpired;
				case "OAUTH_TOKEN_DISABLED": return AuthenticationErrorReason.OauthTokenDisabled;
				case "OAUTH_TOKEN_REVOKED": return AuthenticationErrorReason.OauthTokenRevoked;
				case "OAUTH_TOKEN_HEADER_INVALID": return AuthenticationErrorReason.OauthTokenHeaderInvalid;
				case "LOGIN_COOKIE_INVALID": return AuthenticationErrorReason.LoginCookieInvalid;
				case "FAILED_TO_RETRIEVE_LOGIN_COOKIE": return AuthenticationErrorReason.FailedToRetrieveLoginCookie;
				case "USER_ID_INVALID": return AuthenticationErrorReason.UserIdInvalid;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AuthenticationErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class AuthorizationErrorReasonExtensions
	{
		public static string ToXmlValue(this AuthorizationErrorReason enumValue)
		{
			switch (enumValue)
			{
				case AuthorizationErrorReason.UnableToAuthorize: return "UNABLE_TO_AUTHORIZE";
				case AuthorizationErrorReason.NoAdwordsAccountForCustomer: return "NO_ADWORDS_ACCOUNT_FOR_CUSTOMER";
				case AuthorizationErrorReason.UserPermissionDenied: return "USER_PERMISSION_DENIED";
				case AuthorizationErrorReason.EffectiveUserPermissionDenied: return "EFFECTIVE_USER_PERMISSION_DENIED";
				case AuthorizationErrorReason.UserHasReadonlyPermission: return "USER_HAS_READONLY_PERMISSION";
				case AuthorizationErrorReason.NoCustomerFound: return "NO_CUSTOMER_FOUND";
				case AuthorizationErrorReason.ServiceAccessDenied: return "SERVICE_ACCESS_DENIED";
				default: return null;
			}
		}
		public static AuthorizationErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNABLE_TO_AUTHORIZE": return AuthorizationErrorReason.UnableToAuthorize;
				case "NO_ADWORDS_ACCOUNT_FOR_CUSTOMER": return AuthorizationErrorReason.NoAdwordsAccountForCustomer;
				case "USER_PERMISSION_DENIED": return AuthorizationErrorReason.UserPermissionDenied;
				case "EFFECTIVE_USER_PERMISSION_DENIED": return AuthorizationErrorReason.EffectiveUserPermissionDenied;
				case "USER_HAS_READONLY_PERMISSION": return AuthorizationErrorReason.UserHasReadonlyPermission;
				case "NO_CUSTOMER_FOUND": return AuthorizationErrorReason.NoCustomerFound;
				case "SERVICE_ACCESS_DENIED": return AuthorizationErrorReason.ServiceAccessDenied;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type AuthorizationErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class BatchJobErrorReasonExtensions
	{
		public static string ToXmlValue(this BatchJobErrorReason enumValue)
		{
			switch (enumValue)
			{
				case BatchJobErrorReason.Unknown: return "UNKNOWN";
				case BatchJobErrorReason.DiskQuotaExceeded: return "DISK_QUOTA_EXCEEDED";
				case BatchJobErrorReason.FailedToCreateJob: return "FAILED_TO_CREATE_JOB";
				case BatchJobErrorReason.InvalidStateChange: return "INVALID_STATE_CHANGE";
				default: return null;
			}
		}
		public static BatchJobErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return BatchJobErrorReason.Unknown;
				case "DISK_QUOTA_EXCEEDED": return BatchJobErrorReason.DiskQuotaExceeded;
				case "FAILED_TO_CREATE_JOB": return BatchJobErrorReason.FailedToCreateJob;
				case "INVALID_STATE_CHANGE": return BatchJobErrorReason.InvalidStateChange;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BatchJobErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class BatchJobProcessingErrorReasonExtensions
	{
		public static string ToXmlValue(this BatchJobProcessingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case BatchJobProcessingErrorReason.Unknown: return "UNKNOWN";
				case BatchJobProcessingErrorReason.InputFileCorruption: return "INPUT_FILE_CORRUPTION";
				case BatchJobProcessingErrorReason.InternalError: return "INTERNAL_ERROR";
				case BatchJobProcessingErrorReason.DeadlineExceeded: return "DEADLINE_EXCEEDED";
				case BatchJobProcessingErrorReason.FileFormatError: return "FILE_FORMAT_ERROR";
				default: return null;
			}
		}
		public static BatchJobProcessingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return BatchJobProcessingErrorReason.Unknown;
				case "INPUT_FILE_CORRUPTION": return BatchJobProcessingErrorReason.InputFileCorruption;
				case "INTERNAL_ERROR": return BatchJobProcessingErrorReason.InternalError;
				case "DEADLINE_EXCEEDED": return BatchJobProcessingErrorReason.DeadlineExceeded;
				case "FILE_FORMAT_ERROR": return BatchJobProcessingErrorReason.FileFormatError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BatchJobProcessingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class BatchJobStatusExtensions
	{
		public static string ToXmlValue(this BatchJobStatus enumValue)
		{
			switch (enumValue)
			{
				case BatchJobStatus.Unknown: return "UNKNOWN";
				case BatchJobStatus.AwaitingFile: return "AWAITING_FILE";
				case BatchJobStatus.Active: return "ACTIVE";
				case BatchJobStatus.Canceling: return "CANCELING";
				case BatchJobStatus.Canceled: return "CANCELED";
				case BatchJobStatus.Done: return "DONE";
				default: return null;
			}
		}
		public static BatchJobStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return BatchJobStatus.Unknown;
				case "AWAITING_FILE": return BatchJobStatus.AwaitingFile;
				case "ACTIVE": return BatchJobStatus.Active;
				case "CANCELING": return BatchJobStatus.Canceling;
				case "CANCELED": return BatchJobStatus.Canceled;
				case "DONE": return BatchJobStatus.Done;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BatchJobStatus.", nameof(xmlValue));
			}
		}
	}
	public static class BiddingErrorsReasonExtensions
	{
		public static string ToXmlValue(this BiddingErrorsReason enumValue)
		{
			switch (enumValue)
			{
				case BiddingErrorsReason.BiddingStrategyTransitionNotAllowed: return "BIDDING_STRATEGY_TRANSITION_NOT_ALLOWED";
				case BiddingErrorsReason.BiddingStrategyNotCompatibleWithAdgroupOverrides: return "BIDDING_STRATEGY_NOT_COMPATIBLE_WITH_ADGROUP_OVERRIDES";
				case BiddingErrorsReason.BiddingStrategyNotCompatibleWithAdgroupCriteriaOverrides: return "BIDDING_STRATEGY_NOT_COMPATIBLE_WITH_ADGROUP_CRITERIA_OVERRIDES";
				case BiddingErrorsReason.CampaignBiddingStrategyCannotBeOverridden: return "CAMPAIGN_BIDDING_STRATEGY_CANNOT_BE_OVERRIDDEN";
				case BiddingErrorsReason.AdgroupBiddingStrategyCannotBeOverridden: return "ADGROUP_BIDDING_STRATEGY_CANNOT_BE_OVERRIDDEN";
				case BiddingErrorsReason.CannotAttachBiddingStrategyToCampaign: return "CANNOT_ATTACH_BIDDING_STRATEGY_TO_CAMPAIGN";
				case BiddingErrorsReason.CannotAttachBiddingStrategyToAdgroup: return "CANNOT_ATTACH_BIDDING_STRATEGY_TO_ADGROUP";
				case BiddingErrorsReason.CannotAttachBiddingStrategyToAdgroupCriteria: return "CANNOT_ATTACH_BIDDING_STRATEGY_TO_ADGROUP_CRITERIA";
				case BiddingErrorsReason.InvalidAnonymousBiddingStrategyType: return "INVALID_ANONYMOUS_BIDDING_STRATEGY_TYPE";
				case BiddingErrorsReason.BidsNotAlllowed: return "BIDS_NOT_ALLLOWED";
				case BiddingErrorsReason.DuplicateBids: return "DUPLICATE_BIDS";
				case BiddingErrorsReason.InvalidBiddingScheme: return "INVALID_BIDDING_SCHEME";
				case BiddingErrorsReason.InvalidBiddingStrategyType: return "INVALID_BIDDING_STRATEGY_TYPE";
				case BiddingErrorsReason.MissingBiddingStrategyType: return "MISSING_BIDDING_STRATEGY_TYPE";
				case BiddingErrorsReason.NullBid: return "NULL_BID";
				case BiddingErrorsReason.InvalidBid: return "INVALID_BID";
				case BiddingErrorsReason.BiddingStrategyNotAvailableForAccountType: return "BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE";
				case BiddingErrorsReason.ConversionTrackingNotEnabled: return "CONVERSION_TRACKING_NOT_ENABLED";
				case BiddingErrorsReason.NotEnoughConversions: return "NOT_ENOUGH_CONVERSIONS";
				case BiddingErrorsReason.CannotCreateCampaignWithBiddingStrategy: return "CANNOT_CREATE_CAMPAIGN_WITH_BIDDING_STRATEGY";
				case BiddingErrorsReason.CannotTargetContentNetworkOnlyWithAdGroupLevelPopBiddingStrategy: return "CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_AD_GROUP_LEVEL_POP_BIDDING_STRATEGY";
				case BiddingErrorsReason.CannotTargetContentNetworkOnlyWithCampaignLevelPopBiddingStrategy: return "CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CAMPAIGN_LEVEL_POP_BIDDING_STRATEGY";
				case BiddingErrorsReason.BiddingStrategyNotSupportedWithAdSchedule: return "BIDDING_STRATEGY_NOT_SUPPORTED_WITH_AD_SCHEDULE";
				case BiddingErrorsReason.PayPerConversionNotAvailableForCustomer: return "PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER";
				case BiddingErrorsReason.PayPerConversionNotAllowedWithTargetCpa: return "PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA";
				case BiddingErrorsReason.BiddingStrategyNotAllowedForSearchOnlyCampaigns: return "BIDDING_STRATEGY_NOT_ALLOWED_FOR_SEARCH_ONLY_CAMPAIGNS";
				case BiddingErrorsReason.BiddingStrategyNotSupportedInDraftsOrExperiments: return "BIDDING_STRATEGY_NOT_SUPPORTED_IN_DRAFTS_OR_EXPERIMENTS";
				case BiddingErrorsReason.BiddingStrategyTypeDoesNotSupportProductTypeAdgroupCriterion: return "BIDDING_STRATEGY_TYPE_DOES_NOT_SUPPORT_PRODUCT_TYPE_ADGROUP_CRITERION";
				case BiddingErrorsReason.BidTooSmall: return "BID_TOO_SMALL";
				case BiddingErrorsReason.BidTooBig: return "BID_TOO_BIG";
				case BiddingErrorsReason.BidTooManyFractionalDigits: return "BID_TOO_MANY_FRACTIONAL_DIGITS";
				case BiddingErrorsReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BiddingErrorsReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BIDDING_STRATEGY_TRANSITION_NOT_ALLOWED": return BiddingErrorsReason.BiddingStrategyTransitionNotAllowed;
				case "BIDDING_STRATEGY_NOT_COMPATIBLE_WITH_ADGROUP_OVERRIDES": return BiddingErrorsReason.BiddingStrategyNotCompatibleWithAdgroupOverrides;
				case "BIDDING_STRATEGY_NOT_COMPATIBLE_WITH_ADGROUP_CRITERIA_OVERRIDES": return BiddingErrorsReason.BiddingStrategyNotCompatibleWithAdgroupCriteriaOverrides;
				case "CAMPAIGN_BIDDING_STRATEGY_CANNOT_BE_OVERRIDDEN": return BiddingErrorsReason.CampaignBiddingStrategyCannotBeOverridden;
				case "ADGROUP_BIDDING_STRATEGY_CANNOT_BE_OVERRIDDEN": return BiddingErrorsReason.AdgroupBiddingStrategyCannotBeOverridden;
				case "CANNOT_ATTACH_BIDDING_STRATEGY_TO_CAMPAIGN": return BiddingErrorsReason.CannotAttachBiddingStrategyToCampaign;
				case "CANNOT_ATTACH_BIDDING_STRATEGY_TO_ADGROUP": return BiddingErrorsReason.CannotAttachBiddingStrategyToAdgroup;
				case "CANNOT_ATTACH_BIDDING_STRATEGY_TO_ADGROUP_CRITERIA": return BiddingErrorsReason.CannotAttachBiddingStrategyToAdgroupCriteria;
				case "INVALID_ANONYMOUS_BIDDING_STRATEGY_TYPE": return BiddingErrorsReason.InvalidAnonymousBiddingStrategyType;
				case "BIDS_NOT_ALLLOWED": return BiddingErrorsReason.BidsNotAlllowed;
				case "DUPLICATE_BIDS": return BiddingErrorsReason.DuplicateBids;
				case "INVALID_BIDDING_SCHEME": return BiddingErrorsReason.InvalidBiddingScheme;
				case "INVALID_BIDDING_STRATEGY_TYPE": return BiddingErrorsReason.InvalidBiddingStrategyType;
				case "MISSING_BIDDING_STRATEGY_TYPE": return BiddingErrorsReason.MissingBiddingStrategyType;
				case "NULL_BID": return BiddingErrorsReason.NullBid;
				case "INVALID_BID": return BiddingErrorsReason.InvalidBid;
				case "BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE": return BiddingErrorsReason.BiddingStrategyNotAvailableForAccountType;
				case "CONVERSION_TRACKING_NOT_ENABLED": return BiddingErrorsReason.ConversionTrackingNotEnabled;
				case "NOT_ENOUGH_CONVERSIONS": return BiddingErrorsReason.NotEnoughConversions;
				case "CANNOT_CREATE_CAMPAIGN_WITH_BIDDING_STRATEGY": return BiddingErrorsReason.CannotCreateCampaignWithBiddingStrategy;
				case "CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_AD_GROUP_LEVEL_POP_BIDDING_STRATEGY": return BiddingErrorsReason.CannotTargetContentNetworkOnlyWithAdGroupLevelPopBiddingStrategy;
				case "CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CAMPAIGN_LEVEL_POP_BIDDING_STRATEGY": return BiddingErrorsReason.CannotTargetContentNetworkOnlyWithCampaignLevelPopBiddingStrategy;
				case "BIDDING_STRATEGY_NOT_SUPPORTED_WITH_AD_SCHEDULE": return BiddingErrorsReason.BiddingStrategyNotSupportedWithAdSchedule;
				case "PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER": return BiddingErrorsReason.PayPerConversionNotAvailableForCustomer;
				case "PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA": return BiddingErrorsReason.PayPerConversionNotAllowedWithTargetCpa;
				case "BIDDING_STRATEGY_NOT_ALLOWED_FOR_SEARCH_ONLY_CAMPAIGNS": return BiddingErrorsReason.BiddingStrategyNotAllowedForSearchOnlyCampaigns;
				case "BIDDING_STRATEGY_NOT_SUPPORTED_IN_DRAFTS_OR_EXPERIMENTS": return BiddingErrorsReason.BiddingStrategyNotSupportedInDraftsOrExperiments;
				case "BIDDING_STRATEGY_TYPE_DOES_NOT_SUPPORT_PRODUCT_TYPE_ADGROUP_CRITERION": return BiddingErrorsReason.BiddingStrategyTypeDoesNotSupportProductTypeAdgroupCriterion;
				case "BID_TOO_SMALL": return BiddingErrorsReason.BidTooSmall;
				case "BID_TOO_BIG": return BiddingErrorsReason.BidTooBig;
				case "BID_TOO_MANY_FRACTIONAL_DIGITS": return BiddingErrorsReason.BidTooManyFractionalDigits;
				case "UNKNOWN": return BiddingErrorsReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BiddingErrorsReason.", nameof(xmlValue));
			}
		}
	}
	public static class BiddingStrategyErrorReasonExtensions
	{
		public static string ToXmlValue(this BiddingStrategyErrorReason enumValue)
		{
			switch (enumValue)
			{
				case BiddingStrategyErrorReason.DuplicateName: return "DUPLICATE_NAME";
				case BiddingStrategyErrorReason.CannotChangeBiddingStrategyType: return "CANNOT_CHANGE_BIDDING_STRATEGY_TYPE";
				case BiddingStrategyErrorReason.CannotRemoveAssociatedStrategy: return "CANNOT_REMOVE_ASSOCIATED_STRATEGY";
				case BiddingStrategyErrorReason.BiddingStrategyNotSupported: return "BIDDING_STRATEGY_NOT_SUPPORTED";
				case BiddingStrategyErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BiddingStrategyErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DUPLICATE_NAME": return BiddingStrategyErrorReason.DuplicateName;
				case "CANNOT_CHANGE_BIDDING_STRATEGY_TYPE": return BiddingStrategyErrorReason.CannotChangeBiddingStrategyType;
				case "CANNOT_REMOVE_ASSOCIATED_STRATEGY": return BiddingStrategyErrorReason.CannotRemoveAssociatedStrategy;
				case "BIDDING_STRATEGY_NOT_SUPPORTED": return BiddingStrategyErrorReason.BiddingStrategyNotSupported;
				case "UNKNOWN": return BiddingStrategyErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BiddingStrategyErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class BiddingStrategySourceExtensions
	{
		public static string ToXmlValue(this BiddingStrategySource enumValue)
		{
			switch (enumValue)
			{
				case BiddingStrategySource.Campaign: return "CAMPAIGN";
				case BiddingStrategySource.Adgroup: return "ADGROUP";
				case BiddingStrategySource.Criterion: return "CRITERION";
				default: return null;
			}
		}
		public static BiddingStrategySource Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CAMPAIGN": return BiddingStrategySource.Campaign;
				case "ADGROUP": return BiddingStrategySource.Adgroup;
				case "CRITERION": return BiddingStrategySource.Criterion;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BiddingStrategySource.", nameof(xmlValue));
			}
		}
	}
	public static class BiddingStrategySystemStatusExtensions
	{
		public static string ToXmlValue(this BiddingStrategySystemStatus enumValue)
		{
			switch (enumValue)
			{
				case BiddingStrategySystemStatus.Unknown: return "UNKNOWN";
				case BiddingStrategySystemStatus.Unconstrained: return "UNCONSTRAINED";
				case BiddingStrategySystemStatus.LearningNew: return "LEARNING_NEW";
				case BiddingStrategySystemStatus.LearningSettingChange: return "LEARNING_SETTING_CHANGE";
				case BiddingStrategySystemStatus.LearningBudgetChange: return "LEARNING_BUDGET_CHANGE";
				case BiddingStrategySystemStatus.LearningCompositionChange: return "LEARNING_COMPOSITION_CHANGE";
				case BiddingStrategySystemStatus.LearningConversionTypeChange: return "LEARNING_CONVERSION_TYPE_CHANGE";
				case BiddingStrategySystemStatus.LearningConversionSettingChange: return "LEARNING_CONVERSION_SETTING_CHANGE";
				case BiddingStrategySystemStatus.LimitedByBidConstraints: return "LIMITED_BY_BID_CONSTRAINTS";
				case BiddingStrategySystemStatus.LimitedByMaxBidLimit: return "LIMITED_BY_MAX_BID_LIMIT";
				case BiddingStrategySystemStatus.LimitedByMinBidLimit: return "LIMITED_BY_MIN_BID_LIMIT";
				case BiddingStrategySystemStatus.LimitedByMinRoasLimit: return "LIMITED_BY_MIN_ROAS_LIMIT";
				case BiddingStrategySystemStatus.LimitedByData: return "LIMITED_BY_DATA";
				case BiddingStrategySystemStatus.LimitedByBudget: return "LIMITED_BY_BUDGET";
				case BiddingStrategySystemStatus.LimitedByLowPrioritySpend: return "LIMITED_BY_LOW_PRIORITY_SPEND";
				case BiddingStrategySystemStatus.LimitedByLowQuality: return "LIMITED_BY_LOW_QUALITY";
				case BiddingStrategySystemStatus.MisconfiguredConversionTypes: return "MISCONFIGURED_CONVERSION_TYPES";
				case BiddingStrategySystemStatus.MisconfiguredConversionSettings: return "MISCONFIGURED_CONVERSION_SETTINGS";
				case BiddingStrategySystemStatus.Inactive: return "INACTIVE";
				case BiddingStrategySystemStatus.Unavailable: return "UNAVAILABLE";
				case BiddingStrategySystemStatus.MultipleLearning: return "MULTIPLE_LEARNING";
				case BiddingStrategySystemStatus.MultipleLimited: return "MULTIPLE_LIMITED";
				case BiddingStrategySystemStatus.MultipleMisconfigured: return "MULTIPLE_MISCONFIGURED";
				case BiddingStrategySystemStatus.Multiple: return "MULTIPLE";
				default: return null;
			}
		}
		public static BiddingStrategySystemStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return BiddingStrategySystemStatus.Unknown;
				case "UNCONSTRAINED": return BiddingStrategySystemStatus.Unconstrained;
				case "LEARNING_NEW": return BiddingStrategySystemStatus.LearningNew;
				case "LEARNING_SETTING_CHANGE": return BiddingStrategySystemStatus.LearningSettingChange;
				case "LEARNING_BUDGET_CHANGE": return BiddingStrategySystemStatus.LearningBudgetChange;
				case "LEARNING_COMPOSITION_CHANGE": return BiddingStrategySystemStatus.LearningCompositionChange;
				case "LEARNING_CONVERSION_TYPE_CHANGE": return BiddingStrategySystemStatus.LearningConversionTypeChange;
				case "LEARNING_CONVERSION_SETTING_CHANGE": return BiddingStrategySystemStatus.LearningConversionSettingChange;
				case "LIMITED_BY_BID_CONSTRAINTS": return BiddingStrategySystemStatus.LimitedByBidConstraints;
				case "LIMITED_BY_MAX_BID_LIMIT": return BiddingStrategySystemStatus.LimitedByMaxBidLimit;
				case "LIMITED_BY_MIN_BID_LIMIT": return BiddingStrategySystemStatus.LimitedByMinBidLimit;
				case "LIMITED_BY_MIN_ROAS_LIMIT": return BiddingStrategySystemStatus.LimitedByMinRoasLimit;
				case "LIMITED_BY_DATA": return BiddingStrategySystemStatus.LimitedByData;
				case "LIMITED_BY_BUDGET": return BiddingStrategySystemStatus.LimitedByBudget;
				case "LIMITED_BY_LOW_PRIORITY_SPEND": return BiddingStrategySystemStatus.LimitedByLowPrioritySpend;
				case "LIMITED_BY_LOW_QUALITY": return BiddingStrategySystemStatus.LimitedByLowQuality;
				case "MISCONFIGURED_CONVERSION_TYPES": return BiddingStrategySystemStatus.MisconfiguredConversionTypes;
				case "MISCONFIGURED_CONVERSION_SETTINGS": return BiddingStrategySystemStatus.MisconfiguredConversionSettings;
				case "INACTIVE": return BiddingStrategySystemStatus.Inactive;
				case "UNAVAILABLE": return BiddingStrategySystemStatus.Unavailable;
				case "MULTIPLE_LEARNING": return BiddingStrategySystemStatus.MultipleLearning;
				case "MULTIPLE_LIMITED": return BiddingStrategySystemStatus.MultipleLimited;
				case "MULTIPLE_MISCONFIGURED": return BiddingStrategySystemStatus.MultipleMisconfigured;
				case "MULTIPLE": return BiddingStrategySystemStatus.Multiple;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BiddingStrategySystemStatus.", nameof(xmlValue));
			}
		}
	}
	public static class BiddingStrategyTypeExtensions
	{
		public static string ToXmlValue(this BiddingStrategyType enumValue)
		{
			switch (enumValue)
			{
				case BiddingStrategyType.BudgetOptimizer: return "BUDGET_OPTIMIZER";
				case BiddingStrategyType.ConversionOptimizer: return "CONVERSION_OPTIMIZER";
				case BiddingStrategyType.ManualCpc: return "MANUAL_CPC";
				case BiddingStrategyType.ManualCpm: return "MANUAL_CPM";
				case BiddingStrategyType.PageOnePromoted: return "PAGE_ONE_PROMOTED";
				case BiddingStrategyType.TargetSpend: return "TARGET_SPEND";
				case BiddingStrategyType.EnhancedCpc: return "ENHANCED_CPC";
				case BiddingStrategyType.TargetCpa: return "TARGET_CPA";
				case BiddingStrategyType.TargetRoas: return "TARGET_ROAS";
				case BiddingStrategyType.TargetOutrankShare: return "TARGET_OUTRANK_SHARE";
				case BiddingStrategyType.None: return "NONE";
				case BiddingStrategyType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BiddingStrategyType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BUDGET_OPTIMIZER": return BiddingStrategyType.BudgetOptimizer;
				case "CONVERSION_OPTIMIZER": return BiddingStrategyType.ConversionOptimizer;
				case "MANUAL_CPC": return BiddingStrategyType.ManualCpc;
				case "MANUAL_CPM": return BiddingStrategyType.ManualCpm;
				case "PAGE_ONE_PROMOTED": return BiddingStrategyType.PageOnePromoted;
				case "TARGET_SPEND": return BiddingStrategyType.TargetSpend;
				case "ENHANCED_CPC": return BiddingStrategyType.EnhancedCpc;
				case "TARGET_CPA": return BiddingStrategyType.TargetCpa;
				case "TARGET_ROAS": return BiddingStrategyType.TargetRoas;
				case "TARGET_OUTRANK_SHARE": return BiddingStrategyType.TargetOutrankShare;
				case "NONE": return BiddingStrategyType.None;
				case "UNKNOWN": return BiddingStrategyType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BiddingStrategyType.", nameof(xmlValue));
			}
		}
	}
	public static class BidModifierSourceExtensions
	{
		public static string ToXmlValue(this BidModifierSource enumValue)
		{
			switch (enumValue)
			{
				case BidModifierSource.Unknown: return "UNKNOWN";
				case BidModifierSource.Campaign: return "CAMPAIGN";
				case BidModifierSource.AdGroup: return "AD_GROUP";
				default: return null;
			}
		}
		public static BidModifierSource Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return BidModifierSource.Unknown;
				case "CAMPAIGN": return BidModifierSource.Campaign;
				case "AD_GROUP": return BidModifierSource.AdGroup;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BidModifierSource.", nameof(xmlValue));
			}
		}
	}
	public static class BidSourceExtensions
	{
		public static string ToXmlValue(this BidSource enumValue)
		{
			switch (enumValue)
			{
				case BidSource.Adgroup: return "ADGROUP";
				case BidSource.Criterion: return "CRITERION";
				case BidSource.AdgroupBiddingStrategy: return "ADGROUP_BIDDING_STRATEGY";
				case BidSource.CampaignBiddingStrategy: return "CAMPAIGN_BIDDING_STRATEGY";
				default: return null;
			}
		}
		public static BidSource Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ADGROUP": return BidSource.Adgroup;
				case "CRITERION": return BidSource.Criterion;
				case "ADGROUP_BIDDING_STRATEGY": return BidSource.AdgroupBiddingStrategy;
				case "CAMPAIGN_BIDDING_STRATEGY": return BidSource.CampaignBiddingStrategy;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BidSource.", nameof(xmlValue));
			}
		}
	}
	public static class BudgetBudgetDeliveryMethodExtensions
	{
		public static string ToXmlValue(this BudgetBudgetDeliveryMethod enumValue)
		{
			switch (enumValue)
			{
				case BudgetBudgetDeliveryMethod.Standard: return "STANDARD";
				case BudgetBudgetDeliveryMethod.Accelerated: return "ACCELERATED";
				case BudgetBudgetDeliveryMethod.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BudgetBudgetDeliveryMethod Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "STANDARD": return BudgetBudgetDeliveryMethod.Standard;
				case "ACCELERATED": return BudgetBudgetDeliveryMethod.Accelerated;
				case "UNKNOWN": return BudgetBudgetDeliveryMethod.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BudgetBudgetDeliveryMethod.", nameof(xmlValue));
			}
		}
	}
	public static class BudgetBudgetStatusExtensions
	{
		public static string ToXmlValue(this BudgetBudgetStatus enumValue)
		{
			switch (enumValue)
			{
				case BudgetBudgetStatus.Enabled: return "ENABLED";
				case BudgetBudgetStatus.Removed: return "REMOVED";
				case BudgetBudgetStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BudgetBudgetStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return BudgetBudgetStatus.Enabled;
				case "REMOVED": return BudgetBudgetStatus.Removed;
				case "UNKNOWN": return BudgetBudgetStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BudgetBudgetStatus.", nameof(xmlValue));
			}
		}
	}
	public static class BudgetErrorReasonExtensions
	{
		public static string ToXmlValue(this BudgetErrorReason enumValue)
		{
			switch (enumValue)
			{
				case BudgetErrorReason.BudgetRemoved: return "BUDGET_REMOVED";
				case BudgetErrorReason.BudgetError: return "BUDGET_ERROR";
				case BudgetErrorReason.BudgetInUse: return "BUDGET_IN_USE";
				case BudgetErrorReason.BudgetPeriodNotAvailable: return "BUDGET_PERIOD_NOT_AVAILABLE";
				case BudgetErrorReason.CannotEditSharedBudget: return "CANNOT_EDIT_SHARED_BUDGET";
				case BudgetErrorReason.CannotModifyFieldOfImplicitlySharedBudget: return "CANNOT_MODIFY_FIELD_OF_IMPLICITLY_SHARED_BUDGET";
				case BudgetErrorReason.CannotUpdateBudgetToImplicitlyShared: return "CANNOT_UPDATE_BUDGET_TO_IMPLICITLY_SHARED";
				case BudgetErrorReason.CannotUpdateBudgetToExplicitlySharedWithoutName: return "CANNOT_UPDATE_BUDGET_TO_EXPLICITLY_SHARED_WITHOUT_NAME";
				case BudgetErrorReason.CannotUseImplicitlySharedBudgetWithMultipleCampaigns: return "CANNOT_USE_IMPLICITLY_SHARED_BUDGET_WITH_MULTIPLE_CAMPAIGNS";
				case BudgetErrorReason.DuplicateName: return "DUPLICATE_NAME";
				case BudgetErrorReason.MoneyAmountInWrongCurrency: return "MONEY_AMOUNT_IN_WRONG_CURRENCY";
				case BudgetErrorReason.MoneyAmountLessThanCurrencyMinimumCpc: return "MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC";
				case BudgetErrorReason.MoneyAmountTooLarge: return "MONEY_AMOUNT_TOO_LARGE";
				case BudgetErrorReason.NegativeMoneyAmount: return "NEGATIVE_MONEY_AMOUNT";
				case BudgetErrorReason.NonMultipleOfMinimumCurrencyUnit: return "NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT";
				default: return null;
			}
		}
		public static BudgetErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BUDGET_REMOVED": return BudgetErrorReason.BudgetRemoved;
				case "BUDGET_ERROR": return BudgetErrorReason.BudgetError;
				case "BUDGET_IN_USE": return BudgetErrorReason.BudgetInUse;
				case "BUDGET_PERIOD_NOT_AVAILABLE": return BudgetErrorReason.BudgetPeriodNotAvailable;
				case "CANNOT_EDIT_SHARED_BUDGET": return BudgetErrorReason.CannotEditSharedBudget;
				case "CANNOT_MODIFY_FIELD_OF_IMPLICITLY_SHARED_BUDGET": return BudgetErrorReason.CannotModifyFieldOfImplicitlySharedBudget;
				case "CANNOT_UPDATE_BUDGET_TO_IMPLICITLY_SHARED": return BudgetErrorReason.CannotUpdateBudgetToImplicitlyShared;
				case "CANNOT_UPDATE_BUDGET_TO_EXPLICITLY_SHARED_WITHOUT_NAME": return BudgetErrorReason.CannotUpdateBudgetToExplicitlySharedWithoutName;
				case "CANNOT_USE_IMPLICITLY_SHARED_BUDGET_WITH_MULTIPLE_CAMPAIGNS": return BudgetErrorReason.CannotUseImplicitlySharedBudgetWithMultipleCampaigns;
				case "DUPLICATE_NAME": return BudgetErrorReason.DuplicateName;
				case "MONEY_AMOUNT_IN_WRONG_CURRENCY": return BudgetErrorReason.MoneyAmountInWrongCurrency;
				case "MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC": return BudgetErrorReason.MoneyAmountLessThanCurrencyMinimumCpc;
				case "MONEY_AMOUNT_TOO_LARGE": return BudgetErrorReason.MoneyAmountTooLarge;
				case "NEGATIVE_MONEY_AMOUNT": return BudgetErrorReason.NegativeMoneyAmount;
				case "NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT": return BudgetErrorReason.NonMultipleOfMinimumCurrencyUnit;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BudgetErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class BudgetOrderErrorReasonExtensions
	{
		public static string ToXmlValue(this BudgetOrderErrorReason enumValue)
		{
			switch (enumValue)
			{
				case BudgetOrderErrorReason.BudgetApprovalInProgress: return "BUDGET_APPROVAL_IN_PROGRESS";
				case BudgetOrderErrorReason.ServiceUnavailable: return "SERVICE_UNAVAILABLE";
				case BudgetOrderErrorReason.FieldNotEligibleForCurrentBilling: return "FIELD_NOT_ELIGIBLE_FOR_CURRENT_BILLING";
				case BudgetOrderErrorReason.InvalidBillingAccount: return "INVALID_BILLING_ACCOUNT";
				case BudgetOrderErrorReason.GenericBillingError: return "GENERIC_BILLING_ERROR";
				case BudgetOrderErrorReason.InvalidBillingAccountIdFormat: return "INVALID_BILLING_ACCOUNT_ID_FORMAT";
				case BudgetOrderErrorReason.InvalidBudgetDateRange: return "INVALID_BUDGET_DATE_RANGE";
				case BudgetOrderErrorReason.IncompatibleCurrency: return "INCOMPATIBLE_CURRENCY";
				case BudgetOrderErrorReason.BudgetUpdateDenied: return "BUDGET_UPDATE_DENIED";
				case BudgetOrderErrorReason.BudgetAlreadyStarted: return "BUDGET_ALREADY_STARTED";
				case BudgetOrderErrorReason.BudgetAlreadyEnded: return "BUDGET_ALREADY_ENDED";
				case BudgetOrderErrorReason.InvalidConstraint: return "INVALID_CONSTRAINT";
				case BudgetOrderErrorReason.InvalidBidTooLarge: return "INVALID_BID_TOO_LARGE";
				case BudgetOrderErrorReason.NoSuchBudgetFound: return "NO_SUCH_BUDGET_FOUND";
				case BudgetOrderErrorReason.InvalidBudgetAlreadySpent: return "INVALID_BUDGET_ALREADY_SPENT";
				case BudgetOrderErrorReason.InvalidTimezoneInDate: return "INVALID_TIMEZONE_IN_DATE";
				case BudgetOrderErrorReason.AccountBudgetIdSetInAdd: return "ACCOUNT_BUDGET_ID_SET_IN_ADD";
				case BudgetOrderErrorReason.MoreThanOneOperations: return "MORE_THAN_ONE_OPERATIONS";
				case BudgetOrderErrorReason.InvalidManagerAccount: return "INVALID_MANAGER_ACCOUNT";
				case BudgetOrderErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BudgetOrderErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BUDGET_APPROVAL_IN_PROGRESS": return BudgetOrderErrorReason.BudgetApprovalInProgress;
				case "SERVICE_UNAVAILABLE": return BudgetOrderErrorReason.ServiceUnavailable;
				case "FIELD_NOT_ELIGIBLE_FOR_CURRENT_BILLING": return BudgetOrderErrorReason.FieldNotEligibleForCurrentBilling;
				case "INVALID_BILLING_ACCOUNT": return BudgetOrderErrorReason.InvalidBillingAccount;
				case "GENERIC_BILLING_ERROR": return BudgetOrderErrorReason.GenericBillingError;
				case "INVALID_BILLING_ACCOUNT_ID_FORMAT": return BudgetOrderErrorReason.InvalidBillingAccountIdFormat;
				case "INVALID_BUDGET_DATE_RANGE": return BudgetOrderErrorReason.InvalidBudgetDateRange;
				case "INCOMPATIBLE_CURRENCY": return BudgetOrderErrorReason.IncompatibleCurrency;
				case "BUDGET_UPDATE_DENIED": return BudgetOrderErrorReason.BudgetUpdateDenied;
				case "BUDGET_ALREADY_STARTED": return BudgetOrderErrorReason.BudgetAlreadyStarted;
				case "BUDGET_ALREADY_ENDED": return BudgetOrderErrorReason.BudgetAlreadyEnded;
				case "INVALID_CONSTRAINT": return BudgetOrderErrorReason.InvalidConstraint;
				case "INVALID_BID_TOO_LARGE": return BudgetOrderErrorReason.InvalidBidTooLarge;
				case "NO_SUCH_BUDGET_FOUND": return BudgetOrderErrorReason.NoSuchBudgetFound;
				case "INVALID_BUDGET_ALREADY_SPENT": return BudgetOrderErrorReason.InvalidBudgetAlreadySpent;
				case "INVALID_TIMEZONE_IN_DATE": return BudgetOrderErrorReason.InvalidTimezoneInDate;
				case "ACCOUNT_BUDGET_ID_SET_IN_ADD": return BudgetOrderErrorReason.AccountBudgetIdSetInAdd;
				case "MORE_THAN_ONE_OPERATIONS": return BudgetOrderErrorReason.MoreThanOneOperations;
				case "INVALID_MANAGER_ACCOUNT": return BudgetOrderErrorReason.InvalidManagerAccount;
				case "UNKNOWN": return BudgetOrderErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BudgetOrderErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class BudgetOrderRequestStatusExtensions
	{
		public static string ToXmlValue(this BudgetOrderRequestStatus enumValue)
		{
			switch (enumValue)
			{
				case BudgetOrderRequestStatus.UnderReview: return "UNDER_REVIEW";
				case BudgetOrderRequestStatus.Approved: return "APPROVED";
				case BudgetOrderRequestStatus.Rejected: return "REJECTED";
				case BudgetOrderRequestStatus.Cancelled: return "CANCELLED";
				case BudgetOrderRequestStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static BudgetOrderRequestStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNDER_REVIEW": return BudgetOrderRequestStatus.UnderReview;
				case "APPROVED": return BudgetOrderRequestStatus.Approved;
				case "REJECTED": return BudgetOrderRequestStatus.Rejected;
				case "CANCELLED": return BudgetOrderRequestStatus.Cancelled;
				case "UNKNOWN": return BudgetOrderRequestStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type BudgetOrderRequestStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignCriterionCampaignCriterionStatusExtensions
	{
		public static string ToXmlValue(this CampaignCriterionCampaignCriterionStatus enumValue)
		{
			switch (enumValue)
			{
				case CampaignCriterionCampaignCriterionStatus.Active: return "ACTIVE";
				case CampaignCriterionCampaignCriterionStatus.Removed: return "REMOVED";
				case CampaignCriterionCampaignCriterionStatus.Paused: return "PAUSED";
				default: return null;
			}
		}
		public static CampaignCriterionCampaignCriterionStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACTIVE": return CampaignCriterionCampaignCriterionStatus.Active;
				case "REMOVED": return CampaignCriterionCampaignCriterionStatus.Removed;
				case "PAUSED": return CampaignCriterionCampaignCriterionStatus.Paused;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignCriterionCampaignCriterionStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignCriterionErrorReasonExtensions
	{
		public static string ToXmlValue(this CampaignCriterionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CampaignCriterionErrorReason.ConcreteTypeRequired: return "CONCRETE_TYPE_REQUIRED";
				case CampaignCriterionErrorReason.InvalidPlacementUrl: return "INVALID_PLACEMENT_URL";
				case CampaignCriterionErrorReason.CannotExcludeCriteriaType: return "CANNOT_EXCLUDE_CRITERIA_TYPE";
				case CampaignCriterionErrorReason.CannotSetStatusForCriteriaType: return "CANNOT_SET_STATUS_FOR_CRITERIA_TYPE";
				case CampaignCriterionErrorReason.CannotSetStatusForExcludedCriteria: return "CANNOT_SET_STATUS_FOR_EXCLUDED_CRITERIA";
				case CampaignCriterionErrorReason.CannotTargetAndExclude: return "CANNOT_TARGET_AND_EXCLUDE";
				case CampaignCriterionErrorReason.TooManyOperations: return "TOO_MANY_OPERATIONS";
				case CampaignCriterionErrorReason.OperatorNotSupportedForCriterionType: return "OPERATOR_NOT_SUPPORTED_FOR_CRITERION_TYPE";
				case CampaignCriterionErrorReason.ShoppingCampaignSalesCountryNotSupportedForSalesChannel: return "SHOPPING_CAMPAIGN_SALES_COUNTRY_NOT_SUPPORTED_FOR_SALES_CHANNEL";
				case CampaignCriterionErrorReason.Unknown: return "UNKNOWN";
				case CampaignCriterionErrorReason.CannotAddExistingField: return "CANNOT_ADD_EXISTING_FIELD";
				default: return null;
			}
		}
		public static CampaignCriterionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CONCRETE_TYPE_REQUIRED": return CampaignCriterionErrorReason.ConcreteTypeRequired;
				case "INVALID_PLACEMENT_URL": return CampaignCriterionErrorReason.InvalidPlacementUrl;
				case "CANNOT_EXCLUDE_CRITERIA_TYPE": return CampaignCriterionErrorReason.CannotExcludeCriteriaType;
				case "CANNOT_SET_STATUS_FOR_CRITERIA_TYPE": return CampaignCriterionErrorReason.CannotSetStatusForCriteriaType;
				case "CANNOT_SET_STATUS_FOR_EXCLUDED_CRITERIA": return CampaignCriterionErrorReason.CannotSetStatusForExcludedCriteria;
				case "CANNOT_TARGET_AND_EXCLUDE": return CampaignCriterionErrorReason.CannotTargetAndExclude;
				case "TOO_MANY_OPERATIONS": return CampaignCriterionErrorReason.TooManyOperations;
				case "OPERATOR_NOT_SUPPORTED_FOR_CRITERION_TYPE": return CampaignCriterionErrorReason.OperatorNotSupportedForCriterionType;
				case "SHOPPING_CAMPAIGN_SALES_COUNTRY_NOT_SUPPORTED_FOR_SALES_CHANNEL": return CampaignCriterionErrorReason.ShoppingCampaignSalesCountryNotSupportedForSalesChannel;
				case "UNKNOWN": return CampaignCriterionErrorReason.Unknown;
				case "CANNOT_ADD_EXISTING_FIELD": return CampaignCriterionErrorReason.CannotAddExistingField;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignCriterionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignErrorReasonExtensions
	{
		public static string ToXmlValue(this CampaignErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CampaignErrorReason.CannotGoBackToIncomplete: return "CANNOT_GO_BACK_TO_INCOMPLETE";
				case CampaignErrorReason.CannotTargetContentNetwork: return "CANNOT_TARGET_CONTENT_NETWORK";
				case CampaignErrorReason.CannotTargetSearchNetwork: return "CANNOT_TARGET_SEARCH_NETWORK";
				case CampaignErrorReason.CannotTargetSearchNetworkWithoutGoogleSearch: return "CANNOT_TARGET_SEARCH_NETWORK_WITHOUT_GOOGLE_SEARCH";
				case CampaignErrorReason.CannotTargetGoogleSearchForCpmCampaign: return "CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN";
				case CampaignErrorReason.CampaignMustTargetAtLeastOneNetwork: return "CAMPAIGN_MUST_TARGET_AT_LEAST_ONE_NETWORK";
				case CampaignErrorReason.CannotTargetPartnerSearchNetwork: return "CANNOT_TARGET_PARTNER_SEARCH_NETWORK";
				case CampaignErrorReason.CannotTargetContentNetworkOnlyWithCriteriaLevelBiddingStrategy: return "CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CRITERIA_LEVEL_BIDDING_STRATEGY";
				case CampaignErrorReason.CampaignDurationMustContainAllRunnableTrials: return "CAMPAIGN_DURATION_MUST_CONTAIN_ALL_RUNNABLE_TRIALS";
				case CampaignErrorReason.CannotModifyForTrialCampaign: return "CANNOT_MODIFY_FOR_TRIAL_CAMPAIGN";
				case CampaignErrorReason.DuplicateCampaignName: return "DUPLICATE_CAMPAIGN_NAME";
				case CampaignErrorReason.IncompatibleCampaignField: return "INCOMPATIBLE_CAMPAIGN_FIELD";
				case CampaignErrorReason.InvalidCampaignName: return "INVALID_CAMPAIGN_NAME";
				case CampaignErrorReason.InvalidAdServingOptimizationStatus: return "INVALID_AD_SERVING_OPTIMIZATION_STATUS";
				case CampaignErrorReason.InvalidTrackingUrl: return "INVALID_TRACKING_URL";
				case CampaignErrorReason.CannotSetBothTrackingUrlTemplateAndTrackingSetting: return "CANNOT_SET_BOTH_TRACKING_URL_TEMPLATE_AND_TRACKING_SETTING";
				case CampaignErrorReason.MaxImpressionsNotInRange: return "MAX_IMPRESSIONS_NOT_IN_RANGE";
				case CampaignErrorReason.TimeUnitNotSupported: return "TIME_UNIT_NOT_SUPPORTED";
				case CampaignErrorReason.InvalidOperationIfServingStatusHasEnded: return "INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED";
				case CampaignErrorReason.BudgetCannotBeShared: return "BUDGET_CANNOT_BE_SHARED";
				case CampaignErrorReason.CampaignCannotUseSharedBudget: return "CAMPAIGN_CANNOT_USE_SHARED_BUDGET";
				case CampaignErrorReason.CannotChangeBudgetOnCampaignWithTrials: return "CANNOT_CHANGE_BUDGET_ON_CAMPAIGN_WITH_TRIALS";
				case CampaignErrorReason.CampaignLabelDoesNotExist: return "CAMPAIGN_LABEL_DOES_NOT_EXIST";
				case CampaignErrorReason.CampaignLabelAlreadyExists: return "CAMPAIGN_LABEL_ALREADY_EXISTS";
				case CampaignErrorReason.MissingShoppingSetting: return "MISSING_SHOPPING_SETTING";
				case CampaignErrorReason.InvalidShoppingSalesCountry: return "INVALID_SHOPPING_SALES_COUNTRY";
				case CampaignErrorReason.MissingUniversalAppCampaignSetting: return "MISSING_UNIVERSAL_APP_CAMPAIGN_SETTING";
				case CampaignErrorReason.AdvertisingChannelTypeNotAvailableForAccountType: return "ADVERTISING_CHANNEL_TYPE_NOT_AVAILABLE_FOR_ACCOUNT_TYPE";
				case CampaignErrorReason.InvalidAdvertisingChannelSubType: return "INVALID_ADVERTISING_CHANNEL_SUB_TYPE";
				case CampaignErrorReason.AtLeastOneConversionMustBeSelected: return "AT_LEAST_ONE_CONVERSION_MUST_BE_SELECTED";
				case CampaignErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CampaignErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_GO_BACK_TO_INCOMPLETE": return CampaignErrorReason.CannotGoBackToIncomplete;
				case "CANNOT_TARGET_CONTENT_NETWORK": return CampaignErrorReason.CannotTargetContentNetwork;
				case "CANNOT_TARGET_SEARCH_NETWORK": return CampaignErrorReason.CannotTargetSearchNetwork;
				case "CANNOT_TARGET_SEARCH_NETWORK_WITHOUT_GOOGLE_SEARCH": return CampaignErrorReason.CannotTargetSearchNetworkWithoutGoogleSearch;
				case "CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN": return CampaignErrorReason.CannotTargetGoogleSearchForCpmCampaign;
				case "CAMPAIGN_MUST_TARGET_AT_LEAST_ONE_NETWORK": return CampaignErrorReason.CampaignMustTargetAtLeastOneNetwork;
				case "CANNOT_TARGET_PARTNER_SEARCH_NETWORK": return CampaignErrorReason.CannotTargetPartnerSearchNetwork;
				case "CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CRITERIA_LEVEL_BIDDING_STRATEGY": return CampaignErrorReason.CannotTargetContentNetworkOnlyWithCriteriaLevelBiddingStrategy;
				case "CAMPAIGN_DURATION_MUST_CONTAIN_ALL_RUNNABLE_TRIALS": return CampaignErrorReason.CampaignDurationMustContainAllRunnableTrials;
				case "CANNOT_MODIFY_FOR_TRIAL_CAMPAIGN": return CampaignErrorReason.CannotModifyForTrialCampaign;
				case "DUPLICATE_CAMPAIGN_NAME": return CampaignErrorReason.DuplicateCampaignName;
				case "INCOMPATIBLE_CAMPAIGN_FIELD": return CampaignErrorReason.IncompatibleCampaignField;
				case "INVALID_CAMPAIGN_NAME": return CampaignErrorReason.InvalidCampaignName;
				case "INVALID_AD_SERVING_OPTIMIZATION_STATUS": return CampaignErrorReason.InvalidAdServingOptimizationStatus;
				case "INVALID_TRACKING_URL": return CampaignErrorReason.InvalidTrackingUrl;
				case "CANNOT_SET_BOTH_TRACKING_URL_TEMPLATE_AND_TRACKING_SETTING": return CampaignErrorReason.CannotSetBothTrackingUrlTemplateAndTrackingSetting;
				case "MAX_IMPRESSIONS_NOT_IN_RANGE": return CampaignErrorReason.MaxImpressionsNotInRange;
				case "TIME_UNIT_NOT_SUPPORTED": return CampaignErrorReason.TimeUnitNotSupported;
				case "INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED": return CampaignErrorReason.InvalidOperationIfServingStatusHasEnded;
				case "BUDGET_CANNOT_BE_SHARED": return CampaignErrorReason.BudgetCannotBeShared;
				case "CAMPAIGN_CANNOT_USE_SHARED_BUDGET": return CampaignErrorReason.CampaignCannotUseSharedBudget;
				case "CANNOT_CHANGE_BUDGET_ON_CAMPAIGN_WITH_TRIALS": return CampaignErrorReason.CannotChangeBudgetOnCampaignWithTrials;
				case "CAMPAIGN_LABEL_DOES_NOT_EXIST": return CampaignErrorReason.CampaignLabelDoesNotExist;
				case "CAMPAIGN_LABEL_ALREADY_EXISTS": return CampaignErrorReason.CampaignLabelAlreadyExists;
				case "MISSING_SHOPPING_SETTING": return CampaignErrorReason.MissingShoppingSetting;
				case "INVALID_SHOPPING_SALES_COUNTRY": return CampaignErrorReason.InvalidShoppingSalesCountry;
				case "MISSING_UNIVERSAL_APP_CAMPAIGN_SETTING": return CampaignErrorReason.MissingUniversalAppCampaignSetting;
				case "ADVERTISING_CHANNEL_TYPE_NOT_AVAILABLE_FOR_ACCOUNT_TYPE": return CampaignErrorReason.AdvertisingChannelTypeNotAvailableForAccountType;
				case "INVALID_ADVERTISING_CHANNEL_SUB_TYPE": return CampaignErrorReason.InvalidAdvertisingChannelSubType;
				case "AT_LEAST_ONE_CONVERSION_MUST_BE_SELECTED": return CampaignErrorReason.AtLeastOneConversionMustBeSelected;
				case "UNKNOWN": return CampaignErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignFeedErrorReasonExtensions
	{
		public static string ToXmlValue(this CampaignFeedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CampaignFeedErrorReason.FeedAlreadyExistsForPlaceholderType: return "FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE";
				case CampaignFeedErrorReason.InvalidId: return "INVALID_ID";
				case CampaignFeedErrorReason.CannotAddForDeletedFeed: return "CANNOT_ADD_FOR_DELETED_FEED";
				case CampaignFeedErrorReason.CannotAddAlreadyExistingCampaignFeed: return "CANNOT_ADD_ALREADY_EXISTING_CAMPAIGN_FEED";
				case CampaignFeedErrorReason.CannotOperateOnRemovedCampaignFeed: return "CANNOT_OPERATE_ON_REMOVED_CAMPAIGN_FEED";
				case CampaignFeedErrorReason.InvalidPlaceholderTypes: return "INVALID_PLACEHOLDER_TYPES";
				case CampaignFeedErrorReason.MissingFeedmappingForPlaceholderType: return "MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE";
				case CampaignFeedErrorReason.NoExistingLocationCustomerFeed: return "NO_EXISTING_LOCATION_CUSTOMER_FEED";
				case CampaignFeedErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CampaignFeedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE": return CampaignFeedErrorReason.FeedAlreadyExistsForPlaceholderType;
				case "INVALID_ID": return CampaignFeedErrorReason.InvalidId;
				case "CANNOT_ADD_FOR_DELETED_FEED": return CampaignFeedErrorReason.CannotAddForDeletedFeed;
				case "CANNOT_ADD_ALREADY_EXISTING_CAMPAIGN_FEED": return CampaignFeedErrorReason.CannotAddAlreadyExistingCampaignFeed;
				case "CANNOT_OPERATE_ON_REMOVED_CAMPAIGN_FEED": return CampaignFeedErrorReason.CannotOperateOnRemovedCampaignFeed;
				case "INVALID_PLACEHOLDER_TYPES": return CampaignFeedErrorReason.InvalidPlaceholderTypes;
				case "MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE": return CampaignFeedErrorReason.MissingFeedmappingForPlaceholderType;
				case "NO_EXISTING_LOCATION_CUSTOMER_FEED": return CampaignFeedErrorReason.NoExistingLocationCustomerFeed;
				case "UNKNOWN": return CampaignFeedErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignFeedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignFeedStatusExtensions
	{
		public static string ToXmlValue(this CampaignFeedStatus enumValue)
		{
			switch (enumValue)
			{
				case CampaignFeedStatus.Enabled: return "ENABLED";
				case CampaignFeedStatus.Removed: return "REMOVED";
				case CampaignFeedStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CampaignFeedStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return CampaignFeedStatus.Enabled;
				case "REMOVED": return CampaignFeedStatus.Removed;
				case "UNKNOWN": return CampaignFeedStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignFeedStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignPreferenceErrorReasonExtensions
	{
		public static string ToXmlValue(this CampaignPreferenceErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CampaignPreferenceErrorReason.PreferenceAlreadyExists: return "PREFERENCE_ALREADY_EXISTS";
				case CampaignPreferenceErrorReason.PreferenceNotFound: return "PREFERENCE_NOT_FOUND";
				case CampaignPreferenceErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CampaignPreferenceErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "PREFERENCE_ALREADY_EXISTS": return CampaignPreferenceErrorReason.PreferenceAlreadyExists;
				case "PREFERENCE_NOT_FOUND": return CampaignPreferenceErrorReason.PreferenceNotFound;
				case "UNKNOWN": return CampaignPreferenceErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignPreferenceErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignSharedSetErrorReasonExtensions
	{
		public static string ToXmlValue(this CampaignSharedSetErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CampaignSharedSetErrorReason.CampaignSharedSetDoesNotExist: return "CAMPAIGN_SHARED_SET_DOES_NOT_EXIST";
				case CampaignSharedSetErrorReason.SharedSetNotActive: return "SHARED_SET_NOT_ACTIVE";
				case CampaignSharedSetErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CampaignSharedSetErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CAMPAIGN_SHARED_SET_DOES_NOT_EXIST": return CampaignSharedSetErrorReason.CampaignSharedSetDoesNotExist;
				case "SHARED_SET_NOT_ACTIVE": return CampaignSharedSetErrorReason.SharedSetNotActive;
				case "UNKNOWN": return CampaignSharedSetErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignSharedSetErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignSharedSetStatusExtensions
	{
		public static string ToXmlValue(this CampaignSharedSetStatus enumValue)
		{
			switch (enumValue)
			{
				case CampaignSharedSetStatus.Enabled: return "ENABLED";
				case CampaignSharedSetStatus.Removed: return "REMOVED";
				case CampaignSharedSetStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CampaignSharedSetStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return CampaignSharedSetStatus.Enabled;
				case "REMOVED": return CampaignSharedSetStatus.Removed;
				case "UNKNOWN": return CampaignSharedSetStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignSharedSetStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignStatusExtensions
	{
		public static string ToXmlValue(this CampaignStatus enumValue)
		{
			switch (enumValue)
			{
				case CampaignStatus.Unknown: return "UNKNOWN";
				case CampaignStatus.Enabled: return "ENABLED";
				case CampaignStatus.Paused: return "PAUSED";
				case CampaignStatus.Removed: return "REMOVED";
				default: return null;
			}
		}
		public static CampaignStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return CampaignStatus.Unknown;
				case "ENABLED": return CampaignStatus.Enabled;
				case "PAUSED": return CampaignStatus.Paused;
				case "REMOVED": return CampaignStatus.Removed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CampaignTrialTypeExtensions
	{
		public static string ToXmlValue(this CampaignTrialType enumValue)
		{
			switch (enumValue)
			{
				case CampaignTrialType.Unknown: return "UNKNOWN";
				case CampaignTrialType.Base: return "BASE";
				case CampaignTrialType.Draft: return "DRAFT";
				case CampaignTrialType.Trial: return "TRIAL";
				default: return null;
			}
		}
		public static CampaignTrialType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return CampaignTrialType.Unknown;
				case "BASE": return CampaignTrialType.Base;
				case "DRAFT": return CampaignTrialType.Draft;
				case "TRIAL": return CampaignTrialType.Trial;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CampaignTrialType.", nameof(xmlValue));
			}
		}
	}
	public static class ChangeStatusExtensions
	{
		public static string ToXmlValue(this ChangeStatus enumValue)
		{
			switch (enumValue)
			{
				case ChangeStatus.FieldsUnchanged: return "FIELDS_UNCHANGED";
				case ChangeStatus.FieldsChanged: return "FIELDS_CHANGED";
				case ChangeStatus.New: return "NEW";
				default: return null;
			}
		}
		public static ChangeStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "FIELDS_UNCHANGED": return ChangeStatus.FieldsUnchanged;
				case "FIELDS_CHANGED": return ChangeStatus.FieldsChanged;
				case "NEW": return ChangeStatus.New;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ChangeStatus.", nameof(xmlValue));
			}
		}
	}
	public static class ClientTermsErrorReasonExtensions
	{
		public static string ToXmlValue(this ClientTermsErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ClientTermsErrorReason.IncompleteSignupCurrentAdwordsTncNotAgreed: return "INCOMPLETE_SIGNUP_CURRENT_ADWORDS_TNC_NOT_AGREED";
				default: return null;
			}
		}
		public static ClientTermsErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INCOMPLETE_SIGNUP_CURRENT_ADWORDS_TNC_NOT_AGREED": return ClientTermsErrorReason.IncompleteSignupCurrentAdwordsTncNotAgreed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ClientTermsErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CollectionSizeErrorReasonExtensions
	{
		public static string ToXmlValue(this CollectionSizeErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CollectionSizeErrorReason.TooFew: return "TOO_FEW";
				case CollectionSizeErrorReason.TooMany: return "TOO_MANY";
				default: return null;
			}
		}
		public static CollectionSizeErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "TOO_FEW": return CollectionSizeErrorReason.TooFew;
				case "TOO_MANY": return CollectionSizeErrorReason.TooMany;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CollectionSizeErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CompetitionSearchParameterLevelExtensions
	{
		public static string ToXmlValue(this CompetitionSearchParameterLevel enumValue)
		{
			switch (enumValue)
			{
				case CompetitionSearchParameterLevel.Low: return "LOW";
				case CompetitionSearchParameterLevel.Medium: return "MEDIUM";
				case CompetitionSearchParameterLevel.High: return "HIGH";
				default: return null;
			}
		}
		public static CompetitionSearchParameterLevel Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "LOW": return CompetitionSearchParameterLevel.Low;
				case "MEDIUM": return CompetitionSearchParameterLevel.Medium;
				case "HIGH": return CompetitionSearchParameterLevel.High;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CompetitionSearchParameterLevel.", nameof(xmlValue));
			}
		}
	}
	public static class ConstantDataServiceUserInterestTaxonomyTypeExtensions
	{
		public static string ToXmlValue(this ConstantDataServiceUserInterestTaxonomyType enumValue)
		{
			switch (enumValue)
			{
				case ConstantDataServiceUserInterestTaxonomyType.Brand: return "BRAND";
				case ConstantDataServiceUserInterestTaxonomyType.InMarket: return "IN_MARKET";
				case ConstantDataServiceUserInterestTaxonomyType.MobileAppInstallUser: return "MOBILE_APP_INSTALL_USER";
				case ConstantDataServiceUserInterestTaxonomyType.VerticalGeo: return "VERTICAL_GEO";
				case ConstantDataServiceUserInterestTaxonomyType.NewSmartPhoneUser: return "NEW_SMART_PHONE_USER";
				default: return null;
			}
		}
		public static ConstantDataServiceUserInterestTaxonomyType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BRAND": return ConstantDataServiceUserInterestTaxonomyType.Brand;
				case "IN_MARKET": return ConstantDataServiceUserInterestTaxonomyType.InMarket;
				case "MOBILE_APP_INSTALL_USER": return ConstantDataServiceUserInterestTaxonomyType.MobileAppInstallUser;
				case "VERTICAL_GEO": return ConstantDataServiceUserInterestTaxonomyType.VerticalGeo;
				case "NEW_SMART_PHONE_USER": return ConstantDataServiceUserInterestTaxonomyType.NewSmartPhoneUser;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConstantDataServiceUserInterestTaxonomyType.", nameof(xmlValue));
			}
		}
	}
	public static class ConstantOperandConstantTypeExtensions
	{
		public static string ToXmlValue(this ConstantOperandConstantType enumValue)
		{
			switch (enumValue)
			{
				case ConstantOperandConstantType.Boolean: return "BOOLEAN";
				case ConstantOperandConstantType.Double: return "DOUBLE";
				case ConstantOperandConstantType.Long: return "LONG";
				case ConstantOperandConstantType.String: return "STRING";
				default: return null;
			}
		}
		public static ConstantOperandConstantType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BOOLEAN": return ConstantOperandConstantType.Boolean;
				case "DOUBLE": return ConstantOperandConstantType.Double;
				case "LONG": return ConstantOperandConstantType.Long;
				case "STRING": return ConstantOperandConstantType.String;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConstantOperandConstantType.", nameof(xmlValue));
			}
		}
	}
	public static class ConstantOperandUnitExtensions
	{
		public static string ToXmlValue(this ConstantOperandUnit enumValue)
		{
			switch (enumValue)
			{
				case ConstantOperandUnit.Meters: return "METERS";
				case ConstantOperandUnit.Miles: return "MILES";
				case ConstantOperandUnit.None: return "NONE";
				default: return null;
			}
		}
		public static ConstantOperandUnit Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "METERS": return ConstantOperandUnit.Meters;
				case "MILES": return ConstantOperandUnit.Miles;
				case "NONE": return ConstantOperandUnit.None;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConstantOperandUnit.", nameof(xmlValue));
			}
		}
	}
	public static class ContentLabelTypeExtensions
	{
		public static string ToXmlValue(this ContentLabelType enumValue)
		{
			switch (enumValue)
			{
				case ContentLabelType.Adultish: return "ADULTISH";
				case ContentLabelType.Afe: return "AFE";
				case ContentLabelType.BelowTheFold: return "BELOW_THE_FOLD";
				case ContentLabelType.Conflict: return "CONFLICT";
				case ContentLabelType.Dp: return "DP";
				case ContentLabelType.EmbeddedVideo: return "EMBEDDED_VIDEO";
				case ContentLabelType.Games: return "GAMES";
				case ContentLabelType.Juvenile: return "JUVENILE";
				case ContentLabelType.Profanity: return "PROFANITY";
				case ContentLabelType.UgcForums: return "UGC_FORUMS";
				case ContentLabelType.UgcImages: return "UGC_IMAGES";
				case ContentLabelType.UgcSocial: return "UGC_SOCIAL";
				case ContentLabelType.UgcVideos: return "UGC_VIDEOS";
				case ContentLabelType.Sirens: return "SIRENS";
				case ContentLabelType.Tragedy: return "TRAGEDY";
				case ContentLabelType.Video: return "VIDEO";
				case ContentLabelType.VideoRatingDvG: return "VIDEO_RATING_DV_G";
				case ContentLabelType.VideoRatingDvPg: return "VIDEO_RATING_DV_PG";
				case ContentLabelType.VideoRatingDvT: return "VIDEO_RATING_DV_T";
				case ContentLabelType.VideoRatingDvMa: return "VIDEO_RATING_DV_MA";
				case ContentLabelType.VideoNotYetRated: return "VIDEO_NOT_YET_RATED";
				case ContentLabelType.LiveStreamingVideo: return "LIVE_STREAMING_VIDEO";
				case ContentLabelType.AllowedGamblingContent: return "ALLOWED_GAMBLING_CONTENT";
				case ContentLabelType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ContentLabelType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ADULTISH": return ContentLabelType.Adultish;
				case "AFE": return ContentLabelType.Afe;
				case "BELOW_THE_FOLD": return ContentLabelType.BelowTheFold;
				case "CONFLICT": return ContentLabelType.Conflict;
				case "DP": return ContentLabelType.Dp;
				case "EMBEDDED_VIDEO": return ContentLabelType.EmbeddedVideo;
				case "GAMES": return ContentLabelType.Games;
				case "JUVENILE": return ContentLabelType.Juvenile;
				case "PROFANITY": return ContentLabelType.Profanity;
				case "UGC_FORUMS": return ContentLabelType.UgcForums;
				case "UGC_IMAGES": return ContentLabelType.UgcImages;
				case "UGC_SOCIAL": return ContentLabelType.UgcSocial;
				case "UGC_VIDEOS": return ContentLabelType.UgcVideos;
				case "SIRENS": return ContentLabelType.Sirens;
				case "TRAGEDY": return ContentLabelType.Tragedy;
				case "VIDEO": return ContentLabelType.Video;
				case "VIDEO_RATING_DV_G": return ContentLabelType.VideoRatingDvG;
				case "VIDEO_RATING_DV_PG": return ContentLabelType.VideoRatingDvPg;
				case "VIDEO_RATING_DV_T": return ContentLabelType.VideoRatingDvT;
				case "VIDEO_RATING_DV_MA": return ContentLabelType.VideoRatingDvMa;
				case "VIDEO_NOT_YET_RATED": return ContentLabelType.VideoNotYetRated;
				case "LIVE_STREAMING_VIDEO": return ContentLabelType.LiveStreamingVideo;
				case "ALLOWED_GAMBLING_CONTENT": return ContentLabelType.AllowedGamblingContent;
				case "UNKNOWN": return ContentLabelType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ContentLabelType.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionDeduplicationModeExtensions
	{
		public static string ToXmlValue(this ConversionDeduplicationMode enumValue)
		{
			switch (enumValue)
			{
				case ConversionDeduplicationMode.OnePerClick: return "ONE_PER_CLICK";
				case ConversionDeduplicationMode.ManyPerClick: return "MANY_PER_CLICK";
				default: return null;
			}
		}
		public static ConversionDeduplicationMode Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ONE_PER_CLICK": return ConversionDeduplicationMode.OnePerClick;
				case "MANY_PER_CLICK": return ConversionDeduplicationMode.ManyPerClick;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionDeduplicationMode.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionOptimizerBiddingSchemeBidTypeExtensions
	{
		public static string ToXmlValue(this ConversionOptimizerBiddingSchemeBidType enumValue)
		{
			switch (enumValue)
			{
				case ConversionOptimizerBiddingSchemeBidType.TargetCpa: return "TARGET_CPA";
				default: return null;
			}
		}
		public static ConversionOptimizerBiddingSchemeBidType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "TARGET_CPA": return ConversionOptimizerBiddingSchemeBidType.TargetCpa;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionOptimizerBiddingSchemeBidType.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionOptimizerBiddingSchemePricingModeExtensions
	{
		public static string ToXmlValue(this ConversionOptimizerBiddingSchemePricingMode enumValue)
		{
			switch (enumValue)
			{
				case ConversionOptimizerBiddingSchemePricingMode.Clicks: return "CLICKS";
				case ConversionOptimizerBiddingSchemePricingMode.Conversions: return "CONVERSIONS";
				default: return null;
			}
		}
		public static ConversionOptimizerBiddingSchemePricingMode Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CLICKS": return ConversionOptimizerBiddingSchemePricingMode.Clicks;
				case "CONVERSIONS": return ConversionOptimizerBiddingSchemePricingMode.Conversions;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionOptimizerBiddingSchemePricingMode.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionOptimizerEligibilityRejectionReasonExtensions
	{
		public static string ToXmlValue(this ConversionOptimizerEligibilityRejectionReason enumValue)
		{
			switch (enumValue)
			{
				case ConversionOptimizerEligibilityRejectionReason.CampaignIsNotActive: return "CAMPAIGN_IS_NOT_ACTIVE";
				case ConversionOptimizerEligibilityRejectionReason.NotCpcCampaign: return "NOT_CPC_CAMPAIGN";
				case ConversionOptimizerEligibilityRejectionReason.ConversionTrackingNotEnabled: return "CONVERSION_TRACKING_NOT_ENABLED";
				case ConversionOptimizerEligibilityRejectionReason.NotEnoughConversions: return "NOT_ENOUGH_CONVERSIONS";
				case ConversionOptimizerEligibilityRejectionReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ConversionOptimizerEligibilityRejectionReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CAMPAIGN_IS_NOT_ACTIVE": return ConversionOptimizerEligibilityRejectionReason.CampaignIsNotActive;
				case "NOT_CPC_CAMPAIGN": return ConversionOptimizerEligibilityRejectionReason.NotCpcCampaign;
				case "CONVERSION_TRACKING_NOT_ENABLED": return ConversionOptimizerEligibilityRejectionReason.ConversionTrackingNotEnabled;
				case "NOT_ENOUGH_CONVERSIONS": return ConversionOptimizerEligibilityRejectionReason.NotEnoughConversions;
				case "UNKNOWN": return ConversionOptimizerEligibilityRejectionReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionOptimizerEligibilityRejectionReason.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionTrackerCategoryExtensions
	{
		public static string ToXmlValue(this ConversionTrackerCategory enumValue)
		{
			switch (enumValue)
			{
				case ConversionTrackerCategory.Default: return "DEFAULT";
				case ConversionTrackerCategory.PageView: return "PAGE_VIEW";
				case ConversionTrackerCategory.Purchase: return "PURCHASE";
				case ConversionTrackerCategory.Signup: return "SIGNUP";
				case ConversionTrackerCategory.Lead: return "LEAD";
				case ConversionTrackerCategory.Remarketing: return "REMARKETING";
				case ConversionTrackerCategory.Download: return "DOWNLOAD";
				default: return null;
			}
		}
		public static ConversionTrackerCategory Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DEFAULT": return ConversionTrackerCategory.Default;
				case "PAGE_VIEW": return ConversionTrackerCategory.PageView;
				case "PURCHASE": return ConversionTrackerCategory.Purchase;
				case "SIGNUP": return ConversionTrackerCategory.Signup;
				case "LEAD": return ConversionTrackerCategory.Lead;
				case "REMARKETING": return ConversionTrackerCategory.Remarketing;
				case "DOWNLOAD": return ConversionTrackerCategory.Download;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionTrackerCategory.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionTrackerStatusExtensions
	{
		public static string ToXmlValue(this ConversionTrackerStatus enumValue)
		{
			switch (enumValue)
			{
				case ConversionTrackerStatus.Enabled: return "ENABLED";
				case ConversionTrackerStatus.Disabled: return "DISABLED";
				case ConversionTrackerStatus.Hidden: return "HIDDEN";
				default: return null;
			}
		}
		public static ConversionTrackerStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return ConversionTrackerStatus.Enabled;
				case "DISABLED": return ConversionTrackerStatus.Disabled;
				case "HIDDEN": return ConversionTrackerStatus.Hidden;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionTrackerStatus.", nameof(xmlValue));
			}
		}
	}
	public static class ConversionTrackingErrorReasonExtensions
	{
		public static string ToXmlValue(this ConversionTrackingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ConversionTrackingErrorReason.AlreadyCreatedCustomConversionType: return "ALREADY_CREATED_CUSTOM_CONVERSION_TYPE";
				case ConversionTrackingErrorReason.AnalyticsNotAllowed: return "ANALYTICS_NOT_ALLOWED";
				case ConversionTrackingErrorReason.CannotAddConversionTypeSubclass: return "CANNOT_ADD_CONVERSION_TYPE_SUBCLASS";
				case ConversionTrackingErrorReason.CannotChangeAppConversionType: return "CANNOT_CHANGE_APP_CONVERSION_TYPE";
				case ConversionTrackingErrorReason.CannotChangeAppPlatform: return "CANNOT_CHANGE_APP_PLATFORM";
				case ConversionTrackingErrorReason.CannnotChangeConversionSubclass: return "CANNNOT_CHANGE_CONVERSION_SUBCLASS";
				case ConversionTrackingErrorReason.CannotSetHiddenStatus: return "CANNOT_SET_HIDDEN_STATUS";
				case ConversionTrackingErrorReason.CategoryIsUneditable: return "CATEGORY_IS_UNEDITABLE";
				case ConversionTrackingErrorReason.AttributionModelIsUneditable: return "ATTRIBUTION_MODEL_IS_UNEDITABLE";
				case ConversionTrackingErrorReason.DataDrivenModelWasNeverGenerated: return "DATA_DRIVEN_MODEL_WAS_NEVER_GENERATED";
				case ConversionTrackingErrorReason.DataDrivenModelIsExpired: return "DATA_DRIVEN_MODEL_IS_EXPIRED";
				case ConversionTrackingErrorReason.DataDrivenModelIsStale: return "DATA_DRIVEN_MODEL_IS_STALE";
				case ConversionTrackingErrorReason.DataDrivenModelIsUnknown: return "DATA_DRIVEN_MODEL_IS_UNKNOWN";
				case ConversionTrackingErrorReason.ConversionTypeNotFound: return "CONVERSION_TYPE_NOT_FOUND";
				case ConversionTrackingErrorReason.CtcLookbackWindowIsUneditable: return "CTC_LOOKBACK_WINDOW_IS_UNEDITABLE";
				case ConversionTrackingErrorReason.DomainException: return "DOMAIN_EXCEPTION";
				case ConversionTrackingErrorReason.InconsistentCountingType: return "INCONSISTENT_COUNTING_TYPE";
				case ConversionTrackingErrorReason.DuplicateAppId: return "DUPLICATE_APP_ID";
				case ConversionTrackingErrorReason.DuplicateName: return "DUPLICATE_NAME";
				case ConversionTrackingErrorReason.EmailFailed: return "EMAIL_FAILED";
				case ConversionTrackingErrorReason.ExceededConversionTypeLimit: return "EXCEEDED_CONVERSION_TYPE_LIMIT";
				case ConversionTrackingErrorReason.IdIsNull: return "ID_IS_NULL";
				case ConversionTrackingErrorReason.InvalidAppId: return "INVALID_APP_ID";
				case ConversionTrackingErrorReason.CannotSetAppId: return "CANNOT_SET_APP_ID";
				case ConversionTrackingErrorReason.InvalidColor: return "INVALID_COLOR";
				case ConversionTrackingErrorReason.InvalidDateRange: return "INVALID_DATE_RANGE";
				case ConversionTrackingErrorReason.InvalidEmailAddress: return "INVALID_EMAIL_ADDRESS";
				case ConversionTrackingErrorReason.InvalidOriginalConversionTypeId: return "INVALID_ORIGINAL_CONVERSION_TYPE_ID";
				case ConversionTrackingErrorReason.MustSetAppPlatformAndAppConversionTypeTogether: return "MUST_SET_APP_PLATFORM_AND_APP_CONVERSION_TYPE_TOGETHER";
				case ConversionTrackingErrorReason.NameAlreadyExists: return "NAME_ALREADY_EXISTS";
				case ConversionTrackingErrorReason.NoRecipients: return "NO_RECIPIENTS";
				case ConversionTrackingErrorReason.NoSnippet: return "NO_SNIPPET";
				case ConversionTrackingErrorReason.TooManyWebpages: return "TOO_MANY_WEBPAGES";
				case ConversionTrackingErrorReason.UnknownSortingType: return "UNKNOWN_SORTING_TYPE";
				case ConversionTrackingErrorReason.UnsupportedAppConversionType: return "UNSUPPORTED_APP_CONVERSION_TYPE";
				default: return null;
			}
		}
		public static ConversionTrackingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ALREADY_CREATED_CUSTOM_CONVERSION_TYPE": return ConversionTrackingErrorReason.AlreadyCreatedCustomConversionType;
				case "ANALYTICS_NOT_ALLOWED": return ConversionTrackingErrorReason.AnalyticsNotAllowed;
				case "CANNOT_ADD_CONVERSION_TYPE_SUBCLASS": return ConversionTrackingErrorReason.CannotAddConversionTypeSubclass;
				case "CANNOT_CHANGE_APP_CONVERSION_TYPE": return ConversionTrackingErrorReason.CannotChangeAppConversionType;
				case "CANNOT_CHANGE_APP_PLATFORM": return ConversionTrackingErrorReason.CannotChangeAppPlatform;
				case "CANNNOT_CHANGE_CONVERSION_SUBCLASS": return ConversionTrackingErrorReason.CannnotChangeConversionSubclass;
				case "CANNOT_SET_HIDDEN_STATUS": return ConversionTrackingErrorReason.CannotSetHiddenStatus;
				case "CATEGORY_IS_UNEDITABLE": return ConversionTrackingErrorReason.CategoryIsUneditable;
				case "ATTRIBUTION_MODEL_IS_UNEDITABLE": return ConversionTrackingErrorReason.AttributionModelIsUneditable;
				case "DATA_DRIVEN_MODEL_WAS_NEVER_GENERATED": return ConversionTrackingErrorReason.DataDrivenModelWasNeverGenerated;
				case "DATA_DRIVEN_MODEL_IS_EXPIRED": return ConversionTrackingErrorReason.DataDrivenModelIsExpired;
				case "DATA_DRIVEN_MODEL_IS_STALE": return ConversionTrackingErrorReason.DataDrivenModelIsStale;
				case "DATA_DRIVEN_MODEL_IS_UNKNOWN": return ConversionTrackingErrorReason.DataDrivenModelIsUnknown;
				case "CONVERSION_TYPE_NOT_FOUND": return ConversionTrackingErrorReason.ConversionTypeNotFound;
				case "CTC_LOOKBACK_WINDOW_IS_UNEDITABLE": return ConversionTrackingErrorReason.CtcLookbackWindowIsUneditable;
				case "DOMAIN_EXCEPTION": return ConversionTrackingErrorReason.DomainException;
				case "INCONSISTENT_COUNTING_TYPE": return ConversionTrackingErrorReason.InconsistentCountingType;
				case "DUPLICATE_APP_ID": return ConversionTrackingErrorReason.DuplicateAppId;
				case "DUPLICATE_NAME": return ConversionTrackingErrorReason.DuplicateName;
				case "EMAIL_FAILED": return ConversionTrackingErrorReason.EmailFailed;
				case "EXCEEDED_CONVERSION_TYPE_LIMIT": return ConversionTrackingErrorReason.ExceededConversionTypeLimit;
				case "ID_IS_NULL": return ConversionTrackingErrorReason.IdIsNull;
				case "INVALID_APP_ID": return ConversionTrackingErrorReason.InvalidAppId;
				case "CANNOT_SET_APP_ID": return ConversionTrackingErrorReason.CannotSetAppId;
				case "INVALID_COLOR": return ConversionTrackingErrorReason.InvalidColor;
				case "INVALID_DATE_RANGE": return ConversionTrackingErrorReason.InvalidDateRange;
				case "INVALID_EMAIL_ADDRESS": return ConversionTrackingErrorReason.InvalidEmailAddress;
				case "INVALID_ORIGINAL_CONVERSION_TYPE_ID": return ConversionTrackingErrorReason.InvalidOriginalConversionTypeId;
				case "MUST_SET_APP_PLATFORM_AND_APP_CONVERSION_TYPE_TOGETHER": return ConversionTrackingErrorReason.MustSetAppPlatformAndAppConversionTypeTogether;
				case "NAME_ALREADY_EXISTS": return ConversionTrackingErrorReason.NameAlreadyExists;
				case "NO_RECIPIENTS": return ConversionTrackingErrorReason.NoRecipients;
				case "NO_SNIPPET": return ConversionTrackingErrorReason.NoSnippet;
				case "TOO_MANY_WEBPAGES": return ConversionTrackingErrorReason.TooManyWebpages;
				case "UNKNOWN_SORTING_TYPE": return ConversionTrackingErrorReason.UnknownSortingType;
				case "UNSUPPORTED_APP_CONVERSION_TYPE": return ConversionTrackingErrorReason.UnsupportedAppConversionType;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ConversionTrackingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CriterionErrorReasonExtensions
	{
		public static string ToXmlValue(this CriterionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CriterionErrorReason.ConcreteTypeRequired: return "CONCRETE_TYPE_REQUIRED";
				case CriterionErrorReason.InvalidExcludedCategory: return "INVALID_EXCLUDED_CATEGORY";
				case CriterionErrorReason.InvalidKeywordText: return "INVALID_KEYWORD_TEXT";
				case CriterionErrorReason.KeywordTextTooLong: return "KEYWORD_TEXT_TOO_LONG";
				case CriterionErrorReason.KeywordHasTooManyWords: return "KEYWORD_HAS_TOO_MANY_WORDS";
				case CriterionErrorReason.KeywordHasInvalidChars: return "KEYWORD_HAS_INVALID_CHARS";
				case CriterionErrorReason.InvalidPlacementUrl: return "INVALID_PLACEMENT_URL";
				case CriterionErrorReason.InvalidUserList: return "INVALID_USER_LIST";
				case CriterionErrorReason.InvalidUserInterest: return "INVALID_USER_INTEREST";
				case CriterionErrorReason.InvalidFormatForPlacementUrl: return "INVALID_FORMAT_FOR_PLACEMENT_URL";
				case CriterionErrorReason.PlacementUrlIsTooLong: return "PLACEMENT_URL_IS_TOO_LONG";
				case CriterionErrorReason.PlacementUrlHasIllegalChar: return "PLACEMENT_URL_HAS_ILLEGAL_CHAR";
				case CriterionErrorReason.PlacementUrlHasMultipleSitesInLine: return "PLACEMENT_URL_HAS_MULTIPLE_SITES_IN_LINE";
				case CriterionErrorReason.PlacementIsNotAvailableForTargetingOrExclusion: return "PLACEMENT_IS_NOT_AVAILABLE_FOR_TARGETING_OR_EXCLUSION";
				case CriterionErrorReason.InvalidVerticalPath: return "INVALID_VERTICAL_PATH";
				case CriterionErrorReason.YoutubeVerticalChannelDeprecated: return "YOUTUBE_VERTICAL_CHANNEL_DEPRECATED";
				case CriterionErrorReason.YoutubeDemographicChannelDeprecated: return "YOUTUBE_DEMOGRAPHIC_CHANNEL_DEPRECATED";
				case CriterionErrorReason.YoutubeUrlUnsupported: return "YOUTUBE_URL_UNSUPPORTED";
				case CriterionErrorReason.CannotExcludeCriteriaType: return "CANNOT_EXCLUDE_CRITERIA_TYPE";
				case CriterionErrorReason.CannotAddCriteriaType: return "CANNOT_ADD_CRITERIA_TYPE";
				case CriterionErrorReason.InvalidProductFilter: return "INVALID_PRODUCT_FILTER";
				case CriterionErrorReason.ProductFilterTooLong: return "PRODUCT_FILTER_TOO_LONG";
				case CriterionErrorReason.CannotExcludeSimilarUserList: return "CANNOT_EXCLUDE_SIMILAR_USER_LIST";
				case CriterionErrorReason.CannotAddDisplayOnlyListsToSearchOnlyCampaigns: return "CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_ONLY_CAMPAIGNS";
				case CriterionErrorReason.CannotAddDisplayOnlyListsToSearchCampaigns: return "CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_CAMPAIGNS";
				case CriterionErrorReason.CannotAddUserInterestsToSearchCampaigns: return "CANNOT_ADD_USER_INTERESTS_TO_SEARCH_CAMPAIGNS";
				case CriterionErrorReason.CannotSetBidsOnCriterionTypeInSearchCampaigns: return "CANNOT_SET_BIDS_ON_CRITERION_TYPE_IN_SEARCH_CAMPAIGNS";
				case CriterionErrorReason.CannotAddDestinationUrlToCriterionTypeInSearchCampaigns: return "CANNOT_ADD_DESTINATION_URL_TO_CRITERION_TYPE_IN_SEARCH_CAMPAIGNS";
				case CriterionErrorReason.InvalidIpAddress: return "INVALID_IP_ADDRESS";
				case CriterionErrorReason.InvalidIpFormat: return "INVALID_IP_FORMAT";
				case CriterionErrorReason.InvalidMobileApp: return "INVALID_MOBILE_APP";
				case CriterionErrorReason.InvalidMobileAppCategory: return "INVALID_MOBILE_APP_CATEGORY";
				case CriterionErrorReason.InvalidCriterionId: return "INVALID_CRITERION_ID";
				case CriterionErrorReason.CannotTargetCriterion: return "CANNOT_TARGET_CRITERION";
				case CriterionErrorReason.CannotTargetObsoleteCriterion: return "CANNOT_TARGET_OBSOLETE_CRITERION";
				case CriterionErrorReason.CriterionIdAndTypeMismatch: return "CRITERION_ID_AND_TYPE_MISMATCH";
				case CriterionErrorReason.InvalidProximityRadius: return "INVALID_PROXIMITY_RADIUS";
				case CriterionErrorReason.InvalidProximityRadiusUnits: return "INVALID_PROXIMITY_RADIUS_UNITS";
				case CriterionErrorReason.InvalidStreetaddressLength: return "INVALID_STREETADDRESS_LENGTH";
				case CriterionErrorReason.InvalidCitynameLength: return "INVALID_CITYNAME_LENGTH";
				case CriterionErrorReason.InvalidRegioncodeLength: return "INVALID_REGIONCODE_LENGTH";
				case CriterionErrorReason.InvalidRegionnameLength: return "INVALID_REGIONNAME_LENGTH";
				case CriterionErrorReason.InvalidPostalcodeLength: return "INVALID_POSTALCODE_LENGTH";
				case CriterionErrorReason.InvalidCountryCode: return "INVALID_COUNTRY_CODE";
				case CriterionErrorReason.InvalidLatitude: return "INVALID_LATITUDE";
				case CriterionErrorReason.InvalidLongitude: return "INVALID_LONGITUDE";
				case CriterionErrorReason.ProximityGeopointAndAddressBothCannotBeNull: return "PROXIMITY_GEOPOINT_AND_ADDRESS_BOTH_CANNOT_BE_NULL";
				case CriterionErrorReason.InvalidProximityAddress: return "INVALID_PROXIMITY_ADDRESS";
				case CriterionErrorReason.InvalidUserDomainName: return "INVALID_USER_DOMAIN_NAME";
				case CriterionErrorReason.CriterionParameterTooLong: return "CRITERION_PARAMETER_TOO_LONG";
				case CriterionErrorReason.AdScheduleTimeIntervalsOverlap: return "AD_SCHEDULE_TIME_INTERVALS_OVERLAP";
				case CriterionErrorReason.AdScheduleIntervalCannotSpanMultipleDays: return "AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS";
				case CriterionErrorReason.AdScheduleInvalidTimeInterval: return "AD_SCHEDULE_INVALID_TIME_INTERVAL";
				case CriterionErrorReason.AdScheduleExceededIntervalsPerDayLimit: return "AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT";
				case CriterionErrorReason.AdScheduleCriterionIdMismatchingFields: return "AD_SCHEDULE_CRITERION_ID_MISMATCHING_FIELDS";
				case CriterionErrorReason.CannotBidModifyCriterionType: return "CANNOT_BID_MODIFY_CRITERION_TYPE";
				case CriterionErrorReason.CannotBidModifyCriterionCampaignOptedOut: return "CANNOT_BID_MODIFY_CRITERION_CAMPAIGN_OPTED_OUT";
				case CriterionErrorReason.CannotBidModifyNegativeCriterion: return "CANNOT_BID_MODIFY_NEGATIVE_CRITERION";
				case CriterionErrorReason.BidModifierAlreadyExists: return "BID_MODIFIER_ALREADY_EXISTS";
				case CriterionErrorReason.FeedIdNotAllowed: return "FEED_ID_NOT_ALLOWED";
				case CriterionErrorReason.AccountIneligibleForCriteriaType: return "ACCOUNT_INELIGIBLE_FOR_CRITERIA_TYPE";
				case CriterionErrorReason.CriteriaTypeInvalidForBiddingStrategy: return "CRITERIA_TYPE_INVALID_FOR_BIDDING_STRATEGY";
				case CriterionErrorReason.CannotExcludeCriterion: return "CANNOT_EXCLUDE_CRITERION";
				case CriterionErrorReason.CannotRemoveCriterion: return "CANNOT_REMOVE_CRITERION";
				case CriterionErrorReason.ProductScopeTooLong: return "PRODUCT_SCOPE_TOO_LONG";
				case CriterionErrorReason.ProductScopeTooManyDimensions: return "PRODUCT_SCOPE_TOO_MANY_DIMENSIONS";
				case CriterionErrorReason.ProductPartitionTooLong: return "PRODUCT_PARTITION_TOO_LONG";
				case CriterionErrorReason.ProductPartitionTooManyDimensions: return "PRODUCT_PARTITION_TOO_MANY_DIMENSIONS";
				case CriterionErrorReason.InvalidProductDimension: return "INVALID_PRODUCT_DIMENSION";
				case CriterionErrorReason.InvalidProductDimensionType: return "INVALID_PRODUCT_DIMENSION_TYPE";
				case CriterionErrorReason.InvalidProductBiddingCategory: return "INVALID_PRODUCT_BIDDING_CATEGORY";
				case CriterionErrorReason.MissingShoppingSetting: return "MISSING_SHOPPING_SETTING";
				case CriterionErrorReason.InvalidMatchingFunction: return "INVALID_MATCHING_FUNCTION";
				case CriterionErrorReason.LocationFilterNotAllowed: return "LOCATION_FILTER_NOT_ALLOWED";
				case CriterionErrorReason.LocationFilterInvalid: return "LOCATION_FILTER_INVALID";
				case CriterionErrorReason.CannotAttachCriteriaAtCampaignAndAdgroup: return "CANNOT_ATTACH_CRITERIA_AT_CAMPAIGN_AND_ADGROUP";
				case CriterionErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CriterionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CONCRETE_TYPE_REQUIRED": return CriterionErrorReason.ConcreteTypeRequired;
				case "INVALID_EXCLUDED_CATEGORY": return CriterionErrorReason.InvalidExcludedCategory;
				case "INVALID_KEYWORD_TEXT": return CriterionErrorReason.InvalidKeywordText;
				case "KEYWORD_TEXT_TOO_LONG": return CriterionErrorReason.KeywordTextTooLong;
				case "KEYWORD_HAS_TOO_MANY_WORDS": return CriterionErrorReason.KeywordHasTooManyWords;
				case "KEYWORD_HAS_INVALID_CHARS": return CriterionErrorReason.KeywordHasInvalidChars;
				case "INVALID_PLACEMENT_URL": return CriterionErrorReason.InvalidPlacementUrl;
				case "INVALID_USER_LIST": return CriterionErrorReason.InvalidUserList;
				case "INVALID_USER_INTEREST": return CriterionErrorReason.InvalidUserInterest;
				case "INVALID_FORMAT_FOR_PLACEMENT_URL": return CriterionErrorReason.InvalidFormatForPlacementUrl;
				case "PLACEMENT_URL_IS_TOO_LONG": return CriterionErrorReason.PlacementUrlIsTooLong;
				case "PLACEMENT_URL_HAS_ILLEGAL_CHAR": return CriterionErrorReason.PlacementUrlHasIllegalChar;
				case "PLACEMENT_URL_HAS_MULTIPLE_SITES_IN_LINE": return CriterionErrorReason.PlacementUrlHasMultipleSitesInLine;
				case "PLACEMENT_IS_NOT_AVAILABLE_FOR_TARGETING_OR_EXCLUSION": return CriterionErrorReason.PlacementIsNotAvailableForTargetingOrExclusion;
				case "INVALID_VERTICAL_PATH": return CriterionErrorReason.InvalidVerticalPath;
				case "YOUTUBE_VERTICAL_CHANNEL_DEPRECATED": return CriterionErrorReason.YoutubeVerticalChannelDeprecated;
				case "YOUTUBE_DEMOGRAPHIC_CHANNEL_DEPRECATED": return CriterionErrorReason.YoutubeDemographicChannelDeprecated;
				case "YOUTUBE_URL_UNSUPPORTED": return CriterionErrorReason.YoutubeUrlUnsupported;
				case "CANNOT_EXCLUDE_CRITERIA_TYPE": return CriterionErrorReason.CannotExcludeCriteriaType;
				case "CANNOT_ADD_CRITERIA_TYPE": return CriterionErrorReason.CannotAddCriteriaType;
				case "INVALID_PRODUCT_FILTER": return CriterionErrorReason.InvalidProductFilter;
				case "PRODUCT_FILTER_TOO_LONG": return CriterionErrorReason.ProductFilterTooLong;
				case "CANNOT_EXCLUDE_SIMILAR_USER_LIST": return CriterionErrorReason.CannotExcludeSimilarUserList;
				case "CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_ONLY_CAMPAIGNS": return CriterionErrorReason.CannotAddDisplayOnlyListsToSearchOnlyCampaigns;
				case "CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_CAMPAIGNS": return CriterionErrorReason.CannotAddDisplayOnlyListsToSearchCampaigns;
				case "CANNOT_ADD_USER_INTERESTS_TO_SEARCH_CAMPAIGNS": return CriterionErrorReason.CannotAddUserInterestsToSearchCampaigns;
				case "CANNOT_SET_BIDS_ON_CRITERION_TYPE_IN_SEARCH_CAMPAIGNS": return CriterionErrorReason.CannotSetBidsOnCriterionTypeInSearchCampaigns;
				case "CANNOT_ADD_DESTINATION_URL_TO_CRITERION_TYPE_IN_SEARCH_CAMPAIGNS": return CriterionErrorReason.CannotAddDestinationUrlToCriterionTypeInSearchCampaigns;
				case "INVALID_IP_ADDRESS": return CriterionErrorReason.InvalidIpAddress;
				case "INVALID_IP_FORMAT": return CriterionErrorReason.InvalidIpFormat;
				case "INVALID_MOBILE_APP": return CriterionErrorReason.InvalidMobileApp;
				case "INVALID_MOBILE_APP_CATEGORY": return CriterionErrorReason.InvalidMobileAppCategory;
				case "INVALID_CRITERION_ID": return CriterionErrorReason.InvalidCriterionId;
				case "CANNOT_TARGET_CRITERION": return CriterionErrorReason.CannotTargetCriterion;
				case "CANNOT_TARGET_OBSOLETE_CRITERION": return CriterionErrorReason.CannotTargetObsoleteCriterion;
				case "CRITERION_ID_AND_TYPE_MISMATCH": return CriterionErrorReason.CriterionIdAndTypeMismatch;
				case "INVALID_PROXIMITY_RADIUS": return CriterionErrorReason.InvalidProximityRadius;
				case "INVALID_PROXIMITY_RADIUS_UNITS": return CriterionErrorReason.InvalidProximityRadiusUnits;
				case "INVALID_STREETADDRESS_LENGTH": return CriterionErrorReason.InvalidStreetaddressLength;
				case "INVALID_CITYNAME_LENGTH": return CriterionErrorReason.InvalidCitynameLength;
				case "INVALID_REGIONCODE_LENGTH": return CriterionErrorReason.InvalidRegioncodeLength;
				case "INVALID_REGIONNAME_LENGTH": return CriterionErrorReason.InvalidRegionnameLength;
				case "INVALID_POSTALCODE_LENGTH": return CriterionErrorReason.InvalidPostalcodeLength;
				case "INVALID_COUNTRY_CODE": return CriterionErrorReason.InvalidCountryCode;
				case "INVALID_LATITUDE": return CriterionErrorReason.InvalidLatitude;
				case "INVALID_LONGITUDE": return CriterionErrorReason.InvalidLongitude;
				case "PROXIMITY_GEOPOINT_AND_ADDRESS_BOTH_CANNOT_BE_NULL": return CriterionErrorReason.ProximityGeopointAndAddressBothCannotBeNull;
				case "INVALID_PROXIMITY_ADDRESS": return CriterionErrorReason.InvalidProximityAddress;
				case "INVALID_USER_DOMAIN_NAME": return CriterionErrorReason.InvalidUserDomainName;
				case "CRITERION_PARAMETER_TOO_LONG": return CriterionErrorReason.CriterionParameterTooLong;
				case "AD_SCHEDULE_TIME_INTERVALS_OVERLAP": return CriterionErrorReason.AdScheduleTimeIntervalsOverlap;
				case "AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS": return CriterionErrorReason.AdScheduleIntervalCannotSpanMultipleDays;
				case "AD_SCHEDULE_INVALID_TIME_INTERVAL": return CriterionErrorReason.AdScheduleInvalidTimeInterval;
				case "AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT": return CriterionErrorReason.AdScheduleExceededIntervalsPerDayLimit;
				case "AD_SCHEDULE_CRITERION_ID_MISMATCHING_FIELDS": return CriterionErrorReason.AdScheduleCriterionIdMismatchingFields;
				case "CANNOT_BID_MODIFY_CRITERION_TYPE": return CriterionErrorReason.CannotBidModifyCriterionType;
				case "CANNOT_BID_MODIFY_CRITERION_CAMPAIGN_OPTED_OUT": return CriterionErrorReason.CannotBidModifyCriterionCampaignOptedOut;
				case "CANNOT_BID_MODIFY_NEGATIVE_CRITERION": return CriterionErrorReason.CannotBidModifyNegativeCriterion;
				case "BID_MODIFIER_ALREADY_EXISTS": return CriterionErrorReason.BidModifierAlreadyExists;
				case "FEED_ID_NOT_ALLOWED": return CriterionErrorReason.FeedIdNotAllowed;
				case "ACCOUNT_INELIGIBLE_FOR_CRITERIA_TYPE": return CriterionErrorReason.AccountIneligibleForCriteriaType;
				case "CRITERIA_TYPE_INVALID_FOR_BIDDING_STRATEGY": return CriterionErrorReason.CriteriaTypeInvalidForBiddingStrategy;
				case "CANNOT_EXCLUDE_CRITERION": return CriterionErrorReason.CannotExcludeCriterion;
				case "CANNOT_REMOVE_CRITERION": return CriterionErrorReason.CannotRemoveCriterion;
				case "PRODUCT_SCOPE_TOO_LONG": return CriterionErrorReason.ProductScopeTooLong;
				case "PRODUCT_SCOPE_TOO_MANY_DIMENSIONS": return CriterionErrorReason.ProductScopeTooManyDimensions;
				case "PRODUCT_PARTITION_TOO_LONG": return CriterionErrorReason.ProductPartitionTooLong;
				case "PRODUCT_PARTITION_TOO_MANY_DIMENSIONS": return CriterionErrorReason.ProductPartitionTooManyDimensions;
				case "INVALID_PRODUCT_DIMENSION": return CriterionErrorReason.InvalidProductDimension;
				case "INVALID_PRODUCT_DIMENSION_TYPE": return CriterionErrorReason.InvalidProductDimensionType;
				case "INVALID_PRODUCT_BIDDING_CATEGORY": return CriterionErrorReason.InvalidProductBiddingCategory;
				case "MISSING_SHOPPING_SETTING": return CriterionErrorReason.MissingShoppingSetting;
				case "INVALID_MATCHING_FUNCTION": return CriterionErrorReason.InvalidMatchingFunction;
				case "LOCATION_FILTER_NOT_ALLOWED": return CriterionErrorReason.LocationFilterNotAllowed;
				case "LOCATION_FILTER_INVALID": return CriterionErrorReason.LocationFilterInvalid;
				case "CANNOT_ATTACH_CRITERIA_AT_CAMPAIGN_AND_ADGROUP": return CriterionErrorReason.CannotAttachCriteriaAtCampaignAndAdgroup;
				case "UNKNOWN": return CriterionErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CriterionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CriterionTypeExtensions
	{
		public static string ToXmlValue(this CriterionType enumValue)
		{
			switch (enumValue)
			{
				case CriterionType.ContentLabel: return "CONTENT_LABEL";
				case CriterionType.Keyword: return "KEYWORD";
				case CriterionType.Placement: return "PLACEMENT";
				case CriterionType.Vertical: return "VERTICAL";
				case CriterionType.UserList: return "USER_LIST";
				case CriterionType.UserInterest: return "USER_INTEREST";
				case CriterionType.MobileApplication: return "MOBILE_APPLICATION";
				case CriterionType.MobileAppCategory: return "MOBILE_APP_CATEGORY";
				case CriterionType.ProductPartition: return "PRODUCT_PARTITION";
				case CriterionType.IpBlock: return "IP_BLOCK";
				case CriterionType.Webpage: return "WEBPAGE";
				case CriterionType.Language: return "LANGUAGE";
				case CriterionType.Location: return "LOCATION";
				case CriterionType.AgeRange: return "AGE_RANGE";
				case CriterionType.Carrier: return "CARRIER";
				case CriterionType.OperatingSystemVersion: return "OPERATING_SYSTEM_VERSION";
				case CriterionType.MobileDevice: return "MOBILE_DEVICE";
				case CriterionType.Gender: return "GENDER";
				case CriterionType.Parent: return "PARENT";
				case CriterionType.Proximity: return "PROXIMITY";
				case CriterionType.Platform: return "PLATFORM";
				case CriterionType.PreferredContent: return "PREFERRED_CONTENT";
				case CriterionType.AdSchedule: return "AD_SCHEDULE";
				case CriterionType.LocationGroups: return "LOCATION_GROUPS";
				case CriterionType.ProductScope: return "PRODUCT_SCOPE";
				case CriterionType.YoutubeVideo: return "YOUTUBE_VIDEO";
				case CriterionType.YoutubeChannel: return "YOUTUBE_CHANNEL";
				case CriterionType.AppPaymentModel: return "APP_PAYMENT_MODEL";
				case CriterionType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CriterionType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CONTENT_LABEL": return CriterionType.ContentLabel;
				case "KEYWORD": return CriterionType.Keyword;
				case "PLACEMENT": return CriterionType.Placement;
				case "VERTICAL": return CriterionType.Vertical;
				case "USER_LIST": return CriterionType.UserList;
				case "USER_INTEREST": return CriterionType.UserInterest;
				case "MOBILE_APPLICATION": return CriterionType.MobileApplication;
				case "MOBILE_APP_CATEGORY": return CriterionType.MobileAppCategory;
				case "PRODUCT_PARTITION": return CriterionType.ProductPartition;
				case "IP_BLOCK": return CriterionType.IpBlock;
				case "WEBPAGE": return CriterionType.Webpage;
				case "LANGUAGE": return CriterionType.Language;
				case "LOCATION": return CriterionType.Location;
				case "AGE_RANGE": return CriterionType.AgeRange;
				case "CARRIER": return CriterionType.Carrier;
				case "OPERATING_SYSTEM_VERSION": return CriterionType.OperatingSystemVersion;
				case "MOBILE_DEVICE": return CriterionType.MobileDevice;
				case "GENDER": return CriterionType.Gender;
				case "PARENT": return CriterionType.Parent;
				case "PROXIMITY": return CriterionType.Proximity;
				case "PLATFORM": return CriterionType.Platform;
				case "PREFERRED_CONTENT": return CriterionType.PreferredContent;
				case "AD_SCHEDULE": return CriterionType.AdSchedule;
				case "LOCATION_GROUPS": return CriterionType.LocationGroups;
				case "PRODUCT_SCOPE": return CriterionType.ProductScope;
				case "YOUTUBE_VIDEO": return CriterionType.YoutubeVideo;
				case "YOUTUBE_CHANNEL": return CriterionType.YoutubeChannel;
				case "APP_PAYMENT_MODEL": return CriterionType.AppPaymentModel;
				case "UNKNOWN": return CriterionType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CriterionType.", nameof(xmlValue));
			}
		}
	}
	public static class CriterionTypeGroupExtensions
	{
		public static string ToXmlValue(this CriterionTypeGroup enumValue)
		{
			switch (enumValue)
			{
				case CriterionTypeGroup.Keyword: return "KEYWORD";
				case CriterionTypeGroup.UserInterestAndList: return "USER_INTEREST_AND_LIST";
				case CriterionTypeGroup.Vertical: return "VERTICAL";
				case CriterionTypeGroup.Gender: return "GENDER";
				case CriterionTypeGroup.AgeRange: return "AGE_RANGE";
				case CriterionTypeGroup.Placement: return "PLACEMENT";
				case CriterionTypeGroup.Parent: return "PARENT";
				case CriterionTypeGroup.None: return "NONE";
				case CriterionTypeGroup.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CriterionTypeGroup Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "KEYWORD": return CriterionTypeGroup.Keyword;
				case "USER_INTEREST_AND_LIST": return CriterionTypeGroup.UserInterestAndList;
				case "VERTICAL": return CriterionTypeGroup.Vertical;
				case "GENDER": return CriterionTypeGroup.Gender;
				case "AGE_RANGE": return CriterionTypeGroup.AgeRange;
				case "PLACEMENT": return CriterionTypeGroup.Placement;
				case "PARENT": return CriterionTypeGroup.Parent;
				case "NONE": return CriterionTypeGroup.None;
				case "UNKNOWN": return CriterionTypeGroup.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CriterionTypeGroup.", nameof(xmlValue));
			}
		}
	}
	public static class CriterionUseExtensions
	{
		public static string ToXmlValue(this CriterionUse enumValue)
		{
			switch (enumValue)
			{
				case CriterionUse.Biddable: return "BIDDABLE";
				case CriterionUse.Negative: return "NEGATIVE";
				default: return null;
			}
		}
		public static CriterionUse Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BIDDABLE": return CriterionUse.Biddable;
				case "NEGATIVE": return CriterionUse.Negative;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CriterionUse.", nameof(xmlValue));
			}
		}
	}
	public static class CriterionUserListMembershipStatusExtensions
	{
		public static string ToXmlValue(this CriterionUserListMembershipStatus enumValue)
		{
			switch (enumValue)
			{
				case CriterionUserListMembershipStatus.Open: return "OPEN";
				case CriterionUserListMembershipStatus.Closed: return "CLOSED";
				default: return null;
			}
		}
		public static CriterionUserListMembershipStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "OPEN": return CriterionUserListMembershipStatus.Open;
				case "CLOSED": return CriterionUserListMembershipStatus.Closed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CriterionUserListMembershipStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CurrencyCodeErrorReasonExtensions
	{
		public static string ToXmlValue(this CurrencyCodeErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CurrencyCodeErrorReason.UnsupportedCurrencyCode: return "UNSUPPORTED_CURRENCY_CODE";
				default: return null;
			}
		}
		public static CurrencyCodeErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNSUPPORTED_CURRENCY_CODE": return CurrencyCodeErrorReason.UnsupportedCurrencyCode;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CurrencyCodeErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CustomerErrorReasonExtensions
	{
		public static string ToXmlValue(this CustomerErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CustomerErrorReason.InvalidServiceLink: return "INVALID_SERVICE_LINK";
				case CustomerErrorReason.InvalidStatus: return "INVALID_STATUS";
				case CustomerErrorReason.Temporary: return "TEMPORARY";
				case CustomerErrorReason.AccountNotSetUp: return "ACCOUNT_NOT_SET_UP";
				default: return null;
			}
		}
		public static CustomerErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_SERVICE_LINK": return CustomerErrorReason.InvalidServiceLink;
				case "INVALID_STATUS": return CustomerErrorReason.InvalidStatus;
				case "TEMPORARY": return CustomerErrorReason.Temporary;
				case "ACCOUNT_NOT_SET_UP": return CustomerErrorReason.AccountNotSetUp;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CustomerErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CustomerFeedErrorReasonExtensions
	{
		public static string ToXmlValue(this CustomerFeedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CustomerFeedErrorReason.FeedAlreadyExistsForPlaceholderType: return "FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE";
				case CustomerFeedErrorReason.InvalidId: return "INVALID_ID";
				case CustomerFeedErrorReason.CannotAddForDeletedFeed: return "CANNOT_ADD_FOR_DELETED_FEED";
				case CustomerFeedErrorReason.CannotAddAlreadyExistingCustomerFeed: return "CANNOT_ADD_ALREADY_EXISTING_CUSTOMER_FEED";
				case CustomerFeedErrorReason.CannotModifyRemovedCustomerFeed: return "CANNOT_MODIFY_REMOVED_CUSTOMER_FEED";
				case CustomerFeedErrorReason.InvalidPlaceholderTypes: return "INVALID_PLACEHOLDER_TYPES";
				case CustomerFeedErrorReason.MissingFeedmappingForPlaceholderType: return "MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE";
				case CustomerFeedErrorReason.PlaceholderTypeNotAllowedOnCustomerFeed: return "PLACEHOLDER_TYPE_NOT_ALLOWED_ON_CUSTOMER_FEED";
				case CustomerFeedErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CustomerFeedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE": return CustomerFeedErrorReason.FeedAlreadyExistsForPlaceholderType;
				case "INVALID_ID": return CustomerFeedErrorReason.InvalidId;
				case "CANNOT_ADD_FOR_DELETED_FEED": return CustomerFeedErrorReason.CannotAddForDeletedFeed;
				case "CANNOT_ADD_ALREADY_EXISTING_CUSTOMER_FEED": return CustomerFeedErrorReason.CannotAddAlreadyExistingCustomerFeed;
				case "CANNOT_MODIFY_REMOVED_CUSTOMER_FEED": return CustomerFeedErrorReason.CannotModifyRemovedCustomerFeed;
				case "INVALID_PLACEHOLDER_TYPES": return CustomerFeedErrorReason.InvalidPlaceholderTypes;
				case "MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE": return CustomerFeedErrorReason.MissingFeedmappingForPlaceholderType;
				case "PLACEHOLDER_TYPE_NOT_ALLOWED_ON_CUSTOMER_FEED": return CustomerFeedErrorReason.PlaceholderTypeNotAllowedOnCustomerFeed;
				case "UNKNOWN": return CustomerFeedErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CustomerFeedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CustomerFeedStatusExtensions
	{
		public static string ToXmlValue(this CustomerFeedStatus enumValue)
		{
			switch (enumValue)
			{
				case CustomerFeedStatus.Enabled: return "ENABLED";
				case CustomerFeedStatus.Removed: return "REMOVED";
				case CustomerFeedStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CustomerFeedStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return CustomerFeedStatus.Enabled;
				case "REMOVED": return CustomerFeedStatus.Removed;
				case "UNKNOWN": return CustomerFeedStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CustomerFeedStatus.", nameof(xmlValue));
			}
		}
	}
	public static class CustomerOrderLineErrorReasonExtensions
	{
		public static string ToXmlValue(this CustomerOrderLineErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CustomerOrderLineErrorReason.InvalidOrderLineId: return "INVALID_ORDER_LINE_ID";
				case CustomerOrderLineErrorReason.EndDateBeforeStartDate: return "END_DATE_BEFORE_START_DATE";
				case CustomerOrderLineErrorReason.NegativeSpend: return "NEGATIVE_SPEND";
				case CustomerOrderLineErrorReason.CreateInPast: return "CREATE_IN_PAST";
				case CustomerOrderLineErrorReason.AlreadyStarted: return "ALREADY_STARTED";
				case CustomerOrderLineErrorReason.AlreadySpent: return "ALREADY_SPENT";
				case CustomerOrderLineErrorReason.FinishedInThePast: return "FINISHED_IN_THE_PAST";
				case CustomerOrderLineErrorReason.CancelActive: return "CANCEL_ACTIVE";
				case CustomerOrderLineErrorReason.OverlapDateRange: return "OVERLAP_DATE_RANGE";
				case CustomerOrderLineErrorReason.CosChange: return "COS_CHANGE";
				case CustomerOrderLineErrorReason.NonAdwords: return "NON_ADWORDS";
				case CustomerOrderLineErrorReason.StartDateAfterActual: return "START_DATE_AFTER_ACTUAL";
				case CustomerOrderLineErrorReason.EndDatePastMax: return "END_DATE_PAST_MAX";
				case CustomerOrderLineErrorReason.ParentIsSelf: return "PARENT_IS_SELF";
				case CustomerOrderLineErrorReason.CannotCancelNew: return "CANNOT_CANCEL_NEW";
				case CustomerOrderLineErrorReason.CannotCancelStarted: return "CANNOT_CANCEL_STARTED";
				case CustomerOrderLineErrorReason.CannotPromoteNonPendingOrderline: return "CANNOT_PROMOTE_NON_PENDING_ORDERLINE";
				case CustomerOrderLineErrorReason.UpdateOrderlineWillShiftCurrent: return "UPDATE_ORDERLINE_WILL_SHIFT_CURRENT";
				case CustomerOrderLineErrorReason.OrderlineBeingModifiedIsNotNormalOrPending: return "ORDERLINE_BEING_MODIFIED_IS_NOT_NORMAL_OR_PENDING";
				case CustomerOrderLineErrorReason.InvalidStatusChange: return "INVALID_STATUS_CHANGE";
				case CustomerOrderLineErrorReason.MoreThanOneOperationNotPermitted: return "MORE_THAN_ONE_OPERATION_NOT_PERMITTED";
				case CustomerOrderLineErrorReason.InvalidTimezoneInDateRanges: return "INVALID_TIMEZONE_IN_DATE_RANGES";
				case CustomerOrderLineErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static CustomerOrderLineErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_ORDER_LINE_ID": return CustomerOrderLineErrorReason.InvalidOrderLineId;
				case "END_DATE_BEFORE_START_DATE": return CustomerOrderLineErrorReason.EndDateBeforeStartDate;
				case "NEGATIVE_SPEND": return CustomerOrderLineErrorReason.NegativeSpend;
				case "CREATE_IN_PAST": return CustomerOrderLineErrorReason.CreateInPast;
				case "ALREADY_STARTED": return CustomerOrderLineErrorReason.AlreadyStarted;
				case "ALREADY_SPENT": return CustomerOrderLineErrorReason.AlreadySpent;
				case "FINISHED_IN_THE_PAST": return CustomerOrderLineErrorReason.FinishedInThePast;
				case "CANCEL_ACTIVE": return CustomerOrderLineErrorReason.CancelActive;
				case "OVERLAP_DATE_RANGE": return CustomerOrderLineErrorReason.OverlapDateRange;
				case "COS_CHANGE": return CustomerOrderLineErrorReason.CosChange;
				case "NON_ADWORDS": return CustomerOrderLineErrorReason.NonAdwords;
				case "START_DATE_AFTER_ACTUAL": return CustomerOrderLineErrorReason.StartDateAfterActual;
				case "END_DATE_PAST_MAX": return CustomerOrderLineErrorReason.EndDatePastMax;
				case "PARENT_IS_SELF": return CustomerOrderLineErrorReason.ParentIsSelf;
				case "CANNOT_CANCEL_NEW": return CustomerOrderLineErrorReason.CannotCancelNew;
				case "CANNOT_CANCEL_STARTED": return CustomerOrderLineErrorReason.CannotCancelStarted;
				case "CANNOT_PROMOTE_NON_PENDING_ORDERLINE": return CustomerOrderLineErrorReason.CannotPromoteNonPendingOrderline;
				case "UPDATE_ORDERLINE_WILL_SHIFT_CURRENT": return CustomerOrderLineErrorReason.UpdateOrderlineWillShiftCurrent;
				case "ORDERLINE_BEING_MODIFIED_IS_NOT_NORMAL_OR_PENDING": return CustomerOrderLineErrorReason.OrderlineBeingModifiedIsNotNormalOrPending;
				case "INVALID_STATUS_CHANGE": return CustomerOrderLineErrorReason.InvalidStatusChange;
				case "MORE_THAN_ONE_OPERATION_NOT_PERMITTED": return CustomerOrderLineErrorReason.MoreThanOneOperationNotPermitted;
				case "INVALID_TIMEZONE_IN_DATE_RANGES": return CustomerOrderLineErrorReason.InvalidTimezoneInDateRanges;
				case "UNKNOWN": return CustomerOrderLineErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CustomerOrderLineErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class CustomerSyncErrorReasonExtensions
	{
		public static string ToXmlValue(this CustomerSyncErrorReason enumValue)
		{
			switch (enumValue)
			{
				case CustomerSyncErrorReason.InvalidCampaignId: return "INVALID_CAMPAIGN_ID";
				case CustomerSyncErrorReason.InvalidFeedId: return "INVALID_FEED_ID";
				case CustomerSyncErrorReason.InvalidDateRange: return "INVALID_DATE_RANGE";
				case CustomerSyncErrorReason.TooManyChanges: return "TOO_MANY_CHANGES";
				default: return null;
			}
		}
		public static CustomerSyncErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_CAMPAIGN_ID": return CustomerSyncErrorReason.InvalidCampaignId;
				case "INVALID_FEED_ID": return CustomerSyncErrorReason.InvalidFeedId;
				case "INVALID_DATE_RANGE": return CustomerSyncErrorReason.InvalidDateRange;
				case "TOO_MANY_CHANGES": return CustomerSyncErrorReason.TooManyChanges;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type CustomerSyncErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DatabaseErrorReasonExtensions
	{
		public static string ToXmlValue(this DatabaseErrorReason enumValue)
		{
			switch (enumValue)
			{
				case DatabaseErrorReason.ConcurrentModification: return "CONCURRENT_MODIFICATION";
				case DatabaseErrorReason.PermissionDenied: return "PERMISSION_DENIED";
				case DatabaseErrorReason.AccessProhibited: return "ACCESS_PROHIBITED";
				case DatabaseErrorReason.CampaignProductNotSupported: return "CAMPAIGN_PRODUCT_NOT_SUPPORTED";
				case DatabaseErrorReason.DuplicateKey: return "DUPLICATE_KEY";
				case DatabaseErrorReason.DatabaseError: return "DATABASE_ERROR";
				case DatabaseErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static DatabaseErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CONCURRENT_MODIFICATION": return DatabaseErrorReason.ConcurrentModification;
				case "PERMISSION_DENIED": return DatabaseErrorReason.PermissionDenied;
				case "ACCESS_PROHIBITED": return DatabaseErrorReason.AccessProhibited;
				case "CAMPAIGN_PRODUCT_NOT_SUPPORTED": return DatabaseErrorReason.CampaignProductNotSupported;
				case "DUPLICATE_KEY": return DatabaseErrorReason.DuplicateKey;
				case "DATABASE_ERROR": return DatabaseErrorReason.DatabaseError;
				case "UNKNOWN": return DatabaseErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DatabaseErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DataDrivenModelStatusExtensions
	{
		public static string ToXmlValue(this DataDrivenModelStatus enumValue)
		{
			switch (enumValue)
			{
				case DataDrivenModelStatus.Unknown: return "UNKNOWN";
				case DataDrivenModelStatus.Available: return "AVAILABLE";
				case DataDrivenModelStatus.Stale: return "STALE";
				case DataDrivenModelStatus.Expired: return "EXPIRED";
				case DataDrivenModelStatus.NeverGenerated: return "NEVER_GENERATED";
				default: return null;
			}
		}
		public static DataDrivenModelStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return DataDrivenModelStatus.Unknown;
				case "AVAILABLE": return DataDrivenModelStatus.Available;
				case "STALE": return DataDrivenModelStatus.Stale;
				case "EXPIRED": return DataDrivenModelStatus.Expired;
				case "NEVER_GENERATED": return DataDrivenModelStatus.NeverGenerated;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DataDrivenModelStatus.", nameof(xmlValue));
			}
		}
	}
	public static class DataErrorReasonExtensions
	{
		public static string ToXmlValue(this DataErrorReason enumValue)
		{
			switch (enumValue)
			{
				case DataErrorReason.CannotCreateTableEntry: return "CANNOT_CREATE_TABLE_ENTRY";
				case DataErrorReason.NoTableEntryClassForViewType: return "NO_TABLE_ENTRY_CLASS_FOR_VIEW_TYPE";
				case DataErrorReason.TableServiceError: return "TABLE_SERVICE_ERROR";
				default: return null;
			}
		}
		public static DataErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_CREATE_TABLE_ENTRY": return DataErrorReason.CannotCreateTableEntry;
				case "NO_TABLE_ENTRY_CLASS_FOR_VIEW_TYPE": return DataErrorReason.NoTableEntryClassForViewType;
				case "TABLE_SERVICE_ERROR": return DataErrorReason.TableServiceError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DataErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DateErrorReasonExtensions
	{
		public static string ToXmlValue(this DateErrorReason enumValue)
		{
			switch (enumValue)
			{
				case DateErrorReason.InvalidFieldValuesInDate: return "INVALID_FIELD_VALUES_IN_DATE";
				case DateErrorReason.InvalidFieldValuesInDateTime: return "INVALID_FIELD_VALUES_IN_DATE_TIME";
				case DateErrorReason.InvalidStringDate: return "INVALID_STRING_DATE";
				case DateErrorReason.InvalidStringDateRange: return "INVALID_STRING_DATE_RANGE";
				case DateErrorReason.InvalidStringDateTime: return "INVALID_STRING_DATE_TIME";
				case DateErrorReason.EarlierThanMinimumDate: return "EARLIER_THAN_MINIMUM_DATE";
				case DateErrorReason.LaterThanMaximumDate: return "LATER_THAN_MAXIMUM_DATE";
				case DateErrorReason.DateRangeMinimumDateLaterThanMaximumDate: return "DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE";
				case DateErrorReason.DateRangeMinimumAndMaximumDatesBothNull: return "DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL";
				default: return null;
			}
		}
		public static DateErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_FIELD_VALUES_IN_DATE": return DateErrorReason.InvalidFieldValuesInDate;
				case "INVALID_FIELD_VALUES_IN_DATE_TIME": return DateErrorReason.InvalidFieldValuesInDateTime;
				case "INVALID_STRING_DATE": return DateErrorReason.InvalidStringDate;
				case "INVALID_STRING_DATE_RANGE": return DateErrorReason.InvalidStringDateRange;
				case "INVALID_STRING_DATE_TIME": return DateErrorReason.InvalidStringDateTime;
				case "EARLIER_THAN_MINIMUM_DATE": return DateErrorReason.EarlierThanMinimumDate;
				case "LATER_THAN_MAXIMUM_DATE": return DateErrorReason.LaterThanMaximumDate;
				case "DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE": return DateErrorReason.DateRangeMinimumDateLaterThanMaximumDate;
				case "DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL": return DateErrorReason.DateRangeMinimumAndMaximumDatesBothNull;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DateErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DateRangeErrorReasonExtensions
	{
		public static string ToXmlValue(this DateRangeErrorReason enumValue)
		{
			switch (enumValue)
			{
				case DateRangeErrorReason.DateRangeError: return "DATE_RANGE_ERROR";
				case DateRangeErrorReason.InvalidDate: return "INVALID_DATE";
				case DateRangeErrorReason.StartDateAfterEndDate: return "START_DATE_AFTER_END_DATE";
				case DateRangeErrorReason.CannotSetDateToPast: return "CANNOT_SET_DATE_TO_PAST";
				case DateRangeErrorReason.AfterMaximumAllowableDate: return "AFTER_MAXIMUM_ALLOWABLE_DATE";
				case DateRangeErrorReason.CannotModifyStartDateIfAlreadyStarted: return "CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED";
				default: return null;
			}
		}
		public static DateRangeErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DATE_RANGE_ERROR": return DateRangeErrorReason.DateRangeError;
				case "INVALID_DATE": return DateRangeErrorReason.InvalidDate;
				case "START_DATE_AFTER_END_DATE": return DateRangeErrorReason.StartDateAfterEndDate;
				case "CANNOT_SET_DATE_TO_PAST": return DateRangeErrorReason.CannotSetDateToPast;
				case "AFTER_MAXIMUM_ALLOWABLE_DATE": return DateRangeErrorReason.AfterMaximumAllowableDate;
				case "CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED": return DateRangeErrorReason.CannotModifyStartDateIfAlreadyStarted;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DateRangeErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DateRuleItemDateOperatorExtensions
	{
		public static string ToXmlValue(this DateRuleItemDateOperator enumValue)
		{
			switch (enumValue)
			{
				case DateRuleItemDateOperator.Unknown: return "UNKNOWN";
				case DateRuleItemDateOperator.Equals: return "EQUALS";
				case DateRuleItemDateOperator.NotEqual: return "NOT_EQUAL";
				case DateRuleItemDateOperator.Before: return "BEFORE";
				case DateRuleItemDateOperator.After: return "AFTER";
				default: return null;
			}
		}
		public static DateRuleItemDateOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return DateRuleItemDateOperator.Unknown;
				case "EQUALS": return DateRuleItemDateOperator.Equals;
				case "NOT_EQUAL": return DateRuleItemDateOperator.NotEqual;
				case "BEFORE": return DateRuleItemDateOperator.Before;
				case "AFTER": return DateRuleItemDateOperator.After;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DateRuleItemDateOperator.", nameof(xmlValue));
			}
		}
	}
	public static class DayOfWeekExtensions
	{
		public static string ToXmlValue(this DayOfWeek enumValue)
		{
			switch (enumValue)
			{
				case DayOfWeek.Monday: return "MONDAY";
				case DayOfWeek.Tuesday: return "TUESDAY";
				case DayOfWeek.Wednesday: return "WEDNESDAY";
				case DayOfWeek.Thursday: return "THURSDAY";
				case DayOfWeek.Friday: return "FRIDAY";
				case DayOfWeek.Saturday: return "SATURDAY";
				case DayOfWeek.Sunday: return "SUNDAY";
				default: return null;
			}
		}
		public static DayOfWeek Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "MONDAY": return DayOfWeek.Monday;
				case "TUESDAY": return DayOfWeek.Tuesday;
				case "WEDNESDAY": return DayOfWeek.Wednesday;
				case "THURSDAY": return DayOfWeek.Thursday;
				case "FRIDAY": return DayOfWeek.Friday;
				case "SATURDAY": return DayOfWeek.Saturday;
				case "SUNDAY": return DayOfWeek.Sunday;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DayOfWeek.", nameof(xmlValue));
			}
		}
	}
	public static class DeprecatedAdTypeExtensions
	{
		public static string ToXmlValue(this DeprecatedAdType enumValue)
		{
			switch (enumValue)
			{
				case DeprecatedAdType.Video: return "VIDEO";
				case DeprecatedAdType.ClickToCall: return "CLICK_TO_CALL";
				case DeprecatedAdType.InStreamVideo: return "IN_STREAM_VIDEO";
				case DeprecatedAdType.Froogle: return "FROOGLE";
				case DeprecatedAdType.TextLink: return "TEXT_LINK";
				case DeprecatedAdType.Gadget: return "GADGET";
				case DeprecatedAdType.Print: return "PRINT";
				case DeprecatedAdType.TextWide: return "TEXT_WIDE";
				case DeprecatedAdType.GadgetTemplate: return "GADGET_TEMPLATE";
				case DeprecatedAdType.TextWithVideo: return "TEXT_WITH_VIDEO";
				case DeprecatedAdType.Audio: return "AUDIO";
				case DeprecatedAdType.LocalBusinessAd: return "LOCAL_BUSINESS_AD";
				case DeprecatedAdType.AudioTemplate: return "AUDIO_TEMPLATE";
				case DeprecatedAdType.MobileAd: return "MOBILE_AD";
				case DeprecatedAdType.MobileImageAd: return "MOBILE_IMAGE_AD";
				case DeprecatedAdType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static DeprecatedAdType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "VIDEO": return DeprecatedAdType.Video;
				case "CLICK_TO_CALL": return DeprecatedAdType.ClickToCall;
				case "IN_STREAM_VIDEO": return DeprecatedAdType.InStreamVideo;
				case "FROOGLE": return DeprecatedAdType.Froogle;
				case "TEXT_LINK": return DeprecatedAdType.TextLink;
				case "GADGET": return DeprecatedAdType.Gadget;
				case "PRINT": return DeprecatedAdType.Print;
				case "TEXT_WIDE": return DeprecatedAdType.TextWide;
				case "GADGET_TEMPLATE": return DeprecatedAdType.GadgetTemplate;
				case "TEXT_WITH_VIDEO": return DeprecatedAdType.TextWithVideo;
				case "AUDIO": return DeprecatedAdType.Audio;
				case "LOCAL_BUSINESS_AD": return DeprecatedAdType.LocalBusinessAd;
				case "AUDIO_TEMPLATE": return DeprecatedAdType.AudioTemplate;
				case "MOBILE_AD": return DeprecatedAdType.MobileAd;
				case "MOBILE_IMAGE_AD": return DeprecatedAdType.MobileImageAd;
				case "UNKNOWN": return DeprecatedAdType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DeprecatedAdType.", nameof(xmlValue));
			}
		}
	}
	public static class DistinctErrorReasonExtensions
	{
		public static string ToXmlValue(this DistinctErrorReason enumValue)
		{
			switch (enumValue)
			{
				case DistinctErrorReason.DuplicateElement: return "DUPLICATE_ELEMENT";
				case DistinctErrorReason.DuplicateType: return "DUPLICATE_TYPE";
				default: return null;
			}
		}
		public static DistinctErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DUPLICATE_ELEMENT": return DistinctErrorReason.DuplicateElement;
				case "DUPLICATE_TYPE": return DistinctErrorReason.DuplicateType;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DistinctErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DownloadFormatExtensions
	{
		public static string ToXmlValue(this DownloadFormat enumValue)
		{
			switch (enumValue)
			{
				case DownloadFormat.Csvforexcel: return "CSVFOREXCEL";
				case DownloadFormat.Csv: return "CSV";
				case DownloadFormat.Tsv: return "TSV";
				case DownloadFormat.Xml: return "XML";
				case DownloadFormat.GzippedCsv: return "GZIPPED_CSV";
				case DownloadFormat.GzippedXml: return "GZIPPED_XML";
				default: return null;
			}
		}
		public static DownloadFormat Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CSVFOREXCEL": return DownloadFormat.Csvforexcel;
				case "CSV": return DownloadFormat.Csv;
				case "TSV": return DownloadFormat.Tsv;
				case "XML": return DownloadFormat.Xml;
				case "GZIPPED_CSV": return DownloadFormat.GzippedCsv;
				case "GZIPPED_XML": return DownloadFormat.GzippedXml;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DownloadFormat.", nameof(xmlValue));
			}
		}
	}
	public static class DraftErrorReasonExtensions
	{
		public static string ToXmlValue(this DraftErrorReason enumValue)
		{
			switch (enumValue)
			{
				case DraftErrorReason.CannotChangeArchivedDraft: return "CANNOT_CHANGE_ARCHIVED_DRAFT";
				case DraftErrorReason.CannotChangePromotedDraft: return "CANNOT_CHANGE_PROMOTED_DRAFT";
				case DraftErrorReason.CannotChangePromoteFailedDraft: return "CANNOT_CHANGE_PROMOTE_FAILED_DRAFT";
				case DraftErrorReason.CustomerCannotCreateDraft: return "CUSTOMER_CANNOT_CREATE_DRAFT";
				case DraftErrorReason.CampaignCannotCreateDraft: return "CAMPAIGN_CANNOT_CREATE_DRAFT";
				case DraftErrorReason.DuplicateDraftName: return "DUPLICATE_DRAFT_NAME";
				case DraftErrorReason.InvalidDraftChange: return "INVALID_DRAFT_CHANGE";
				case DraftErrorReason.InvalidStatusTransition: return "INVALID_STATUS_TRANSITION";
				case DraftErrorReason.MaxNumberOfDraftsPerCampaignReached: return "MAX_NUMBER_OF_DRAFTS_PER_CAMPAIGN_REACHED";
				case DraftErrorReason.DraftError: return "DRAFT_ERROR";
				default: return null;
			}
		}
		public static DraftErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_CHANGE_ARCHIVED_DRAFT": return DraftErrorReason.CannotChangeArchivedDraft;
				case "CANNOT_CHANGE_PROMOTED_DRAFT": return DraftErrorReason.CannotChangePromotedDraft;
				case "CANNOT_CHANGE_PROMOTE_FAILED_DRAFT": return DraftErrorReason.CannotChangePromoteFailedDraft;
				case "CUSTOMER_CANNOT_CREATE_DRAFT": return DraftErrorReason.CustomerCannotCreateDraft;
				case "CAMPAIGN_CANNOT_CREATE_DRAFT": return DraftErrorReason.CampaignCannotCreateDraft;
				case "DUPLICATE_DRAFT_NAME": return DraftErrorReason.DuplicateDraftName;
				case "INVALID_DRAFT_CHANGE": return DraftErrorReason.InvalidDraftChange;
				case "INVALID_STATUS_TRANSITION": return DraftErrorReason.InvalidStatusTransition;
				case "MAX_NUMBER_OF_DRAFTS_PER_CAMPAIGN_REACHED": return DraftErrorReason.MaxNumberOfDraftsPerCampaignReached;
				case "DRAFT_ERROR": return DraftErrorReason.DraftError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DraftErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class DraftStatusExtensions
	{
		public static string ToXmlValue(this DraftStatus enumValue)
		{
			switch (enumValue)
			{
				case DraftStatus.Unknown: return "UNKNOWN";
				case DraftStatus.Proposed: return "PROPOSED";
				case DraftStatus.Promoted: return "PROMOTED";
				case DraftStatus.Promoting: return "PROMOTING";
				case DraftStatus.Archived: return "ARCHIVED";
				case DraftStatus.PromoteFailed: return "PROMOTE_FAILED";
				default: return null;
			}
		}
		public static DraftStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return DraftStatus.Unknown;
				case "PROPOSED": return DraftStatus.Proposed;
				case "PROMOTED": return DraftStatus.Promoted;
				case "PROMOTING": return DraftStatus.Promoting;
				case "ARCHIVED": return DraftStatus.Archived;
				case "PROMOTE_FAILED": return DraftStatus.PromoteFailed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type DraftStatus.", nameof(xmlValue));
			}
		}
	}
	public static class EntityAccessDeniedReasonExtensions
	{
		public static string ToXmlValue(this EntityAccessDeniedReason enumValue)
		{
			switch (enumValue)
			{
				case EntityAccessDeniedReason.ReadAccessDenied: return "READ_ACCESS_DENIED";
				case EntityAccessDeniedReason.WriteAccessDenied: return "WRITE_ACCESS_DENIED";
				default: return null;
			}
		}
		public static EntityAccessDeniedReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "READ_ACCESS_DENIED": return EntityAccessDeniedReason.ReadAccessDenied;
				case "WRITE_ACCESS_DENIED": return EntityAccessDeniedReason.WriteAccessDenied;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type EntityAccessDeniedReason.", nameof(xmlValue));
			}
		}
	}
	public static class EntityCountLimitExceededReasonExtensions
	{
		public static string ToXmlValue(this EntityCountLimitExceededReason enumValue)
		{
			switch (enumValue)
			{
				case EntityCountLimitExceededReason.AccountLimit: return "ACCOUNT_LIMIT";
				case EntityCountLimitExceededReason.CampaignLimit: return "CAMPAIGN_LIMIT";
				case EntityCountLimitExceededReason.AdgroupLimit: return "ADGROUP_LIMIT";
				case EntityCountLimitExceededReason.AdGroupAdLimit: return "AD_GROUP_AD_LIMIT";
				case EntityCountLimitExceededReason.AdGroupCriterionLimit: return "AD_GROUP_CRITERION_LIMIT";
				case EntityCountLimitExceededReason.SharedSetLimit: return "SHARED_SET_LIMIT";
				case EntityCountLimitExceededReason.MatchingFunctionLimit: return "MATCHING_FUNCTION_LIMIT";
				case EntityCountLimitExceededReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static EntityCountLimitExceededReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACCOUNT_LIMIT": return EntityCountLimitExceededReason.AccountLimit;
				case "CAMPAIGN_LIMIT": return EntityCountLimitExceededReason.CampaignLimit;
				case "ADGROUP_LIMIT": return EntityCountLimitExceededReason.AdgroupLimit;
				case "AD_GROUP_AD_LIMIT": return EntityCountLimitExceededReason.AdGroupAdLimit;
				case "AD_GROUP_CRITERION_LIMIT": return EntityCountLimitExceededReason.AdGroupCriterionLimit;
				case "SHARED_SET_LIMIT": return EntityCountLimitExceededReason.SharedSetLimit;
				case "MATCHING_FUNCTION_LIMIT": return EntityCountLimitExceededReason.MatchingFunctionLimit;
				case "UNKNOWN": return EntityCountLimitExceededReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type EntityCountLimitExceededReason.", nameof(xmlValue));
			}
		}
	}
	public static class EntityNotFoundReasonExtensions
	{
		public static string ToXmlValue(this EntityNotFoundReason enumValue)
		{
			switch (enumValue)
			{
				case EntityNotFoundReason.InvalidId: return "INVALID_ID";
				default: return null;
			}
		}
		public static EntityNotFoundReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_ID": return EntityNotFoundReason.InvalidId;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type EntityNotFoundReason.", nameof(xmlValue));
			}
		}
	}
	public static class ExtensionSettingErrorReasonExtensions
	{
		public static string ToXmlValue(this ExtensionSettingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ExtensionSettingErrorReason.ExtensionsRequired: return "EXTENSIONS_REQUIRED";
				case ExtensionSettingErrorReason.FeedTypeExtensionTypeMismatch: return "FEED_TYPE_EXTENSION_TYPE_MISMATCH";
				case ExtensionSettingErrorReason.InvalidFeedType: return "INVALID_FEED_TYPE";
				case ExtensionSettingErrorReason.InvalidFeedTypeForCustomerExtensionSetting: return "INVALID_FEED_TYPE_FOR_CUSTOMER_EXTENSION_SETTING";
				case ExtensionSettingErrorReason.CannotChangeFeedItemOnAdd: return "CANNOT_CHANGE_FEED_ITEM_ON_ADD";
				case ExtensionSettingErrorReason.CannotHaveRestrictionOnEmptyGeoTargeting: return "CANNOT_HAVE_RESTRICTION_ON_EMPTY_GEO_TARGETING";
				case ExtensionSettingErrorReason.CannotUpdateNewlyAddedExtension: return "CANNOT_UPDATE_NEWLY_ADDED_EXTENSION";
				case ExtensionSettingErrorReason.NoExistingAdGroupExtensionSettingForType: return "NO_EXISTING_AD_GROUP_EXTENSION_SETTING_FOR_TYPE";
				case ExtensionSettingErrorReason.NoExistingCampaignExtensionSettingForType: return "NO_EXISTING_CAMPAIGN_EXTENSION_SETTING_FOR_TYPE";
				case ExtensionSettingErrorReason.NoExistingCustomerExtensionSettingForType: return "NO_EXISTING_CUSTOMER_EXTENSION_SETTING_FOR_TYPE";
				case ExtensionSettingErrorReason.AdGroupExtensionSettingAlreadyExists: return "AD_GROUP_EXTENSION_SETTING_ALREADY_EXISTS";
				case ExtensionSettingErrorReason.CampaignExtensionSettingAlreadyExists: return "CAMPAIGN_EXTENSION_SETTING_ALREADY_EXISTS";
				case ExtensionSettingErrorReason.CustomerExtensionSettingAlreadyExists: return "CUSTOMER_EXTENSION_SETTING_ALREADY_EXISTS";
				case ExtensionSettingErrorReason.AdGroupFeedAlreadyExistsForPlaceholderType: return "AD_GROUP_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE";
				case ExtensionSettingErrorReason.CampaignFeedAlreadyExistsForPlaceholderType: return "CAMPAIGN_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE";
				case ExtensionSettingErrorReason.CustomerFeedAlreadyExistsForPlaceholderType: return "CUSTOMER_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE";
				case ExtensionSettingErrorReason.ValueOutOfRange: return "VALUE_OUT_OF_RANGE";
				case ExtensionSettingErrorReason.CannotSetWithFinalUrls: return "CANNOT_SET_WITH_FINAL_URLS";
				case ExtensionSettingErrorReason.CannotSetWithoutFinalUrls: return "CANNOT_SET_WITHOUT_FINAL_URLS";
				case ExtensionSettingErrorReason.CannotSetBothDestinationUrlAndTrackingUrlTemplate: return "CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE";
				case ExtensionSettingErrorReason.InvalidPhoneNumber: return "INVALID_PHONE_NUMBER";
				case ExtensionSettingErrorReason.PhoneNumberNotSupportedForCountry: return "PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY";
				case ExtensionSettingErrorReason.CarrierSpecificShortNumberNotAllowed: return "CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED";
				case ExtensionSettingErrorReason.PremiumRateNumberNotAllowed: return "PREMIUM_RATE_NUMBER_NOT_ALLOWED";
				case ExtensionSettingErrorReason.DisallowedNumberType: return "DISALLOWED_NUMBER_TYPE";
				case ExtensionSettingErrorReason.InvalidDomesticPhoneNumberFormat: return "INVALID_DOMESTIC_PHONE_NUMBER_FORMAT";
				case ExtensionSettingErrorReason.VanityPhoneNumberNotAllowed: return "VANITY_PHONE_NUMBER_NOT_ALLOWED";
				case ExtensionSettingErrorReason.InvalidCountryCode: return "INVALID_COUNTRY_CODE";
				case ExtensionSettingErrorReason.InvalidCallConversionTypeId: return "INVALID_CALL_CONVERSION_TYPE_ID";
				case ExtensionSettingErrorReason.CustomerNotWhitelistedForCalltracking: return "CUSTOMER_NOT_WHITELISTED_FOR_CALLTRACKING";
				case ExtensionSettingErrorReason.CalltrackingNotSupportedForCountry: return "CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY";
				case ExtensionSettingErrorReason.InvalidAppId: return "INVALID_APP_ID";
				case ExtensionSettingErrorReason.QuotesInReviewExtensionSnippet: return "QUOTES_IN_REVIEW_EXTENSION_SNIPPET";
				case ExtensionSettingErrorReason.HyphensInReviewExtensionSnippet: return "HYPHENS_IN_REVIEW_EXTENSION_SNIPPET";
				case ExtensionSettingErrorReason.ReviewExtensionSourceIneligible: return "REVIEW_EXTENSION_SOURCE_INELIGIBLE";
				case ExtensionSettingErrorReason.SourceNameInReviewExtensionText: return "SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT";
				case ExtensionSettingErrorReason.MissingField: return "MISSING_FIELD";
				case ExtensionSettingErrorReason.InconsistentCurrencyCodes: return "INCONSISTENT_CURRENCY_CODES";
				case ExtensionSettingErrorReason.PriceExtensionHasDuplicatedHeaders: return "PRICE_EXTENSION_HAS_DUPLICATED_HEADERS";
				case ExtensionSettingErrorReason.PriceItemHasDuplicatedHeaderAndDescription: return "PRICE_ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION";
				case ExtensionSettingErrorReason.PriceExtensionHasTooFewItems: return "PRICE_EXTENSION_HAS_TOO_FEW_ITEMS";
				case ExtensionSettingErrorReason.PriceExtensionHasTooManyItems: return "PRICE_EXTENSION_HAS_TOO_MANY_ITEMS";
				case ExtensionSettingErrorReason.UnsupportedValue: return "UNSUPPORTED_VALUE";
				case ExtensionSettingErrorReason.InvalidDevicePreference: return "INVALID_DEVICE_PREFERENCE";
				case ExtensionSettingErrorReason.InvalidScheduleEnd: return "INVALID_SCHEDULE_END";
				case ExtensionSettingErrorReason.DateTimeMustBeInAccountTimeZone: return "DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE";
				case ExtensionSettingErrorReason.OverlappingSchedules: return "OVERLAPPING_SCHEDULES";
				case ExtensionSettingErrorReason.ScheduleEndNotAfterStart: return "SCHEDULE_END_NOT_AFTER_START";
				case ExtensionSettingErrorReason.TooManySchedulesPerDay: return "TOO_MANY_SCHEDULES_PER_DAY";
				case ExtensionSettingErrorReason.DuplicateExtensionFeedItemEdit: return "DUPLICATE_EXTENSION_FEED_ITEM_EDIT";
				case ExtensionSettingErrorReason.InvalidSnippetsHeader: return "INVALID_SNIPPETS_HEADER";
				case ExtensionSettingErrorReason.PhoneNumberNotSupportedWithCalltrackingForCountry: return "PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY";
				case ExtensionSettingErrorReason.CampaignTargetingMismatch: return "CAMPAIGN_TARGETING_MISMATCH";
				case ExtensionSettingErrorReason.CannotOperateOnDeletedFeed: return "CANNOT_OPERATE_ON_DELETED_FEED";
				case ExtensionSettingErrorReason.ConcreteExtensionTypeRequired: return "CONCRETE_EXTENSION_TYPE_REQUIRED";
				case ExtensionSettingErrorReason.IncompatibleUnderlyingMatchingFunction: return "INCOMPATIBLE_UNDERLYING_MATCHING_FUNCTION";
				case ExtensionSettingErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ExtensionSettingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EXTENSIONS_REQUIRED": return ExtensionSettingErrorReason.ExtensionsRequired;
				case "FEED_TYPE_EXTENSION_TYPE_MISMATCH": return ExtensionSettingErrorReason.FeedTypeExtensionTypeMismatch;
				case "INVALID_FEED_TYPE": return ExtensionSettingErrorReason.InvalidFeedType;
				case "INVALID_FEED_TYPE_FOR_CUSTOMER_EXTENSION_SETTING": return ExtensionSettingErrorReason.InvalidFeedTypeForCustomerExtensionSetting;
				case "CANNOT_CHANGE_FEED_ITEM_ON_ADD": return ExtensionSettingErrorReason.CannotChangeFeedItemOnAdd;
				case "CANNOT_HAVE_RESTRICTION_ON_EMPTY_GEO_TARGETING": return ExtensionSettingErrorReason.CannotHaveRestrictionOnEmptyGeoTargeting;
				case "CANNOT_UPDATE_NEWLY_ADDED_EXTENSION": return ExtensionSettingErrorReason.CannotUpdateNewlyAddedExtension;
				case "NO_EXISTING_AD_GROUP_EXTENSION_SETTING_FOR_TYPE": return ExtensionSettingErrorReason.NoExistingAdGroupExtensionSettingForType;
				case "NO_EXISTING_CAMPAIGN_EXTENSION_SETTING_FOR_TYPE": return ExtensionSettingErrorReason.NoExistingCampaignExtensionSettingForType;
				case "NO_EXISTING_CUSTOMER_EXTENSION_SETTING_FOR_TYPE": return ExtensionSettingErrorReason.NoExistingCustomerExtensionSettingForType;
				case "AD_GROUP_EXTENSION_SETTING_ALREADY_EXISTS": return ExtensionSettingErrorReason.AdGroupExtensionSettingAlreadyExists;
				case "CAMPAIGN_EXTENSION_SETTING_ALREADY_EXISTS": return ExtensionSettingErrorReason.CampaignExtensionSettingAlreadyExists;
				case "CUSTOMER_EXTENSION_SETTING_ALREADY_EXISTS": return ExtensionSettingErrorReason.CustomerExtensionSettingAlreadyExists;
				case "AD_GROUP_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE": return ExtensionSettingErrorReason.AdGroupFeedAlreadyExistsForPlaceholderType;
				case "CAMPAIGN_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE": return ExtensionSettingErrorReason.CampaignFeedAlreadyExistsForPlaceholderType;
				case "CUSTOMER_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE": return ExtensionSettingErrorReason.CustomerFeedAlreadyExistsForPlaceholderType;
				case "VALUE_OUT_OF_RANGE": return ExtensionSettingErrorReason.ValueOutOfRange;
				case "CANNOT_SET_WITH_FINAL_URLS": return ExtensionSettingErrorReason.CannotSetWithFinalUrls;
				case "CANNOT_SET_WITHOUT_FINAL_URLS": return ExtensionSettingErrorReason.CannotSetWithoutFinalUrls;
				case "CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE": return ExtensionSettingErrorReason.CannotSetBothDestinationUrlAndTrackingUrlTemplate;
				case "INVALID_PHONE_NUMBER": return ExtensionSettingErrorReason.InvalidPhoneNumber;
				case "PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY": return ExtensionSettingErrorReason.PhoneNumberNotSupportedForCountry;
				case "CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED": return ExtensionSettingErrorReason.CarrierSpecificShortNumberNotAllowed;
				case "PREMIUM_RATE_NUMBER_NOT_ALLOWED": return ExtensionSettingErrorReason.PremiumRateNumberNotAllowed;
				case "DISALLOWED_NUMBER_TYPE": return ExtensionSettingErrorReason.DisallowedNumberType;
				case "INVALID_DOMESTIC_PHONE_NUMBER_FORMAT": return ExtensionSettingErrorReason.InvalidDomesticPhoneNumberFormat;
				case "VANITY_PHONE_NUMBER_NOT_ALLOWED": return ExtensionSettingErrorReason.VanityPhoneNumberNotAllowed;
				case "INVALID_COUNTRY_CODE": return ExtensionSettingErrorReason.InvalidCountryCode;
				case "INVALID_CALL_CONVERSION_TYPE_ID": return ExtensionSettingErrorReason.InvalidCallConversionTypeId;
				case "CUSTOMER_NOT_WHITELISTED_FOR_CALLTRACKING": return ExtensionSettingErrorReason.CustomerNotWhitelistedForCalltracking;
				case "CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY": return ExtensionSettingErrorReason.CalltrackingNotSupportedForCountry;
				case "INVALID_APP_ID": return ExtensionSettingErrorReason.InvalidAppId;
				case "QUOTES_IN_REVIEW_EXTENSION_SNIPPET": return ExtensionSettingErrorReason.QuotesInReviewExtensionSnippet;
				case "HYPHENS_IN_REVIEW_EXTENSION_SNIPPET": return ExtensionSettingErrorReason.HyphensInReviewExtensionSnippet;
				case "REVIEW_EXTENSION_SOURCE_INELIGIBLE": return ExtensionSettingErrorReason.ReviewExtensionSourceIneligible;
				case "SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT": return ExtensionSettingErrorReason.SourceNameInReviewExtensionText;
				case "MISSING_FIELD": return ExtensionSettingErrorReason.MissingField;
				case "INCONSISTENT_CURRENCY_CODES": return ExtensionSettingErrorReason.InconsistentCurrencyCodes;
				case "PRICE_EXTENSION_HAS_DUPLICATED_HEADERS": return ExtensionSettingErrorReason.PriceExtensionHasDuplicatedHeaders;
				case "PRICE_ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION": return ExtensionSettingErrorReason.PriceItemHasDuplicatedHeaderAndDescription;
				case "PRICE_EXTENSION_HAS_TOO_FEW_ITEMS": return ExtensionSettingErrorReason.PriceExtensionHasTooFewItems;
				case "PRICE_EXTENSION_HAS_TOO_MANY_ITEMS": return ExtensionSettingErrorReason.PriceExtensionHasTooManyItems;
				case "UNSUPPORTED_VALUE": return ExtensionSettingErrorReason.UnsupportedValue;
				case "INVALID_DEVICE_PREFERENCE": return ExtensionSettingErrorReason.InvalidDevicePreference;
				case "INVALID_SCHEDULE_END": return ExtensionSettingErrorReason.InvalidScheduleEnd;
				case "DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE": return ExtensionSettingErrorReason.DateTimeMustBeInAccountTimeZone;
				case "OVERLAPPING_SCHEDULES": return ExtensionSettingErrorReason.OverlappingSchedules;
				case "SCHEDULE_END_NOT_AFTER_START": return ExtensionSettingErrorReason.ScheduleEndNotAfterStart;
				case "TOO_MANY_SCHEDULES_PER_DAY": return ExtensionSettingErrorReason.TooManySchedulesPerDay;
				case "DUPLICATE_EXTENSION_FEED_ITEM_EDIT": return ExtensionSettingErrorReason.DuplicateExtensionFeedItemEdit;
				case "INVALID_SNIPPETS_HEADER": return ExtensionSettingErrorReason.InvalidSnippetsHeader;
				case "PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY": return ExtensionSettingErrorReason.PhoneNumberNotSupportedWithCalltrackingForCountry;
				case "CAMPAIGN_TARGETING_MISMATCH": return ExtensionSettingErrorReason.CampaignTargetingMismatch;
				case "CANNOT_OPERATE_ON_DELETED_FEED": return ExtensionSettingErrorReason.CannotOperateOnDeletedFeed;
				case "CONCRETE_EXTENSION_TYPE_REQUIRED": return ExtensionSettingErrorReason.ConcreteExtensionTypeRequired;
				case "INCOMPATIBLE_UNDERLYING_MATCHING_FUNCTION": return ExtensionSettingErrorReason.IncompatibleUnderlyingMatchingFunction;
				case "UNKNOWN": return ExtensionSettingErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ExtensionSettingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ExtensionSettingPlatformExtensions
	{
		public static string ToXmlValue(this ExtensionSettingPlatform enumValue)
		{
			switch (enumValue)
			{
				case ExtensionSettingPlatform.Desktop: return "DESKTOP";
				case ExtensionSettingPlatform.Mobile: return "MOBILE";
				case ExtensionSettingPlatform.None: return "NONE";
				default: return null;
			}
		}
		public static ExtensionSettingPlatform Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DESKTOP": return ExtensionSettingPlatform.Desktop;
				case "MOBILE": return ExtensionSettingPlatform.Mobile;
				case "NONE": return ExtensionSettingPlatform.None;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ExtensionSettingPlatform.", nameof(xmlValue));
			}
		}
	}
	public static class FeedAttributeReferenceErrorReasonExtensions
	{
		public static string ToXmlValue(this FeedAttributeReferenceErrorReason enumValue)
		{
			switch (enumValue)
			{
				case FeedAttributeReferenceErrorReason.CannotReferenceDeletedFeed: return "CANNOT_REFERENCE_DELETED_FEED";
				case FeedAttributeReferenceErrorReason.InvalidFeedName: return "INVALID_FEED_NAME";
				case FeedAttributeReferenceErrorReason.InvalidFeedAttributeName: return "INVALID_FEED_ATTRIBUTE_NAME";
				default: return null;
			}
		}
		public static FeedAttributeReferenceErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_REFERENCE_DELETED_FEED": return FeedAttributeReferenceErrorReason.CannotReferenceDeletedFeed;
				case "INVALID_FEED_NAME": return FeedAttributeReferenceErrorReason.InvalidFeedName;
				case "INVALID_FEED_ATTRIBUTE_NAME": return FeedAttributeReferenceErrorReason.InvalidFeedAttributeName;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedAttributeReferenceErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class FeedAttributeTypeExtensions
	{
		public static string ToXmlValue(this FeedAttributeType enumValue)
		{
			switch (enumValue)
			{
				case FeedAttributeType.Int64: return "INT64";
				case FeedAttributeType.Float: return "FLOAT";
				case FeedAttributeType.String: return "STRING";
				case FeedAttributeType.Boolean: return "BOOLEAN";
				case FeedAttributeType.Url: return "URL";
				case FeedAttributeType.DateTime: return "DATE_TIME";
				case FeedAttributeType.Int64List: return "INT64_LIST";
				case FeedAttributeType.FloatList: return "FLOAT_LIST";
				case FeedAttributeType.StringList: return "STRING_LIST";
				case FeedAttributeType.BooleanList: return "BOOLEAN_LIST";
				case FeedAttributeType.UrlList: return "URL_LIST";
				case FeedAttributeType.DateTimeList: return "DATE_TIME_LIST";
				case FeedAttributeType.Price: return "PRICE";
				case FeedAttributeType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedAttributeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INT64": return FeedAttributeType.Int64;
				case "FLOAT": return FeedAttributeType.Float;
				case "STRING": return FeedAttributeType.String;
				case "BOOLEAN": return FeedAttributeType.Boolean;
				case "URL": return FeedAttributeType.Url;
				case "DATE_TIME": return FeedAttributeType.DateTime;
				case "INT64_LIST": return FeedAttributeType.Int64List;
				case "FLOAT_LIST": return FeedAttributeType.FloatList;
				case "STRING_LIST": return FeedAttributeType.StringList;
				case "BOOLEAN_LIST": return FeedAttributeType.BooleanList;
				case "URL_LIST": return FeedAttributeType.UrlList;
				case "DATE_TIME_LIST": return FeedAttributeType.DateTimeList;
				case "PRICE": return FeedAttributeType.Price;
				case "UNKNOWN": return FeedAttributeType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedAttributeType.", nameof(xmlValue));
			}
		}
	}
	public static class FeedErrorReasonExtensions
	{
		public static string ToXmlValue(this FeedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case FeedErrorReason.AttributeNamesNotUnique: return "ATTRIBUTE_NAMES_NOT_UNIQUE";
				case FeedErrorReason.AttributesDoNotMatchExistingAttributes: return "ATTRIBUTES_DO_NOT_MATCH_EXISTING_ATTRIBUTES";
				case FeedErrorReason.CannotChangeOrigin: return "CANNOT_CHANGE_ORIGIN";
				case FeedErrorReason.CannotSpecifyUserOriginForSystemFeed: return "CANNOT_SPECIFY_USER_ORIGIN_FOR_SYSTEM_FEED";
				case FeedErrorReason.CannotSpecifyAdwordsOriginForNonSystemFeed: return "CANNOT_SPECIFY_ADWORDS_ORIGIN_FOR_NON_SYSTEM_FEED";
				case FeedErrorReason.CannotSpecifyFeedAttributesForSystemFeed: return "CANNOT_SPECIFY_FEED_ATTRIBUTES_FOR_SYSTEM_FEED";
				case FeedErrorReason.CannotUpdateFeedAttributesWithOriginAdwords: return "CANNOT_UPDATE_FEED_ATTRIBUTES_WITH_ORIGIN_ADWORDS";
				case FeedErrorReason.FeedRemoved: return "FEED_REMOVED";
				case FeedErrorReason.InvalidOriginValue: return "INVALID_ORIGIN_VALUE";
				case FeedErrorReason.FeedOriginIsNotUser: return "FEED_ORIGIN_IS_NOT_USER";
				case FeedErrorReason.DuplicateFeedName: return "DUPLICATE_FEED_NAME";
				case FeedErrorReason.InvalidFeedName: return "INVALID_FEED_NAME";
				case FeedErrorReason.MissingOauthInfo: return "MISSING_OAUTH_INFO";
				case FeedErrorReason.NewAttributeCannotBePartOfUniqueKey: return "NEW_ATTRIBUTE_CANNOT_BE_PART_OF_UNIQUE_KEY";
				case FeedErrorReason.TooManyFeedAttributesForFeed: return "TOO_MANY_FEED_ATTRIBUTES_FOR_FEED";
				case FeedErrorReason.InvalidBusinessAccount: return "INVALID_BUSINESS_ACCOUNT";
				case FeedErrorReason.BusinessAccountCannotAccessLocationAccount: return "BUSINESS_ACCOUNT_CANNOT_ACCESS_LOCATION_ACCOUNT";
				case FeedErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ATTRIBUTE_NAMES_NOT_UNIQUE": return FeedErrorReason.AttributeNamesNotUnique;
				case "ATTRIBUTES_DO_NOT_MATCH_EXISTING_ATTRIBUTES": return FeedErrorReason.AttributesDoNotMatchExistingAttributes;
				case "CANNOT_CHANGE_ORIGIN": return FeedErrorReason.CannotChangeOrigin;
				case "CANNOT_SPECIFY_USER_ORIGIN_FOR_SYSTEM_FEED": return FeedErrorReason.CannotSpecifyUserOriginForSystemFeed;
				case "CANNOT_SPECIFY_ADWORDS_ORIGIN_FOR_NON_SYSTEM_FEED": return FeedErrorReason.CannotSpecifyAdwordsOriginForNonSystemFeed;
				case "CANNOT_SPECIFY_FEED_ATTRIBUTES_FOR_SYSTEM_FEED": return FeedErrorReason.CannotSpecifyFeedAttributesForSystemFeed;
				case "CANNOT_UPDATE_FEED_ATTRIBUTES_WITH_ORIGIN_ADWORDS": return FeedErrorReason.CannotUpdateFeedAttributesWithOriginAdwords;
				case "FEED_REMOVED": return FeedErrorReason.FeedRemoved;
				case "INVALID_ORIGIN_VALUE": return FeedErrorReason.InvalidOriginValue;
				case "FEED_ORIGIN_IS_NOT_USER": return FeedErrorReason.FeedOriginIsNotUser;
				case "DUPLICATE_FEED_NAME": return FeedErrorReason.DuplicateFeedName;
				case "INVALID_FEED_NAME": return FeedErrorReason.InvalidFeedName;
				case "MISSING_OAUTH_INFO": return FeedErrorReason.MissingOauthInfo;
				case "NEW_ATTRIBUTE_CANNOT_BE_PART_OF_UNIQUE_KEY": return FeedErrorReason.NewAttributeCannotBePartOfUniqueKey;
				case "TOO_MANY_FEED_ATTRIBUTES_FOR_FEED": return FeedErrorReason.TooManyFeedAttributesForFeed;
				case "INVALID_BUSINESS_ACCOUNT": return FeedErrorReason.InvalidBusinessAccount;
				case "BUSINESS_ACCOUNT_CANNOT_ACCESS_LOCATION_ACCOUNT": return FeedErrorReason.BusinessAccountCannotAccessLocationAccount;
				case "UNKNOWN": return FeedErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class FeedItemApprovalStatusExtensions
	{
		public static string ToXmlValue(this FeedItemApprovalStatus enumValue)
		{
			switch (enumValue)
			{
				case FeedItemApprovalStatus.Unchecked: return "UNCHECKED";
				case FeedItemApprovalStatus.Approved: return "APPROVED";
				case FeedItemApprovalStatus.Disapproved: return "DISAPPROVED";
				default: return null;
			}
		}
		public static FeedItemApprovalStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNCHECKED": return FeedItemApprovalStatus.Unchecked;
				case "APPROVED": return FeedItemApprovalStatus.Approved;
				case "DISAPPROVED": return FeedItemApprovalStatus.Disapproved;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedItemApprovalStatus.", nameof(xmlValue));
			}
		}
	}
	public static class FeedItemErrorReasonExtensions
	{
		public static string ToXmlValue(this FeedItemErrorReason enumValue)
		{
			switch (enumValue)
			{
				case FeedItemErrorReason.CampaignTargetingMismatch: return "CAMPAIGN_TARGETING_MISMATCH";
				case FeedItemErrorReason.CannotConvertAttributeValueFromString: return "CANNOT_CONVERT_ATTRIBUTE_VALUE_FROM_STRING";
				case FeedItemErrorReason.CannotHaveRestrictionOnEmptyGeoTargeting: return "CANNOT_HAVE_RESTRICTION_ON_EMPTY_GEO_TARGETING";
				case FeedItemErrorReason.CannotOperateOnRemovedFeedItem: return "CANNOT_OPERATE_ON_REMOVED_FEED_ITEM";
				case FeedItemErrorReason.DateTimeMustBeInAccountTimeZone: return "DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE";
				case FeedItemErrorReason.KeyAttributesNotFound: return "KEY_ATTRIBUTES_NOT_FOUND";
				case FeedItemErrorReason.InvalidDevicePreference: return "INVALID_DEVICE_PREFERENCE";
				case FeedItemErrorReason.InvalidScheduleEnd: return "INVALID_SCHEDULE_END";
				case FeedItemErrorReason.InvalidUrl: return "INVALID_URL";
				case FeedItemErrorReason.MissingKeyAttributes: return "MISSING_KEY_ATTRIBUTES";
				case FeedItemErrorReason.KeyAttributesNotUnique: return "KEY_ATTRIBUTES_NOT_UNIQUE";
				case FeedItemErrorReason.CannotModifyKeyAttributeValue: return "CANNOT_MODIFY_KEY_ATTRIBUTE_VALUE";
				case FeedItemErrorReason.OverlappingSchedules: return "OVERLAPPING_SCHEDULES";
				case FeedItemErrorReason.ScheduleEndNotAfterStart: return "SCHEDULE_END_NOT_AFTER_START";
				case FeedItemErrorReason.TooManySchedulesPerDay: return "TOO_MANY_SCHEDULES_PER_DAY";
				case FeedItemErrorReason.SizeTooLargeForMultiValueAttribute: return "SIZE_TOO_LARGE_FOR_MULTI_VALUE_ATTRIBUTE";
				case FeedItemErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedItemErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CAMPAIGN_TARGETING_MISMATCH": return FeedItemErrorReason.CampaignTargetingMismatch;
				case "CANNOT_CONVERT_ATTRIBUTE_VALUE_FROM_STRING": return FeedItemErrorReason.CannotConvertAttributeValueFromString;
				case "CANNOT_HAVE_RESTRICTION_ON_EMPTY_GEO_TARGETING": return FeedItemErrorReason.CannotHaveRestrictionOnEmptyGeoTargeting;
				case "CANNOT_OPERATE_ON_REMOVED_FEED_ITEM": return FeedItemErrorReason.CannotOperateOnRemovedFeedItem;
				case "DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE": return FeedItemErrorReason.DateTimeMustBeInAccountTimeZone;
				case "KEY_ATTRIBUTES_NOT_FOUND": return FeedItemErrorReason.KeyAttributesNotFound;
				case "INVALID_DEVICE_PREFERENCE": return FeedItemErrorReason.InvalidDevicePreference;
				case "INVALID_SCHEDULE_END": return FeedItemErrorReason.InvalidScheduleEnd;
				case "INVALID_URL": return FeedItemErrorReason.InvalidUrl;
				case "MISSING_KEY_ATTRIBUTES": return FeedItemErrorReason.MissingKeyAttributes;
				case "KEY_ATTRIBUTES_NOT_UNIQUE": return FeedItemErrorReason.KeyAttributesNotUnique;
				case "CANNOT_MODIFY_KEY_ATTRIBUTE_VALUE": return FeedItemErrorReason.CannotModifyKeyAttributeValue;
				case "OVERLAPPING_SCHEDULES": return FeedItemErrorReason.OverlappingSchedules;
				case "SCHEDULE_END_NOT_AFTER_START": return FeedItemErrorReason.ScheduleEndNotAfterStart;
				case "TOO_MANY_SCHEDULES_PER_DAY": return FeedItemErrorReason.TooManySchedulesPerDay;
				case "SIZE_TOO_LARGE_FOR_MULTI_VALUE_ATTRIBUTE": return FeedItemErrorReason.SizeTooLargeForMultiValueAttribute;
				case "UNKNOWN": return FeedItemErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedItemErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class FeedItemQualityApprovalStatusExtensions
	{
		public static string ToXmlValue(this FeedItemQualityApprovalStatus enumValue)
		{
			switch (enumValue)
			{
				case FeedItemQualityApprovalStatus.Unknown: return "UNKNOWN";
				case FeedItemQualityApprovalStatus.Approved: return "APPROVED";
				case FeedItemQualityApprovalStatus.Disapproved: return "DISAPPROVED";
				default: return null;
			}
		}
		public static FeedItemQualityApprovalStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return FeedItemQualityApprovalStatus.Unknown;
				case "APPROVED": return FeedItemQualityApprovalStatus.Approved;
				case "DISAPPROVED": return FeedItemQualityApprovalStatus.Disapproved;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedItemQualityApprovalStatus.", nameof(xmlValue));
			}
		}
	}
	public static class FeedItemQualityDisapprovalReasonsExtensions
	{
		public static string ToXmlValue(this FeedItemQualityDisapprovalReasons enumValue)
		{
			switch (enumValue)
			{
				case FeedItemQualityDisapprovalReasons.Unknown: return "UNKNOWN";
				case FeedItemQualityDisapprovalReasons.TableRepetitiveHeaders: return "TABLE_REPETITIVE_HEADERS";
				case FeedItemQualityDisapprovalReasons.TableRepetitiveDescription: return "TABLE_REPETITIVE_DESCRIPTION";
				case FeedItemQualityDisapprovalReasons.TableInconsistentRows: return "TABLE_INCONSISTENT_ROWS";
				case FeedItemQualityDisapprovalReasons.DescriptionHasPriceQualifiers: return "DESCRIPTION_HAS_PRICE_QUALIFIERS";
				case FeedItemQualityDisapprovalReasons.UnsupportedLanguage: return "UNSUPPORTED_LANGUAGE";
				case FeedItemQualityDisapprovalReasons.TableRowHeaderTableTypeMismatch: return "TABLE_ROW_HEADER_TABLE_TYPE_MISMATCH";
				case FeedItemQualityDisapprovalReasons.TableRowHeaderHasPromotionalText: return "TABLE_ROW_HEADER_HAS_PROMOTIONAL_TEXT";
				case FeedItemQualityDisapprovalReasons.TableRowDescriptionNotRelevant: return "TABLE_ROW_DESCRIPTION_NOT_RELEVANT";
				case FeedItemQualityDisapprovalReasons.TableRowDescriptionHasPromotionalText: return "TABLE_ROW_DESCRIPTION_HAS_PROMOTIONAL_TEXT";
				case FeedItemQualityDisapprovalReasons.TableRowHeaderDescriptionRepetitive: return "TABLE_ROW_HEADER_DESCRIPTION_REPETITIVE";
				case FeedItemQualityDisapprovalReasons.TableRowUnrateable: return "TABLE_ROW_UNRATEABLE";
				case FeedItemQualityDisapprovalReasons.TableRowPriceInvalid: return "TABLE_ROW_PRICE_INVALID";
				case FeedItemQualityDisapprovalReasons.TableRowUrlInvalid: return "TABLE_ROW_URL_INVALID";
				case FeedItemQualityDisapprovalReasons.HeaderOrDescriptionHasPrice: return "HEADER_OR_DESCRIPTION_HAS_PRICE";
				case FeedItemQualityDisapprovalReasons.StructuredSnippetsHeaderPolicyViolated: return "STRUCTURED_SNIPPETS_HEADER_POLICY_VIOLATED";
				case FeedItemQualityDisapprovalReasons.StructuredSnippetsRepeatedValues: return "STRUCTURED_SNIPPETS_REPEATED_VALUES";
				case FeedItemQualityDisapprovalReasons.StructuredSnippetsEditorialGuidelines: return "STRUCTURED_SNIPPETS_EDITORIAL_GUIDELINES";
				case FeedItemQualityDisapprovalReasons.StructuredSnippetsHasPromotionalText: return "STRUCTURED_SNIPPETS_HAS_PROMOTIONAL_TEXT";
				default: return null;
			}
		}
		public static FeedItemQualityDisapprovalReasons Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return FeedItemQualityDisapprovalReasons.Unknown;
				case "TABLE_REPETITIVE_HEADERS": return FeedItemQualityDisapprovalReasons.TableRepetitiveHeaders;
				case "TABLE_REPETITIVE_DESCRIPTION": return FeedItemQualityDisapprovalReasons.TableRepetitiveDescription;
				case "TABLE_INCONSISTENT_ROWS": return FeedItemQualityDisapprovalReasons.TableInconsistentRows;
				case "DESCRIPTION_HAS_PRICE_QUALIFIERS": return FeedItemQualityDisapprovalReasons.DescriptionHasPriceQualifiers;
				case "UNSUPPORTED_LANGUAGE": return FeedItemQualityDisapprovalReasons.UnsupportedLanguage;
				case "TABLE_ROW_HEADER_TABLE_TYPE_MISMATCH": return FeedItemQualityDisapprovalReasons.TableRowHeaderTableTypeMismatch;
				case "TABLE_ROW_HEADER_HAS_PROMOTIONAL_TEXT": return FeedItemQualityDisapprovalReasons.TableRowHeaderHasPromotionalText;
				case "TABLE_ROW_DESCRIPTION_NOT_RELEVANT": return FeedItemQualityDisapprovalReasons.TableRowDescriptionNotRelevant;
				case "TABLE_ROW_DESCRIPTION_HAS_PROMOTIONAL_TEXT": return FeedItemQualityDisapprovalReasons.TableRowDescriptionHasPromotionalText;
				case "TABLE_ROW_HEADER_DESCRIPTION_REPETITIVE": return FeedItemQualityDisapprovalReasons.TableRowHeaderDescriptionRepetitive;
				case "TABLE_ROW_UNRATEABLE": return FeedItemQualityDisapprovalReasons.TableRowUnrateable;
				case "TABLE_ROW_PRICE_INVALID": return FeedItemQualityDisapprovalReasons.TableRowPriceInvalid;
				case "TABLE_ROW_URL_INVALID": return FeedItemQualityDisapprovalReasons.TableRowUrlInvalid;
				case "HEADER_OR_DESCRIPTION_HAS_PRICE": return FeedItemQualityDisapprovalReasons.HeaderOrDescriptionHasPrice;
				case "STRUCTURED_SNIPPETS_HEADER_POLICY_VIOLATED": return FeedItemQualityDisapprovalReasons.StructuredSnippetsHeaderPolicyViolated;
				case "STRUCTURED_SNIPPETS_REPEATED_VALUES": return FeedItemQualityDisapprovalReasons.StructuredSnippetsRepeatedValues;
				case "STRUCTURED_SNIPPETS_EDITORIAL_GUIDELINES": return FeedItemQualityDisapprovalReasons.StructuredSnippetsEditorialGuidelines;
				case "STRUCTURED_SNIPPETS_HAS_PROMOTIONAL_TEXT": return FeedItemQualityDisapprovalReasons.StructuredSnippetsHasPromotionalText;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedItemQualityDisapprovalReasons.", nameof(xmlValue));
			}
		}
	}
	public static class FeedItemStatusExtensions
	{
		public static string ToXmlValue(this FeedItemStatus enumValue)
		{
			switch (enumValue)
			{
				case FeedItemStatus.Enabled: return "ENABLED";
				case FeedItemStatus.Removed: return "REMOVED";
				case FeedItemStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedItemStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return FeedItemStatus.Enabled;
				case "REMOVED": return FeedItemStatus.Removed;
				case "UNKNOWN": return FeedItemStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedItemStatus.", nameof(xmlValue));
			}
		}
	}
	public static class FeedItemValidationStatusExtensions
	{
		public static string ToXmlValue(this FeedItemValidationStatus enumValue)
		{
			switch (enumValue)
			{
				case FeedItemValidationStatus.Unchecked: return "UNCHECKED";
				case FeedItemValidationStatus.Error: return "ERROR";
				case FeedItemValidationStatus.Valid: return "VALID";
				default: return null;
			}
		}
		public static FeedItemValidationStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNCHECKED": return FeedItemValidationStatus.Unchecked;
				case "ERROR": return FeedItemValidationStatus.Error;
				case "VALID": return FeedItemValidationStatus.Valid;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedItemValidationStatus.", nameof(xmlValue));
			}
		}
	}
	public static class FeedMappingErrorReasonExtensions
	{
		public static string ToXmlValue(this FeedMappingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case FeedMappingErrorReason.InvalidPlaceholderField: return "INVALID_PLACEHOLDER_FIELD";
				case FeedMappingErrorReason.InvalidCriterionField: return "INVALID_CRITERION_FIELD";
				case FeedMappingErrorReason.InvalidPlaceholderType: return "INVALID_PLACEHOLDER_TYPE";
				case FeedMappingErrorReason.InvalidCriterionType: return "INVALID_CRITERION_TYPE";
				case FeedMappingErrorReason.CannotSetPlaceholderTypeAndCriterionType: return "CANNOT_SET_PLACEHOLDER_TYPE_AND_CRITERION_TYPE";
				case FeedMappingErrorReason.NoAttributeFieldMappings: return "NO_ATTRIBUTE_FIELD_MAPPINGS";
				case FeedMappingErrorReason.FeedAttributeTypeMismatch: return "FEED_ATTRIBUTE_TYPE_MISMATCH";
				case FeedMappingErrorReason.CannotOperateOnMappingsForSystemGeneratedFeed: return "CANNOT_OPERATE_ON_MAPPINGS_FOR_SYSTEM_GENERATED_FEED";
				case FeedMappingErrorReason.MultipleMappingsForPlaceholderType: return "MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_TYPE";
				case FeedMappingErrorReason.MultipleMappingsForCriterionType: return "MULTIPLE_MAPPINGS_FOR_CRITERION_TYPE";
				case FeedMappingErrorReason.MultipleMappingsForPlaceholderField: return "MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_FIELD";
				case FeedMappingErrorReason.MultipleMappingsForCriterionField: return "MULTIPLE_MAPPINGS_FOR_CRITERION_FIELD";
				case FeedMappingErrorReason.UnexpectedAttributeFieldMappings: return "UNEXPECTED_ATTRIBUTE_FIELD_MAPPINGS";
				case FeedMappingErrorReason.LocationPlaceholderOnlyForPlacesFeeds: return "LOCATION_PLACEHOLDER_ONLY_FOR_PLACES_FEEDS";
				case FeedMappingErrorReason.CannotModifyMappingsForTypedFeed: return "CANNOT_MODIFY_MAPPINGS_FOR_TYPED_FEED";
				case FeedMappingErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedMappingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_PLACEHOLDER_FIELD": return FeedMappingErrorReason.InvalidPlaceholderField;
				case "INVALID_CRITERION_FIELD": return FeedMappingErrorReason.InvalidCriterionField;
				case "INVALID_PLACEHOLDER_TYPE": return FeedMappingErrorReason.InvalidPlaceholderType;
				case "INVALID_CRITERION_TYPE": return FeedMappingErrorReason.InvalidCriterionType;
				case "CANNOT_SET_PLACEHOLDER_TYPE_AND_CRITERION_TYPE": return FeedMappingErrorReason.CannotSetPlaceholderTypeAndCriterionType;
				case "NO_ATTRIBUTE_FIELD_MAPPINGS": return FeedMappingErrorReason.NoAttributeFieldMappings;
				case "FEED_ATTRIBUTE_TYPE_MISMATCH": return FeedMappingErrorReason.FeedAttributeTypeMismatch;
				case "CANNOT_OPERATE_ON_MAPPINGS_FOR_SYSTEM_GENERATED_FEED": return FeedMappingErrorReason.CannotOperateOnMappingsForSystemGeneratedFeed;
				case "MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_TYPE": return FeedMappingErrorReason.MultipleMappingsForPlaceholderType;
				case "MULTIPLE_MAPPINGS_FOR_CRITERION_TYPE": return FeedMappingErrorReason.MultipleMappingsForCriterionType;
				case "MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_FIELD": return FeedMappingErrorReason.MultipleMappingsForPlaceholderField;
				case "MULTIPLE_MAPPINGS_FOR_CRITERION_FIELD": return FeedMappingErrorReason.MultipleMappingsForCriterionField;
				case "UNEXPECTED_ATTRIBUTE_FIELD_MAPPINGS": return FeedMappingErrorReason.UnexpectedAttributeFieldMappings;
				case "LOCATION_PLACEHOLDER_ONLY_FOR_PLACES_FEEDS": return FeedMappingErrorReason.LocationPlaceholderOnlyForPlacesFeeds;
				case "CANNOT_MODIFY_MAPPINGS_FOR_TYPED_FEED": return FeedMappingErrorReason.CannotModifyMappingsForTypedFeed;
				case "UNKNOWN": return FeedMappingErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedMappingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class FeedMappingStatusExtensions
	{
		public static string ToXmlValue(this FeedMappingStatus enumValue)
		{
			switch (enumValue)
			{
				case FeedMappingStatus.Enabled: return "ENABLED";
				case FeedMappingStatus.Removed: return "REMOVED";
				case FeedMappingStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedMappingStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return FeedMappingStatus.Enabled;
				case "REMOVED": return FeedMappingStatus.Removed;
				case "UNKNOWN": return FeedMappingStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedMappingStatus.", nameof(xmlValue));
			}
		}
	}
	public static class FeedOriginExtensions
	{
		public static string ToXmlValue(this FeedOrigin enumValue)
		{
			switch (enumValue)
			{
				case FeedOrigin.User: return "USER";
				case FeedOrigin.Adwords: return "ADWORDS";
				case FeedOrigin.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedOrigin Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "USER": return FeedOrigin.User;
				case "ADWORDS": return FeedOrigin.Adwords;
				case "UNKNOWN": return FeedOrigin.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedOrigin.", nameof(xmlValue));
			}
		}
	}
	public static class FeedStatusExtensions
	{
		public static string ToXmlValue(this FeedStatus enumValue)
		{
			switch (enumValue)
			{
				case FeedStatus.Enabled: return "ENABLED";
				case FeedStatus.Removed: return "REMOVED";
				case FeedStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FeedStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return FeedStatus.Enabled;
				case "REMOVED": return FeedStatus.Removed;
				case "UNKNOWN": return FeedStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedStatus.", nameof(xmlValue));
			}
		}
	}
	public static class FeedTypeExtensions
	{
		public static string ToXmlValue(this FeedType enumValue)
		{
			switch (enumValue)
			{
				case FeedType.None: return "NONE";
				case FeedType.Sitelink: return "SITELINK";
				case FeedType.Call: return "CALL";
				case FeedType.App: return "APP";
				case FeedType.Review: return "REVIEW";
				case FeedType.AdCustomizer: return "AD_CUSTOMIZER";
				case FeedType.Callout: return "CALLOUT";
				case FeedType.StructuredSnippet: return "STRUCTURED_SNIPPET";
				case FeedType.Price: return "PRICE";
				default: return null;
			}
		}
		public static FeedType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NONE": return FeedType.None;
				case "SITELINK": return FeedType.Sitelink;
				case "CALL": return FeedType.Call;
				case "APP": return FeedType.App;
				case "REVIEW": return FeedType.Review;
				case "AD_CUSTOMIZER": return FeedType.AdCustomizer;
				case "CALLOUT": return FeedType.Callout;
				case "STRUCTURED_SNIPPET": return FeedType.StructuredSnippet;
				case "PRICE": return FeedType.Price;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FeedType.", nameof(xmlValue));
			}
		}
	}
	public static class ForwardCompatibilityErrorReasonExtensions
	{
		public static string ToXmlValue(this ForwardCompatibilityErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ForwardCompatibilityErrorReason.InvalidForwardCompatibilityMapValue: return "INVALID_FORWARD_COMPATIBILITY_MAP_VALUE";
				case ForwardCompatibilityErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ForwardCompatibilityErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_FORWARD_COMPATIBILITY_MAP_VALUE": return ForwardCompatibilityErrorReason.InvalidForwardCompatibilityMapValue;
				case "UNKNOWN": return ForwardCompatibilityErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ForwardCompatibilityErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class FunctionErrorReasonExtensions
	{
		public static string ToXmlValue(this FunctionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case FunctionErrorReason.InvalidFunctionFormat: return "INVALID_FUNCTION_FORMAT";
				case FunctionErrorReason.DataTypeMismatch: return "DATA_TYPE_MISMATCH";
				case FunctionErrorReason.InvalidConjunctionOperands: return "INVALID_CONJUNCTION_OPERANDS";
				case FunctionErrorReason.InvalidNumberOfOperands: return "INVALID_NUMBER_OF_OPERANDS";
				case FunctionErrorReason.InvalidOperandType: return "INVALID_OPERAND_TYPE";
				case FunctionErrorReason.InvalidOperator: return "INVALID_OPERATOR";
				case FunctionErrorReason.InvalidRequestContextType: return "INVALID_REQUEST_CONTEXT_TYPE";
				case FunctionErrorReason.InvalidFunctionForCallPlaceholder: return "INVALID_FUNCTION_FOR_CALL_PLACEHOLDER";
				case FunctionErrorReason.InvalidFunctionForPlaceholder: return "INVALID_FUNCTION_FOR_PLACEHOLDER";
				case FunctionErrorReason.InvalidOperand: return "INVALID_OPERAND";
				case FunctionErrorReason.MissingConstantOperandValue: return "MISSING_CONSTANT_OPERAND_VALUE";
				case FunctionErrorReason.InvalidConstantOperandValue: return "INVALID_CONSTANT_OPERAND_VALUE";
				case FunctionErrorReason.InvalidNesting: return "INVALID_NESTING";
				case FunctionErrorReason.MultipleFeedIdsNotSupported: return "MULTIPLE_FEED_IDS_NOT_SUPPORTED";
				case FunctionErrorReason.InvalidFunctionForFeedWithFixedSchema: return "INVALID_FUNCTION_FOR_FEED_WITH_FIXED_SCHEMA";
				case FunctionErrorReason.InvalidAttributeName: return "INVALID_ATTRIBUTE_NAME";
				case FunctionErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FunctionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_FUNCTION_FORMAT": return FunctionErrorReason.InvalidFunctionFormat;
				case "DATA_TYPE_MISMATCH": return FunctionErrorReason.DataTypeMismatch;
				case "INVALID_CONJUNCTION_OPERANDS": return FunctionErrorReason.InvalidConjunctionOperands;
				case "INVALID_NUMBER_OF_OPERANDS": return FunctionErrorReason.InvalidNumberOfOperands;
				case "INVALID_OPERAND_TYPE": return FunctionErrorReason.InvalidOperandType;
				case "INVALID_OPERATOR": return FunctionErrorReason.InvalidOperator;
				case "INVALID_REQUEST_CONTEXT_TYPE": return FunctionErrorReason.InvalidRequestContextType;
				case "INVALID_FUNCTION_FOR_CALL_PLACEHOLDER": return FunctionErrorReason.InvalidFunctionForCallPlaceholder;
				case "INVALID_FUNCTION_FOR_PLACEHOLDER": return FunctionErrorReason.InvalidFunctionForPlaceholder;
				case "INVALID_OPERAND": return FunctionErrorReason.InvalidOperand;
				case "MISSING_CONSTANT_OPERAND_VALUE": return FunctionErrorReason.MissingConstantOperandValue;
				case "INVALID_CONSTANT_OPERAND_VALUE": return FunctionErrorReason.InvalidConstantOperandValue;
				case "INVALID_NESTING": return FunctionErrorReason.InvalidNesting;
				case "MULTIPLE_FEED_IDS_NOT_SUPPORTED": return FunctionErrorReason.MultipleFeedIdsNotSupported;
				case "INVALID_FUNCTION_FOR_FEED_WITH_FIXED_SCHEMA": return FunctionErrorReason.InvalidFunctionForFeedWithFixedSchema;
				case "INVALID_ATTRIBUTE_NAME": return FunctionErrorReason.InvalidAttributeName;
				case "UNKNOWN": return FunctionErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FunctionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class FunctionOperatorExtensions
	{
		public static string ToXmlValue(this FunctionOperator enumValue)
		{
			switch (enumValue)
			{
				case FunctionOperator.In: return "IN";
				case FunctionOperator.Identity: return "IDENTITY";
				case FunctionOperator.Equals: return "EQUALS";
				case FunctionOperator.And: return "AND";
				case FunctionOperator.ContainsAny: return "CONTAINS_ANY";
				case FunctionOperator.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FunctionOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "IN": return FunctionOperator.In;
				case "IDENTITY": return FunctionOperator.Identity;
				case "EQUALS": return FunctionOperator.Equals;
				case "AND": return FunctionOperator.And;
				case "CONTAINS_ANY": return FunctionOperator.ContainsAny;
				case "UNKNOWN": return FunctionOperator.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FunctionOperator.", nameof(xmlValue));
			}
		}
	}
	public static class FunctionParsingErrorReasonExtensions
	{
		public static string ToXmlValue(this FunctionParsingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case FunctionParsingErrorReason.NoMoreInput: return "NO_MORE_INPUT";
				case FunctionParsingErrorReason.ExpectedCharacter: return "EXPECTED_CHARACTER";
				case FunctionParsingErrorReason.UnexpectedSeparator: return "UNEXPECTED_SEPARATOR";
				case FunctionParsingErrorReason.UnmatchedLeftBracket: return "UNMATCHED_LEFT_BRACKET";
				case FunctionParsingErrorReason.UnmatchedRightBracket: return "UNMATCHED_RIGHT_BRACKET";
				case FunctionParsingErrorReason.TooManyNestedFunctions: return "TOO_MANY_NESTED_FUNCTIONS";
				case FunctionParsingErrorReason.MissingRightHandOperand: return "MISSING_RIGHT_HAND_OPERAND";
				case FunctionParsingErrorReason.InvalidOperatorName: return "INVALID_OPERATOR_NAME";
				case FunctionParsingErrorReason.FeedAttributeOperandArgumentNotInteger: return "FEED_ATTRIBUTE_OPERAND_ARGUMENT_NOT_INTEGER";
				case FunctionParsingErrorReason.NoOperands: return "NO_OPERANDS";
				case FunctionParsingErrorReason.TooManyOperands: return "TOO_MANY_OPERANDS";
				case FunctionParsingErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static FunctionParsingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NO_MORE_INPUT": return FunctionParsingErrorReason.NoMoreInput;
				case "EXPECTED_CHARACTER": return FunctionParsingErrorReason.ExpectedCharacter;
				case "UNEXPECTED_SEPARATOR": return FunctionParsingErrorReason.UnexpectedSeparator;
				case "UNMATCHED_LEFT_BRACKET": return FunctionParsingErrorReason.UnmatchedLeftBracket;
				case "UNMATCHED_RIGHT_BRACKET": return FunctionParsingErrorReason.UnmatchedRightBracket;
				case "TOO_MANY_NESTED_FUNCTIONS": return FunctionParsingErrorReason.TooManyNestedFunctions;
				case "MISSING_RIGHT_HAND_OPERAND": return FunctionParsingErrorReason.MissingRightHandOperand;
				case "INVALID_OPERATOR_NAME": return FunctionParsingErrorReason.InvalidOperatorName;
				case "FEED_ATTRIBUTE_OPERAND_ARGUMENT_NOT_INTEGER": return FunctionParsingErrorReason.FeedAttributeOperandArgumentNotInteger;
				case "NO_OPERANDS": return FunctionParsingErrorReason.NoOperands;
				case "TOO_MANY_OPERANDS": return FunctionParsingErrorReason.TooManyOperands;
				case "UNKNOWN": return FunctionParsingErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type FunctionParsingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class GenderGenderTypeExtensions
	{
		public static string ToXmlValue(this GenderGenderType enumValue)
		{
			switch (enumValue)
			{
				case GenderGenderType.GenderMale: return "GENDER_MALE";
				case GenderGenderType.GenderFemale: return "GENDER_FEMALE";
				case GenderGenderType.GenderUndetermined: return "GENDER_UNDETERMINED";
				default: return null;
			}
		}
		public static GenderGenderType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "GENDER_MALE": return GenderGenderType.GenderMale;
				case "GENDER_FEMALE": return GenderGenderType.GenderFemale;
				case "GENDER_UNDETERMINED": return GenderGenderType.GenderUndetermined;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type GenderGenderType.", nameof(xmlValue));
			}
		}
	}
	public static class GeoRestrictionExtensions
	{
		public static string ToXmlValue(this GeoRestriction enumValue)
		{
			switch (enumValue)
			{
				case GeoRestriction.Unknown: return "UNKNOWN";
				case GeoRestriction.LocationOfPresence: return "LOCATION_OF_PRESENCE";
				default: return null;
			}
		}
		public static GeoRestriction Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return GeoRestriction.Unknown;
				case "LOCATION_OF_PRESENCE": return GeoRestriction.LocationOfPresence;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type GeoRestriction.", nameof(xmlValue));
			}
		}
	}
	public static class GeoTargetTypeSettingNegativeGeoTargetTypeExtensions
	{
		public static string ToXmlValue(this GeoTargetTypeSettingNegativeGeoTargetType enumValue)
		{
			switch (enumValue)
			{
				case GeoTargetTypeSettingNegativeGeoTargetType.DontCare: return "DONT_CARE";
				case GeoTargetTypeSettingNegativeGeoTargetType.LocationOfPresence: return "LOCATION_OF_PRESENCE";
				default: return null;
			}
		}
		public static GeoTargetTypeSettingNegativeGeoTargetType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DONT_CARE": return GeoTargetTypeSettingNegativeGeoTargetType.DontCare;
				case "LOCATION_OF_PRESENCE": return GeoTargetTypeSettingNegativeGeoTargetType.LocationOfPresence;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type GeoTargetTypeSettingNegativeGeoTargetType.", nameof(xmlValue));
			}
		}
	}
	public static class GeoTargetTypeSettingPositiveGeoTargetTypeExtensions
	{
		public static string ToXmlValue(this GeoTargetTypeSettingPositiveGeoTargetType enumValue)
		{
			switch (enumValue)
			{
				case GeoTargetTypeSettingPositiveGeoTargetType.DontCare: return "DONT_CARE";
				case GeoTargetTypeSettingPositiveGeoTargetType.AreaOfInterest: return "AREA_OF_INTEREST";
				case GeoTargetTypeSettingPositiveGeoTargetType.LocationOfPresence: return "LOCATION_OF_PRESENCE";
				default: return null;
			}
		}
		public static GeoTargetTypeSettingPositiveGeoTargetType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DONT_CARE": return GeoTargetTypeSettingPositiveGeoTargetType.DontCare;
				case "AREA_OF_INTEREST": return GeoTargetTypeSettingPositiveGeoTargetType.AreaOfInterest;
				case "LOCATION_OF_PRESENCE": return GeoTargetTypeSettingPositiveGeoTargetType.LocationOfPresence;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type GeoTargetTypeSettingPositiveGeoTargetType.", nameof(xmlValue));
			}
		}
	}
	public static class IdeaTypeExtensions
	{
		public static string ToXmlValue(this IdeaType enumValue)
		{
			switch (enumValue)
			{
				case IdeaType.Keyword: return "KEYWORD";
				default: return null;
			}
		}
		public static IdeaType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "KEYWORD": return IdeaType.Keyword;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type IdeaType.", nameof(xmlValue));
			}
		}
	}
	public static class IdErrorReasonExtensions
	{
		public static string ToXmlValue(this IdErrorReason enumValue)
		{
			switch (enumValue)
			{
				case IdErrorReason.NotFound: return "NOT_FOUND";
				default: return null;
			}
		}
		public static IdErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NOT_FOUND": return IdErrorReason.NotFound;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type IdErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ImageErrorReasonExtensions
	{
		public static string ToXmlValue(this ImageErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ImageErrorReason.InvalidImage: return "INVALID_IMAGE";
				case ImageErrorReason.StorageError: return "STORAGE_ERROR";
				case ImageErrorReason.BadRequest: return "BAD_REQUEST";
				case ImageErrorReason.UnexpectedSize: return "UNEXPECTED_SIZE";
				case ImageErrorReason.AnimatedNotAllowed: return "ANIMATED_NOT_ALLOWED";
				case ImageErrorReason.AnimationTooLong: return "ANIMATION_TOO_LONG";
				case ImageErrorReason.ServerError: return "SERVER_ERROR";
				case ImageErrorReason.CmykJpegNotAllowed: return "CMYK_JPEG_NOT_ALLOWED";
				case ImageErrorReason.FlashNotAllowed: return "FLASH_NOT_ALLOWED";
				case ImageErrorReason.FlashWithoutClicktag: return "FLASH_WITHOUT_CLICKTAG";
				case ImageErrorReason.FlashErrorAfterFixingClickTag: return "FLASH_ERROR_AFTER_FIXING_CLICK_TAG";
				case ImageErrorReason.AnimatedVisualEffect: return "ANIMATED_VISUAL_EFFECT";
				case ImageErrorReason.FlashError: return "FLASH_ERROR";
				case ImageErrorReason.LayoutProblem: return "LAYOUT_PROBLEM";
				case ImageErrorReason.ProblemReadingImageFile: return "PROBLEM_READING_IMAGE_FILE";
				case ImageErrorReason.ErrorStoringImage: return "ERROR_STORING_IMAGE";
				case ImageErrorReason.AspectRatioNotAllowed: return "ASPECT_RATIO_NOT_ALLOWED";
				case ImageErrorReason.FlashHasNetworkObjects: return "FLASH_HAS_NETWORK_OBJECTS";
				case ImageErrorReason.FlashHasNetworkMethods: return "FLASH_HAS_NETWORK_METHODS";
				case ImageErrorReason.FlashHasUrl: return "FLASH_HAS_URL";
				case ImageErrorReason.FlashHasMouseTracking: return "FLASH_HAS_MOUSE_TRACKING";
				case ImageErrorReason.FlashHasRandomNum: return "FLASH_HAS_RANDOM_NUM";
				case ImageErrorReason.FlashSelfTargets: return "FLASH_SELF_TARGETS";
				case ImageErrorReason.FlashBadGeturlTarget: return "FLASH_BAD_GETURL_TARGET";
				case ImageErrorReason.FlashVersionNotSupported: return "FLASH_VERSION_NOT_SUPPORTED";
				case ImageErrorReason.FlashWithoutHardCodedClickUrl: return "FLASH_WITHOUT_HARD_CODED_CLICK_URL";
				case ImageErrorReason.InvalidFlashFile: return "INVALID_FLASH_FILE";
				case ImageErrorReason.FailedToFixClickTagInFlash: return "FAILED_TO_FIX_CLICK_TAG_IN_FLASH";
				case ImageErrorReason.FlashAccessesNetworkResources: return "FLASH_ACCESSES_NETWORK_RESOURCES";
				case ImageErrorReason.FlashExternalJsCall: return "FLASH_EXTERNAL_JS_CALL";
				case ImageErrorReason.FlashExternalFsCall: return "FLASH_EXTERNAL_FS_CALL";
				case ImageErrorReason.FileTooLarge: return "FILE_TOO_LARGE";
				case ImageErrorReason.ImageDataTooLarge: return "IMAGE_DATA_TOO_LARGE";
				case ImageErrorReason.ImageProcessingError: return "IMAGE_PROCESSING_ERROR";
				case ImageErrorReason.ImageTooSmall: return "IMAGE_TOO_SMALL";
				case ImageErrorReason.InvalidInput: return "INVALID_INPUT";
				case ImageErrorReason.ProblemReadingFile: return "PROBLEM_READING_FILE";
				default: return null;
			}
		}
		public static ImageErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_IMAGE": return ImageErrorReason.InvalidImage;
				case "STORAGE_ERROR": return ImageErrorReason.StorageError;
				case "BAD_REQUEST": return ImageErrorReason.BadRequest;
				case "UNEXPECTED_SIZE": return ImageErrorReason.UnexpectedSize;
				case "ANIMATED_NOT_ALLOWED": return ImageErrorReason.AnimatedNotAllowed;
				case "ANIMATION_TOO_LONG": return ImageErrorReason.AnimationTooLong;
				case "SERVER_ERROR": return ImageErrorReason.ServerError;
				case "CMYK_JPEG_NOT_ALLOWED": return ImageErrorReason.CmykJpegNotAllowed;
				case "FLASH_NOT_ALLOWED": return ImageErrorReason.FlashNotAllowed;
				case "FLASH_WITHOUT_CLICKTAG": return ImageErrorReason.FlashWithoutClicktag;
				case "FLASH_ERROR_AFTER_FIXING_CLICK_TAG": return ImageErrorReason.FlashErrorAfterFixingClickTag;
				case "ANIMATED_VISUAL_EFFECT": return ImageErrorReason.AnimatedVisualEffect;
				case "FLASH_ERROR": return ImageErrorReason.FlashError;
				case "LAYOUT_PROBLEM": return ImageErrorReason.LayoutProblem;
				case "PROBLEM_READING_IMAGE_FILE": return ImageErrorReason.ProblemReadingImageFile;
				case "ERROR_STORING_IMAGE": return ImageErrorReason.ErrorStoringImage;
				case "ASPECT_RATIO_NOT_ALLOWED": return ImageErrorReason.AspectRatioNotAllowed;
				case "FLASH_HAS_NETWORK_OBJECTS": return ImageErrorReason.FlashHasNetworkObjects;
				case "FLASH_HAS_NETWORK_METHODS": return ImageErrorReason.FlashHasNetworkMethods;
				case "FLASH_HAS_URL": return ImageErrorReason.FlashHasUrl;
				case "FLASH_HAS_MOUSE_TRACKING": return ImageErrorReason.FlashHasMouseTracking;
				case "FLASH_HAS_RANDOM_NUM": return ImageErrorReason.FlashHasRandomNum;
				case "FLASH_SELF_TARGETS": return ImageErrorReason.FlashSelfTargets;
				case "FLASH_BAD_GETURL_TARGET": return ImageErrorReason.FlashBadGeturlTarget;
				case "FLASH_VERSION_NOT_SUPPORTED": return ImageErrorReason.FlashVersionNotSupported;
				case "FLASH_WITHOUT_HARD_CODED_CLICK_URL": return ImageErrorReason.FlashWithoutHardCodedClickUrl;
				case "INVALID_FLASH_FILE": return ImageErrorReason.InvalidFlashFile;
				case "FAILED_TO_FIX_CLICK_TAG_IN_FLASH": return ImageErrorReason.FailedToFixClickTagInFlash;
				case "FLASH_ACCESSES_NETWORK_RESOURCES": return ImageErrorReason.FlashAccessesNetworkResources;
				case "FLASH_EXTERNAL_JS_CALL": return ImageErrorReason.FlashExternalJsCall;
				case "FLASH_EXTERNAL_FS_CALL": return ImageErrorReason.FlashExternalFsCall;
				case "FILE_TOO_LARGE": return ImageErrorReason.FileTooLarge;
				case "IMAGE_DATA_TOO_LARGE": return ImageErrorReason.ImageDataTooLarge;
				case "IMAGE_PROCESSING_ERROR": return ImageErrorReason.ImageProcessingError;
				case "IMAGE_TOO_SMALL": return ImageErrorReason.ImageTooSmall;
				case "INVALID_INPUT": return ImageErrorReason.InvalidInput;
				case "PROBLEM_READING_FILE": return ImageErrorReason.ProblemReadingFile;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ImageErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class IncomeTierExtensions
	{
		public static string ToXmlValue(this IncomeTier enumValue)
		{
			switch (enumValue)
			{
				case IncomeTier.Unknown: return "UNKNOWN";
				case IncomeTier.Tier1: return "TIER_1";
				case IncomeTier.Tier2: return "TIER_2";
				case IncomeTier.Tier3: return "TIER_3";
				case IncomeTier.Tier4: return "TIER_4";
				case IncomeTier.Tier5: return "TIER_5";
				case IncomeTier.Tier6To10: return "TIER_6_TO_10";
				default: return null;
			}
		}
		public static IncomeTier Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return IncomeTier.Unknown;
				case "TIER_1": return IncomeTier.Tier1;
				case "TIER_2": return IncomeTier.Tier2;
				case "TIER_3": return IncomeTier.Tier3;
				case "TIER_4": return IncomeTier.Tier4;
				case "TIER_5": return IncomeTier.Tier5;
				case "TIER_6_TO_10": return IncomeTier.Tier6To10;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type IncomeTier.", nameof(xmlValue));
			}
		}
	}
	public static class InternalApiErrorReasonExtensions
	{
		public static string ToXmlValue(this InternalApiErrorReason enumValue)
		{
			switch (enumValue)
			{
				case InternalApiErrorReason.UnexpectedInternalApiError: return "UNEXPECTED_INTERNAL_API_ERROR";
				case InternalApiErrorReason.TransientError: return "TRANSIENT_ERROR";
				case InternalApiErrorReason.Unknown: return "UNKNOWN";
				case InternalApiErrorReason.Downtime: return "DOWNTIME";
				default: return null;
			}
		}
		public static InternalApiErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNEXPECTED_INTERNAL_API_ERROR": return InternalApiErrorReason.UnexpectedInternalApiError;
				case "TRANSIENT_ERROR": return InternalApiErrorReason.TransientError;
				case "UNKNOWN": return InternalApiErrorReason.Unknown;
				case "DOWNTIME": return InternalApiErrorReason.Downtime;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type InternalApiErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class KeywordMatchTypeExtensions
	{
		public static string ToXmlValue(this KeywordMatchType enumValue)
		{
			switch (enumValue)
			{
				case KeywordMatchType.Exact: return "EXACT";
				case KeywordMatchType.Phrase: return "PHRASE";
				case KeywordMatchType.Broad: return "BROAD";
				default: return null;
			}
		}
		public static KeywordMatchType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EXACT": return KeywordMatchType.Exact;
				case "PHRASE": return KeywordMatchType.Phrase;
				case "BROAD": return KeywordMatchType.Broad;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type KeywordMatchType.", nameof(xmlValue));
			}
		}
	}
	public static class LabelErrorReasonExtensions
	{
		public static string ToXmlValue(this LabelErrorReason enumValue)
		{
			switch (enumValue)
			{
				case LabelErrorReason.DuplicateName: return "DUPLICATE_NAME";
				case LabelErrorReason.InvalidLabelName: return "INVALID_LABEL_NAME";
				case LabelErrorReason.InvalidLabelType: return "INVALID_LABEL_TYPE";
				case LabelErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static LabelErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DUPLICATE_NAME": return LabelErrorReason.DuplicateName;
				case "INVALID_LABEL_NAME": return LabelErrorReason.InvalidLabelName;
				case "INVALID_LABEL_TYPE": return LabelErrorReason.InvalidLabelType;
				case "UNKNOWN": return LabelErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type LabelErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class LabelServiceErrorReasonExtensions
	{
		public static string ToXmlValue(this LabelServiceErrorReason enumValue)
		{
			switch (enumValue)
			{
				case LabelServiceErrorReason.EmptyLabelName: return "EMPTY_LABEL_NAME";
				case LabelServiceErrorReason.LabelNameTooLong: return "LABEL_NAME_TOO_LONG";
				case LabelServiceErrorReason.DuplicateLabelName: return "DUPLICATE_LABEL_NAME";
				case LabelServiceErrorReason.ReservedLabelName: return "RESERVED_LABEL_NAME";
				case LabelServiceErrorReason.CannotBeDeleted: return "CANNOT_BE_DELETED";
				case LabelServiceErrorReason.TooManyLabels: return "TOO_MANY_LABELS";
				case LabelServiceErrorReason.InvalidLabelId: return "INVALID_LABEL_ID";
				case LabelServiceErrorReason.CustomerCannotCreateLabels: return "CUSTOMER_CANNOT_CREATE_LABELS";
				case LabelServiceErrorReason.ServerClientVersionMismatch: return "SERVER_CLIENT_VERSION_MISMATCH";
				default: return null;
			}
		}
		public static LabelServiceErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EMPTY_LABEL_NAME": return LabelServiceErrorReason.EmptyLabelName;
				case "LABEL_NAME_TOO_LONG": return LabelServiceErrorReason.LabelNameTooLong;
				case "DUPLICATE_LABEL_NAME": return LabelServiceErrorReason.DuplicateLabelName;
				case "RESERVED_LABEL_NAME": return LabelServiceErrorReason.ReservedLabelName;
				case "CANNOT_BE_DELETED": return LabelServiceErrorReason.CannotBeDeleted;
				case "TOO_MANY_LABELS": return LabelServiceErrorReason.TooManyLabels;
				case "INVALID_LABEL_ID": return LabelServiceErrorReason.InvalidLabelId;
				case "CUSTOMER_CANNOT_CREATE_LABELS": return LabelServiceErrorReason.CustomerCannotCreateLabels;
				case "SERVER_CLIENT_VERSION_MISMATCH": return LabelServiceErrorReason.ServerClientVersionMismatch;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type LabelServiceErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class LabelStatusExtensions
	{
		public static string ToXmlValue(this LabelStatus enumValue)
		{
			switch (enumValue)
			{
				case LabelStatus.Enabled: return "ENABLED";
				case LabelStatus.Removed: return "REMOVED";
				case LabelStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static LabelStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return LabelStatus.Enabled;
				case "REMOVED": return LabelStatus.Removed;
				case "UNKNOWN": return LabelStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type LabelStatus.", nameof(xmlValue));
			}
		}
	}
	public static class LevelExtensions
	{
		public static string ToXmlValue(this Level enumValue)
		{
			switch (enumValue)
			{
				case Level.Creative: return "CREATIVE";
				case Level.Adgroup: return "ADGROUP";
				case Level.Campaign: return "CAMPAIGN";
				case Level.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static Level Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CREATIVE": return Level.Creative;
				case "ADGROUP": return Level.Adgroup;
				case "CAMPAIGN": return Level.Campaign;
				case "UNKNOWN": return Level.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type Level.", nameof(xmlValue));
			}
		}
	}
	public static class LinkStatusExtensions
	{
		public static string ToXmlValue(this LinkStatus enumValue)
		{
			switch (enumValue)
			{
				case LinkStatus.Active: return "ACTIVE";
				case LinkStatus.Inactive: return "INACTIVE";
				case LinkStatus.Pending: return "PENDING";
				case LinkStatus.Refused: return "REFUSED";
				case LinkStatus.Cancelled: return "CANCELLED";
				case LinkStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static LinkStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACTIVE": return LinkStatus.Active;
				case "INACTIVE": return LinkStatus.Inactive;
				case "PENDING": return LinkStatus.Pending;
				case "REFUSED": return LinkStatus.Refused;
				case "CANCELLED": return LinkStatus.Cancelled;
				case "UNKNOWN": return LinkStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type LinkStatus.", nameof(xmlValue));
			}
		}
	}
	public static class ListErrorReasonExtensions
	{
		public static string ToXmlValue(this ListErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ListErrorReason.ClearUnsupported: return "CLEAR_UNSUPPORTED";
				case ListErrorReason.InvalidOperator: return "INVALID_OPERATOR";
				case ListErrorReason.InvalidElement: return "INVALID_ELEMENT";
				case ListErrorReason.ListLengthMismatch: return "LIST_LENGTH_MISMATCH";
				case ListErrorReason.DuplicateElement: return "DUPLICATE_ELEMENT";
				case ListErrorReason.MutateUnsupported: return "MUTATE_UNSUPPORTED";
				case ListErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ListErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CLEAR_UNSUPPORTED": return ListErrorReason.ClearUnsupported;
				case "INVALID_OPERATOR": return ListErrorReason.InvalidOperator;
				case "INVALID_ELEMENT": return ListErrorReason.InvalidElement;
				case "LIST_LENGTH_MISMATCH": return ListErrorReason.ListLengthMismatch;
				case "DUPLICATE_ELEMENT": return ListErrorReason.DuplicateElement;
				case "MUTATE_UNSUPPORTED": return ListErrorReason.MutateUnsupported;
				case "UNKNOWN": return ListErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ListErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ListOperationsListOperatorExtensions
	{
		public static string ToXmlValue(this ListOperationsListOperator enumValue)
		{
			switch (enumValue)
			{
				case ListOperationsListOperator.Put: return "PUT";
				case ListOperationsListOperator.Remove: return "REMOVE";
				case ListOperationsListOperator.Update: return "UPDATE";
				case ListOperationsListOperator.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ListOperationsListOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "PUT": return ListOperationsListOperator.Put;
				case "REMOVE": return ListOperationsListOperator.Remove;
				case "UPDATE": return ListOperationsListOperator.Update;
				case "UNKNOWN": return ListOperationsListOperator.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ListOperationsListOperator.", nameof(xmlValue));
			}
		}
	}
	public static class LocationCriterionServiceErrorReasonExtensions
	{
		public static string ToXmlValue(this LocationCriterionServiceErrorReason enumValue)
		{
			switch (enumValue)
			{
				case LocationCriterionServiceErrorReason.RequiredLocationCriterionPredicateMissing: return "REQUIRED_LOCATION_CRITERION_PREDICATE_MISSING";
				case LocationCriterionServiceErrorReason.TooManyLocationCriterionPredicatesSpecified: return "TOO_MANY_LOCATION_CRITERION_PREDICATES_SPECIFIED";
				case LocationCriterionServiceErrorReason.InvalidCountryCode: return "INVALID_COUNTRY_CODE";
				case LocationCriterionServiceErrorReason.LocationCriterionServiceError: return "LOCATION_CRITERION_SERVICE_ERROR";
				default: return null;
			}
		}
		public static LocationCriterionServiceErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "REQUIRED_LOCATION_CRITERION_PREDICATE_MISSING": return LocationCriterionServiceErrorReason.RequiredLocationCriterionPredicateMissing;
				case "TOO_MANY_LOCATION_CRITERION_PREDICATES_SPECIFIED": return LocationCriterionServiceErrorReason.TooManyLocationCriterionPredicatesSpecified;
				case "INVALID_COUNTRY_CODE": return LocationCriterionServiceErrorReason.InvalidCountryCode;
				case "LOCATION_CRITERION_SERVICE_ERROR": return LocationCriterionServiceErrorReason.LocationCriterionServiceError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type LocationCriterionServiceErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class LocationTargetingStatusExtensions
	{
		public static string ToXmlValue(this LocationTargetingStatus enumValue)
		{
			switch (enumValue)
			{
				case LocationTargetingStatus.Active: return "ACTIVE";
				case LocationTargetingStatus.Obsolete: return "OBSOLETE";
				case LocationTargetingStatus.PhasingOut: return "PHASING_OUT";
				default: return null;
			}
		}
		public static LocationTargetingStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACTIVE": return LocationTargetingStatus.Active;
				case "OBSOLETE": return LocationTargetingStatus.Obsolete;
				case "PHASING_OUT": return LocationTargetingStatus.PhasingOut;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type LocationTargetingStatus.", nameof(xmlValue));
			}
		}
	}
	public static class ManagedCustomerServiceErrorReasonExtensions
	{
		public static string ToXmlValue(this ManagedCustomerServiceErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ManagedCustomerServiceErrorReason.Unknown: return "UNKNOWN";
				case ManagedCustomerServiceErrorReason.NotAuthorized: return "NOT_AUTHORIZED";
				case ManagedCustomerServiceErrorReason.InvalidSelector: return "INVALID_SELECTOR";
				case ManagedCustomerServiceErrorReason.InvalidTimezone: return "INVALID_TIMEZONE";
				case ManagedCustomerServiceErrorReason.InvalidCurrency: return "INVALID_CURRENCY";
				case ManagedCustomerServiceErrorReason.InvalidDescriptiveName: return "INVALID_DESCRIPTIVE_NAME";
				case ManagedCustomerServiceErrorReason.AddCustomerFailure: return "ADD_CUSTOMER_FAILURE";
				case ManagedCustomerServiceErrorReason.SaveCustomersFailure: return "SAVE_CUSTOMERS_FAILURE";
				case ManagedCustomerServiceErrorReason.AlreadyManagedByThisManager: return "ALREADY_MANAGED_BY_THIS_MANAGER";
				case ManagedCustomerServiceErrorReason.AlreadyInvitedByThisManager: return "ALREADY_INVITED_BY_THIS_MANAGER";
				case ManagedCustomerServiceErrorReason.AlreadyManagedInHierarchy: return "ALREADY_MANAGED_IN_HIERARCHY";
				case ManagedCustomerServiceErrorReason.AlreadyManagedForUiAccess: return "ALREADY_MANAGED_FOR_UI_ACCESS";
				case ManagedCustomerServiceErrorReason.MaxLinkDepthExceeded: return "MAX_LINK_DEPTH_EXCEEDED";
				case ManagedCustomerServiceErrorReason.NoPendingInvitation: return "NO_PENDING_INVITATION";
				case ManagedCustomerServiceErrorReason.TooManyAccounts: return "TOO_MANY_ACCOUNTS";
				case ManagedCustomerServiceErrorReason.TooManyAccountsAtManager: return "TOO_MANY_ACCOUNTS_AT_MANAGER";
				case ManagedCustomerServiceErrorReason.TooManyUiApiManagers: return "TOO_MANY_UI_API_MANAGERS";
				case ManagedCustomerServiceErrorReason.TestAccountLinkError: return "TEST_ACCOUNT_LINK_ERROR";
				case ManagedCustomerServiceErrorReason.InvalidLabelId: return "INVALID_LABEL_ID";
				case ManagedCustomerServiceErrorReason.CannotApplyInactiveLabel: return "CANNOT_APPLY_INACTIVE_LABEL";
				case ManagedCustomerServiceErrorReason.AppliedLabelToTooManyAccounts: return "APPLIED_LABEL_TO_TOO_MANY_ACCOUNTS";
				default: return null;
			}
		}
		public static ManagedCustomerServiceErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ManagedCustomerServiceErrorReason.Unknown;
				case "NOT_AUTHORIZED": return ManagedCustomerServiceErrorReason.NotAuthorized;
				case "INVALID_SELECTOR": return ManagedCustomerServiceErrorReason.InvalidSelector;
				case "INVALID_TIMEZONE": return ManagedCustomerServiceErrorReason.InvalidTimezone;
				case "INVALID_CURRENCY": return ManagedCustomerServiceErrorReason.InvalidCurrency;
				case "INVALID_DESCRIPTIVE_NAME": return ManagedCustomerServiceErrorReason.InvalidDescriptiveName;
				case "ADD_CUSTOMER_FAILURE": return ManagedCustomerServiceErrorReason.AddCustomerFailure;
				case "SAVE_CUSTOMERS_FAILURE": return ManagedCustomerServiceErrorReason.SaveCustomersFailure;
				case "ALREADY_MANAGED_BY_THIS_MANAGER": return ManagedCustomerServiceErrorReason.AlreadyManagedByThisManager;
				case "ALREADY_INVITED_BY_THIS_MANAGER": return ManagedCustomerServiceErrorReason.AlreadyInvitedByThisManager;
				case "ALREADY_MANAGED_IN_HIERARCHY": return ManagedCustomerServiceErrorReason.AlreadyManagedInHierarchy;
				case "ALREADY_MANAGED_FOR_UI_ACCESS": return ManagedCustomerServiceErrorReason.AlreadyManagedForUiAccess;
				case "MAX_LINK_DEPTH_EXCEEDED": return ManagedCustomerServiceErrorReason.MaxLinkDepthExceeded;
				case "NO_PENDING_INVITATION": return ManagedCustomerServiceErrorReason.NoPendingInvitation;
				case "TOO_MANY_ACCOUNTS": return ManagedCustomerServiceErrorReason.TooManyAccounts;
				case "TOO_MANY_ACCOUNTS_AT_MANAGER": return ManagedCustomerServiceErrorReason.TooManyAccountsAtManager;
				case "TOO_MANY_UI_API_MANAGERS": return ManagedCustomerServiceErrorReason.TooManyUiApiManagers;
				case "TEST_ACCOUNT_LINK_ERROR": return ManagedCustomerServiceErrorReason.TestAccountLinkError;
				case "INVALID_LABEL_ID": return ManagedCustomerServiceErrorReason.InvalidLabelId;
				case "CANNOT_APPLY_INACTIVE_LABEL": return ManagedCustomerServiceErrorReason.CannotApplyInactiveLabel;
				case "APPLIED_LABEL_TO_TOO_MANY_ACCOUNTS": return ManagedCustomerServiceErrorReason.AppliedLabelToTooManyAccounts;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ManagedCustomerServiceErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class MediaBundleErrorReasonExtensions
	{
		public static string ToXmlValue(this MediaBundleErrorReason enumValue)
		{
			switch (enumValue)
			{
				case MediaBundleErrorReason.EntryPointCannotBeSetUsingMediaService: return "ENTRY_POINT_CANNOT_BE_SET_USING_MEDIA_SERVICE";
				case MediaBundleErrorReason.BadRequest: return "BAD_REQUEST";
				case MediaBundleErrorReason.DoubleclickBundleNotAllowed: return "DOUBLECLICK_BUNDLE_NOT_ALLOWED";
				case MediaBundleErrorReason.ExternalUrlNotAllowed: return "EXTERNAL_URL_NOT_ALLOWED";
				case MediaBundleErrorReason.FileTooLarge: return "FILE_TOO_LARGE";
				case MediaBundleErrorReason.GoogleWebDesignerZipFileNotPublished: return "GOOGLE_WEB_DESIGNER_ZIP_FILE_NOT_PUBLISHED";
				case MediaBundleErrorReason.InvalidInput: return "INVALID_INPUT";
				case MediaBundleErrorReason.InvalidMediaBundle: return "INVALID_MEDIA_BUNDLE";
				case MediaBundleErrorReason.InvalidMediaBundleEntry: return "INVALID_MEDIA_BUNDLE_ENTRY";
				case MediaBundleErrorReason.InvalidMimeType: return "INVALID_MIME_TYPE";
				case MediaBundleErrorReason.InvalidPath: return "INVALID_PATH";
				case MediaBundleErrorReason.InvalidUrlReference: return "INVALID_URL_REFERENCE";
				case MediaBundleErrorReason.MediaDataTooLarge: return "MEDIA_DATA_TOO_LARGE";
				case MediaBundleErrorReason.MissingPrimaryMediaBundleEntry: return "MISSING_PRIMARY_MEDIA_BUNDLE_ENTRY";
				case MediaBundleErrorReason.ServerError: return "SERVER_ERROR";
				case MediaBundleErrorReason.StorageError: return "STORAGE_ERROR";
				case MediaBundleErrorReason.SwiffyBundleNotAllowed: return "SWIFFY_BUNDLE_NOT_ALLOWED";
				case MediaBundleErrorReason.TooManyFiles: return "TOO_MANY_FILES";
				case MediaBundleErrorReason.UnexpectedSize: return "UNEXPECTED_SIZE";
				case MediaBundleErrorReason.UnsupportedGoogleWebDesignerEnvironment: return "UNSUPPORTED_GOOGLE_WEB_DESIGNER_ENVIRONMENT";
				case MediaBundleErrorReason.UnsupportedHtml5Feature: return "UNSUPPORTED_HTML5_FEATURE";
				case MediaBundleErrorReason.UrlInMediaBundleNotSslCompliant: return "URL_IN_MEDIA_BUNDLE_NOT_SSL_COMPLIANT";
				default: return null;
			}
		}
		public static MediaBundleErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENTRY_POINT_CANNOT_BE_SET_USING_MEDIA_SERVICE": return MediaBundleErrorReason.EntryPointCannotBeSetUsingMediaService;
				case "BAD_REQUEST": return MediaBundleErrorReason.BadRequest;
				case "DOUBLECLICK_BUNDLE_NOT_ALLOWED": return MediaBundleErrorReason.DoubleclickBundleNotAllowed;
				case "EXTERNAL_URL_NOT_ALLOWED": return MediaBundleErrorReason.ExternalUrlNotAllowed;
				case "FILE_TOO_LARGE": return MediaBundleErrorReason.FileTooLarge;
				case "GOOGLE_WEB_DESIGNER_ZIP_FILE_NOT_PUBLISHED": return MediaBundleErrorReason.GoogleWebDesignerZipFileNotPublished;
				case "INVALID_INPUT": return MediaBundleErrorReason.InvalidInput;
				case "INVALID_MEDIA_BUNDLE": return MediaBundleErrorReason.InvalidMediaBundle;
				case "INVALID_MEDIA_BUNDLE_ENTRY": return MediaBundleErrorReason.InvalidMediaBundleEntry;
				case "INVALID_MIME_TYPE": return MediaBundleErrorReason.InvalidMimeType;
				case "INVALID_PATH": return MediaBundleErrorReason.InvalidPath;
				case "INVALID_URL_REFERENCE": return MediaBundleErrorReason.InvalidUrlReference;
				case "MEDIA_DATA_TOO_LARGE": return MediaBundleErrorReason.MediaDataTooLarge;
				case "MISSING_PRIMARY_MEDIA_BUNDLE_ENTRY": return MediaBundleErrorReason.MissingPrimaryMediaBundleEntry;
				case "SERVER_ERROR": return MediaBundleErrorReason.ServerError;
				case "STORAGE_ERROR": return MediaBundleErrorReason.StorageError;
				case "SWIFFY_BUNDLE_NOT_ALLOWED": return MediaBundleErrorReason.SwiffyBundleNotAllowed;
				case "TOO_MANY_FILES": return MediaBundleErrorReason.TooManyFiles;
				case "UNEXPECTED_SIZE": return MediaBundleErrorReason.UnexpectedSize;
				case "UNSUPPORTED_GOOGLE_WEB_DESIGNER_ENVIRONMENT": return MediaBundleErrorReason.UnsupportedGoogleWebDesignerEnvironment;
				case "UNSUPPORTED_HTML5_FEATURE": return MediaBundleErrorReason.UnsupportedHtml5Feature;
				case "URL_IN_MEDIA_BUNDLE_NOT_SSL_COMPLIANT": return MediaBundleErrorReason.UrlInMediaBundleNotSslCompliant;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MediaBundleErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class MediaErrorReasonExtensions
	{
		public static string ToXmlValue(this MediaErrorReason enumValue)
		{
			switch (enumValue)
			{
				case MediaErrorReason.CannotAddStandardIcon: return "CANNOT_ADD_STANDARD_ICON";
				case MediaErrorReason.CannotSelectStandardIconWithOtherTypes: return "CANNOT_SELECT_STANDARD_ICON_WITH_OTHER_TYPES";
				case MediaErrorReason.CannotSpecifyMediaIdAndData: return "CANNOT_SPECIFY_MEDIA_ID_AND_DATA";
				case MediaErrorReason.DuplicateMedia: return "DUPLICATE_MEDIA";
				case MediaErrorReason.EmptyField: return "EMPTY_FIELD";
				case MediaErrorReason.EntityReferencedInMultipleOps: return "ENTITY_REFERENCED_IN_MULTIPLE_OPS";
				case MediaErrorReason.FieldNotSupportedForMediaSubType: return "FIELD_NOT_SUPPORTED_FOR_MEDIA_SUB_TYPE";
				case MediaErrorReason.InvalidMediaId: return "INVALID_MEDIA_ID";
				case MediaErrorReason.InvalidMediaSubType: return "INVALID_MEDIA_SUB_TYPE";
				case MediaErrorReason.InvalidMediaType: return "INVALID_MEDIA_TYPE";
				case MediaErrorReason.InvalidMimeType: return "INVALID_MIME_TYPE";
				case MediaErrorReason.InvalidReferenceId: return "INVALID_REFERENCE_ID";
				case MediaErrorReason.InvalidYouTubeId: return "INVALID_YOU_TUBE_ID";
				case MediaErrorReason.MediaFailedTranscoding: return "MEDIA_FAILED_TRANSCODING";
				case MediaErrorReason.MediaNotTranscoded: return "MEDIA_NOT_TRANSCODED";
				case MediaErrorReason.MediaTypeDoesNotMatchObjectType: return "MEDIA_TYPE_DOES_NOT_MATCH_OBJECT_TYPE";
				case MediaErrorReason.NoFieldsSpecified: return "NO_FIELDS_SPECIFIED";
				case MediaErrorReason.NullReferenceIdAndMediaId: return "NULL_REFERENCE_ID_AND_MEDIA_ID";
				case MediaErrorReason.TooLong: return "TOO_LONG";
				case MediaErrorReason.UnsupportedOperation: return "UNSUPPORTED_OPERATION";
				case MediaErrorReason.UnsupportedType: return "UNSUPPORTED_TYPE";
				case MediaErrorReason.YouTubeServiceUnavailable: return "YOU_TUBE_SERVICE_UNAVAILABLE";
				case MediaErrorReason.YouTubeVideoHasNonPositiveDuration: return "YOU_TUBE_VIDEO_HAS_NON_POSITIVE_DURATION";
				case MediaErrorReason.YouTubeVideoNotFound: return "YOU_TUBE_VIDEO_NOT_FOUND";
				default: return null;
			}
		}
		public static MediaErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_ADD_STANDARD_ICON": return MediaErrorReason.CannotAddStandardIcon;
				case "CANNOT_SELECT_STANDARD_ICON_WITH_OTHER_TYPES": return MediaErrorReason.CannotSelectStandardIconWithOtherTypes;
				case "CANNOT_SPECIFY_MEDIA_ID_AND_DATA": return MediaErrorReason.CannotSpecifyMediaIdAndData;
				case "DUPLICATE_MEDIA": return MediaErrorReason.DuplicateMedia;
				case "EMPTY_FIELD": return MediaErrorReason.EmptyField;
				case "ENTITY_REFERENCED_IN_MULTIPLE_OPS": return MediaErrorReason.EntityReferencedInMultipleOps;
				case "FIELD_NOT_SUPPORTED_FOR_MEDIA_SUB_TYPE": return MediaErrorReason.FieldNotSupportedForMediaSubType;
				case "INVALID_MEDIA_ID": return MediaErrorReason.InvalidMediaId;
				case "INVALID_MEDIA_SUB_TYPE": return MediaErrorReason.InvalidMediaSubType;
				case "INVALID_MEDIA_TYPE": return MediaErrorReason.InvalidMediaType;
				case "INVALID_MIME_TYPE": return MediaErrorReason.InvalidMimeType;
				case "INVALID_REFERENCE_ID": return MediaErrorReason.InvalidReferenceId;
				case "INVALID_YOU_TUBE_ID": return MediaErrorReason.InvalidYouTubeId;
				case "MEDIA_FAILED_TRANSCODING": return MediaErrorReason.MediaFailedTranscoding;
				case "MEDIA_NOT_TRANSCODED": return MediaErrorReason.MediaNotTranscoded;
				case "MEDIA_TYPE_DOES_NOT_MATCH_OBJECT_TYPE": return MediaErrorReason.MediaTypeDoesNotMatchObjectType;
				case "NO_FIELDS_SPECIFIED": return MediaErrorReason.NoFieldsSpecified;
				case "NULL_REFERENCE_ID_AND_MEDIA_ID": return MediaErrorReason.NullReferenceIdAndMediaId;
				case "TOO_LONG": return MediaErrorReason.TooLong;
				case "UNSUPPORTED_OPERATION": return MediaErrorReason.UnsupportedOperation;
				case "UNSUPPORTED_TYPE": return MediaErrorReason.UnsupportedType;
				case "YOU_TUBE_SERVICE_UNAVAILABLE": return MediaErrorReason.YouTubeServiceUnavailable;
				case "YOU_TUBE_VIDEO_HAS_NON_POSITIVE_DURATION": return MediaErrorReason.YouTubeVideoHasNonPositiveDuration;
				case "YOU_TUBE_VIDEO_NOT_FOUND": return MediaErrorReason.YouTubeVideoNotFound;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MediaErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class MediaMediaTypeExtensions
	{
		public static string ToXmlValue(this MediaMediaType enumValue)
		{
			switch (enumValue)
			{
				case MediaMediaType.Audio: return "AUDIO";
				case MediaMediaType.DynamicImage: return "DYNAMIC_IMAGE";
				case MediaMediaType.Icon: return "ICON";
				case MediaMediaType.Image: return "IMAGE";
				case MediaMediaType.StandardIcon: return "STANDARD_ICON";
				case MediaMediaType.Video: return "VIDEO";
				case MediaMediaType.MediaBundle: return "MEDIA_BUNDLE";
				default: return null;
			}
		}
		public static MediaMediaType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AUDIO": return MediaMediaType.Audio;
				case "DYNAMIC_IMAGE": return MediaMediaType.DynamicImage;
				case "ICON": return MediaMediaType.Icon;
				case "IMAGE": return MediaMediaType.Image;
				case "STANDARD_ICON": return MediaMediaType.StandardIcon;
				case "VIDEO": return MediaMediaType.Video;
				case "MEDIA_BUNDLE": return MediaMediaType.MediaBundle;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MediaMediaType.", nameof(xmlValue));
			}
		}
	}
	public static class MediaMimeTypeExtensions
	{
		public static string ToXmlValue(this MediaMimeType enumValue)
		{
			switch (enumValue)
			{
				case MediaMimeType.ImageJpeg: return "IMAGE_JPEG";
				case MediaMimeType.ImageGif: return "IMAGE_GIF";
				case MediaMimeType.ImagePng: return "IMAGE_PNG";
				case MediaMimeType.Flash: return "FLASH";
				case MediaMimeType.TextHtml: return "TEXT_HTML";
				case MediaMimeType.Pdf: return "PDF";
				case MediaMimeType.Msword: return "MSWORD";
				case MediaMimeType.Msexcel: return "MSEXCEL";
				case MediaMimeType.Rtf: return "RTF";
				case MediaMimeType.AudioWav: return "AUDIO_WAV";
				case MediaMimeType.AudioMp3: return "AUDIO_MP3";
				case MediaMimeType.Html5AdZip: return "HTML5_AD_ZIP";
				default: return null;
			}
		}
		public static MediaMimeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "IMAGE_JPEG": return MediaMimeType.ImageJpeg;
				case "IMAGE_GIF": return MediaMimeType.ImageGif;
				case "IMAGE_PNG": return MediaMimeType.ImagePng;
				case "FLASH": return MediaMimeType.Flash;
				case "TEXT_HTML": return MediaMimeType.TextHtml;
				case "PDF": return MediaMimeType.Pdf;
				case "MSWORD": return MediaMimeType.Msword;
				case "MSEXCEL": return MediaMimeType.Msexcel;
				case "RTF": return MediaMimeType.Rtf;
				case "AUDIO_WAV": return MediaMimeType.AudioWav;
				case "AUDIO_MP3": return MediaMimeType.AudioMp3;
				case "HTML5_AD_ZIP": return MediaMimeType.Html5AdZip;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MediaMimeType.", nameof(xmlValue));
			}
		}
	}
	public static class MediaSizeExtensions
	{
		public static string ToXmlValue(this MediaSize enumValue)
		{
			switch (enumValue)
			{
				case MediaSize.Full: return "FULL";
				case MediaSize.Shrunken: return "SHRUNKEN";
				case MediaSize.Preview: return "PREVIEW";
				case MediaSize.VideoThumbnail: return "VIDEO_THUMBNAIL";
				default: return null;
			}
		}
		public static MediaSize Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "FULL": return MediaSize.Full;
				case "SHRUNKEN": return MediaSize.Shrunken;
				case "PREVIEW": return MediaSize.Preview;
				case "VIDEO_THUMBNAIL": return MediaSize.VideoThumbnail;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MediaSize.", nameof(xmlValue));
			}
		}
	}
	public static class MinuteOfHourExtensions
	{
		public static string ToXmlValue(this MinuteOfHour enumValue)
		{
			switch (enumValue)
			{
				case MinuteOfHour.Zero: return "ZERO";
				case MinuteOfHour.Fifteen: return "FIFTEEN";
				case MinuteOfHour.Thirty: return "THIRTY";
				case MinuteOfHour.FortyFive: return "FORTY_FIVE";
				default: return null;
			}
		}
		public static MinuteOfHour Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ZERO": return MinuteOfHour.Zero;
				case "FIFTEEN": return MinuteOfHour.Fifteen;
				case "THIRTY": return MinuteOfHour.Thirty;
				case "FORTY_FIVE": return MinuteOfHour.FortyFive;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MinuteOfHour.", nameof(xmlValue));
			}
		}
	}
	public static class MobileDeviceDeviceTypeExtensions
	{
		public static string ToXmlValue(this MobileDeviceDeviceType enumValue)
		{
			switch (enumValue)
			{
				case MobileDeviceDeviceType.DeviceTypeMobile: return "DEVICE_TYPE_MOBILE";
				case MobileDeviceDeviceType.DeviceTypeTablet: return "DEVICE_TYPE_TABLET";
				default: return null;
			}
		}
		public static MobileDeviceDeviceType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DEVICE_TYPE_MOBILE": return MobileDeviceDeviceType.DeviceTypeMobile;
				case "DEVICE_TYPE_TABLET": return MobileDeviceDeviceType.DeviceTypeTablet;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MobileDeviceDeviceType.", nameof(xmlValue));
			}
		}
	}
	public static class MultiplierErrorReasonExtensions
	{
		public static string ToXmlValue(this MultiplierErrorReason enumValue)
		{
			switch (enumValue)
			{
				case MultiplierErrorReason.MultiplierTooHigh: return "MULTIPLIER_TOO_HIGH";
				case MultiplierErrorReason.MultiplierTooLow: return "MULTIPLIER_TOO_LOW";
				case MultiplierErrorReason.TooManyFractionalDigits: return "TOO_MANY_FRACTIONAL_DIGITS";
				case MultiplierErrorReason.MultiplierNotAllowedForBiddingStrategy: return "MULTIPLIER_NOT_ALLOWED_FOR_BIDDING_STRATEGY";
				case MultiplierErrorReason.MultiplierNotAllowedWhenBaseBidIsMissing: return "MULTIPLIER_NOT_ALLOWED_WHEN_BASE_BID_IS_MISSING";
				case MultiplierErrorReason.NoMultiplierSpecified: return "NO_MULTIPLIER_SPECIFIED";
				case MultiplierErrorReason.MultiplierCausesBidToExceedDailyBudget: return "MULTIPLIER_CAUSES_BID_TO_EXCEED_DAILY_BUDGET";
				case MultiplierErrorReason.MultiplierCausesBidToExceedMonthlyBudget: return "MULTIPLIER_CAUSES_BID_TO_EXCEED_MONTHLY_BUDGET";
				case MultiplierErrorReason.MultiplierCausesBidToExceedCustomBudget: return "MULTIPLIER_CAUSES_BID_TO_EXCEED_CUSTOM_BUDGET";
				case MultiplierErrorReason.MultiplierCausesBidToExceedMaxAllowedBid: return "MULTIPLIER_CAUSES_BID_TO_EXCEED_MAX_ALLOWED_BID";
				case MultiplierErrorReason.BidLessThanMinAllowedBidWithMultiplier: return "BID_LESS_THAN_MIN_ALLOWED_BID_WITH_MULTIPLIER";
				case MultiplierErrorReason.MultiplierAndBiddingStrategyTypeMismatch: return "MULTIPLIER_AND_BIDDING_STRATEGY_TYPE_MISMATCH";
				case MultiplierErrorReason.MultiplierError: return "MULTIPLIER_ERROR";
				default: return null;
			}
		}
		public static MultiplierErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "MULTIPLIER_TOO_HIGH": return MultiplierErrorReason.MultiplierTooHigh;
				case "MULTIPLIER_TOO_LOW": return MultiplierErrorReason.MultiplierTooLow;
				case "TOO_MANY_FRACTIONAL_DIGITS": return MultiplierErrorReason.TooManyFractionalDigits;
				case "MULTIPLIER_NOT_ALLOWED_FOR_BIDDING_STRATEGY": return MultiplierErrorReason.MultiplierNotAllowedForBiddingStrategy;
				case "MULTIPLIER_NOT_ALLOWED_WHEN_BASE_BID_IS_MISSING": return MultiplierErrorReason.MultiplierNotAllowedWhenBaseBidIsMissing;
				case "NO_MULTIPLIER_SPECIFIED": return MultiplierErrorReason.NoMultiplierSpecified;
				case "MULTIPLIER_CAUSES_BID_TO_EXCEED_DAILY_BUDGET": return MultiplierErrorReason.MultiplierCausesBidToExceedDailyBudget;
				case "MULTIPLIER_CAUSES_BID_TO_EXCEED_MONTHLY_BUDGET": return MultiplierErrorReason.MultiplierCausesBidToExceedMonthlyBudget;
				case "MULTIPLIER_CAUSES_BID_TO_EXCEED_CUSTOM_BUDGET": return MultiplierErrorReason.MultiplierCausesBidToExceedCustomBudget;
				case "MULTIPLIER_CAUSES_BID_TO_EXCEED_MAX_ALLOWED_BID": return MultiplierErrorReason.MultiplierCausesBidToExceedMaxAllowedBid;
				case "BID_LESS_THAN_MIN_ALLOWED_BID_WITH_MULTIPLIER": return MultiplierErrorReason.BidLessThanMinAllowedBidWithMultiplier;
				case "MULTIPLIER_AND_BIDDING_STRATEGY_TYPE_MISMATCH": return MultiplierErrorReason.MultiplierAndBiddingStrategyTypeMismatch;
				case "MULTIPLIER_ERROR": return MultiplierErrorReason.MultiplierError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MultiplierErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class MutateMembersErrorReasonExtensions
	{
		public static string ToXmlValue(this MutateMembersErrorReason enumValue)
		{
			switch (enumValue)
			{
				case MutateMembersErrorReason.Unknown: return "UNKNOWN";
				case MutateMembersErrorReason.UnsupportedMethod: return "UNSUPPORTED_METHOD";
				case MutateMembersErrorReason.InvalidUserListId: return "INVALID_USER_LIST_ID";
				case MutateMembersErrorReason.InvalidUserListType: return "INVALID_USER_LIST_TYPE";
				case MutateMembersErrorReason.InvalidDataType: return "INVALID_DATA_TYPE";
				case MutateMembersErrorReason.InvalidSha256Format: return "INVALID_SHA256_FORMAT";
				case MutateMembersErrorReason.OperatorConflictForSameUserListId: return "OPERATOR_CONFLICT_FOR_SAME_USER_LIST_ID";
				case MutateMembersErrorReason.InvalidRemoveallOperation: return "INVALID_REMOVEALL_OPERATION";
				case MutateMembersErrorReason.InvalidOperationOrder: return "INVALID_OPERATION_ORDER";
				default: return null;
			}
		}
		public static MutateMembersErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return MutateMembersErrorReason.Unknown;
				case "UNSUPPORTED_METHOD": return MutateMembersErrorReason.UnsupportedMethod;
				case "INVALID_USER_LIST_ID": return MutateMembersErrorReason.InvalidUserListId;
				case "INVALID_USER_LIST_TYPE": return MutateMembersErrorReason.InvalidUserListType;
				case "INVALID_DATA_TYPE": return MutateMembersErrorReason.InvalidDataType;
				case "INVALID_SHA256_FORMAT": return MutateMembersErrorReason.InvalidSha256Format;
				case "OPERATOR_CONFLICT_FOR_SAME_USER_LIST_ID": return MutateMembersErrorReason.OperatorConflictForSameUserListId;
				case "INVALID_REMOVEALL_OPERATION": return MutateMembersErrorReason.InvalidRemoveallOperation;
				case "INVALID_OPERATION_ORDER": return MutateMembersErrorReason.InvalidOperationOrder;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MutateMembersErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class MutateMembersOperandDataTypeExtensions
	{
		public static string ToXmlValue(this MutateMembersOperandDataType enumValue)
		{
			switch (enumValue)
			{
				case MutateMembersOperandDataType.EmailSha256: return "EMAIL_SHA256";
				default: return null;
			}
		}
		public static MutateMembersOperandDataType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EMAIL_SHA256": return MutateMembersOperandDataType.EmailSha256;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type MutateMembersOperandDataType.", nameof(xmlValue));
			}
		}
	}
	public static class NewEntityCreationErrorReasonExtensions
	{
		public static string ToXmlValue(this NewEntityCreationErrorReason enumValue)
		{
			switch (enumValue)
			{
				case NewEntityCreationErrorReason.CannotSetIdForAdd: return "CANNOT_SET_ID_FOR_ADD";
				case NewEntityCreationErrorReason.DuplicateTempIds: return "DUPLICATE_TEMP_IDS";
				case NewEntityCreationErrorReason.TempIdEntityHadErrors: return "TEMP_ID_ENTITY_HAD_ERRORS";
				default: return null;
			}
		}
		public static NewEntityCreationErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CANNOT_SET_ID_FOR_ADD": return NewEntityCreationErrorReason.CannotSetIdForAdd;
				case "DUPLICATE_TEMP_IDS": return NewEntityCreationErrorReason.DuplicateTempIds;
				case "TEMP_ID_ENTITY_HAD_ERRORS": return NewEntityCreationErrorReason.TempIdEntityHadErrors;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type NewEntityCreationErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class NotEmptyErrorReasonExtensions
	{
		public static string ToXmlValue(this NotEmptyErrorReason enumValue)
		{
			switch (enumValue)
			{
				case NotEmptyErrorReason.EmptyList: return "EMPTY_LIST";
				default: return null;
			}
		}
		public static NotEmptyErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EMPTY_LIST": return NotEmptyErrorReason.EmptyList;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type NotEmptyErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class NotWhitelistedErrorReasonExtensions
	{
		public static string ToXmlValue(this NotWhitelistedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case NotWhitelistedErrorReason.CustomerNotWhitelistedForApi: return "CUSTOMER_NOT_WHITELISTED_FOR_API";
				default: return null;
			}
		}
		public static NotWhitelistedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CUSTOMER_NOT_WHITELISTED_FOR_API": return NotWhitelistedErrorReason.CustomerNotWhitelistedForApi;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type NotWhitelistedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class NullErrorReasonExtensions
	{
		public static string ToXmlValue(this NullErrorReason enumValue)
		{
			switch (enumValue)
			{
				case NullErrorReason.NullContent: return "NULL_CONTENT";
				default: return null;
			}
		}
		public static NullErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NULL_CONTENT": return NullErrorReason.NullContent;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type NullErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class NumberRuleItemNumberOperatorExtensions
	{
		public static string ToXmlValue(this NumberRuleItemNumberOperator enumValue)
		{
			switch (enumValue)
			{
				case NumberRuleItemNumberOperator.Unknown: return "UNKNOWN";
				case NumberRuleItemNumberOperator.GreaterThan: return "GREATER_THAN";
				case NumberRuleItemNumberOperator.GreaterThanOrEqual: return "GREATER_THAN_OR_EQUAL";
				case NumberRuleItemNumberOperator.Equals: return "EQUALS";
				case NumberRuleItemNumberOperator.NotEqual: return "NOT_EQUAL";
				case NumberRuleItemNumberOperator.LessThan: return "LESS_THAN";
				case NumberRuleItemNumberOperator.LessThanOrEqual: return "LESS_THAN_OR_EQUAL";
				default: return null;
			}
		}
		public static NumberRuleItemNumberOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return NumberRuleItemNumberOperator.Unknown;
				case "GREATER_THAN": return NumberRuleItemNumberOperator.GreaterThan;
				case "GREATER_THAN_OR_EQUAL": return NumberRuleItemNumberOperator.GreaterThanOrEqual;
				case "EQUALS": return NumberRuleItemNumberOperator.Equals;
				case "NOT_EQUAL": return NumberRuleItemNumberOperator.NotEqual;
				case "LESS_THAN": return NumberRuleItemNumberOperator.LessThan;
				case "LESS_THAN_OR_EQUAL": return NumberRuleItemNumberOperator.LessThanOrEqual;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type NumberRuleItemNumberOperator.", nameof(xmlValue));
			}
		}
	}
	public static class OfflineCallConversionErrorReasonExtensions
	{
		public static string ToXmlValue(this OfflineCallConversionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case OfflineCallConversionErrorReason.ConversionPrecedesCall: return "CONVERSION_PRECEDES_CALL";
				case OfflineCallConversionErrorReason.FutureCallStartTime: return "FUTURE_CALL_START_TIME";
				case OfflineCallConversionErrorReason.FutureConversionTime: return "FUTURE_CONVERSION_TIME";
				case OfflineCallConversionErrorReason.ExpiredCall: return "EXPIRED_CALL";
				case OfflineCallConversionErrorReason.TooRecentCall: return "TOO_RECENT_CALL";
				case OfflineCallConversionErrorReason.UnparseableCallersPhoneNumber: return "UNPARSEABLE_CALLERS_PHONE_NUMBER";
				case OfflineCallConversionErrorReason.InvalidCall: return "INVALID_CALL";
				case OfflineCallConversionErrorReason.UnauthorizedUser: return "UNAUTHORIZED_USER";
				case OfflineCallConversionErrorReason.InvalidConversionType: return "INVALID_CONVERSION_TYPE";
				case OfflineCallConversionErrorReason.TooRecentConversionType: return "TOO_RECENT_CONVERSION_TYPE";
				case OfflineCallConversionErrorReason.ConversionTrackingNotEnabledAtCallTime: return "CONVERSION_TRACKING_NOT_ENABLED_AT_CALL_TIME";
				case OfflineCallConversionErrorReason.DesktopCallNotSupported: return "DESKTOP_CALL_NOT_SUPPORTED";
				case OfflineCallConversionErrorReason.InternalError: return "INTERNAL_ERROR";
				case OfflineCallConversionErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static OfflineCallConversionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CONVERSION_PRECEDES_CALL": return OfflineCallConversionErrorReason.ConversionPrecedesCall;
				case "FUTURE_CALL_START_TIME": return OfflineCallConversionErrorReason.FutureCallStartTime;
				case "FUTURE_CONVERSION_TIME": return OfflineCallConversionErrorReason.FutureConversionTime;
				case "EXPIRED_CALL": return OfflineCallConversionErrorReason.ExpiredCall;
				case "TOO_RECENT_CALL": return OfflineCallConversionErrorReason.TooRecentCall;
				case "UNPARSEABLE_CALLERS_PHONE_NUMBER": return OfflineCallConversionErrorReason.UnparseableCallersPhoneNumber;
				case "INVALID_CALL": return OfflineCallConversionErrorReason.InvalidCall;
				case "UNAUTHORIZED_USER": return OfflineCallConversionErrorReason.UnauthorizedUser;
				case "INVALID_CONVERSION_TYPE": return OfflineCallConversionErrorReason.InvalidConversionType;
				case "TOO_RECENT_CONVERSION_TYPE": return OfflineCallConversionErrorReason.TooRecentConversionType;
				case "CONVERSION_TRACKING_NOT_ENABLED_AT_CALL_TIME": return OfflineCallConversionErrorReason.ConversionTrackingNotEnabledAtCallTime;
				case "DESKTOP_CALL_NOT_SUPPORTED": return OfflineCallConversionErrorReason.DesktopCallNotSupported;
				case "INTERNAL_ERROR": return OfflineCallConversionErrorReason.InternalError;
				case "UNKNOWN": return OfflineCallConversionErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type OfflineCallConversionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class OfflineConversionErrorReasonExtensions
	{
		public static string ToXmlValue(this OfflineConversionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case OfflineConversionErrorReason.UnparseableGclid: return "UNPARSEABLE_GCLID";
				case OfflineConversionErrorReason.ConversionPrecedesClick: return "CONVERSION_PRECEDES_CLICK";
				case OfflineConversionErrorReason.FutureConversionTime: return "FUTURE_CONVERSION_TIME";
				case OfflineConversionErrorReason.ExpiredClick: return "EXPIRED_CLICK";
				case OfflineConversionErrorReason.TooRecentClick: return "TOO_RECENT_CLICK";
				case OfflineConversionErrorReason.InvalidClick: return "INVALID_CLICK";
				case OfflineConversionErrorReason.UnauthorizedUser: return "UNAUTHORIZED_USER";
				case OfflineConversionErrorReason.InvalidConversionType: return "INVALID_CONVERSION_TYPE";
				case OfflineConversionErrorReason.TooRecentConversionType: return "TOO_RECENT_CONVERSION_TYPE";
				case OfflineConversionErrorReason.ClickMissingConversionLabel: return "CLICK_MISSING_CONVERSION_LABEL";
				case OfflineConversionErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static OfflineConversionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNPARSEABLE_GCLID": return OfflineConversionErrorReason.UnparseableGclid;
				case "CONVERSION_PRECEDES_CLICK": return OfflineConversionErrorReason.ConversionPrecedesClick;
				case "FUTURE_CONVERSION_TIME": return OfflineConversionErrorReason.FutureConversionTime;
				case "EXPIRED_CLICK": return OfflineConversionErrorReason.ExpiredClick;
				case "TOO_RECENT_CLICK": return OfflineConversionErrorReason.TooRecentClick;
				case "INVALID_CLICK": return OfflineConversionErrorReason.InvalidClick;
				case "UNAUTHORIZED_USER": return OfflineConversionErrorReason.UnauthorizedUser;
				case "INVALID_CONVERSION_TYPE": return OfflineConversionErrorReason.InvalidConversionType;
				case "TOO_RECENT_CONVERSION_TYPE": return OfflineConversionErrorReason.TooRecentConversionType;
				case "CLICK_MISSING_CONVERSION_LABEL": return OfflineConversionErrorReason.ClickMissingConversionLabel;
				case "UNKNOWN": return OfflineConversionErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type OfflineConversionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class OperatingSystemVersionOperatorTypeExtensions
	{
		public static string ToXmlValue(this OperatingSystemVersionOperatorType enumValue)
		{
			switch (enumValue)
			{
				case OperatingSystemVersionOperatorType.GreaterThanEqualTo: return "GREATER_THAN_EQUAL_TO";
				case OperatingSystemVersionOperatorType.EqualTo: return "EQUAL_TO";
				case OperatingSystemVersionOperatorType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static OperatingSystemVersionOperatorType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "GREATER_THAN_EQUAL_TO": return OperatingSystemVersionOperatorType.GreaterThanEqualTo;
				case "EQUAL_TO": return OperatingSystemVersionOperatorType.EqualTo;
				case "UNKNOWN": return OperatingSystemVersionOperatorType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type OperatingSystemVersionOperatorType.", nameof(xmlValue));
			}
		}
	}
	public static class OperationAccessDeniedReasonExtensions
	{
		public static string ToXmlValue(this OperationAccessDeniedReason enumValue)
		{
			switch (enumValue)
			{
				case OperationAccessDeniedReason.ActionNotPermitted: return "ACTION_NOT_PERMITTED";
				case OperationAccessDeniedReason.AddOperationNotPermitted: return "ADD_OPERATION_NOT_PERMITTED";
				case OperationAccessDeniedReason.RemoveOperationNotPermitted: return "REMOVE_OPERATION_NOT_PERMITTED";
				case OperationAccessDeniedReason.SetOperationNotPermitted: return "SET_OPERATION_NOT_PERMITTED";
				case OperationAccessDeniedReason.MutateActionNotPermittedForClient: return "MUTATE_ACTION_NOT_PERMITTED_FOR_CLIENT";
				case OperationAccessDeniedReason.OperationNotPermittedForCampaignType: return "OPERATION_NOT_PERMITTED_FOR_CAMPAIGN_TYPE";
				case OperationAccessDeniedReason.AddAsRemovedNotPermitted: return "ADD_AS_REMOVED_NOT_PERMITTED";
				case OperationAccessDeniedReason.OperationNotPermittedForRemovedEntity: return "OPERATION_NOT_PERMITTED_FOR_REMOVED_ENTITY";
				case OperationAccessDeniedReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static OperationAccessDeniedReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACTION_NOT_PERMITTED": return OperationAccessDeniedReason.ActionNotPermitted;
				case "ADD_OPERATION_NOT_PERMITTED": return OperationAccessDeniedReason.AddOperationNotPermitted;
				case "REMOVE_OPERATION_NOT_PERMITTED": return OperationAccessDeniedReason.RemoveOperationNotPermitted;
				case "SET_OPERATION_NOT_PERMITTED": return OperationAccessDeniedReason.SetOperationNotPermitted;
				case "MUTATE_ACTION_NOT_PERMITTED_FOR_CLIENT": return OperationAccessDeniedReason.MutateActionNotPermittedForClient;
				case "OPERATION_NOT_PERMITTED_FOR_CAMPAIGN_TYPE": return OperationAccessDeniedReason.OperationNotPermittedForCampaignType;
				case "ADD_AS_REMOVED_NOT_PERMITTED": return OperationAccessDeniedReason.AddAsRemovedNotPermitted;
				case "OPERATION_NOT_PERMITTED_FOR_REMOVED_ENTITY": return OperationAccessDeniedReason.OperationNotPermittedForRemovedEntity;
				case "UNKNOWN": return OperationAccessDeniedReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type OperationAccessDeniedReason.", nameof(xmlValue));
			}
		}
	}
	public static class OperatorExtensions
	{
		public static string ToXmlValue(this Operator enumValue)
		{
			switch (enumValue)
			{
				case Operator.Add: return "ADD";
				case Operator.Remove: return "REMOVE";
				case Operator.Set: return "SET";
				default: return null;
			}
		}
		public static Operator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ADD": return Operator.Add;
				case "REMOVE": return Operator.Remove;
				case "SET": return Operator.Set;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type Operator.", nameof(xmlValue));
			}
		}
	}
	public static class OperatorErrorReasonExtensions
	{
		public static string ToXmlValue(this OperatorErrorReason enumValue)
		{
			switch (enumValue)
			{
				case OperatorErrorReason.OperatorNotSupported: return "OPERATOR_NOT_SUPPORTED";
				default: return null;
			}
		}
		public static OperatorErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "OPERATOR_NOT_SUPPORTED": return OperatorErrorReason.OperatorNotSupported;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type OperatorErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class PageOnePromotedBiddingSchemeStrategyGoalExtensions
	{
		public static string ToXmlValue(this PageOnePromotedBiddingSchemeStrategyGoal enumValue)
		{
			switch (enumValue)
			{
				case PageOnePromotedBiddingSchemeStrategyGoal.PageOne: return "PAGE_ONE";
				case PageOnePromotedBiddingSchemeStrategyGoal.PageOnePromoted: return "PAGE_ONE_PROMOTED";
				default: return null;
			}
		}
		public static PageOnePromotedBiddingSchemeStrategyGoal Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "PAGE_ONE": return PageOnePromotedBiddingSchemeStrategyGoal.PageOne;
				case "PAGE_ONE_PROMOTED": return PageOnePromotedBiddingSchemeStrategyGoal.PageOnePromoted;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PageOnePromotedBiddingSchemeStrategyGoal.", nameof(xmlValue));
			}
		}
	}
	public static class PagingErrorReasonExtensions
	{
		public static string ToXmlValue(this PagingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case PagingErrorReason.StartIndexCannotBeNegative: return "START_INDEX_CANNOT_BE_NEGATIVE";
				case PagingErrorReason.NumberOfResultsCannotBeNegative: return "NUMBER_OF_RESULTS_CANNOT_BE_NEGATIVE";
				case PagingErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static PagingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "START_INDEX_CANNOT_BE_NEGATIVE": return PagingErrorReason.StartIndexCannotBeNegative;
				case "NUMBER_OF_RESULTS_CANNOT_BE_NEGATIVE": return PagingErrorReason.NumberOfResultsCannotBeNegative;
				case "UNKNOWN": return PagingErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PagingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ParentParentTypeExtensions
	{
		public static string ToXmlValue(this ParentParentType enumValue)
		{
			switch (enumValue)
			{
				case ParentParentType.ParentParent: return "PARENT_PARENT";
				case ParentParentType.ParentNotAParent: return "PARENT_NOT_A_PARENT";
				case ParentParentType.ParentUndetermined: return "PARENT_UNDETERMINED";
				case ParentParentType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ParentParentType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "PARENT_PARENT": return ParentParentType.ParentParent;
				case "PARENT_NOT_A_PARENT": return ParentParentType.ParentNotAParent;
				case "PARENT_UNDETERMINED": return ParentParentType.ParentUndetermined;
				case "UNKNOWN": return ParentParentType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ParentParentType.", nameof(xmlValue));
			}
		}
	}
	public static class PlacesOfInterestOperandCategoryExtensions
	{
		public static string ToXmlValue(this PlacesOfInterestOperandCategory enumValue)
		{
			switch (enumValue)
			{
				case PlacesOfInterestOperandCategory.Airport: return "AIRPORT";
				case PlacesOfInterestOperandCategory.Downtown: return "DOWNTOWN";
				case PlacesOfInterestOperandCategory.University: return "UNIVERSITY";
				case PlacesOfInterestOperandCategory.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static PlacesOfInterestOperandCategory Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "AIRPORT": return PlacesOfInterestOperandCategory.Airport;
				case "DOWNTOWN": return PlacesOfInterestOperandCategory.Downtown;
				case "UNIVERSITY": return PlacesOfInterestOperandCategory.University;
				case "UNKNOWN": return PlacesOfInterestOperandCategory.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PlacesOfInterestOperandCategory.", nameof(xmlValue));
			}
		}
	}
	public static class PolicyTopicEntryTypeExtensions
	{
		public static string ToXmlValue(this PolicyTopicEntryType enumValue)
		{
			switch (enumValue)
			{
				case PolicyTopicEntryType.Unknown: return "UNKNOWN";
				case PolicyTopicEntryType.Prohibited: return "PROHIBITED";
				case PolicyTopicEntryType.Limited: return "LIMITED";
				default: return null;
			}
		}
		public static PolicyTopicEntryType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return PolicyTopicEntryType.Unknown;
				case "PROHIBITED": return PolicyTopicEntryType.Prohibited;
				case "LIMITED": return PolicyTopicEntryType.Limited;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PolicyTopicEntryType.", nameof(xmlValue));
			}
		}
	}
	public static class PolicyTopicEvidenceTypeExtensions
	{
		public static string ToXmlValue(this PolicyTopicEvidenceType enumValue)
		{
			switch (enumValue)
			{
				case PolicyTopicEvidenceType.Unknown: return "UNKNOWN";
				case PolicyTopicEvidenceType.AdText: return "AD_TEXT";
				case PolicyTopicEvidenceType.HttpCode: return "HTTP_CODE";
				default: return null;
			}
		}
		public static PolicyTopicEvidenceType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return PolicyTopicEvidenceType.Unknown;
				case "AD_TEXT": return PolicyTopicEvidenceType.AdText;
				case "HTTP_CODE": return PolicyTopicEvidenceType.HttpCode;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PolicyTopicEvidenceType.", nameof(xmlValue));
			}
		}
	}
	public static class PredicateOperatorExtensions
	{
		public static string ToXmlValue(this PredicateOperator enumValue)
		{
			switch (enumValue)
			{
				case PredicateOperator.Equals: return "EQUALS";
				case PredicateOperator.NotEquals: return "NOT_EQUALS";
				case PredicateOperator.In: return "IN";
				case PredicateOperator.NotIn: return "NOT_IN";
				case PredicateOperator.GreaterThan: return "GREATER_THAN";
				case PredicateOperator.GreaterThanEquals: return "GREATER_THAN_EQUALS";
				case PredicateOperator.LessThan: return "LESS_THAN";
				case PredicateOperator.LessThanEquals: return "LESS_THAN_EQUALS";
				case PredicateOperator.StartsWith: return "STARTS_WITH";
				case PredicateOperator.StartsWithIgnoreCase: return "STARTS_WITH_IGNORE_CASE";
				case PredicateOperator.Contains: return "CONTAINS";
				case PredicateOperator.ContainsIgnoreCase: return "CONTAINS_IGNORE_CASE";
				case PredicateOperator.DoesNotContain: return "DOES_NOT_CONTAIN";
				case PredicateOperator.DoesNotContainIgnoreCase: return "DOES_NOT_CONTAIN_IGNORE_CASE";
				case PredicateOperator.ContainsAny: return "CONTAINS_ANY";
				case PredicateOperator.ContainsAll: return "CONTAINS_ALL";
				case PredicateOperator.ContainsNone: return "CONTAINS_NONE";
				case PredicateOperator.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static PredicateOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EQUALS": return PredicateOperator.Equals;
				case "NOT_EQUALS": return PredicateOperator.NotEquals;
				case "IN": return PredicateOperator.In;
				case "NOT_IN": return PredicateOperator.NotIn;
				case "GREATER_THAN": return PredicateOperator.GreaterThan;
				case "GREATER_THAN_EQUALS": return PredicateOperator.GreaterThanEquals;
				case "LESS_THAN": return PredicateOperator.LessThan;
				case "LESS_THAN_EQUALS": return PredicateOperator.LessThanEquals;
				case "STARTS_WITH": return PredicateOperator.StartsWith;
				case "STARTS_WITH_IGNORE_CASE": return PredicateOperator.StartsWithIgnoreCase;
				case "CONTAINS": return PredicateOperator.Contains;
				case "CONTAINS_IGNORE_CASE": return PredicateOperator.ContainsIgnoreCase;
				case "DOES_NOT_CONTAIN": return PredicateOperator.DoesNotContain;
				case "DOES_NOT_CONTAIN_IGNORE_CASE": return PredicateOperator.DoesNotContainIgnoreCase;
				case "CONTAINS_ANY": return PredicateOperator.ContainsAny;
				case "CONTAINS_ALL": return PredicateOperator.ContainsAll;
				case "CONTAINS_NONE": return PredicateOperator.ContainsNone;
				case "UNKNOWN": return PredicateOperator.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PredicateOperator.", nameof(xmlValue));
			}
		}
	}
	public static class PriceExtensionPriceQualifierExtensions
	{
		public static string ToXmlValue(this PriceExtensionPriceQualifier enumValue)
		{
			switch (enumValue)
			{
				case PriceExtensionPriceQualifier.Unknown: return "UNKNOWN";
				case PriceExtensionPriceQualifier.From: return "FROM";
				case PriceExtensionPriceQualifier.UpTo: return "UP_TO";
				case PriceExtensionPriceQualifier.None: return "NONE";
				default: return null;
			}
		}
		public static PriceExtensionPriceQualifier Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return PriceExtensionPriceQualifier.Unknown;
				case "FROM": return PriceExtensionPriceQualifier.From;
				case "UP_TO": return PriceExtensionPriceQualifier.UpTo;
				case "NONE": return PriceExtensionPriceQualifier.None;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PriceExtensionPriceQualifier.", nameof(xmlValue));
			}
		}
	}
	public static class PriceExtensionPriceUnitExtensions
	{
		public static string ToXmlValue(this PriceExtensionPriceUnit enumValue)
		{
			switch (enumValue)
			{
				case PriceExtensionPriceUnit.Unknown: return "UNKNOWN";
				case PriceExtensionPriceUnit.PerHour: return "PER_HOUR";
				case PriceExtensionPriceUnit.PerDay: return "PER_DAY";
				case PriceExtensionPriceUnit.PerWeek: return "PER_WEEK";
				case PriceExtensionPriceUnit.PerMonth: return "PER_MONTH";
				case PriceExtensionPriceUnit.PerYear: return "PER_YEAR";
				case PriceExtensionPriceUnit.None: return "NONE";
				default: return null;
			}
		}
		public static PriceExtensionPriceUnit Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return PriceExtensionPriceUnit.Unknown;
				case "PER_HOUR": return PriceExtensionPriceUnit.PerHour;
				case "PER_DAY": return PriceExtensionPriceUnit.PerDay;
				case "PER_WEEK": return PriceExtensionPriceUnit.PerWeek;
				case "PER_MONTH": return PriceExtensionPriceUnit.PerMonth;
				case "PER_YEAR": return PriceExtensionPriceUnit.PerYear;
				case "NONE": return PriceExtensionPriceUnit.None;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PriceExtensionPriceUnit.", nameof(xmlValue));
			}
		}
	}
	public static class PriceExtensionTypeExtensions
	{
		public static string ToXmlValue(this PriceExtensionType enumValue)
		{
			switch (enumValue)
			{
				case PriceExtensionType.Unknown: return "UNKNOWN";
				case PriceExtensionType.Brands: return "BRANDS";
				case PriceExtensionType.Events: return "EVENTS";
				case PriceExtensionType.Locations: return "LOCATIONS";
				case PriceExtensionType.Neighborhoods: return "NEIGHBORHOODS";
				case PriceExtensionType.ProductCategories: return "PRODUCT_CATEGORIES";
				case PriceExtensionType.ProductTiers: return "PRODUCT_TIERS";
				case PriceExtensionType.Services: return "SERVICES";
				case PriceExtensionType.ServiceCategories: return "SERVICE_CATEGORIES";
				case PriceExtensionType.ServiceTiers: return "SERVICE_TIERS";
				default: return null;
			}
		}
		public static PriceExtensionType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return PriceExtensionType.Unknown;
				case "BRANDS": return PriceExtensionType.Brands;
				case "EVENTS": return PriceExtensionType.Events;
				case "LOCATIONS": return PriceExtensionType.Locations;
				case "NEIGHBORHOODS": return PriceExtensionType.Neighborhoods;
				case "PRODUCT_CATEGORIES": return PriceExtensionType.ProductCategories;
				case "PRODUCT_TIERS": return PriceExtensionType.ProductTiers;
				case "SERVICES": return PriceExtensionType.Services;
				case "SERVICE_CATEGORIES": return PriceExtensionType.ServiceCategories;
				case "SERVICE_TIERS": return PriceExtensionType.ServiceTiers;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type PriceExtensionType.", nameof(xmlValue));
			}
		}
	}
	public static class ProductCanonicalConditionConditionExtensions
	{
		public static string ToXmlValue(this ProductCanonicalConditionCondition enumValue)
		{
			switch (enumValue)
			{
				case ProductCanonicalConditionCondition.New: return "NEW";
				case ProductCanonicalConditionCondition.Used: return "USED";
				case ProductCanonicalConditionCondition.Refurbished: return "REFURBISHED";
				case ProductCanonicalConditionCondition.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ProductCanonicalConditionCondition Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NEW": return ProductCanonicalConditionCondition.New;
				case "USED": return ProductCanonicalConditionCondition.Used;
				case "REFURBISHED": return ProductCanonicalConditionCondition.Refurbished;
				case "UNKNOWN": return ProductCanonicalConditionCondition.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ProductCanonicalConditionCondition.", nameof(xmlValue));
			}
		}
	}
	public static class ProductDimensionTypeExtensions
	{
		public static string ToXmlValue(this ProductDimensionType enumValue)
		{
			switch (enumValue)
			{
				case ProductDimensionType.Unknown: return "UNKNOWN";
				case ProductDimensionType.BiddingCategoryL1: return "BIDDING_CATEGORY_L1";
				case ProductDimensionType.BiddingCategoryL2: return "BIDDING_CATEGORY_L2";
				case ProductDimensionType.BiddingCategoryL3: return "BIDDING_CATEGORY_L3";
				case ProductDimensionType.BiddingCategoryL4: return "BIDDING_CATEGORY_L4";
				case ProductDimensionType.BiddingCategoryL5: return "BIDDING_CATEGORY_L5";
				case ProductDimensionType.Brand: return "BRAND";
				case ProductDimensionType.CanonicalCondition: return "CANONICAL_CONDITION";
				case ProductDimensionType.CustomAttribute0: return "CUSTOM_ATTRIBUTE_0";
				case ProductDimensionType.CustomAttribute1: return "CUSTOM_ATTRIBUTE_1";
				case ProductDimensionType.CustomAttribute2: return "CUSTOM_ATTRIBUTE_2";
				case ProductDimensionType.CustomAttribute3: return "CUSTOM_ATTRIBUTE_3";
				case ProductDimensionType.CustomAttribute4: return "CUSTOM_ATTRIBUTE_4";
				case ProductDimensionType.OfferId: return "OFFER_ID";
				case ProductDimensionType.ProductTypeL1: return "PRODUCT_TYPE_L1";
				case ProductDimensionType.ProductTypeL2: return "PRODUCT_TYPE_L2";
				case ProductDimensionType.ProductTypeL3: return "PRODUCT_TYPE_L3";
				case ProductDimensionType.ProductTypeL4: return "PRODUCT_TYPE_L4";
				case ProductDimensionType.ProductTypeL5: return "PRODUCT_TYPE_L5";
				case ProductDimensionType.Channel: return "CHANNEL";
				case ProductDimensionType.ChannelExclusivity: return "CHANNEL_EXCLUSIVITY";
				default: return null;
			}
		}
		public static ProductDimensionType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ProductDimensionType.Unknown;
				case "BIDDING_CATEGORY_L1": return ProductDimensionType.BiddingCategoryL1;
				case "BIDDING_CATEGORY_L2": return ProductDimensionType.BiddingCategoryL2;
				case "BIDDING_CATEGORY_L3": return ProductDimensionType.BiddingCategoryL3;
				case "BIDDING_CATEGORY_L4": return ProductDimensionType.BiddingCategoryL4;
				case "BIDDING_CATEGORY_L5": return ProductDimensionType.BiddingCategoryL5;
				case "BRAND": return ProductDimensionType.Brand;
				case "CANONICAL_CONDITION": return ProductDimensionType.CanonicalCondition;
				case "CUSTOM_ATTRIBUTE_0": return ProductDimensionType.CustomAttribute0;
				case "CUSTOM_ATTRIBUTE_1": return ProductDimensionType.CustomAttribute1;
				case "CUSTOM_ATTRIBUTE_2": return ProductDimensionType.CustomAttribute2;
				case "CUSTOM_ATTRIBUTE_3": return ProductDimensionType.CustomAttribute3;
				case "CUSTOM_ATTRIBUTE_4": return ProductDimensionType.CustomAttribute4;
				case "OFFER_ID": return ProductDimensionType.OfferId;
				case "PRODUCT_TYPE_L1": return ProductDimensionType.ProductTypeL1;
				case "PRODUCT_TYPE_L2": return ProductDimensionType.ProductTypeL2;
				case "PRODUCT_TYPE_L3": return ProductDimensionType.ProductTypeL3;
				case "PRODUCT_TYPE_L4": return ProductDimensionType.ProductTypeL4;
				case "PRODUCT_TYPE_L5": return ProductDimensionType.ProductTypeL5;
				case "CHANNEL": return ProductDimensionType.Channel;
				case "CHANNEL_EXCLUSIVITY": return ProductDimensionType.ChannelExclusivity;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ProductDimensionType.", nameof(xmlValue));
			}
		}
	}
	public static class ProductPartitionTypeExtensions
	{
		public static string ToXmlValue(this ProductPartitionType enumValue)
		{
			switch (enumValue)
			{
				case ProductPartitionType.Unknown: return "UNKNOWN";
				case ProductPartitionType.Subdivision: return "SUBDIVISION";
				case ProductPartitionType.Unit: return "UNIT";
				default: return null;
			}
		}
		public static ProductPartitionType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ProductPartitionType.Unknown;
				case "SUBDIVISION": return ProductPartitionType.Subdivision;
				case "UNIT": return ProductPartitionType.Unit;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ProductPartitionType.", nameof(xmlValue));
			}
		}
	}
	public static class ProximityDistanceUnitsExtensions
	{
		public static string ToXmlValue(this ProximityDistanceUnits enumValue)
		{
			switch (enumValue)
			{
				case ProximityDistanceUnits.Kilometers: return "KILOMETERS";
				case ProximityDistanceUnits.Miles: return "MILES";
				default: return null;
			}
		}
		public static ProximityDistanceUnits Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "KILOMETERS": return ProximityDistanceUnits.Kilometers;
				case "MILES": return ProximityDistanceUnits.Miles;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ProximityDistanceUnits.", nameof(xmlValue));
			}
		}
	}
	public static class QueryErrorReasonExtensions
	{
		public static string ToXmlValue(this QueryErrorReason enumValue)
		{
			switch (enumValue)
			{
				case QueryErrorReason.ParsingFailed: return "PARSING_FAILED";
				case QueryErrorReason.MissingQuery: return "MISSING_QUERY";
				case QueryErrorReason.MissingSelectClause: return "MISSING_SELECT_CLAUSE";
				case QueryErrorReason.MissingFromClause: return "MISSING_FROM_CLAUSE";
				case QueryErrorReason.InvalidSelectClause: return "INVALID_SELECT_CLAUSE";
				case QueryErrorReason.InvalidFromClause: return "INVALID_FROM_CLAUSE";
				case QueryErrorReason.InvalidWhereClause: return "INVALID_WHERE_CLAUSE";
				case QueryErrorReason.InvalidOrderByClause: return "INVALID_ORDER_BY_CLAUSE";
				case QueryErrorReason.InvalidLimitClause: return "INVALID_LIMIT_CLAUSE";
				case QueryErrorReason.InvalidStartIndexInLimitClause: return "INVALID_START_INDEX_IN_LIMIT_CLAUSE";
				case QueryErrorReason.InvalidPageSizeInLimitClause: return "INVALID_PAGE_SIZE_IN_LIMIT_CLAUSE";
				case QueryErrorReason.InvalidDuringClause: return "INVALID_DURING_CLAUSE";
				case QueryErrorReason.InvalidMinDateInDuringClause: return "INVALID_MIN_DATE_IN_DURING_CLAUSE";
				case QueryErrorReason.InvalidMaxDateInDuringClause: return "INVALID_MAX_DATE_IN_DURING_CLAUSE";
				case QueryErrorReason.MaxLessThanMinInDuringClause: return "MAX_LESS_THAN_MIN_IN_DURING_CLAUSE";
				case QueryErrorReason.ValidationFailed: return "VALIDATION_FAILED";
				default: return null;
			}
		}
		public static QueryErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "PARSING_FAILED": return QueryErrorReason.ParsingFailed;
				case "MISSING_QUERY": return QueryErrorReason.MissingQuery;
				case "MISSING_SELECT_CLAUSE": return QueryErrorReason.MissingSelectClause;
				case "MISSING_FROM_CLAUSE": return QueryErrorReason.MissingFromClause;
				case "INVALID_SELECT_CLAUSE": return QueryErrorReason.InvalidSelectClause;
				case "INVALID_FROM_CLAUSE": return QueryErrorReason.InvalidFromClause;
				case "INVALID_WHERE_CLAUSE": return QueryErrorReason.InvalidWhereClause;
				case "INVALID_ORDER_BY_CLAUSE": return QueryErrorReason.InvalidOrderByClause;
				case "INVALID_LIMIT_CLAUSE": return QueryErrorReason.InvalidLimitClause;
				case "INVALID_START_INDEX_IN_LIMIT_CLAUSE": return QueryErrorReason.InvalidStartIndexInLimitClause;
				case "INVALID_PAGE_SIZE_IN_LIMIT_CLAUSE": return QueryErrorReason.InvalidPageSizeInLimitClause;
				case "INVALID_DURING_CLAUSE": return QueryErrorReason.InvalidDuringClause;
				case "INVALID_MIN_DATE_IN_DURING_CLAUSE": return QueryErrorReason.InvalidMinDateInDuringClause;
				case "INVALID_MAX_DATE_IN_DURING_CLAUSE": return QueryErrorReason.InvalidMaxDateInDuringClause;
				case "MAX_LESS_THAN_MIN_IN_DURING_CLAUSE": return QueryErrorReason.MaxLessThanMinInDuringClause;
				case "VALIDATION_FAILED": return QueryErrorReason.ValidationFailed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type QueryErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class QuotaCheckErrorReasonExtensions
	{
		public static string ToXmlValue(this QuotaCheckErrorReason enumValue)
		{
			switch (enumValue)
			{
				case QuotaCheckErrorReason.InvalidTokenHeader: return "INVALID_TOKEN_HEADER";
				case QuotaCheckErrorReason.AccountDelinquent: return "ACCOUNT_DELINQUENT";
				case QuotaCheckErrorReason.AccountInaccessible: return "ACCOUNT_INACCESSIBLE";
				case QuotaCheckErrorReason.AccountInactive: return "ACCOUNT_INACTIVE";
				case QuotaCheckErrorReason.IncompleteSignup: return "INCOMPLETE_SIGNUP";
				case QuotaCheckErrorReason.DeveloperTokenNotApproved: return "DEVELOPER_TOKEN_NOT_APPROVED";
				case QuotaCheckErrorReason.TermsAndConditionsNotSigned: return "TERMS_AND_CONDITIONS_NOT_SIGNED";
				case QuotaCheckErrorReason.MonthlyBudgetReached: return "MONTHLY_BUDGET_REACHED";
				case QuotaCheckErrorReason.QuotaExceeded: return "QUOTA_EXCEEDED";
				default: return null;
			}
		}
		public static QuotaCheckErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_TOKEN_HEADER": return QuotaCheckErrorReason.InvalidTokenHeader;
				case "ACCOUNT_DELINQUENT": return QuotaCheckErrorReason.AccountDelinquent;
				case "ACCOUNT_INACCESSIBLE": return QuotaCheckErrorReason.AccountInaccessible;
				case "ACCOUNT_INACTIVE": return QuotaCheckErrorReason.AccountInactive;
				case "INCOMPLETE_SIGNUP": return QuotaCheckErrorReason.IncompleteSignup;
				case "DEVELOPER_TOKEN_NOT_APPROVED": return QuotaCheckErrorReason.DeveloperTokenNotApproved;
				case "TERMS_AND_CONDITIONS_NOT_SIGNED": return QuotaCheckErrorReason.TermsAndConditionsNotSigned;
				case "MONTHLY_BUDGET_REACHED": return QuotaCheckErrorReason.MonthlyBudgetReached;
				case "QUOTA_EXCEEDED": return QuotaCheckErrorReason.QuotaExceeded;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type QuotaCheckErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class RangeErrorReasonExtensions
	{
		public static string ToXmlValue(this RangeErrorReason enumValue)
		{
			switch (enumValue)
			{
				case RangeErrorReason.TooLow: return "TOO_LOW";
				case RangeErrorReason.TooHigh: return "TOO_HIGH";
				default: return null;
			}
		}
		public static RangeErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "TOO_LOW": return RangeErrorReason.TooLow;
				case "TOO_HIGH": return RangeErrorReason.TooHigh;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RangeErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class RateExceededErrorReasonExtensions
	{
		public static string ToXmlValue(this RateExceededErrorReason enumValue)
		{
			switch (enumValue)
			{
				case RateExceededErrorReason.RateExceeded: return "RATE_EXCEEDED";
				default: return null;
			}
		}
		public static RateExceededErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "RATE_EXCEEDED": return RateExceededErrorReason.RateExceeded;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RateExceededErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ReadOnlyErrorReasonExtensions
	{
		public static string ToXmlValue(this ReadOnlyErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ReadOnlyErrorReason.ReadOnly: return "READ_ONLY";
				default: return null;
			}
		}
		public static ReadOnlyErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "READ_ONLY": return ReadOnlyErrorReason.ReadOnly;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ReadOnlyErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class RegionCodeErrorReasonExtensions
	{
		public static string ToXmlValue(this RegionCodeErrorReason enumValue)
		{
			switch (enumValue)
			{
				case RegionCodeErrorReason.InvalidRegionCode: return "INVALID_REGION_CODE";
				default: return null;
			}
		}
		public static RegionCodeErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_REGION_CODE": return RegionCodeErrorReason.InvalidRegionCode;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RegionCodeErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class RejectedErrorReasonExtensions
	{
		public static string ToXmlValue(this RejectedErrorReason enumValue)
		{
			switch (enumValue)
			{
				case RejectedErrorReason.UnknownValue: return "UNKNOWN_VALUE";
				default: return null;
			}
		}
		public static RejectedErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN_VALUE": return RejectedErrorReason.UnknownValue;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RejectedErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ReportDefinitionDateRangeTypeExtensions
	{
		public static string ToXmlValue(this ReportDefinitionDateRangeType enumValue)
		{
			switch (enumValue)
			{
				case ReportDefinitionDateRangeType.Today: return "TODAY";
				case ReportDefinitionDateRangeType.Yesterday: return "YESTERDAY";
				case ReportDefinitionDateRangeType.Last7Days: return "LAST_7_DAYS";
				case ReportDefinitionDateRangeType.LastWeek: return "LAST_WEEK";
				case ReportDefinitionDateRangeType.LastBusinessWeek: return "LAST_BUSINESS_WEEK";
				case ReportDefinitionDateRangeType.ThisMonth: return "THIS_MONTH";
				case ReportDefinitionDateRangeType.LastMonth: return "LAST_MONTH";
				case ReportDefinitionDateRangeType.AllTime: return "ALL_TIME";
				case ReportDefinitionDateRangeType.CustomDate: return "CUSTOM_DATE";
				case ReportDefinitionDateRangeType.Last14Days: return "LAST_14_DAYS";
				case ReportDefinitionDateRangeType.Last30Days: return "LAST_30_DAYS";
				case ReportDefinitionDateRangeType.ThisWeekSunToday: return "THIS_WEEK_SUN_TODAY";
				case ReportDefinitionDateRangeType.ThisWeekMonToday: return "THIS_WEEK_MON_TODAY";
				case ReportDefinitionDateRangeType.LastWeekSunSat: return "LAST_WEEK_SUN_SAT";
				default: return null;
			}
		}
		public static ReportDefinitionDateRangeType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "TODAY": return ReportDefinitionDateRangeType.Today;
				case "YESTERDAY": return ReportDefinitionDateRangeType.Yesterday;
				case "LAST_7_DAYS": return ReportDefinitionDateRangeType.Last7Days;
				case "LAST_WEEK": return ReportDefinitionDateRangeType.LastWeek;
				case "LAST_BUSINESS_WEEK": return ReportDefinitionDateRangeType.LastBusinessWeek;
				case "THIS_MONTH": return ReportDefinitionDateRangeType.ThisMonth;
				case "LAST_MONTH": return ReportDefinitionDateRangeType.LastMonth;
				case "ALL_TIME": return ReportDefinitionDateRangeType.AllTime;
				case "CUSTOM_DATE": return ReportDefinitionDateRangeType.CustomDate;
				case "LAST_14_DAYS": return ReportDefinitionDateRangeType.Last14Days;
				case "LAST_30_DAYS": return ReportDefinitionDateRangeType.Last30Days;
				case "THIS_WEEK_SUN_TODAY": return ReportDefinitionDateRangeType.ThisWeekSunToday;
				case "THIS_WEEK_MON_TODAY": return ReportDefinitionDateRangeType.ThisWeekMonToday;
				case "LAST_WEEK_SUN_SAT": return ReportDefinitionDateRangeType.LastWeekSunSat;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ReportDefinitionDateRangeType.", nameof(xmlValue));
			}
		}
	}
	public static class ReportDefinitionErrorReasonExtensions
	{
		public static string ToXmlValue(this ReportDefinitionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case ReportDefinitionErrorReason.InvalidDateRangeForReport: return "INVALID_DATE_RANGE_FOR_REPORT";
				case ReportDefinitionErrorReason.InvalidFieldNameForReport: return "INVALID_FIELD_NAME_FOR_REPORT";
				case ReportDefinitionErrorReason.UnableToFindMappingForThisReport: return "UNABLE_TO_FIND_MAPPING_FOR_THIS_REPORT";
				case ReportDefinitionErrorReason.InvalidColumnNameForReport: return "INVALID_COLUMN_NAME_FOR_REPORT";
				case ReportDefinitionErrorReason.InvalidReportDefinitionId: return "INVALID_REPORT_DEFINITION_ID";
				case ReportDefinitionErrorReason.ReportSelectorCannotBeNull: return "REPORT_SELECTOR_CANNOT_BE_NULL";
				case ReportDefinitionErrorReason.NoEnumsForThisColumnName: return "NO_ENUMS_FOR_THIS_COLUMN_NAME";
				case ReportDefinitionErrorReason.InvalidView: return "INVALID_VIEW";
				case ReportDefinitionErrorReason.SortingNotSupported: return "SORTING_NOT_SUPPORTED";
				case ReportDefinitionErrorReason.PagingNotSupported: return "PAGING_NOT_SUPPORTED";
				case ReportDefinitionErrorReason.CustomerServingTypeReportMismatch: return "CUSTOMER_SERVING_TYPE_REPORT_MISMATCH";
				case ReportDefinitionErrorReason.ClientSelectorNoCustomerIdentifier: return "CLIENT_SELECTOR_NO_CUSTOMER_IDENTIFIER";
				case ReportDefinitionErrorReason.ClientSelectorInvalidCustomerId: return "CLIENT_SELECTOR_INVALID_CUSTOMER_ID";
				case ReportDefinitionErrorReason.ReportDefinitionError: return "REPORT_DEFINITION_ERROR";
				default: return null;
			}
		}
		public static ReportDefinitionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_DATE_RANGE_FOR_REPORT": return ReportDefinitionErrorReason.InvalidDateRangeForReport;
				case "INVALID_FIELD_NAME_FOR_REPORT": return ReportDefinitionErrorReason.InvalidFieldNameForReport;
				case "UNABLE_TO_FIND_MAPPING_FOR_THIS_REPORT": return ReportDefinitionErrorReason.UnableToFindMappingForThisReport;
				case "INVALID_COLUMN_NAME_FOR_REPORT": return ReportDefinitionErrorReason.InvalidColumnNameForReport;
				case "INVALID_REPORT_DEFINITION_ID": return ReportDefinitionErrorReason.InvalidReportDefinitionId;
				case "REPORT_SELECTOR_CANNOT_BE_NULL": return ReportDefinitionErrorReason.ReportSelectorCannotBeNull;
				case "NO_ENUMS_FOR_THIS_COLUMN_NAME": return ReportDefinitionErrorReason.NoEnumsForThisColumnName;
				case "INVALID_VIEW": return ReportDefinitionErrorReason.InvalidView;
				case "SORTING_NOT_SUPPORTED": return ReportDefinitionErrorReason.SortingNotSupported;
				case "PAGING_NOT_SUPPORTED": return ReportDefinitionErrorReason.PagingNotSupported;
				case "CUSTOMER_SERVING_TYPE_REPORT_MISMATCH": return ReportDefinitionErrorReason.CustomerServingTypeReportMismatch;
				case "CLIENT_SELECTOR_NO_CUSTOMER_IDENTIFIER": return ReportDefinitionErrorReason.ClientSelectorNoCustomerIdentifier;
				case "CLIENT_SELECTOR_INVALID_CUSTOMER_ID": return ReportDefinitionErrorReason.ClientSelectorInvalidCustomerId;
				case "REPORT_DEFINITION_ERROR": return ReportDefinitionErrorReason.ReportDefinitionError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ReportDefinitionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ReportDefinitionReportTypeExtensions
	{
		public static string ToXmlValue(this ReportDefinitionReportType enumValue)
		{
			switch (enumValue)
			{
				case ReportDefinitionReportType.KeywordsPerformanceReport: return "KEYWORDS_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.AdPerformanceReport: return "AD_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.UrlPerformanceReport: return "URL_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.AdgroupPerformanceReport: return "ADGROUP_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.CampaignPerformanceReport: return "CAMPAIGN_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.AccountPerformanceReport: return "ACCOUNT_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.GeoPerformanceReport: return "GEO_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.SearchQueryPerformanceReport: return "SEARCH_QUERY_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.AutomaticPlacementsPerformanceReport: return "AUTOMATIC_PLACEMENTS_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.CampaignNegativeKeywordsPerformanceReport: return "CAMPAIGN_NEGATIVE_KEYWORDS_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.CampaignNegativePlacementsPerformanceReport: return "CAMPAIGN_NEGATIVE_PLACEMENTS_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.DestinationUrlReport: return "DESTINATION_URL_REPORT";
				case ReportDefinitionReportType.SharedSetReport: return "SHARED_SET_REPORT";
				case ReportDefinitionReportType.CampaignSharedSetReport: return "CAMPAIGN_SHARED_SET_REPORT";
				case ReportDefinitionReportType.SharedSetCriteriaReport: return "SHARED_SET_CRITERIA_REPORT";
				case ReportDefinitionReportType.CreativeConversionReport: return "CREATIVE_CONVERSION_REPORT";
				case ReportDefinitionReportType.CallMetricsCallDetailsReport: return "CALL_METRICS_CALL_DETAILS_REPORT";
				case ReportDefinitionReportType.KeywordlessQueryReport: return "KEYWORDLESS_QUERY_REPORT";
				case ReportDefinitionReportType.KeywordlessCategoryReport: return "KEYWORDLESS_CATEGORY_REPORT";
				case ReportDefinitionReportType.CriteriaPerformanceReport: return "CRITERIA_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.ClickPerformanceReport: return "CLICK_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.BudgetPerformanceReport: return "BUDGET_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.BidGoalPerformanceReport: return "BID_GOAL_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.DisplayKeywordPerformanceReport: return "DISPLAY_KEYWORD_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.PlaceholderFeedItemReport: return "PLACEHOLDER_FEED_ITEM_REPORT";
				case ReportDefinitionReportType.PlacementPerformanceReport: return "PLACEMENT_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.CampaignNegativeLocationsReport: return "CAMPAIGN_NEGATIVE_LOCATIONS_REPORT";
				case ReportDefinitionReportType.GenderPerformanceReport: return "GENDER_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.AgeRangePerformanceReport: return "AGE_RANGE_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.CampaignLocationTargetReport: return "CAMPAIGN_LOCATION_TARGET_REPORT";
				case ReportDefinitionReportType.CampaignAdScheduleTargetReport: return "CAMPAIGN_AD_SCHEDULE_TARGET_REPORT";
				case ReportDefinitionReportType.PaidOrganicQueryReport: return "PAID_ORGANIC_QUERY_REPORT";
				case ReportDefinitionReportType.AudiencePerformanceReport: return "AUDIENCE_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.DisplayTopicsPerformanceReport: return "DISPLAY_TOPICS_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.UserAdDistanceReport: return "USER_AD_DISTANCE_REPORT";
				case ReportDefinitionReportType.ShoppingPerformanceReport: return "SHOPPING_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.ProductPartitionReport: return "PRODUCT_PARTITION_REPORT";
				case ReportDefinitionReportType.ParentalStatusPerformanceReport: return "PARENTAL_STATUS_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.PlaceholderReport: return "PLACEHOLDER_REPORT";
				case ReportDefinitionReportType.AdCustomizersFeedItemReport: return "AD_CUSTOMIZERS_FEED_ITEM_REPORT";
				case ReportDefinitionReportType.LabelReport: return "LABEL_REPORT";
				case ReportDefinitionReportType.FinalUrlReport: return "FINAL_URL_REPORT";
				case ReportDefinitionReportType.VideoPerformanceReport: return "VIDEO_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.TopContentPerformanceReport: return "TOP_CONTENT_PERFORMANCE_REPORT";
				case ReportDefinitionReportType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ReportDefinitionReportType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "KEYWORDS_PERFORMANCE_REPORT": return ReportDefinitionReportType.KeywordsPerformanceReport;
				case "AD_PERFORMANCE_REPORT": return ReportDefinitionReportType.AdPerformanceReport;
				case "URL_PERFORMANCE_REPORT": return ReportDefinitionReportType.UrlPerformanceReport;
				case "ADGROUP_PERFORMANCE_REPORT": return ReportDefinitionReportType.AdgroupPerformanceReport;
				case "CAMPAIGN_PERFORMANCE_REPORT": return ReportDefinitionReportType.CampaignPerformanceReport;
				case "ACCOUNT_PERFORMANCE_REPORT": return ReportDefinitionReportType.AccountPerformanceReport;
				case "GEO_PERFORMANCE_REPORT": return ReportDefinitionReportType.GeoPerformanceReport;
				case "SEARCH_QUERY_PERFORMANCE_REPORT": return ReportDefinitionReportType.SearchQueryPerformanceReport;
				case "AUTOMATIC_PLACEMENTS_PERFORMANCE_REPORT": return ReportDefinitionReportType.AutomaticPlacementsPerformanceReport;
				case "CAMPAIGN_NEGATIVE_KEYWORDS_PERFORMANCE_REPORT": return ReportDefinitionReportType.CampaignNegativeKeywordsPerformanceReport;
				case "CAMPAIGN_NEGATIVE_PLACEMENTS_PERFORMANCE_REPORT": return ReportDefinitionReportType.CampaignNegativePlacementsPerformanceReport;
				case "DESTINATION_URL_REPORT": return ReportDefinitionReportType.DestinationUrlReport;
				case "SHARED_SET_REPORT": return ReportDefinitionReportType.SharedSetReport;
				case "CAMPAIGN_SHARED_SET_REPORT": return ReportDefinitionReportType.CampaignSharedSetReport;
				case "SHARED_SET_CRITERIA_REPORT": return ReportDefinitionReportType.SharedSetCriteriaReport;
				case "CREATIVE_CONVERSION_REPORT": return ReportDefinitionReportType.CreativeConversionReport;
				case "CALL_METRICS_CALL_DETAILS_REPORT": return ReportDefinitionReportType.CallMetricsCallDetailsReport;
				case "KEYWORDLESS_QUERY_REPORT": return ReportDefinitionReportType.KeywordlessQueryReport;
				case "KEYWORDLESS_CATEGORY_REPORT": return ReportDefinitionReportType.KeywordlessCategoryReport;
				case "CRITERIA_PERFORMANCE_REPORT": return ReportDefinitionReportType.CriteriaPerformanceReport;
				case "CLICK_PERFORMANCE_REPORT": return ReportDefinitionReportType.ClickPerformanceReport;
				case "BUDGET_PERFORMANCE_REPORT": return ReportDefinitionReportType.BudgetPerformanceReport;
				case "BID_GOAL_PERFORMANCE_REPORT": return ReportDefinitionReportType.BidGoalPerformanceReport;
				case "DISPLAY_KEYWORD_PERFORMANCE_REPORT": return ReportDefinitionReportType.DisplayKeywordPerformanceReport;
				case "PLACEHOLDER_FEED_ITEM_REPORT": return ReportDefinitionReportType.PlaceholderFeedItemReport;
				case "PLACEMENT_PERFORMANCE_REPORT": return ReportDefinitionReportType.PlacementPerformanceReport;
				case "CAMPAIGN_NEGATIVE_LOCATIONS_REPORT": return ReportDefinitionReportType.CampaignNegativeLocationsReport;
				case "GENDER_PERFORMANCE_REPORT": return ReportDefinitionReportType.GenderPerformanceReport;
				case "AGE_RANGE_PERFORMANCE_REPORT": return ReportDefinitionReportType.AgeRangePerformanceReport;
				case "CAMPAIGN_LOCATION_TARGET_REPORT": return ReportDefinitionReportType.CampaignLocationTargetReport;
				case "CAMPAIGN_AD_SCHEDULE_TARGET_REPORT": return ReportDefinitionReportType.CampaignAdScheduleTargetReport;
				case "PAID_ORGANIC_QUERY_REPORT": return ReportDefinitionReportType.PaidOrganicQueryReport;
				case "AUDIENCE_PERFORMANCE_REPORT": return ReportDefinitionReportType.AudiencePerformanceReport;
				case "DISPLAY_TOPICS_PERFORMANCE_REPORT": return ReportDefinitionReportType.DisplayTopicsPerformanceReport;
				case "USER_AD_DISTANCE_REPORT": return ReportDefinitionReportType.UserAdDistanceReport;
				case "SHOPPING_PERFORMANCE_REPORT": return ReportDefinitionReportType.ShoppingPerformanceReport;
				case "PRODUCT_PARTITION_REPORT": return ReportDefinitionReportType.ProductPartitionReport;
				case "PARENTAL_STATUS_PERFORMANCE_REPORT": return ReportDefinitionReportType.ParentalStatusPerformanceReport;
				case "PLACEHOLDER_REPORT": return ReportDefinitionReportType.PlaceholderReport;
				case "AD_CUSTOMIZERS_FEED_ITEM_REPORT": return ReportDefinitionReportType.AdCustomizersFeedItemReport;
				case "LABEL_REPORT": return ReportDefinitionReportType.LabelReport;
				case "FINAL_URL_REPORT": return ReportDefinitionReportType.FinalUrlReport;
				case "VIDEO_PERFORMANCE_REPORT": return ReportDefinitionReportType.VideoPerformanceReport;
				case "TOP_CONTENT_PERFORMANCE_REPORT": return ReportDefinitionReportType.TopContentPerformanceReport;
				case "UNKNOWN": return ReportDefinitionReportType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ReportDefinitionReportType.", nameof(xmlValue));
			}
		}
	}
	public static class RequestContextOperandContextTypeExtensions
	{
		public static string ToXmlValue(this RequestContextOperandContextType enumValue)
		{
			switch (enumValue)
			{
				case RequestContextOperandContextType.FeedItemId: return "FEED_ITEM_ID";
				case RequestContextOperandContextType.DevicePlatform: return "DEVICE_PLATFORM";
				case RequestContextOperandContextType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static RequestContextOperandContextType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "FEED_ITEM_ID": return RequestContextOperandContextType.FeedItemId;
				case "DEVICE_PLATFORM": return RequestContextOperandContextType.DevicePlatform;
				case "UNKNOWN": return RequestContextOperandContextType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RequestContextOperandContextType.", nameof(xmlValue));
			}
		}
	}
	public static class RequestErrorReasonExtensions
	{
		public static string ToXmlValue(this RequestErrorReason enumValue)
		{
			switch (enumValue)
			{
				case RequestErrorReason.Unknown: return "UNKNOWN";
				case RequestErrorReason.InvalidInput: return "INVALID_INPUT";
				case RequestErrorReason.UnsupportedVersion: return "UNSUPPORTED_VERSION";
				default: return null;
			}
		}
		public static RequestErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return RequestErrorReason.Unknown;
				case "INVALID_INPUT": return RequestErrorReason.InvalidInput;
				case "UNSUPPORTED_VERSION": return RequestErrorReason.UnsupportedVersion;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RequestErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class RequestTypeExtensions
	{
		public static string ToXmlValue(this RequestType enumValue)
		{
			switch (enumValue)
			{
				case RequestType.Ideas: return "IDEAS";
				case RequestType.Stats: return "STATS";
				default: return null;
			}
		}
		public static RequestType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "IDEAS": return RequestType.Ideas;
				case "STATS": return RequestType.Stats;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RequestType.", nameof(xmlValue));
			}
		}
	}
	public static class RequiredErrorReasonExtensions
	{
		public static string ToXmlValue(this RequiredErrorReason enumValue)
		{
			switch (enumValue)
			{
				case RequiredErrorReason.Required: return "REQUIRED";
				default: return null;
			}
		}
		public static RequiredErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "REQUIRED": return RequiredErrorReason.Required;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RequiredErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class RichMediaAdAdAttributeExtensions
	{
		public static string ToXmlValue(this RichMediaAdAdAttribute enumValue)
		{
			switch (enumValue)
			{
				case RichMediaAdAdAttribute.Unknown: return "UNKNOWN";
				case RichMediaAdAdAttribute.RollOverToExpand: return "ROLL_OVER_TO_EXPAND";
				case RichMediaAdAdAttribute.Ssl: return "SSL";
				default: return null;
			}
		}
		public static RichMediaAdAdAttribute Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return RichMediaAdAdAttribute.Unknown;
				case "ROLL_OVER_TO_EXPAND": return RichMediaAdAdAttribute.RollOverToExpand;
				case "SSL": return RichMediaAdAdAttribute.Ssl;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RichMediaAdAdAttribute.", nameof(xmlValue));
			}
		}
	}
	public static class RichMediaAdRichMediaAdTypeExtensions
	{
		public static string ToXmlValue(this RichMediaAdRichMediaAdType enumValue)
		{
			switch (enumValue)
			{
				case RichMediaAdRichMediaAdType.Standard: return "STANDARD";
				case RichMediaAdRichMediaAdType.InStreamVideo: return "IN_STREAM_VIDEO";
				default: return null;
			}
		}
		public static RichMediaAdRichMediaAdType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "STANDARD": return RichMediaAdRichMediaAdType.Standard;
				case "IN_STREAM_VIDEO": return RichMediaAdRichMediaAdType.InStreamVideo;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type RichMediaAdRichMediaAdType.", nameof(xmlValue));
			}
		}
	}
	public static class SelectorErrorReasonExtensions
	{
		public static string ToXmlValue(this SelectorErrorReason enumValue)
		{
			switch (enumValue)
			{
				case SelectorErrorReason.InvalidFieldName: return "INVALID_FIELD_NAME";
				case SelectorErrorReason.MissingFields: return "MISSING_FIELDS";
				case SelectorErrorReason.MissingPredicates: return "MISSING_PREDICATES";
				case SelectorErrorReason.OperatorDoesNotSupportMultipleValues: return "OPERATOR_DOES_NOT_SUPPORT_MULTIPLE_VALUES";
				case SelectorErrorReason.InvalidPredicateEnumValue: return "INVALID_PREDICATE_ENUM_VALUE";
				case SelectorErrorReason.MissingPredicateOperator: return "MISSING_PREDICATE_OPERATOR";
				case SelectorErrorReason.MissingPredicateValues: return "MISSING_PREDICATE_VALUES";
				case SelectorErrorReason.InvalidPredicateFieldName: return "INVALID_PREDICATE_FIELD_NAME";
				case SelectorErrorReason.InvalidPredicateOperator: return "INVALID_PREDICATE_OPERATOR";
				case SelectorErrorReason.InvalidFieldSelection: return "INVALID_FIELD_SELECTION";
				case SelectorErrorReason.InvalidPredicateValue: return "INVALID_PREDICATE_VALUE";
				case SelectorErrorReason.InvalidSortFieldName: return "INVALID_SORT_FIELD_NAME";
				case SelectorErrorReason.SelectorError: return "SELECTOR_ERROR";
				case SelectorErrorReason.FilterByDateRangeNotSupported: return "FILTER_BY_DATE_RANGE_NOT_SUPPORTED";
				case SelectorErrorReason.StartIndexIsTooHigh: return "START_INDEX_IS_TOO_HIGH";
				case SelectorErrorReason.TooManyPredicateValues: return "TOO_MANY_PREDICATE_VALUES";
				case SelectorErrorReason.UnknownError: return "UNKNOWN_ERROR";
				default: return null;
			}
		}
		public static SelectorErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_FIELD_NAME": return SelectorErrorReason.InvalidFieldName;
				case "MISSING_FIELDS": return SelectorErrorReason.MissingFields;
				case "MISSING_PREDICATES": return SelectorErrorReason.MissingPredicates;
				case "OPERATOR_DOES_NOT_SUPPORT_MULTIPLE_VALUES": return SelectorErrorReason.OperatorDoesNotSupportMultipleValues;
				case "INVALID_PREDICATE_ENUM_VALUE": return SelectorErrorReason.InvalidPredicateEnumValue;
				case "MISSING_PREDICATE_OPERATOR": return SelectorErrorReason.MissingPredicateOperator;
				case "MISSING_PREDICATE_VALUES": return SelectorErrorReason.MissingPredicateValues;
				case "INVALID_PREDICATE_FIELD_NAME": return SelectorErrorReason.InvalidPredicateFieldName;
				case "INVALID_PREDICATE_OPERATOR": return SelectorErrorReason.InvalidPredicateOperator;
				case "INVALID_FIELD_SELECTION": return SelectorErrorReason.InvalidFieldSelection;
				case "INVALID_PREDICATE_VALUE": return SelectorErrorReason.InvalidPredicateValue;
				case "INVALID_SORT_FIELD_NAME": return SelectorErrorReason.InvalidSortFieldName;
				case "SELECTOR_ERROR": return SelectorErrorReason.SelectorError;
				case "FILTER_BY_DATE_RANGE_NOT_SUPPORTED": return SelectorErrorReason.FilterByDateRangeNotSupported;
				case "START_INDEX_IS_TOO_HIGH": return SelectorErrorReason.StartIndexIsTooHigh;
				case "TOO_MANY_PREDICATE_VALUES": return SelectorErrorReason.TooManyPredicateValues;
				case "UNKNOWN_ERROR": return SelectorErrorReason.UnknownError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SelectorErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class ServiceLinkLinkStatusExtensions
	{
		public static string ToXmlValue(this ServiceLinkLinkStatus enumValue)
		{
			switch (enumValue)
			{
				case ServiceLinkLinkStatus.Active: return "ACTIVE";
				case ServiceLinkLinkStatus.Pending: return "PENDING";
				case ServiceLinkLinkStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ServiceLinkLinkStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ACTIVE": return ServiceLinkLinkStatus.Active;
				case "PENDING": return ServiceLinkLinkStatus.Pending;
				case "UNKNOWN": return ServiceLinkLinkStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ServiceLinkLinkStatus.", nameof(xmlValue));
			}
		}
	}
	public static class ServiceTypeExtensions
	{
		public static string ToXmlValue(this ServiceType enumValue)
		{
			switch (enumValue)
			{
				case ServiceType.MerchantCenter: return "MERCHANT_CENTER";
				case ServiceType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static ServiceType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "MERCHANT_CENTER": return ServiceType.MerchantCenter;
				case "UNKNOWN": return ServiceType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ServiceType.", nameof(xmlValue));
			}
		}
	}
	public static class ServingStatusExtensions
	{
		public static string ToXmlValue(this ServingStatus enumValue)
		{
			switch (enumValue)
			{
				case ServingStatus.Serving: return "SERVING";
				case ServingStatus.None: return "NONE";
				case ServingStatus.Ended: return "ENDED";
				case ServingStatus.Pending: return "PENDING";
				case ServingStatus.Suspended: return "SUSPENDED";
				default: return null;
			}
		}
		public static ServingStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "SERVING": return ServingStatus.Serving;
				case "NONE": return ServingStatus.None;
				case "ENDED": return ServingStatus.Ended;
				case "PENDING": return ServingStatus.Pending;
				case "SUSPENDED": return ServingStatus.Suspended;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ServingStatus.", nameof(xmlValue));
			}
		}
	}
	public static class SettingErrorReasonExtensions
	{
		public static string ToXmlValue(this SettingErrorReason enumValue)
		{
			switch (enumValue)
			{
				case SettingErrorReason.DuplicateSettingType: return "DUPLICATE_SETTING_TYPE";
				case SettingErrorReason.SettingTypeIsNotAvailable: return "SETTING_TYPE_IS_NOT_AVAILABLE";
				case SettingErrorReason.SettingTypeIsNotCompatibleWithCampaign: return "SETTING_TYPE_IS_NOT_COMPATIBLE_WITH_CAMPAIGN";
				case SettingErrorReason.TargetingSettingContainsInvalidCriterionTypeGroup: return "TARGETING_SETTING_CONTAINS_INVALID_CRITERION_TYPE_GROUP";
				case SettingErrorReason.DynamicSearchAdsSettingContainsInvalidDomainName: return "DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_DOMAIN_NAME";
				case SettingErrorReason.DynamicSearchAdsSettingContainsInvalidLanguageCode: return "DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_LANGUAGE_CODE";
				case SettingErrorReason.TargetAllIsNotAllowedForPlacementInSearchCampaign: return "TARGET_ALL_IS_NOT_ALLOWED_FOR_PLACEMENT_IN_SEARCH_CAMPAIGN";
				case SettingErrorReason.UniversalAppCampaignSettingDuplicateDescription: return "UNIVERSAL_APP_CAMPAIGN_SETTING_DUPLICATE_DESCRIPTION";
				case SettingErrorReason.UniversalAppCampaignSettingDescriptionLineWidthTooLong: return "UNIVERSAL_APP_CAMPAIGN_SETTING_DESCRIPTION_LINE_WIDTH_TOO_LONG";
				case SettingErrorReason.UniversalAppCampaignSettingAppIdCannotBeModified: return "UNIVERSAL_APP_CAMPAIGN_SETTING_APP_ID_CANNOT_BE_MODIFIED";
				case SettingErrorReason.TooManyYoutubeMediaIdsInUniversalAppCampaign: return "TOO_MANY_YOUTUBE_MEDIA_IDS_IN_UNIVERSAL_APP_CAMPAIGN";
				case SettingErrorReason.TooManyImageMediaIdsInUniversalAppCampaign: return "TOO_MANY_IMAGE_MEDIA_IDS_IN_UNIVERSAL_APP_CAMPAIGN";
				case SettingErrorReason.MediaIncompatibleForUniversalAppCampaign: return "MEDIA_INCOMPATIBLE_FOR_UNIVERSAL_APP_CAMPAIGN";
				case SettingErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SettingErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DUPLICATE_SETTING_TYPE": return SettingErrorReason.DuplicateSettingType;
				case "SETTING_TYPE_IS_NOT_AVAILABLE": return SettingErrorReason.SettingTypeIsNotAvailable;
				case "SETTING_TYPE_IS_NOT_COMPATIBLE_WITH_CAMPAIGN": return SettingErrorReason.SettingTypeIsNotCompatibleWithCampaign;
				case "TARGETING_SETTING_CONTAINS_INVALID_CRITERION_TYPE_GROUP": return SettingErrorReason.TargetingSettingContainsInvalidCriterionTypeGroup;
				case "DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_DOMAIN_NAME": return SettingErrorReason.DynamicSearchAdsSettingContainsInvalidDomainName;
				case "DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_LANGUAGE_CODE": return SettingErrorReason.DynamicSearchAdsSettingContainsInvalidLanguageCode;
				case "TARGET_ALL_IS_NOT_ALLOWED_FOR_PLACEMENT_IN_SEARCH_CAMPAIGN": return SettingErrorReason.TargetAllIsNotAllowedForPlacementInSearchCampaign;
				case "UNIVERSAL_APP_CAMPAIGN_SETTING_DUPLICATE_DESCRIPTION": return SettingErrorReason.UniversalAppCampaignSettingDuplicateDescription;
				case "UNIVERSAL_APP_CAMPAIGN_SETTING_DESCRIPTION_LINE_WIDTH_TOO_LONG": return SettingErrorReason.UniversalAppCampaignSettingDescriptionLineWidthTooLong;
				case "UNIVERSAL_APP_CAMPAIGN_SETTING_APP_ID_CANNOT_BE_MODIFIED": return SettingErrorReason.UniversalAppCampaignSettingAppIdCannotBeModified;
				case "TOO_MANY_YOUTUBE_MEDIA_IDS_IN_UNIVERSAL_APP_CAMPAIGN": return SettingErrorReason.TooManyYoutubeMediaIdsInUniversalAppCampaign;
				case "TOO_MANY_IMAGE_MEDIA_IDS_IN_UNIVERSAL_APP_CAMPAIGN": return SettingErrorReason.TooManyImageMediaIdsInUniversalAppCampaign;
				case "MEDIA_INCOMPATIBLE_FOR_UNIVERSAL_APP_CAMPAIGN": return SettingErrorReason.MediaIncompatibleForUniversalAppCampaign;
				case "UNKNOWN": return SettingErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SettingErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class SharedBiddingStrategyBiddingStrategyStatusExtensions
	{
		public static string ToXmlValue(this SharedBiddingStrategyBiddingStrategyStatus enumValue)
		{
			switch (enumValue)
			{
				case SharedBiddingStrategyBiddingStrategyStatus.Enabled: return "ENABLED";
				case SharedBiddingStrategyBiddingStrategyStatus.Removed: return "REMOVED";
				case SharedBiddingStrategyBiddingStrategyStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SharedBiddingStrategyBiddingStrategyStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return SharedBiddingStrategyBiddingStrategyStatus.Enabled;
				case "REMOVED": return SharedBiddingStrategyBiddingStrategyStatus.Removed;
				case "UNKNOWN": return SharedBiddingStrategyBiddingStrategyStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SharedBiddingStrategyBiddingStrategyStatus.", nameof(xmlValue));
			}
		}
	}
	public static class SharedCriterionErrorReasonExtensions
	{
		public static string ToXmlValue(this SharedCriterionErrorReason enumValue)
		{
			switch (enumValue)
			{
				case SharedCriterionErrorReason.ExceedsCriteriaLimit: return "EXCEEDS_CRITERIA_LIMIT";
				case SharedCriterionErrorReason.IncorrectCriterionType: return "INCORRECT_CRITERION_TYPE";
				case SharedCriterionErrorReason.CannotTargetAndExclude: return "CANNOT_TARGET_AND_EXCLUDE";
				case SharedCriterionErrorReason.NegativeCriterionRequired: return "NEGATIVE_CRITERION_REQUIRED";
				case SharedCriterionErrorReason.ConcreteTypeRequired: return "CONCRETE_TYPE_REQUIRED";
				case SharedCriterionErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SharedCriterionErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EXCEEDS_CRITERIA_LIMIT": return SharedCriterionErrorReason.ExceedsCriteriaLimit;
				case "INCORRECT_CRITERION_TYPE": return SharedCriterionErrorReason.IncorrectCriterionType;
				case "CANNOT_TARGET_AND_EXCLUDE": return SharedCriterionErrorReason.CannotTargetAndExclude;
				case "NEGATIVE_CRITERION_REQUIRED": return SharedCriterionErrorReason.NegativeCriterionRequired;
				case "CONCRETE_TYPE_REQUIRED": return SharedCriterionErrorReason.ConcreteTypeRequired;
				case "UNKNOWN": return SharedCriterionErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SharedCriterionErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class SharedSetErrorReasonExtensions
	{
		public static string ToXmlValue(this SharedSetErrorReason enumValue)
		{
			switch (enumValue)
			{
				case SharedSetErrorReason.CustomerCannotCreateSharedSetOfThisType: return "CUSTOMER_CANNOT_CREATE_SHARED_SET_OF_THIS_TYPE";
				case SharedSetErrorReason.DuplicateName: return "DUPLICATE_NAME";
				case SharedSetErrorReason.SharedSetRemoved: return "SHARED_SET_REMOVED";
				case SharedSetErrorReason.SharedSetInUse: return "SHARED_SET_IN_USE";
				case SharedSetErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SharedSetErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "CUSTOMER_CANNOT_CREATE_SHARED_SET_OF_THIS_TYPE": return SharedSetErrorReason.CustomerCannotCreateSharedSetOfThisType;
				case "DUPLICATE_NAME": return SharedSetErrorReason.DuplicateName;
				case "SHARED_SET_REMOVED": return SharedSetErrorReason.SharedSetRemoved;
				case "SHARED_SET_IN_USE": return SharedSetErrorReason.SharedSetInUse;
				case "UNKNOWN": return SharedSetErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SharedSetErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class SharedSetStatusExtensions
	{
		public static string ToXmlValue(this SharedSetStatus enumValue)
		{
			switch (enumValue)
			{
				case SharedSetStatus.Enabled: return "ENABLED";
				case SharedSetStatus.Removed: return "REMOVED";
				case SharedSetStatus.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SharedSetStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return SharedSetStatus.Enabled;
				case "REMOVED": return SharedSetStatus.Removed;
				case "UNKNOWN": return SharedSetStatus.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SharedSetStatus.", nameof(xmlValue));
			}
		}
	}
	public static class SharedSetTypeExtensions
	{
		public static string ToXmlValue(this SharedSetType enumValue)
		{
			switch (enumValue)
			{
				case SharedSetType.NegativeKeywords: return "NEGATIVE_KEYWORDS";
				case SharedSetType.NegativePlacements: return "NEGATIVE_PLACEMENTS";
				case SharedSetType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SharedSetType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NEGATIVE_KEYWORDS": return SharedSetType.NegativeKeywords;
				case "NEGATIVE_PLACEMENTS": return SharedSetType.NegativePlacements;
				case "UNKNOWN": return SharedSetType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SharedSetType.", nameof(xmlValue));
			}
		}
	}
	public static class ShoppingBiddingDimensionStatusExtensions
	{
		public static string ToXmlValue(this ShoppingBiddingDimensionStatus enumValue)
		{
			switch (enumValue)
			{
				case ShoppingBiddingDimensionStatus.Unknown: return "UNKNOWN";
				case ShoppingBiddingDimensionStatus.Active: return "ACTIVE";
				case ShoppingBiddingDimensionStatus.Obsolete: return "OBSOLETE";
				default: return null;
			}
		}
		public static ShoppingBiddingDimensionStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ShoppingBiddingDimensionStatus.Unknown;
				case "ACTIVE": return ShoppingBiddingDimensionStatus.Active;
				case "OBSOLETE": return ShoppingBiddingDimensionStatus.Obsolete;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ShoppingBiddingDimensionStatus.", nameof(xmlValue));
			}
		}
	}
	public static class ShoppingProductChannelExtensions
	{
		public static string ToXmlValue(this ShoppingProductChannel enumValue)
		{
			switch (enumValue)
			{
				case ShoppingProductChannel.Unknown: return "UNKNOWN";
				case ShoppingProductChannel.Online: return "ONLINE";
				case ShoppingProductChannel.Local: return "LOCAL";
				default: return null;
			}
		}
		public static ShoppingProductChannel Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ShoppingProductChannel.Unknown;
				case "ONLINE": return ShoppingProductChannel.Online;
				case "LOCAL": return ShoppingProductChannel.Local;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ShoppingProductChannel.", nameof(xmlValue));
			}
		}
	}
	public static class ShoppingProductChannelExclusivityExtensions
	{
		public static string ToXmlValue(this ShoppingProductChannelExclusivity enumValue)
		{
			switch (enumValue)
			{
				case ShoppingProductChannelExclusivity.Unknown: return "UNKNOWN";
				case ShoppingProductChannelExclusivity.SingleChannel: return "SINGLE_CHANNEL";
				case ShoppingProductChannelExclusivity.MultiChannel: return "MULTI_CHANNEL";
				default: return null;
			}
		}
		public static ShoppingProductChannelExclusivity Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ShoppingProductChannelExclusivity.Unknown;
				case "SINGLE_CHANNEL": return ShoppingProductChannelExclusivity.SingleChannel;
				case "MULTI_CHANNEL": return ShoppingProductChannelExclusivity.MultiChannel;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ShoppingProductChannelExclusivity.", nameof(xmlValue));
			}
		}
	}
	public static class SizeLimitErrorReasonExtensions
	{
		public static string ToXmlValue(this SizeLimitErrorReason enumValue)
		{
			switch (enumValue)
			{
				case SizeLimitErrorReason.RequestSizeLimitExceeded: return "REQUEST_SIZE_LIMIT_EXCEEDED";
				case SizeLimitErrorReason.ResponseSizeLimitExceeded: return "RESPONSE_SIZE_LIMIT_EXCEEDED";
				case SizeLimitErrorReason.InternalStorageError: return "INTERNAL_STORAGE_ERROR";
				case SizeLimitErrorReason.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static SizeLimitErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "REQUEST_SIZE_LIMIT_EXCEEDED": return SizeLimitErrorReason.RequestSizeLimitExceeded;
				case "RESPONSE_SIZE_LIMIT_EXCEEDED": return SizeLimitErrorReason.ResponseSizeLimitExceeded;
				case "INTERNAL_STORAGE_ERROR": return SizeLimitErrorReason.InternalStorageError;
				case "UNKNOWN": return SizeLimitErrorReason.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SizeLimitErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class SizeRangeExtensions
	{
		public static string ToXmlValue(this SizeRange enumValue)
		{
			switch (enumValue)
			{
				case SizeRange.LessThanFiveHundred: return "LESS_THAN_FIVE_HUNDRED";
				case SizeRange.LessThanOneThousand: return "LESS_THAN_ONE_THOUSAND";
				case SizeRange.OneThousandToTenThousand: return "ONE_THOUSAND_TO_TEN_THOUSAND";
				case SizeRange.TenThousandToFiftyThousand: return "TEN_THOUSAND_TO_FIFTY_THOUSAND";
				case SizeRange.FiftyThousandToOneHundredThousand: return "FIFTY_THOUSAND_TO_ONE_HUNDRED_THOUSAND";
				case SizeRange.OneHundredThousandToThreeHundredThousand: return "ONE_HUNDRED_THOUSAND_TO_THREE_HUNDRED_THOUSAND";
				case SizeRange.ThreeHundredThousandToFiveHundredThousand: return "THREE_HUNDRED_THOUSAND_TO_FIVE_HUNDRED_THOUSAND";
				case SizeRange.FiveHundredThousandToOneMillion: return "FIVE_HUNDRED_THOUSAND_TO_ONE_MILLION";
				case SizeRange.OneMillionToTwoMillion: return "ONE_MILLION_TO_TWO_MILLION";
				case SizeRange.TwoMillionToThreeMillion: return "TWO_MILLION_TO_THREE_MILLION";
				case SizeRange.ThreeMillionToFiveMillion: return "THREE_MILLION_TO_FIVE_MILLION";
				case SizeRange.FiveMillionToTenMillion: return "FIVE_MILLION_TO_TEN_MILLION";
				case SizeRange.TenMillionToTwentyMillion: return "TEN_MILLION_TO_TWENTY_MILLION";
				case SizeRange.TwentyMillionToThirtyMillion: return "TWENTY_MILLION_TO_THIRTY_MILLION";
				case SizeRange.ThirtyMillionToFiftyMillion: return "THIRTY_MILLION_TO_FIFTY_MILLION";
				case SizeRange.OverFiftyMillion: return "OVER_FIFTY_MILLION";
				default: return null;
			}
		}
		public static SizeRange Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "LESS_THAN_FIVE_HUNDRED": return SizeRange.LessThanFiveHundred;
				case "LESS_THAN_ONE_THOUSAND": return SizeRange.LessThanOneThousand;
				case "ONE_THOUSAND_TO_TEN_THOUSAND": return SizeRange.OneThousandToTenThousand;
				case "TEN_THOUSAND_TO_FIFTY_THOUSAND": return SizeRange.TenThousandToFiftyThousand;
				case "FIFTY_THOUSAND_TO_ONE_HUNDRED_THOUSAND": return SizeRange.FiftyThousandToOneHundredThousand;
				case "ONE_HUNDRED_THOUSAND_TO_THREE_HUNDRED_THOUSAND": return SizeRange.OneHundredThousandToThreeHundredThousand;
				case "THREE_HUNDRED_THOUSAND_TO_FIVE_HUNDRED_THOUSAND": return SizeRange.ThreeHundredThousandToFiveHundredThousand;
				case "FIVE_HUNDRED_THOUSAND_TO_ONE_MILLION": return SizeRange.FiveHundredThousandToOneMillion;
				case "ONE_MILLION_TO_TWO_MILLION": return SizeRange.OneMillionToTwoMillion;
				case "TWO_MILLION_TO_THREE_MILLION": return SizeRange.TwoMillionToThreeMillion;
				case "THREE_MILLION_TO_FIVE_MILLION": return SizeRange.ThreeMillionToFiveMillion;
				case "FIVE_MILLION_TO_TEN_MILLION": return SizeRange.FiveMillionToTenMillion;
				case "TEN_MILLION_TO_TWENTY_MILLION": return SizeRange.TenMillionToTwentyMillion;
				case "TWENTY_MILLION_TO_THIRTY_MILLION": return SizeRange.TwentyMillionToThirtyMillion;
				case "THIRTY_MILLION_TO_FIFTY_MILLION": return SizeRange.ThirtyMillionToFiftyMillion;
				case "OVER_FIFTY_MILLION": return SizeRange.OverFiftyMillion;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SizeRange.", nameof(xmlValue));
			}
		}
	}
	public static class SortOrderExtensions
	{
		public static string ToXmlValue(this SortOrder enumValue)
		{
			switch (enumValue)
			{
				case SortOrder.Ascending: return "ASCENDING";
				case SortOrder.Descending: return "DESCENDING";
				default: return null;
			}
		}
		public static SortOrder Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ASCENDING": return SortOrder.Ascending;
				case "DESCENDING": return SortOrder.Descending;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SortOrder.", nameof(xmlValue));
			}
		}
	}
	public static class StatsQueryErrorReasonExtensions
	{
		public static string ToXmlValue(this StatsQueryErrorReason enumValue)
		{
			switch (enumValue)
			{
				case StatsQueryErrorReason.DateNotInValidRange: return "DATE_NOT_IN_VALID_RANGE";
				default: return null;
			}
		}
		public static StatsQueryErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DATE_NOT_IN_VALID_RANGE": return StatsQueryErrorReason.DateNotInValidRange;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type StatsQueryErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class StringFormatErrorReasonExtensions
	{
		public static string ToXmlValue(this StringFormatErrorReason enumValue)
		{
			switch (enumValue)
			{
				case StringFormatErrorReason.Unknown: return "UNKNOWN";
				case StringFormatErrorReason.IllegalChars: return "ILLEGAL_CHARS";
				case StringFormatErrorReason.InvalidFormat: return "INVALID_FORMAT";
				default: return null;
			}
		}
		public static StringFormatErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return StringFormatErrorReason.Unknown;
				case "ILLEGAL_CHARS": return StringFormatErrorReason.IllegalChars;
				case "INVALID_FORMAT": return StringFormatErrorReason.InvalidFormat;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type StringFormatErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class StringLengthErrorReasonExtensions
	{
		public static string ToXmlValue(this StringLengthErrorReason enumValue)
		{
			switch (enumValue)
			{
				case StringLengthErrorReason.TooShort: return "TOO_SHORT";
				case StringLengthErrorReason.TooLong: return "TOO_LONG";
				default: return null;
			}
		}
		public static StringLengthErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "TOO_SHORT": return StringLengthErrorReason.TooShort;
				case "TOO_LONG": return StringLengthErrorReason.TooLong;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type StringLengthErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class StringRuleItemStringOperatorExtensions
	{
		public static string ToXmlValue(this StringRuleItemStringOperator enumValue)
		{
			switch (enumValue)
			{
				case StringRuleItemStringOperator.Unknown: return "UNKNOWN";
				case StringRuleItemStringOperator.Contains: return "CONTAINS";
				case StringRuleItemStringOperator.Equals: return "EQUALS";
				case StringRuleItemStringOperator.StartsWith: return "STARTS_WITH";
				case StringRuleItemStringOperator.EndsWith: return "ENDS_WITH";
				case StringRuleItemStringOperator.NotEqual: return "NOT_EQUAL";
				case StringRuleItemStringOperator.NotContain: return "NOT_CONTAIN";
				case StringRuleItemStringOperator.NotStartWith: return "NOT_START_WITH";
				case StringRuleItemStringOperator.NotEndWith: return "NOT_END_WITH";
				default: return null;
			}
		}
		public static StringRuleItemStringOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return StringRuleItemStringOperator.Unknown;
				case "CONTAINS": return StringRuleItemStringOperator.Contains;
				case "EQUALS": return StringRuleItemStringOperator.Equals;
				case "STARTS_WITH": return StringRuleItemStringOperator.StartsWith;
				case "ENDS_WITH": return StringRuleItemStringOperator.EndsWith;
				case "NOT_EQUAL": return StringRuleItemStringOperator.NotEqual;
				case "NOT_CONTAIN": return StringRuleItemStringOperator.NotContain;
				case "NOT_START_WITH": return StringRuleItemStringOperator.NotStartWith;
				case "NOT_END_WITH": return StringRuleItemStringOperator.NotEndWith;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type StringRuleItemStringOperator.", nameof(xmlValue));
			}
		}
	}
	public static class SystemServingStatusExtensions
	{
		public static string ToXmlValue(this SystemServingStatus enumValue)
		{
			switch (enumValue)
			{
				case SystemServingStatus.Eligible: return "ELIGIBLE";
				case SystemServingStatus.RarelyServed: return "RARELY_SERVED";
				default: return null;
			}
		}
		public static SystemServingStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ELIGIBLE": return SystemServingStatus.Eligible;
				case "RARELY_SERVED": return SystemServingStatus.RarelyServed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type SystemServingStatus.", nameof(xmlValue));
			}
		}
	}
	public static class TargetingIdeaErrorReasonExtensions
	{
		public static string ToXmlValue(this TargetingIdeaErrorReason enumValue)
		{
			switch (enumValue)
			{
				case TargetingIdeaErrorReason.DuplicateSearchFilterTypesPresent: return "DUPLICATE_SEARCH_FILTER_TYPES_PRESENT";
				case TargetingIdeaErrorReason.InsufficientSearchParameters: return "INSUFFICIENT_SEARCH_PARAMETERS";
				case TargetingIdeaErrorReason.InvalidAttributeType: return "INVALID_ATTRIBUTE_TYPE";
				case TargetingIdeaErrorReason.InvalidSearchParameters: return "INVALID_SEARCH_PARAMETERS";
				case TargetingIdeaErrorReason.InvalidDomainSuffix: return "INVALID_DOMAIN_SUFFIX";
				case TargetingIdeaErrorReason.MutuallyExclusiveSearchParametersInQuery: return "MUTUALLY_EXCLUSIVE_SEARCH_PARAMETERS_IN_QUERY";
				case TargetingIdeaErrorReason.ServiceUnavailable: return "SERVICE_UNAVAILABLE";
				case TargetingIdeaErrorReason.InvalidUrlInSearchParameter: return "INVALID_URL_IN_SEARCH_PARAMETER";
				case TargetingIdeaErrorReason.TooManyResultsRequested: return "TOO_MANY_RESULTS_REQUESTED";
				case TargetingIdeaErrorReason.NoPagingInSelector: return "NO_PAGING_IN_SELECTOR";
				case TargetingIdeaErrorReason.InvalidIncludedExcludedKeywords: return "INVALID_INCLUDED_EXCLUDED_KEYWORDS";
				default: return null;
			}
		}
		public static TargetingIdeaErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "DUPLICATE_SEARCH_FILTER_TYPES_PRESENT": return TargetingIdeaErrorReason.DuplicateSearchFilterTypesPresent;
				case "INSUFFICIENT_SEARCH_PARAMETERS": return TargetingIdeaErrorReason.InsufficientSearchParameters;
				case "INVALID_ATTRIBUTE_TYPE": return TargetingIdeaErrorReason.InvalidAttributeType;
				case "INVALID_SEARCH_PARAMETERS": return TargetingIdeaErrorReason.InvalidSearchParameters;
				case "INVALID_DOMAIN_SUFFIX": return TargetingIdeaErrorReason.InvalidDomainSuffix;
				case "MUTUALLY_EXCLUSIVE_SEARCH_PARAMETERS_IN_QUERY": return TargetingIdeaErrorReason.MutuallyExclusiveSearchParametersInQuery;
				case "SERVICE_UNAVAILABLE": return TargetingIdeaErrorReason.ServiceUnavailable;
				case "INVALID_URL_IN_SEARCH_PARAMETER": return TargetingIdeaErrorReason.InvalidUrlInSearchParameter;
				case "TOO_MANY_RESULTS_REQUESTED": return TargetingIdeaErrorReason.TooManyResultsRequested;
				case "NO_PAGING_IN_SELECTOR": return TargetingIdeaErrorReason.NoPagingInSelector;
				case "INVALID_INCLUDED_EXCLUDED_KEYWORDS": return TargetingIdeaErrorReason.InvalidIncludedExcludedKeywords;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type TargetingIdeaErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class TemplateElementFieldTypeExtensions
	{
		public static string ToXmlValue(this TemplateElementFieldType enumValue)
		{
			switch (enumValue)
			{
				case TemplateElementFieldType.Address: return "ADDRESS";
				case TemplateElementFieldType.Audio: return "AUDIO";
				case TemplateElementFieldType.Enum: return "ENUM";
				case TemplateElementFieldType.Image: return "IMAGE";
				case TemplateElementFieldType.BackgroundImage: return "BACKGROUND_IMAGE";
				case TemplateElementFieldType.Number: return "NUMBER";
				case TemplateElementFieldType.Text: return "TEXT";
				case TemplateElementFieldType.Url: return "URL";
				case TemplateElementFieldType.Video: return "VIDEO";
				case TemplateElementFieldType.VisibleUrl: return "VISIBLE_URL";
				case TemplateElementFieldType.MediaBundle: return "MEDIA_BUNDLE";
				case TemplateElementFieldType.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static TemplateElementFieldType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ADDRESS": return TemplateElementFieldType.Address;
				case "AUDIO": return TemplateElementFieldType.Audio;
				case "ENUM": return TemplateElementFieldType.Enum;
				case "IMAGE": return TemplateElementFieldType.Image;
				case "BACKGROUND_IMAGE": return TemplateElementFieldType.BackgroundImage;
				case "NUMBER": return TemplateElementFieldType.Number;
				case "TEXT": return TemplateElementFieldType.Text;
				case "URL": return TemplateElementFieldType.Url;
				case "VIDEO": return TemplateElementFieldType.Video;
				case "VISIBLE_URL": return TemplateElementFieldType.VisibleUrl;
				case "MEDIA_BUNDLE": return TemplateElementFieldType.MediaBundle;
				case "UNKNOWN": return TemplateElementFieldType.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type TemplateElementFieldType.", nameof(xmlValue));
			}
		}
	}
	public static class ThirdPartyRedirectAdExpandingDirectionExtensions
	{
		public static string ToXmlValue(this ThirdPartyRedirectAdExpandingDirection enumValue)
		{
			switch (enumValue)
			{
				case ThirdPartyRedirectAdExpandingDirection.Unknown: return "UNKNOWN";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingUp: return "EXPANDING_UP";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingDown: return "EXPANDING_DOWN";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingLeft: return "EXPANDING_LEFT";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingRight: return "EXPANDING_RIGHT";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingUpleft: return "EXPANDING_UPLEFT";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingUpright: return "EXPANDING_UPRIGHT";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingDownleft: return "EXPANDING_DOWNLEFT";
				case ThirdPartyRedirectAdExpandingDirection.ExpandingDownright: return "EXPANDING_DOWNRIGHT";
				default: return null;
			}
		}
		public static ThirdPartyRedirectAdExpandingDirection Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return ThirdPartyRedirectAdExpandingDirection.Unknown;
				case "EXPANDING_UP": return ThirdPartyRedirectAdExpandingDirection.ExpandingUp;
				case "EXPANDING_DOWN": return ThirdPartyRedirectAdExpandingDirection.ExpandingDown;
				case "EXPANDING_LEFT": return ThirdPartyRedirectAdExpandingDirection.ExpandingLeft;
				case "EXPANDING_RIGHT": return ThirdPartyRedirectAdExpandingDirection.ExpandingRight;
				case "EXPANDING_UPLEFT": return ThirdPartyRedirectAdExpandingDirection.ExpandingUpleft;
				case "EXPANDING_UPRIGHT": return ThirdPartyRedirectAdExpandingDirection.ExpandingUpright;
				case "EXPANDING_DOWNLEFT": return ThirdPartyRedirectAdExpandingDirection.ExpandingDownleft;
				case "EXPANDING_DOWNRIGHT": return ThirdPartyRedirectAdExpandingDirection.ExpandingDownright;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type ThirdPartyRedirectAdExpandingDirection.", nameof(xmlValue));
			}
		}
	}
	public static class TimeUnitExtensions
	{
		public static string ToXmlValue(this TimeUnit enumValue)
		{
			switch (enumValue)
			{
				case TimeUnit.Minute: return "MINUTE";
				case TimeUnit.Hour: return "HOUR";
				case TimeUnit.Day: return "DAY";
				case TimeUnit.Week: return "WEEK";
				case TimeUnit.Month: return "MONTH";
				case TimeUnit.Lifetime: return "LIFETIME";
				default: return null;
			}
		}
		public static TimeUnit Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "MINUTE": return TimeUnit.Minute;
				case "HOUR": return TimeUnit.Hour;
				case "DAY": return TimeUnit.Day;
				case "WEEK": return TimeUnit.Week;
				case "MONTH": return TimeUnit.Month;
				case "LIFETIME": return TimeUnit.Lifetime;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type TimeUnit.", nameof(xmlValue));
			}
		}
	}
	public static class TrafficEstimatorErrorReasonExtensions
	{
		public static string ToXmlValue(this TrafficEstimatorErrorReason enumValue)
		{
			switch (enumValue)
			{
				case TrafficEstimatorErrorReason.NoCampaignForAdGroupEstimateRequest: return "NO_CAMPAIGN_FOR_AD_GROUP_ESTIMATE_REQUEST";
				case TrafficEstimatorErrorReason.NoAdGroupForKeywordEstimateRequest: return "NO_AD_GROUP_FOR_KEYWORD_ESTIMATE_REQUEST";
				case TrafficEstimatorErrorReason.NoMaxCpcForKeywordEstimateRequest: return "NO_MAX_CPC_FOR_KEYWORD_ESTIMATE_REQUEST";
				case TrafficEstimatorErrorReason.TooManyKeywordEstimateRequests: return "TOO_MANY_KEYWORD_ESTIMATE_REQUESTS";
				case TrafficEstimatorErrorReason.TooManyCampaignEstimateRequests: return "TOO_MANY_CAMPAIGN_ESTIMATE_REQUESTS";
				case TrafficEstimatorErrorReason.TooManyAdgroupEstimateRequests: return "TOO_MANY_ADGROUP_ESTIMATE_REQUESTS";
				case TrafficEstimatorErrorReason.TooManyTargets: return "TOO_MANY_TARGETS";
				case TrafficEstimatorErrorReason.KeywordTooLong: return "KEYWORD_TOO_LONG";
				case TrafficEstimatorErrorReason.KeywordContainsBroadMatchModifiers: return "KEYWORD_CONTAINS_BROAD_MATCH_MODIFIERS";
				case TrafficEstimatorErrorReason.InvalidInput: return "INVALID_INPUT";
				case TrafficEstimatorErrorReason.ServiceUnavailable: return "SERVICE_UNAVAILABLE";
				default: return null;
			}
		}
		public static TrafficEstimatorErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "NO_CAMPAIGN_FOR_AD_GROUP_ESTIMATE_REQUEST": return TrafficEstimatorErrorReason.NoCampaignForAdGroupEstimateRequest;
				case "NO_AD_GROUP_FOR_KEYWORD_ESTIMATE_REQUEST": return TrafficEstimatorErrorReason.NoAdGroupForKeywordEstimateRequest;
				case "NO_MAX_CPC_FOR_KEYWORD_ESTIMATE_REQUEST": return TrafficEstimatorErrorReason.NoMaxCpcForKeywordEstimateRequest;
				case "TOO_MANY_KEYWORD_ESTIMATE_REQUESTS": return TrafficEstimatorErrorReason.TooManyKeywordEstimateRequests;
				case "TOO_MANY_CAMPAIGN_ESTIMATE_REQUESTS": return TrafficEstimatorErrorReason.TooManyCampaignEstimateRequests;
				case "TOO_MANY_ADGROUP_ESTIMATE_REQUESTS": return TrafficEstimatorErrorReason.TooManyAdgroupEstimateRequests;
				case "TOO_MANY_TARGETS": return TrafficEstimatorErrorReason.TooManyTargets;
				case "KEYWORD_TOO_LONG": return TrafficEstimatorErrorReason.KeywordTooLong;
				case "KEYWORD_CONTAINS_BROAD_MATCH_MODIFIERS": return TrafficEstimatorErrorReason.KeywordContainsBroadMatchModifiers;
				case "INVALID_INPUT": return TrafficEstimatorErrorReason.InvalidInput;
				case "SERVICE_UNAVAILABLE": return TrafficEstimatorErrorReason.ServiceUnavailable;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type TrafficEstimatorErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class TrialErrorReasonExtensions
	{
		public static string ToXmlValue(this TrialErrorReason enumValue)
		{
			switch (enumValue)
			{
				case TrialErrorReason.Unknown: return "UNKNOWN";
				case TrialErrorReason.InvalidStatusTransition: return "INVALID_STATUS_TRANSITION";
				case TrialErrorReason.CannotUseTrialWithSharedBudget: return "CANNOT_USE_TRIAL_WITH_SHARED_BUDGET";
				case TrialErrorReason.CannotCreateTrialWhenCampaignHasActiveExperiments: return "CANNOT_CREATE_TRIAL_WHEN_CAMPAIGN_HAS_ACTIVE_EXPERIMENTS";
				case TrialErrorReason.CannotCreateTrialForDeletedBaseCampaign: return "CANNOT_CREATE_TRIAL_FOR_DELETED_BASE_CAMPAIGN";
				case TrialErrorReason.CannotCreateTrialForNonProposedDraft: return "CANNOT_CREATE_TRIAL_FOR_NON_PROPOSED_DRAFT";
				case TrialErrorReason.CustomerCannotCreateTrial: return "CUSTOMER_CANNOT_CREATE_TRIAL";
				case TrialErrorReason.CampaignCannotCreateTrial: return "CAMPAIGN_CANNOT_CREATE_TRIAL";
				case TrialErrorReason.NameAlreadyInUse: return "NAME_ALREADY_IN_USE";
				case TrialErrorReason.TrialDurationsMustNotOverlap: return "TRIAL_DURATIONS_MUST_NOT_OVERLAP";
				case TrialErrorReason.TrialDurationMustBeWithinCampaignDuration: return "TRIAL_DURATION_MUST_BE_WITHIN_CAMPAIGN_DURATION";
				default: return null;
			}
		}
		public static TrialErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return TrialErrorReason.Unknown;
				case "INVALID_STATUS_TRANSITION": return TrialErrorReason.InvalidStatusTransition;
				case "CANNOT_USE_TRIAL_WITH_SHARED_BUDGET": return TrialErrorReason.CannotUseTrialWithSharedBudget;
				case "CANNOT_CREATE_TRIAL_WHEN_CAMPAIGN_HAS_ACTIVE_EXPERIMENTS": return TrialErrorReason.CannotCreateTrialWhenCampaignHasActiveExperiments;
				case "CANNOT_CREATE_TRIAL_FOR_DELETED_BASE_CAMPAIGN": return TrialErrorReason.CannotCreateTrialForDeletedBaseCampaign;
				case "CANNOT_CREATE_TRIAL_FOR_NON_PROPOSED_DRAFT": return TrialErrorReason.CannotCreateTrialForNonProposedDraft;
				case "CUSTOMER_CANNOT_CREATE_TRIAL": return TrialErrorReason.CustomerCannotCreateTrial;
				case "CAMPAIGN_CANNOT_CREATE_TRIAL": return TrialErrorReason.CampaignCannotCreateTrial;
				case "NAME_ALREADY_IN_USE": return TrialErrorReason.NameAlreadyInUse;
				case "TRIAL_DURATIONS_MUST_NOT_OVERLAP": return TrialErrorReason.TrialDurationsMustNotOverlap;
				case "TRIAL_DURATION_MUST_BE_WITHIN_CAMPAIGN_DURATION": return TrialErrorReason.TrialDurationMustBeWithinCampaignDuration;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type TrialErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class TrialStatusExtensions
	{
		public static string ToXmlValue(this TrialStatus enumValue)
		{
			switch (enumValue)
			{
				case TrialStatus.Unknown: return "UNKNOWN";
				case TrialStatus.Creating: return "CREATING";
				case TrialStatus.Active: return "ACTIVE";
				case TrialStatus.Promoting: return "PROMOTING";
				case TrialStatus.Promoted: return "PROMOTED";
				case TrialStatus.Archived: return "ARCHIVED";
				case TrialStatus.CreationFailed: return "CREATION_FAILED";
				case TrialStatus.PromoteFailed: return "PROMOTE_FAILED";
				case TrialStatus.Graduated: return "GRADUATED";
				case TrialStatus.Halted: return "HALTED";
				default: return null;
			}
		}
		public static TrialStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return TrialStatus.Unknown;
				case "CREATING": return TrialStatus.Creating;
				case "ACTIVE": return TrialStatus.Active;
				case "PROMOTING": return TrialStatus.Promoting;
				case "PROMOTED": return TrialStatus.Promoted;
				case "ARCHIVED": return TrialStatus.Archived;
				case "CREATION_FAILED": return TrialStatus.CreationFailed;
				case "PROMOTE_FAILED": return TrialStatus.PromoteFailed;
				case "GRADUATED": return TrialStatus.Graduated;
				case "HALTED": return TrialStatus.Halted;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type TrialStatus.", nameof(xmlValue));
			}
		}
	}
	public static class UniversalAppBiddingStrategyGoalTypeExtensions
	{
		public static string ToXmlValue(this UniversalAppBiddingStrategyGoalType enumValue)
		{
			switch (enumValue)
			{
				case UniversalAppBiddingStrategyGoalType.Unknown: return "UNKNOWN";
				case UniversalAppBiddingStrategyGoalType.OptimizeForInstallConversionVolume: return "OPTIMIZE_FOR_INSTALL_CONVERSION_VOLUME";
				case UniversalAppBiddingStrategyGoalType.OptimizeForInAppConversionVolume: return "OPTIMIZE_FOR_IN_APP_CONVERSION_VOLUME";
				case UniversalAppBiddingStrategyGoalType.OptimizeForTotalConversionValue: return "OPTIMIZE_FOR_TOTAL_CONVERSION_VALUE";
				default: return null;
			}
		}
		public static UniversalAppBiddingStrategyGoalType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return UniversalAppBiddingStrategyGoalType.Unknown;
				case "OPTIMIZE_FOR_INSTALL_CONVERSION_VOLUME": return UniversalAppBiddingStrategyGoalType.OptimizeForInstallConversionVolume;
				case "OPTIMIZE_FOR_IN_APP_CONVERSION_VOLUME": return UniversalAppBiddingStrategyGoalType.OptimizeForInAppConversionVolume;
				case "OPTIMIZE_FOR_TOTAL_CONVERSION_VALUE": return UniversalAppBiddingStrategyGoalType.OptimizeForTotalConversionValue;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UniversalAppBiddingStrategyGoalType.", nameof(xmlValue));
			}
		}
	}
	public static class UniversalAppCampaignAssetExtensions
	{
		public static string ToXmlValue(this UniversalAppCampaignAsset enumValue)
		{
			switch (enumValue)
			{
				case UniversalAppCampaignAsset.Unknown: return "UNKNOWN";
				case UniversalAppCampaignAsset.Combination: return "COMBINATION";
				case UniversalAppCampaignAsset.AppDestination: return "APP_DESTINATION";
				case UniversalAppCampaignAsset.AppAssets: return "APP_ASSETS";
				case UniversalAppCampaignAsset.Description1: return "DESCRIPTION_1";
				case UniversalAppCampaignAsset.Description2: return "DESCRIPTION_2";
				case UniversalAppCampaignAsset.Description3: return "DESCRIPTION_3";
				case UniversalAppCampaignAsset.Description4: return "DESCRIPTION_4";
				case UniversalAppCampaignAsset.Video: return "VIDEO";
				case UniversalAppCampaignAsset.Image: return "IMAGE";
				default: return null;
			}
		}
		public static UniversalAppCampaignAsset Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return UniversalAppCampaignAsset.Unknown;
				case "COMBINATION": return UniversalAppCampaignAsset.Combination;
				case "APP_DESTINATION": return UniversalAppCampaignAsset.AppDestination;
				case "APP_ASSETS": return UniversalAppCampaignAsset.AppAssets;
				case "DESCRIPTION_1": return UniversalAppCampaignAsset.Description1;
				case "DESCRIPTION_2": return UniversalAppCampaignAsset.Description2;
				case "DESCRIPTION_3": return UniversalAppCampaignAsset.Description3;
				case "DESCRIPTION_4": return UniversalAppCampaignAsset.Description4;
				case "VIDEO": return UniversalAppCampaignAsset.Video;
				case "IMAGE": return UniversalAppCampaignAsset.Image;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UniversalAppCampaignAsset.", nameof(xmlValue));
			}
		}
	}
	public static class UrlErrorReasonExtensions
	{
		public static string ToXmlValue(this UrlErrorReason enumValue)
		{
			switch (enumValue)
			{
				case UrlErrorReason.InvalidTrackingUrlTemplate: return "INVALID_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.InvalidTagInTrackingUrlTemplate: return "INVALID_TAG_IN_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.MissingTrackingUrlTemplateTag: return "MISSING_TRACKING_URL_TEMPLATE_TAG";
				case UrlErrorReason.MissingProtocolInTrackingUrlTemplate: return "MISSING_PROTOCOL_IN_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.InvalidProtocolInTrackingUrlTemplate: return "INVALID_PROTOCOL_IN_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.MalformedTrackingUrlTemplate: return "MALFORMED_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.MissingHostInTrackingUrlTemplate: return "MISSING_HOST_IN_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.InvalidTldInTrackingUrlTemplate: return "INVALID_TLD_IN_TRACKING_URL_TEMPLATE";
				case UrlErrorReason.RedundantNestedTrackingUrlTemplateTag: return "REDUNDANT_NESTED_TRACKING_URL_TEMPLATE_TAG";
				case UrlErrorReason.InvalidFinalUrl: return "INVALID_FINAL_URL";
				case UrlErrorReason.InvalidTagInFinalUrl: return "INVALID_TAG_IN_FINAL_URL";
				case UrlErrorReason.RedundantNestedFinalUrlTag: return "REDUNDANT_NESTED_FINAL_URL_TAG";
				case UrlErrorReason.MissingProtocolInFinalUrl: return "MISSING_PROTOCOL_IN_FINAL_URL";
				case UrlErrorReason.InvalidProtocolInFinalUrl: return "INVALID_PROTOCOL_IN_FINAL_URL";
				case UrlErrorReason.MalformedFinalUrl: return "MALFORMED_FINAL_URL";
				case UrlErrorReason.MissingHostInFinalUrl: return "MISSING_HOST_IN_FINAL_URL";
				case UrlErrorReason.InvalidTldInFinalUrl: return "INVALID_TLD_IN_FINAL_URL";
				case UrlErrorReason.InvalidFinalMobileUrl: return "INVALID_FINAL_MOBILE_URL";
				case UrlErrorReason.InvalidTagInFinalMobileUrl: return "INVALID_TAG_IN_FINAL_MOBILE_URL";
				case UrlErrorReason.RedundantNestedFinalMobileUrlTag: return "REDUNDANT_NESTED_FINAL_MOBILE_URL_TAG";
				case UrlErrorReason.MissingProtocolInFinalMobileUrl: return "MISSING_PROTOCOL_IN_FINAL_MOBILE_URL";
				case UrlErrorReason.InvalidProtocolInFinalMobileUrl: return "INVALID_PROTOCOL_IN_FINAL_MOBILE_URL";
				case UrlErrorReason.MalformedFinalMobileUrl: return "MALFORMED_FINAL_MOBILE_URL";
				case UrlErrorReason.MissingHostInFinalMobileUrl: return "MISSING_HOST_IN_FINAL_MOBILE_URL";
				case UrlErrorReason.InvalidTldInFinalMobileUrl: return "INVALID_TLD_IN_FINAL_MOBILE_URL";
				case UrlErrorReason.InvalidFinalAppUrl: return "INVALID_FINAL_APP_URL";
				case UrlErrorReason.InvalidTagInFinalAppUrl: return "INVALID_TAG_IN_FINAL_APP_URL";
				case UrlErrorReason.RedundantNestedFinalAppUrlTag: return "REDUNDANT_NESTED_FINAL_APP_URL_TAG";
				case UrlErrorReason.MultipleAppUrlsForOstype: return "MULTIPLE_APP_URLS_FOR_OSTYPE";
				case UrlErrorReason.InvalidOstype: return "INVALID_OSTYPE";
				case UrlErrorReason.InvalidProtocolForAppUrl: return "INVALID_PROTOCOL_FOR_APP_URL";
				case UrlErrorReason.InvalidPackageIdForAppUrl: return "INVALID_PACKAGE_ID_FOR_APP_URL";
				case UrlErrorReason.UrlCustomParametersCountExceedsLimit: return "URL_CUSTOM_PARAMETERS_COUNT_EXCEEDS_LIMIT";
				case UrlErrorReason.UrlCustomParameterRemovalWithNonNullValue: return "URL_CUSTOM_PARAMETER_REMOVAL_WITH_NON_NULL_VALUE";
				case UrlErrorReason.CannotRemoveUrlCustomParameterInAddOperation: return "CANNOT_REMOVE_URL_CUSTOM_PARAMETER_IN_ADD_OPERATION";
				case UrlErrorReason.CannotRemoveUrlCustomParameterDuringFullReplacement: return "CANNOT_REMOVE_URL_CUSTOM_PARAMETER_DURING_FULL_REPLACEMENT";
				case UrlErrorReason.NullCustomParameterValueDuringAddOrFullReplacement: return "NULL_CUSTOM_PARAMETER_VALUE_DURING_ADD_OR_FULL_REPLACEMENT";
				case UrlErrorReason.InvalidCharactersInUrlCustomParameterKey: return "INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_KEY";
				case UrlErrorReason.InvalidCharactersInUrlCustomParameterValue: return "INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_VALUE";
				case UrlErrorReason.InvalidTagInUrlCustomParameterValue: return "INVALID_TAG_IN_URL_CUSTOM_PARAMETER_VALUE";
				case UrlErrorReason.RedundantNestedUrlCustomParameterTag: return "REDUNDANT_NESTED_URL_CUSTOM_PARAMETER_TAG";
				case UrlErrorReason.MissingProtocol: return "MISSING_PROTOCOL";
				case UrlErrorReason.InvalidUrl: return "INVALID_URL";
				case UrlErrorReason.DestinationUrlDeprecated: return "DESTINATION_URL_DEPRECATED";
				case UrlErrorReason.InvalidTagInUrl: return "INVALID_TAG_IN_URL";
				case UrlErrorReason.MissingUrlTag: return "MISSING_URL_TAG";
				case UrlErrorReason.UrlError: return "URL_ERROR";
				default: return null;
			}
		}
		public static UrlErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_TRACKING_URL_TEMPLATE": return UrlErrorReason.InvalidTrackingUrlTemplate;
				case "INVALID_TAG_IN_TRACKING_URL_TEMPLATE": return UrlErrorReason.InvalidTagInTrackingUrlTemplate;
				case "MISSING_TRACKING_URL_TEMPLATE_TAG": return UrlErrorReason.MissingTrackingUrlTemplateTag;
				case "MISSING_PROTOCOL_IN_TRACKING_URL_TEMPLATE": return UrlErrorReason.MissingProtocolInTrackingUrlTemplate;
				case "INVALID_PROTOCOL_IN_TRACKING_URL_TEMPLATE": return UrlErrorReason.InvalidProtocolInTrackingUrlTemplate;
				case "MALFORMED_TRACKING_URL_TEMPLATE": return UrlErrorReason.MalformedTrackingUrlTemplate;
				case "MISSING_HOST_IN_TRACKING_URL_TEMPLATE": return UrlErrorReason.MissingHostInTrackingUrlTemplate;
				case "INVALID_TLD_IN_TRACKING_URL_TEMPLATE": return UrlErrorReason.InvalidTldInTrackingUrlTemplate;
				case "REDUNDANT_NESTED_TRACKING_URL_TEMPLATE_TAG": return UrlErrorReason.RedundantNestedTrackingUrlTemplateTag;
				case "INVALID_FINAL_URL": return UrlErrorReason.InvalidFinalUrl;
				case "INVALID_TAG_IN_FINAL_URL": return UrlErrorReason.InvalidTagInFinalUrl;
				case "REDUNDANT_NESTED_FINAL_URL_TAG": return UrlErrorReason.RedundantNestedFinalUrlTag;
				case "MISSING_PROTOCOL_IN_FINAL_URL": return UrlErrorReason.MissingProtocolInFinalUrl;
				case "INVALID_PROTOCOL_IN_FINAL_URL": return UrlErrorReason.InvalidProtocolInFinalUrl;
				case "MALFORMED_FINAL_URL": return UrlErrorReason.MalformedFinalUrl;
				case "MISSING_HOST_IN_FINAL_URL": return UrlErrorReason.MissingHostInFinalUrl;
				case "INVALID_TLD_IN_FINAL_URL": return UrlErrorReason.InvalidTldInFinalUrl;
				case "INVALID_FINAL_MOBILE_URL": return UrlErrorReason.InvalidFinalMobileUrl;
				case "INVALID_TAG_IN_FINAL_MOBILE_URL": return UrlErrorReason.InvalidTagInFinalMobileUrl;
				case "REDUNDANT_NESTED_FINAL_MOBILE_URL_TAG": return UrlErrorReason.RedundantNestedFinalMobileUrlTag;
				case "MISSING_PROTOCOL_IN_FINAL_MOBILE_URL": return UrlErrorReason.MissingProtocolInFinalMobileUrl;
				case "INVALID_PROTOCOL_IN_FINAL_MOBILE_URL": return UrlErrorReason.InvalidProtocolInFinalMobileUrl;
				case "MALFORMED_FINAL_MOBILE_URL": return UrlErrorReason.MalformedFinalMobileUrl;
				case "MISSING_HOST_IN_FINAL_MOBILE_URL": return UrlErrorReason.MissingHostInFinalMobileUrl;
				case "INVALID_TLD_IN_FINAL_MOBILE_URL": return UrlErrorReason.InvalidTldInFinalMobileUrl;
				case "INVALID_FINAL_APP_URL": return UrlErrorReason.InvalidFinalAppUrl;
				case "INVALID_TAG_IN_FINAL_APP_URL": return UrlErrorReason.InvalidTagInFinalAppUrl;
				case "REDUNDANT_NESTED_FINAL_APP_URL_TAG": return UrlErrorReason.RedundantNestedFinalAppUrlTag;
				case "MULTIPLE_APP_URLS_FOR_OSTYPE": return UrlErrorReason.MultipleAppUrlsForOstype;
				case "INVALID_OSTYPE": return UrlErrorReason.InvalidOstype;
				case "INVALID_PROTOCOL_FOR_APP_URL": return UrlErrorReason.InvalidProtocolForAppUrl;
				case "INVALID_PACKAGE_ID_FOR_APP_URL": return UrlErrorReason.InvalidPackageIdForAppUrl;
				case "URL_CUSTOM_PARAMETERS_COUNT_EXCEEDS_LIMIT": return UrlErrorReason.UrlCustomParametersCountExceedsLimit;
				case "URL_CUSTOM_PARAMETER_REMOVAL_WITH_NON_NULL_VALUE": return UrlErrorReason.UrlCustomParameterRemovalWithNonNullValue;
				case "CANNOT_REMOVE_URL_CUSTOM_PARAMETER_IN_ADD_OPERATION": return UrlErrorReason.CannotRemoveUrlCustomParameterInAddOperation;
				case "CANNOT_REMOVE_URL_CUSTOM_PARAMETER_DURING_FULL_REPLACEMENT": return UrlErrorReason.CannotRemoveUrlCustomParameterDuringFullReplacement;
				case "NULL_CUSTOM_PARAMETER_VALUE_DURING_ADD_OR_FULL_REPLACEMENT": return UrlErrorReason.NullCustomParameterValueDuringAddOrFullReplacement;
				case "INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_KEY": return UrlErrorReason.InvalidCharactersInUrlCustomParameterKey;
				case "INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_VALUE": return UrlErrorReason.InvalidCharactersInUrlCustomParameterValue;
				case "INVALID_TAG_IN_URL_CUSTOM_PARAMETER_VALUE": return UrlErrorReason.InvalidTagInUrlCustomParameterValue;
				case "REDUNDANT_NESTED_URL_CUSTOM_PARAMETER_TAG": return UrlErrorReason.RedundantNestedUrlCustomParameterTag;
				case "MISSING_PROTOCOL": return UrlErrorReason.MissingProtocol;
				case "INVALID_URL": return UrlErrorReason.InvalidUrl;
				case "DESTINATION_URL_DEPRECATED": return UrlErrorReason.DestinationUrlDeprecated;
				case "INVALID_TAG_IN_URL": return UrlErrorReason.InvalidTagInUrl;
				case "MISSING_URL_TAG": return UrlErrorReason.MissingUrlTag;
				case "URL_ERROR": return UrlErrorReason.UrlError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UrlErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class UserListConversionTypeCategoryExtensions
	{
		public static string ToXmlValue(this UserListConversionTypeCategory enumValue)
		{
			switch (enumValue)
			{
				case UserListConversionTypeCategory.BoomerangEvent: return "BOOMERANG_EVENT";
				case UserListConversionTypeCategory.Other: return "OTHER";
				default: return null;
			}
		}
		public static UserListConversionTypeCategory Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "BOOMERANG_EVENT": return UserListConversionTypeCategory.BoomerangEvent;
				case "OTHER": return UserListConversionTypeCategory.Other;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UserListConversionTypeCategory.", nameof(xmlValue));
			}
		}
	}
	public static class UserListErrorReasonExtensions
	{
		public static string ToXmlValue(this UserListErrorReason enumValue)
		{
			switch (enumValue)
			{
				case UserListErrorReason.ExternalRemarketingUserListMutateNotSupported: return "EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED";
				case UserListErrorReason.ConcreteTypeRequired: return "CONCRETE_TYPE_REQUIRED";
				case UserListErrorReason.ConversionTypeIdRequired: return "CONVERSION_TYPE_ID_REQUIRED";
				case UserListErrorReason.DuplicateConversionTypes: return "DUPLICATE_CONVERSION_TYPES";
				case UserListErrorReason.InvalidConversionType: return "INVALID_CONVERSION_TYPE";
				case UserListErrorReason.InvalidDescription: return "INVALID_DESCRIPTION";
				case UserListErrorReason.InvalidName: return "INVALID_NAME";
				case UserListErrorReason.InvalidType: return "INVALID_TYPE";
				case UserListErrorReason.InvalidUserListLogicalRuleOperand: return "INVALID_USER_LIST_LOGICAL_RULE_OPERAND";
				case UserListErrorReason.NameAlreadyUsed: return "NAME_ALREADY_USED";
				case UserListErrorReason.NewConversionTypeNameRequired: return "NEW_CONVERSION_TYPE_NAME_REQUIRED";
				case UserListErrorReason.OwnershipRequiredForSet: return "OWNERSHIP_REQUIRED_FOR_SET";
				case UserListErrorReason.RemoveNotSupported: return "REMOVE_NOT_SUPPORTED";
				case UserListErrorReason.UserListMutateNotSupported: return "USER_LIST_MUTATE_NOT_SUPPORTED";
				case UserListErrorReason.InvalidRule: return "INVALID_RULE";
				case UserListErrorReason.InvalidDateRange: return "INVALID_DATE_RANGE";
				case UserListErrorReason.CanNotMutateSensitiveUserlist: return "CAN_NOT_MUTATE_SENSITIVE_USERLIST";
				case UserListErrorReason.MaxNumRulebasedUserlists: return "MAX_NUM_RULEBASED_USERLISTS";
				case UserListErrorReason.CannotModifyBillableRecordCount: return "CANNOT_MODIFY_BILLABLE_RECORD_COUNT";
				case UserListErrorReason.UserListServiceError: return "USER_LIST_SERVICE_ERROR";
				default: return null;
			}
		}
		public static UserListErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED": return UserListErrorReason.ExternalRemarketingUserListMutateNotSupported;
				case "CONCRETE_TYPE_REQUIRED": return UserListErrorReason.ConcreteTypeRequired;
				case "CONVERSION_TYPE_ID_REQUIRED": return UserListErrorReason.ConversionTypeIdRequired;
				case "DUPLICATE_CONVERSION_TYPES": return UserListErrorReason.DuplicateConversionTypes;
				case "INVALID_CONVERSION_TYPE": return UserListErrorReason.InvalidConversionType;
				case "INVALID_DESCRIPTION": return UserListErrorReason.InvalidDescription;
				case "INVALID_NAME": return UserListErrorReason.InvalidName;
				case "INVALID_TYPE": return UserListErrorReason.InvalidType;
				case "INVALID_USER_LIST_LOGICAL_RULE_OPERAND": return UserListErrorReason.InvalidUserListLogicalRuleOperand;
				case "NAME_ALREADY_USED": return UserListErrorReason.NameAlreadyUsed;
				case "NEW_CONVERSION_TYPE_NAME_REQUIRED": return UserListErrorReason.NewConversionTypeNameRequired;
				case "OWNERSHIP_REQUIRED_FOR_SET": return UserListErrorReason.OwnershipRequiredForSet;
				case "REMOVE_NOT_SUPPORTED": return UserListErrorReason.RemoveNotSupported;
				case "USER_LIST_MUTATE_NOT_SUPPORTED": return UserListErrorReason.UserListMutateNotSupported;
				case "INVALID_RULE": return UserListErrorReason.InvalidRule;
				case "INVALID_DATE_RANGE": return UserListErrorReason.InvalidDateRange;
				case "CAN_NOT_MUTATE_SENSITIVE_USERLIST": return UserListErrorReason.CanNotMutateSensitiveUserlist;
				case "MAX_NUM_RULEBASED_USERLISTS": return UserListErrorReason.MaxNumRulebasedUserlists;
				case "CANNOT_MODIFY_BILLABLE_RECORD_COUNT": return UserListErrorReason.CannotModifyBillableRecordCount;
				case "USER_LIST_SERVICE_ERROR": return UserListErrorReason.UserListServiceError;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UserListErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class UserListLogicalRuleOperatorExtensions
	{
		public static string ToXmlValue(this UserListLogicalRuleOperator enumValue)
		{
			switch (enumValue)
			{
				case UserListLogicalRuleOperator.All: return "ALL";
				case UserListLogicalRuleOperator.Any: return "ANY";
				case UserListLogicalRuleOperator.None: return "NONE";
				case UserListLogicalRuleOperator.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static UserListLogicalRuleOperator Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ALL": return UserListLogicalRuleOperator.All;
				case "ANY": return UserListLogicalRuleOperator.Any;
				case "NONE": return UserListLogicalRuleOperator.None;
				case "UNKNOWN": return UserListLogicalRuleOperator.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UserListLogicalRuleOperator.", nameof(xmlValue));
			}
		}
	}
	public static class UserListMembershipStatusExtensions
	{
		public static string ToXmlValue(this UserListMembershipStatus enumValue)
		{
			switch (enumValue)
			{
				case UserListMembershipStatus.Open: return "OPEN";
				case UserListMembershipStatus.Closed: return "CLOSED";
				default: return null;
			}
		}
		public static UserListMembershipStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "OPEN": return UserListMembershipStatus.Open;
				case "CLOSED": return UserListMembershipStatus.Closed;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UserListMembershipStatus.", nameof(xmlValue));
			}
		}
	}
	public static class UserListTypeExtensions
	{
		public static string ToXmlValue(this UserListType enumValue)
		{
			switch (enumValue)
			{
				case UserListType.Unknown: return "UNKNOWN";
				case UserListType.Remarketing: return "REMARKETING";
				case UserListType.Logical: return "LOGICAL";
				case UserListType.ExternalRemarketing: return "EXTERNAL_REMARKETING";
				case UserListType.RuleBased: return "RULE_BASED";
				case UserListType.Similar: return "SIMILAR";
				case UserListType.CrmBased: return "CRM_BASED";
				default: return null;
			}
		}
		public static UserListType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return UserListType.Unknown;
				case "REMARKETING": return UserListType.Remarketing;
				case "LOGICAL": return UserListType.Logical;
				case "EXTERNAL_REMARKETING": return UserListType.ExternalRemarketing;
				case "RULE_BASED": return UserListType.RuleBased;
				case "SIMILAR": return UserListType.Similar;
				case "CRM_BASED": return UserListType.CrmBased;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UserListType.", nameof(xmlValue));
			}
		}
	}
	public static class UserStatusExtensions
	{
		public static string ToXmlValue(this UserStatus enumValue)
		{
			switch (enumValue)
			{
				case UserStatus.Enabled: return "ENABLED";
				case UserStatus.Removed: return "REMOVED";
				case UserStatus.Paused: return "PAUSED";
				default: return null;
			}
		}
		public static UserStatus Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ENABLED": return UserStatus.Enabled;
				case "REMOVED": return UserStatus.Removed;
				case "PAUSED": return UserStatus.Paused;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type UserStatus.", nameof(xmlValue));
			}
		}
	}
	public static class VanityPharmaDisplayUrlModeExtensions
	{
		public static string ToXmlValue(this VanityPharmaDisplayUrlMode enumValue)
		{
			switch (enumValue)
			{
				case VanityPharmaDisplayUrlMode.Unknown: return "UNKNOWN";
				case VanityPharmaDisplayUrlMode.ManufacturerWebsiteUrl: return "MANUFACTURER_WEBSITE_URL";
				case VanityPharmaDisplayUrlMode.WebsiteDescription: return "WEBSITE_DESCRIPTION";
				default: return null;
			}
		}
		public static VanityPharmaDisplayUrlMode Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return VanityPharmaDisplayUrlMode.Unknown;
				case "MANUFACTURER_WEBSITE_URL": return VanityPharmaDisplayUrlMode.ManufacturerWebsiteUrl;
				case "WEBSITE_DESCRIPTION": return VanityPharmaDisplayUrlMode.WebsiteDescription;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type VanityPharmaDisplayUrlMode.", nameof(xmlValue));
			}
		}
	}
	public static class VanityPharmaTextExtensions
	{
		public static string ToXmlValue(this VanityPharmaText enumValue)
		{
			switch (enumValue)
			{
				case VanityPharmaText.Unknown: return "UNKNOWN";
				case VanityPharmaText.PrescriptionTreatmentWebsiteEn: return "PRESCRIPTION_TREATMENT_WEBSITE_EN";
				case VanityPharmaText.PrescriptionTreatmentWebsiteEs: return "PRESCRIPTION_TREATMENT_WEBSITE_ES";
				case VanityPharmaText.PrescriptionDeviceWebsiteEn: return "PRESCRIPTION_DEVICE_WEBSITE_EN";
				case VanityPharmaText.PrescriptionDeviceWebsiteEs: return "PRESCRIPTION_DEVICE_WEBSITE_ES";
				case VanityPharmaText.MedicalDeviceWebsiteEn: return "MEDICAL_DEVICE_WEBSITE_EN";
				case VanityPharmaText.MedicalDeviceWebsiteEs: return "MEDICAL_DEVICE_WEBSITE_ES";
				case VanityPharmaText.PreventativeTreatmentWebsiteEn: return "PREVENTATIVE_TREATMENT_WEBSITE_EN";
				case VanityPharmaText.PreventativeTreatmentWebsiteEs: return "PREVENTATIVE_TREATMENT_WEBSITE_ES";
				case VanityPharmaText.PrescriptionContraceptionWebsiteEn: return "PRESCRIPTION_CONTRACEPTION_WEBSITE_EN";
				case VanityPharmaText.PrescriptionContraceptionWebsiteEs: return "PRESCRIPTION_CONTRACEPTION_WEBSITE_ES";
				case VanityPharmaText.PrescriptionVaccineWebsiteEn: return "PRESCRIPTION_VACCINE_WEBSITE_EN";
				case VanityPharmaText.PrescriptionVaccineWebsiteEs: return "PRESCRIPTION_VACCINE_WEBSITE_ES";
				default: return null;
			}
		}
		public static VanityPharmaText Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "UNKNOWN": return VanityPharmaText.Unknown;
				case "PRESCRIPTION_TREATMENT_WEBSITE_EN": return VanityPharmaText.PrescriptionTreatmentWebsiteEn;
				case "PRESCRIPTION_TREATMENT_WEBSITE_ES": return VanityPharmaText.PrescriptionTreatmentWebsiteEs;
				case "PRESCRIPTION_DEVICE_WEBSITE_EN": return VanityPharmaText.PrescriptionDeviceWebsiteEn;
				case "PRESCRIPTION_DEVICE_WEBSITE_ES": return VanityPharmaText.PrescriptionDeviceWebsiteEs;
				case "MEDICAL_DEVICE_WEBSITE_EN": return VanityPharmaText.MedicalDeviceWebsiteEn;
				case "MEDICAL_DEVICE_WEBSITE_ES": return VanityPharmaText.MedicalDeviceWebsiteEs;
				case "PREVENTATIVE_TREATMENT_WEBSITE_EN": return VanityPharmaText.PreventativeTreatmentWebsiteEn;
				case "PREVENTATIVE_TREATMENT_WEBSITE_ES": return VanityPharmaText.PreventativeTreatmentWebsiteEs;
				case "PRESCRIPTION_CONTRACEPTION_WEBSITE_EN": return VanityPharmaText.PrescriptionContraceptionWebsiteEn;
				case "PRESCRIPTION_CONTRACEPTION_WEBSITE_ES": return VanityPharmaText.PrescriptionContraceptionWebsiteEs;
				case "PRESCRIPTION_VACCINE_WEBSITE_EN": return VanityPharmaText.PrescriptionVaccineWebsiteEn;
				case "PRESCRIPTION_VACCINE_WEBSITE_ES": return VanityPharmaText.PrescriptionVaccineWebsiteEs;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type VanityPharmaText.", nameof(xmlValue));
			}
		}
	}
	public static class VideoErrorReasonExtensions
	{
		public static string ToXmlValue(this VideoErrorReason enumValue)
		{
			switch (enumValue)
			{
				case VideoErrorReason.InvalidVideo: return "INVALID_VIDEO";
				case VideoErrorReason.StorageError: return "STORAGE_ERROR";
				case VideoErrorReason.BadRequest: return "BAD_REQUEST";
				case VideoErrorReason.ErrorGeneratingStreamingUrl: return "ERROR_GENERATING_STREAMING_URL";
				case VideoErrorReason.UnexpectedSize: return "UNEXPECTED_SIZE";
				case VideoErrorReason.ServerError: return "SERVER_ERROR";
				case VideoErrorReason.FileTooLarge: return "FILE_TOO_LARGE";
				case VideoErrorReason.VideoProcessingError: return "VIDEO_PROCESSING_ERROR";
				case VideoErrorReason.InvalidInput: return "INVALID_INPUT";
				case VideoErrorReason.ProblemReadingFile: return "PROBLEM_READING_FILE";
				case VideoErrorReason.InvalidIsci: return "INVALID_ISCI";
				case VideoErrorReason.InvalidAdId: return "INVALID_AD_ID";
				default: return null;
			}
		}
		public static VideoErrorReason Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "INVALID_VIDEO": return VideoErrorReason.InvalidVideo;
				case "STORAGE_ERROR": return VideoErrorReason.StorageError;
				case "BAD_REQUEST": return VideoErrorReason.BadRequest;
				case "ERROR_GENERATING_STREAMING_URL": return VideoErrorReason.ErrorGeneratingStreamingUrl;
				case "UNEXPECTED_SIZE": return VideoErrorReason.UnexpectedSize;
				case "SERVER_ERROR": return VideoErrorReason.ServerError;
				case "FILE_TOO_LARGE": return VideoErrorReason.FileTooLarge;
				case "VIDEO_PROCESSING_ERROR": return VideoErrorReason.VideoProcessingError;
				case "INVALID_INPUT": return VideoErrorReason.InvalidInput;
				case "PROBLEM_READING_FILE": return VideoErrorReason.ProblemReadingFile;
				case "INVALID_ISCI": return VideoErrorReason.InvalidIsci;
				case "INVALID_AD_ID": return VideoErrorReason.InvalidAdId;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type VideoErrorReason.", nameof(xmlValue));
			}
		}
	}
	public static class VideoTypeExtensions
	{
		public static string ToXmlValue(this VideoType enumValue)
		{
			switch (enumValue)
			{
				case VideoType.Adobe: return "ADOBE";
				case VideoType.Realplayer: return "REALPLAYER";
				case VideoType.Quicktime: return "QUICKTIME";
				case VideoType.Windowsmedia: return "WINDOWSMEDIA";
				default: return null;
			}
		}
		public static VideoType Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "ADOBE": return VideoType.Adobe;
				case "REALPLAYER": return VideoType.Realplayer;
				case "QUICKTIME": return VideoType.Quicktime;
				case "WINDOWSMEDIA": return VideoType.Windowsmedia;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type VideoType.", nameof(xmlValue));
			}
		}
	}
	public static class WebpageConditionOperandExtensions
	{
		public static string ToXmlValue(this WebpageConditionOperand enumValue)
		{
			switch (enumValue)
			{
				case WebpageConditionOperand.Url: return "URL";
				case WebpageConditionOperand.Category: return "CATEGORY";
				case WebpageConditionOperand.PageTitle: return "PAGE_TITLE";
				case WebpageConditionOperand.PageContent: return "PAGE_CONTENT";
				case WebpageConditionOperand.Unknown: return "UNKNOWN";
				default: return null;
			}
		}
		public static WebpageConditionOperand Parse(string xmlValue)
		{
			switch (xmlValue)
			{
				case "URL": return WebpageConditionOperand.Url;
				case "CATEGORY": return WebpageConditionOperand.Category;
				case "PAGE_TITLE": return WebpageConditionOperand.PageTitle;
				case "PAGE_CONTENT": return WebpageConditionOperand.PageContent;
				case "UNKNOWN": return WebpageConditionOperand.Unknown;
				default: throw new ArgumentException($"Unknown value \"{xmlValue}\" for type WebpageConditionOperand.", nameof(xmlValue));
			}
		}
	}
}
