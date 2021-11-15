namespace Pop1_Stats_Collector
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PlayerStatsResponse
    {
        [JsonProperty("accountInfo")]
        public AccountInfo AccountInfo { get; set; }

        [JsonProperty("characterInventories")]
        public List<CharacterInventory> CharacterInventories { get; set; }

        [JsonProperty("characterList")]
        public List<CharacterList> CharacterList { get; set; }

        [JsonProperty("playerProfile")]
        public PlayerProfile PlayerProfile { get; set; }

        [JsonProperty("playerStatistics")]
        public List<PlayerStatistic> PlayerStatistics { get; set; }

        [JsonProperty("titleData")]
        public Data TitleData { get; set; }

        [JsonProperty("userData")]
        public UserData UserData { get; set; }

        [JsonProperty("userDataVersion")]
        public long UserDataVersion { get; set; }

        [JsonProperty("userInventory")]
        public List<Inventory> UserInventory { get; set; }

        [JsonProperty("userReadOnlyData")]
        public UserData UserReadOnlyData { get; set; }

        [JsonProperty("userReadOnlyDataVersion")]
        public long UserReadOnlyDataVersion { get; set; }

        [JsonProperty("userVirtualCurrency")]
        public UserVirtualCurrency UserVirtualCurrency { get; set; }

        [JsonProperty("userVirtualCurrencyRechargeTimes")]
        public UserVirtualCurrencyRechargeTimes UserVirtualCurrencyRechargeTimes { get; set; }
    }

    public partial class AccountInfo
    {
        [JsonProperty("androidDeviceInfo")]
        public AndroidDeviceInfo AndroidDeviceInfo { get; set; }

        [JsonProperty("appleAccountInfo")]
        public AppleAccountInfo AppleAccountInfo { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("customIdInfo")]
        public CustomIdInfo CustomIdInfo { get; set; }

        [JsonProperty("facebookInfo")]
        public FacebookInfo FacebookInfo { get; set; }

        [JsonProperty("facebookInstantGamesIdInfo")]
        public FacebookInstantGamesIdInfo FacebookInstantGamesIdInfo { get; set; }

        [JsonProperty("gameCenterInfo")]
        public GameCenterInfo GameCenterInfo { get; set; }

        [JsonProperty("googleInfo")]
        public GoogleInfo GoogleInfo { get; set; }

        [JsonProperty("iosDeviceInfo")]
        public IosDeviceInfo IosDeviceInfo { get; set; }

        [JsonProperty("kongregateInfo")]
        public KongregateInfo KongregateInfo { get; set; }

        [JsonProperty("nintendoSwitchAccountInfo")]
        public NintendoSwitchAccountInfo NintendoSwitchAccountInfo { get; set; }

        [JsonProperty("nintendoSwitchDeviceIdInfo")]
        public NintendoSwitchDeviceIdInfo NintendoSwitchDeviceIdInfo { get; set; }

        [JsonProperty("openIdInfo")]
        public List<OpenIdInfo> OpenIdInfo { get; set; }

        [JsonProperty("playFabId")]
        public string PlayFabId { get; set; }

        [JsonProperty("privateInfo")]
        public PrivateInfo PrivateInfo { get; set; }

        [JsonProperty("psnInfo")]
        public PsnInfo PsnInfo { get; set; }

        [JsonProperty("steamInfo")]
        public SteamInfo SteamInfo { get; set; }

        [JsonProperty("titleInfo")]
        public TitleInfo TitleInfo { get; set; }

        [JsonProperty("twitchInfo")]
        public TwitchInfo TwitchInfo { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("windowsHelloInfo")]
        public WindowsHelloInfo WindowsHelloInfo { get; set; }

        [JsonProperty("xboxInfo")]
        public XboxInfo XboxInfo { get; set; }
    }

    public partial class AndroidDeviceInfo
    {
        [JsonProperty("androidDeviceId")]
        public string AndroidDeviceId { get; set; }
    }

    public partial class AppleAccountInfo
    {
        [JsonProperty("appleSubjectId")]
        public string AppleSubjectId { get; set; }
    }

    public partial class CustomIdInfo
    {
        [JsonProperty("customId")]
        public string CustomId { get; set; }
    }

    public partial class FacebookInfo
    {
        [JsonProperty("facebookId")]
        public string FacebookId { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public partial class FacebookInstantGamesIdInfo
    {
        [JsonProperty("facebookInstantGamesId")]
        public string FacebookInstantGamesId { get; set; }
    }

    public partial class GameCenterInfo
    {
        [JsonProperty("gameCenterId")]
        public string GameCenterId { get; set; }
    }

    public partial class GoogleInfo
    {
        [JsonProperty("googleEmail")]
        public string GoogleEmail { get; set; }

        [JsonProperty("googleGender")]
        public string GoogleGender { get; set; }

        [JsonProperty("googleId")]
        public string GoogleId { get; set; }

        [JsonProperty("googleLocale")]
        public string GoogleLocale { get; set; }

        [JsonProperty("googleName")]
        public string GoogleName { get; set; }
    }

    public partial class IosDeviceInfo
    {
        [JsonProperty("iosDeviceId")]
        public string IosDeviceId { get; set; }
    }

    public partial class KongregateInfo
    {
        [JsonProperty("kongregateId")]
        public string KongregateId { get; set; }

        [JsonProperty("kongregateName")]
        public string KongregateName { get; set; }
    }

    public partial class NintendoSwitchAccountInfo
    {
        [JsonProperty("nintendoSwitchAccountSubjectId")]
        public string NintendoSwitchAccountSubjectId { get; set; }
    }

    public partial class NintendoSwitchDeviceIdInfo
    {
        [JsonProperty("nintendoSwitchDeviceId")]
        public string NintendoSwitchDeviceId { get; set; }
    }

    public partial class OpenIdInfo
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public partial class PrivateInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class PsnInfo
    {
        [JsonProperty("psnAccountId")]
        public string PsnAccountId { get; set; }

        [JsonProperty("psnOnlineId")]
        public string PsnOnlineId { get; set; }
    }

    public partial class SteamInfo
    {
        [JsonProperty("steamActivationStatus")]
        public long SteamActivationStatus { get; set; }

        [JsonProperty("steamCountry")]
        public string SteamCountry { get; set; }

        [JsonProperty("steamCurrency")]
        public long SteamCurrency { get; set; }

        [JsonProperty("steamId")]
        public string SteamId { get; set; }

        [JsonProperty("steamName")]
        public string SteamName { get; set; }
    }

    public partial class TitleInfo
    {
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }


        [JsonProperty("titlePlayerAccount")]
        public TitlePlayerAccount TitlePlayerAccount { get; set; }
    }

    public partial class TitlePlayerAccount
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class TwitchInfo
    {
        [JsonProperty("twitchId")]
        public string TwitchId { get; set; }

        [JsonProperty("twitchUserName")]
        public string TwitchUserName { get; set; }
    }

    public partial class WindowsHelloInfo
    {
        [JsonProperty("windowsHelloDeviceName")]
        public string WindowsHelloDeviceName { get; set; }

        [JsonProperty("windowsHelloPublicKeyHash")]
        public string WindowsHelloPublicKeyHash { get; set; }
    }

    public partial class XboxInfo
    {
        [JsonProperty("xboxUserId")]
        public string XboxUserId { get; set; }
    }

    public partial class CharacterInventory
    {
        [JsonProperty("characterId")]
        public string CharacterId { get; set; }

        [JsonProperty("inventory")]
        public List<Inventory> Inventory { get; set; }
    }

    public partial class Inventory
    {
        [JsonProperty("annotation")]
        public string Annotation { get; set; }

        [JsonProperty("bundleContents")]
        public List<string> BundleContents { get; set; }

        [JsonProperty("bundleParent")]
        public string BundleParent { get; set; }

        [JsonProperty("catalogVersion")]
        public string CatalogVersion { get; set; }

        [JsonProperty("customData")]
        public Data CustomData { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("expiration")]
        public DateTimeOffset Expiration { get; set; }

        [JsonProperty("itemClass")]
        public string ItemClass { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemInstanceId")]
        public string ItemInstanceId { get; set; }

        [JsonProperty("purchaseDate")]
        public DateTimeOffset PurchaseDate { get; set; }

        [JsonProperty("remainingUses")]
        public long RemainingUses { get; set; }

        [JsonProperty("unitCurrency")]
        public string UnitCurrency { get; set; }

        [JsonProperty("unitPrice")]
        public long UnitPrice { get; set; }

        [JsonProperty("usesIncrementedBy")]
        public long UsesIncrementedBy { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public partial class CharacterList
    {
        [JsonProperty("characterId")]
        public string CharacterId { get; set; }

        [JsonProperty("characterName")]
        public string CharacterName { get; set; }

        [JsonProperty("characterType")]
        public string CharacterType { get; set; }
    }

    public partial class PlayerProfile
    {
        [JsonProperty("adCampaignAttributions")]
        public List<AdCampaignAttribution> AdCampaignAttributions { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("bannedUntil")]
        public DateTimeOffset BannedUntil { get; set; }

        [JsonProperty("contactEmailAddresses")]
        public List<ContactEmailAddress> ContactEmailAddresses { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("experimentVariants")]
        public List<string> ExperimentVariants { get; set; }

        [JsonProperty("lastLogin")]
        public DateTimeOffset LastLogin { get; set; }

        [JsonProperty("linkedAccounts")]
        public List<LinkedAccount> LinkedAccounts { get; set; }

        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }

        [JsonProperty("memberships")]
        public List<Membership> Memberships { get; set; }

        [JsonProperty("origination")]
        public long Origination { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        [JsonProperty("pushNotificationRegistrations")]
        public List<PushNotificationRegistration> PushNotificationRegistrations { get; set; }

        [JsonProperty("statistics")]
        public List<Statistic> Statistics { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("titleId")]
        public string TitleId { get; set; }

        [JsonProperty("totalValueToDateInUSD")]
        public long TotalValueToDateInUsd { get; set; }

        [JsonProperty("valuesToDate")]
        public List<ValuesToDate> ValuesToDate { get; set; }
    }

    public partial class AdCampaignAttribution
    {
        [JsonProperty("attributedAt")]
        public DateTimeOffset AttributedAt { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }
    }

    public partial class ContactEmailAddress
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("verificationStatus")]
        public long VerificationStatus { get; set; }
    }

    public partial class LinkedAccount
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("platform")]
        public long Platform { get; set; }

        [JsonProperty("platformUserId")]
        public string PlatformUserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("continentCode")]
        public long ContinentCode { get; set; }

        [JsonProperty("countryCode")]
        public long CountryCode { get; set; }

        [JsonProperty("latitude")]
        public long Latitude { get; set; }

        [JsonProperty("longitude")]
        public long Longitude { get; set; }
    }

    public partial class Membership
    {
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("membershipExpiration")]
        public DateTimeOffset MembershipExpiration { get; set; }

        [JsonProperty("membershipId")]
        public string MembershipId { get; set; }

        [JsonProperty("overrideExpiration")]
        public DateTimeOffset OverrideExpiration { get; set; }

        [JsonProperty("subscriptions")]
        public List<Subscription> Subscriptions { get; set; }
    }

    public partial class Subscription
    {
        [JsonProperty("expiration")]
        public DateTimeOffset Expiration { get; set; }

        [JsonProperty("initialSubscriptionTime")]
        public DateTimeOffset InitialSubscriptionTime { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("subscriptionItemId")]
        public string SubscriptionItemId { get; set; }

        [JsonProperty("subscriptionProvider")]
        public string SubscriptionProvider { get; set; }
    }

    public partial class PushNotificationRegistration
    {
        [JsonProperty("notificationEndpointARN")]
        public string NotificationEndpointArn { get; set; }

        [JsonProperty("platform")]
        public long Platform { get; set; }
    }

    public partial class Statistic
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("tagValue")]
        public string TagValue { get; set; }
    }

    public partial class ValuesToDate
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalValue")]
        public long TotalValue { get; set; }

        [JsonProperty("totalValueAsDecimal")]
        public string TotalValueAsDecimal { get; set; }
    }

    public partial class PlayerStatistic
    {
        [JsonProperty("statisticName")]
        public string StatisticName { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }

    public partial class UserData
    {
        [JsonProperty("additionalProp1")]
        public UserDataAdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public UserDataAdditionalProp1 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public UserDataAdditionalProp1 AdditionalProp3 { get; set; }
    }

    public partial class UserDataAdditionalProp1
    {
        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("permission")]
        public long Permission { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class UserVirtualCurrency
    {
        [JsonProperty("additionalProp1")]
        public long AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public long AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public long AdditionalProp3 { get; set; }
    }

    public partial class UserVirtualCurrencyRechargeTimes
    {
        [JsonProperty("additionalProp1")]
        public UserVirtualCurrencyRechargeTimesAdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public UserVirtualCurrencyRechargeTimesAdditionalProp1 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public UserVirtualCurrencyRechargeTimesAdditionalProp1 AdditionalProp3 { get; set; }
    }

    public partial class UserVirtualCurrencyRechargeTimesAdditionalProp1
    {
        [JsonProperty("rechargeMax")]
        public long RechargeMax { get; set; }

        [JsonProperty("rechargeTime")]
        public DateTimeOffset RechargeTime { get; set; }

        [JsonProperty("secondsToRecharge")]
        public long SecondsToRecharge { get; set; }
    }

    public partial class Temperatures
    {
 //       public static Temperatures FromJson(string json) => JsonConvert.DeserializeObject<Player>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
     //   public static string ToJson(this Temperatures self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
