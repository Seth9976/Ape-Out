using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B4 RID: 948
	public sealed class LifetimeServices : Object
	{
		// Token: 0x06003E61 RID: 15969 RVA: 0x001268A4 File Offset: 0x00124AA4
		// Note: this type is marked as 'beforefieldinit'.
		static LifetimeServices()
		{
			Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LifetimeServices");
			LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManagerPollTime");
			LifetimeServices.NativeFieldInfoPtr__leaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseTime");
			LifetimeServices.NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_renewOnCallTime");
			LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_sponsorshipTimeout");
			LifetimeServices.NativeFieldInfoPtr__leaseManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManager");
			LifetimeServices.NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672534);
			LifetimeServices.NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672535);
			LifetimeServices.NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672536);
			LifetimeServices.NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672537);
			LifetimeServices.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672538);
			LifetimeServices.NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672539);
			LifetimeServices.NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672540);
			LifetimeServices.NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672541);
			LifetimeServices.NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672542);
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x001269E4 File Offset: 0x00124BE4
		// (set) Token: 0x06003E63 RID: 15971 RVA: 0x00126A14 File Offset: 0x00124C14
		public unsafe static TimeSpan LeaseManagerPollTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222085, XrefRangeEnd = 222089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222096, RefRangeEnd = 222097, XrefRangeStart = 222089, XrefRangeEnd = 222096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x00126A48 File Offset: 0x00124C48
		// (set) Token: 0x06003E65 RID: 15973 RVA: 0x00126A78 File Offset: 0x00124C78
		public unsafe static TimeSpan LeaseTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222097, XrefRangeEnd = 222101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222101, XrefRangeEnd = 222105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x00126AAC File Offset: 0x00124CAC
		// (set) Token: 0x06003E67 RID: 15975 RVA: 0x00126ADC File Offset: 0x00124CDC
		public unsafe static TimeSpan RenewOnCallTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222105, XrefRangeEnd = 222109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222109, XrefRangeEnd = 222113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06003E68 RID: 15976 RVA: 0x00126B10 File Offset: 0x00124D10
		// (set) Token: 0x06003E69 RID: 15977 RVA: 0x00126B40 File Offset: 0x00124D40
		public unsafe static TimeSpan SponsorshipTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222113, XrefRangeEnd = 222117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222117, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x00126B74 File Offset: 0x00124D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222121, XrefRangeEnd = 222127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackLifetime(ServerIdentity identity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x000174A7 File Offset: 0x000156A7
		public LifetimeServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x00126BAC File Offset: 0x00124DAC
		// (set) Token: 0x06003E6D RID: 15981 RVA: 0x000174B0 File Offset: 0x000156B0
		public unsafe static TimeSpan _leaseManagerPollTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&value));
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003E6E RID: 15982 RVA: 0x00126BC8 File Offset: 0x00124DC8
		// (set) Token: 0x06003E6F RID: 15983 RVA: 0x000174BE File Offset: 0x000156BE
		public unsafe static TimeSpan _leaseTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseTime, (void*)(&value));
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x00126BE4 File Offset: 0x00124DE4
		// (set) Token: 0x06003E71 RID: 15985 RVA: 0x000174CC File Offset: 0x000156CC
		public unsafe static TimeSpan _renewOnCallTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__renewOnCallTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__renewOnCallTime, (void*)(&value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x00126C00 File Offset: 0x00124E00
		// (set) Token: 0x06003E73 RID: 15987 RVA: 0x000174DA File Offset: 0x000156DA
		public unsafe static TimeSpan _sponsorshipTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x00126C1C File Offset: 0x00124E1C
		// (set) Token: 0x06003E75 RID: 15989 RVA: 0x000174E8 File Offset: 0x000156E8
		public unsafe static LeaseManager _leaseManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaseManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeFieldInfoPtr__leaseManagerPollTime;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeFieldInfoPtr__leaseTime;

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeFieldInfoPtr__renewOnCallTime;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeFieldInfoPtr__leaseManager;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0;

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0;

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0;
	}
}
