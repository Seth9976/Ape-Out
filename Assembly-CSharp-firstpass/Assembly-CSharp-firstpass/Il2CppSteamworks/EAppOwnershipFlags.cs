using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSteamworks
{
	// Token: 0x0200011A RID: 282
	[OriginalName("Assembly-CSharp-firstpass.dll", "Steamworks", "EAppOwnershipFlags")]
	[Flags]
	public enum EAppOwnershipFlags
	{
		// Token: 0x04000B97 RID: 2967
		k_EAppOwnershipFlags_None = 0,
		// Token: 0x04000B98 RID: 2968
		k_EAppOwnershipFlags_OwnsLicense = 1,
		// Token: 0x04000B99 RID: 2969
		k_EAppOwnershipFlags_FreeLicense = 2,
		// Token: 0x04000B9A RID: 2970
		k_EAppOwnershipFlags_RegionRestricted = 4,
		// Token: 0x04000B9B RID: 2971
		k_EAppOwnershipFlags_LowViolence = 8,
		// Token: 0x04000B9C RID: 2972
		k_EAppOwnershipFlags_InvalidPlatform = 16,
		// Token: 0x04000B9D RID: 2973
		k_EAppOwnershipFlags_SharedLicense = 32,
		// Token: 0x04000B9E RID: 2974
		k_EAppOwnershipFlags_FreeWeekend = 64,
		// Token: 0x04000B9F RID: 2975
		k_EAppOwnershipFlags_RetailLicense = 128,
		// Token: 0x04000BA0 RID: 2976
		k_EAppOwnershipFlags_LicenseLocked = 256,
		// Token: 0x04000BA1 RID: 2977
		k_EAppOwnershipFlags_LicensePending = 512,
		// Token: 0x04000BA2 RID: 2978
		k_EAppOwnershipFlags_LicenseExpired = 1024,
		// Token: 0x04000BA3 RID: 2979
		k_EAppOwnershipFlags_LicensePermanent = 2048,
		// Token: 0x04000BA4 RID: 2980
		k_EAppOwnershipFlags_LicenseRecurring = 4096,
		// Token: 0x04000BA5 RID: 2981
		k_EAppOwnershipFlags_LicenseCanceled = 8192,
		// Token: 0x04000BA6 RID: 2982
		k_EAppOwnershipFlags_AutoGrant = 16384,
		// Token: 0x04000BA7 RID: 2983
		k_EAppOwnershipFlags_PendingGift = 32768,
		// Token: 0x04000BA8 RID: 2984
		k_EAppOwnershipFlags_RentalNotActivated = 65536,
		// Token: 0x04000BA9 RID: 2985
		k_EAppOwnershipFlags_Rental = 131072,
		// Token: 0x04000BAA RID: 2986
		k_EAppOwnershipFlags_SiteLicense = 262144
	}
}
