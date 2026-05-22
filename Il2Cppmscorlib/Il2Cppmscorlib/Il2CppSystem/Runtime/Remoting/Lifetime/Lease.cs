using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B0 RID: 944
	public class Lease : MarshalByRefObject
	{
		// Token: 0x06003E31 RID: 15921 RVA: 0x00125EA4 File Offset: 0x001240A4
		// Note: this type is marked as 'beforefieldinit'.
		static Lease()
		{
			Il2CppClassPointerStore<Lease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "Lease");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lease>.NativeClassPtr);
			Lease.NativeFieldInfoPtr__leaseExpireTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_leaseExpireTime");
			Lease.NativeFieldInfoPtr__currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_currentState");
			Lease.NativeFieldInfoPtr__initialLeaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_initialLeaseTime");
			Lease.NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewOnCallTime");
			Lease.NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_sponsorshipTimeout");
			Lease.NativeFieldInfoPtr__sponsors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_sponsors");
			Lease.NativeFieldInfoPtr__renewingSponsors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewingSponsors");
			Lease.NativeFieldInfoPtr__renewalDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewalDelegate");
			Lease.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672509);
			Lease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672510);
			Lease.NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672511);
			Lease.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672512);
			Lease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672513);
			Lease.NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672514);
			Lease.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672515);
			Lease.NativeMethodInfoPtr_UpdateState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672516);
			Lease.NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672517);
			Lease.NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672518);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0012603C File Offset: 0x0012423C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221922, XrefRangeEnd = 221943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lease()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lease>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003E33 RID: 15923 RVA: 0x00126078 File Offset: 0x00124278
		public unsafe virtual TimeSpan CurrentLeaseTime
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 221947, RefRangeEnd = 221950, XrefRangeStart = 221943, XrefRangeEnd = 221947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x001260B4 File Offset: 0x001242B4
		public unsafe virtual LeaseState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x001260F0 File Offset: 0x001242F0
		[CallerCount(0)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x00126124 File Offset: 0x00124324
		public unsafe virtual TimeSpan RenewOnCallTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00126160 File Offset: 0x00124360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221950, XrefRangeEnd = 221956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renewalTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x001261AC File Offset: 0x001243AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221962, RefRangeEnd = 221963, XrefRangeStart = 221956, XrefRangeEnd = 221962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unregister(ISponsor obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x001261F0 File Offset: 0x001243F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221969, RefRangeEnd = 221970, XrefRangeStart = 221963, XrefRangeEnd = 221969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_UpdateState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00126224 File Offset: 0x00124424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221987, RefRangeEnd = 221988, XrefRangeStart = 221970, XrefRangeEnd = 221987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNextSponsor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00126258 File Offset: 0x00124458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221988, XrefRangeEnd = 222011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSponsorResponse(Object state, bool timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0001734B File Offset: 0x0001554B
		public Lease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06003E3D RID: 15933 RVA: 0x001262A8 File Offset: 0x001244A8
		// (set) Token: 0x06003E3E RID: 15934 RVA: 0x00017354 File Offset: 0x00015554
		public unsafe DateTime _leaseExpireTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__leaseExpireTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__leaseExpireTime)) = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x001262D0 File Offset: 0x001244D0
		// (set) Token: 0x06003E40 RID: 15936 RVA: 0x0001736F File Offset: 0x0001556F
		public unsafe LeaseState _currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__currentState)) = value;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06003E41 RID: 15937 RVA: 0x001262F8 File Offset: 0x001244F8
		// (set) Token: 0x06003E42 RID: 15938 RVA: 0x0001738A File Offset: 0x0001558A
		public unsafe TimeSpan _initialLeaseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__initialLeaseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__initialLeaseTime)) = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06003E43 RID: 15939 RVA: 0x00126320 File Offset: 0x00124520
		// (set) Token: 0x06003E44 RID: 15940 RVA: 0x000173A5 File Offset: 0x000155A5
		public unsafe TimeSpan _renewOnCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewOnCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewOnCallTime)) = value;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x00126348 File Offset: 0x00124548
		// (set) Token: 0x06003E46 RID: 15942 RVA: 0x000173C0 File Offset: 0x000155C0
		public unsafe TimeSpan _sponsorshipTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsorshipTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsorshipTimeout)) = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x00126370 File Offset: 0x00124570
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x000173DB File Offset: 0x000155DB
		public unsafe ArrayList _sponsors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x001263A0 File Offset: 0x001245A0
		// (set) Token: 0x06003E4A RID: 15946 RVA: 0x000173FA File Offset: 0x000155FA
		public unsafe Queue _renewingSponsors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewingSponsors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewingSponsors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x001263D0 File Offset: 0x001245D0
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00017419 File Offset: 0x00015619
		public unsafe Lease.RenewalDelegate _renewalDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewalDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lease.RenewalDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewalDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeFieldInfoPtr__leaseExpireTime;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeFieldInfoPtr__currentState;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeFieldInfoPtr__initialLeaseTime;

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeFieldInfoPtr__renewOnCallTime;

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeFieldInfoPtr__sponsors;

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeFieldInfoPtr__renewingSponsors;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeFieldInfoPtr__renewalDelegate;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0;

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Internal_Void_0;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0;

		// Token: 0x0200062F RID: 1583
		public sealed class RenewalDelegate : MulticastDelegate
		{
			// Token: 0x060055F9 RID: 22009 RVA: 0x001800DC File Offset: 0x0017E2DC
			// Note: this type is marked as 'beforefieldinit'.
			static RenewalDelegate()
			{
				Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lease>.NativeClassPtr, "RenewalDelegate");
				Lease.RenewalDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672519);
				Lease.RenewalDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672520);
				Lease.RenewalDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672521);
				Lease.RenewalDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672522);
			}

			// Token: 0x060055FA RID: 22010 RVA: 0x00180150 File Offset: 0x0017E350
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenewalDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055FB RID: 22011 RVA: 0x001801AC File Offset: 0x0017E3AC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 221917, RefRangeEnd = 221922, XrefRangeStart = 221917, XrefRangeEnd = 221917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan Invoke(ILease lease)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055FC RID: 22012 RVA: 0x001801FC File Offset: 0x0017E3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060055FD RID: 22013 RVA: 0x00180270 File Offset: 0x0017E470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055FE RID: 22014 RVA: 0x00020C01 File Offset: 0x0001EE01
			public RenewalDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060055FF RID: 22015 RVA: 0x00020C0A File Offset: 0x0001EE0A
			public static implicit operator Lease.RenewalDelegate(Func<ILease, TimeSpan> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lease.RenewalDelegate>(A_0);
			}

			// Token: 0x06005600 RID: 22016 RVA: 0x00020C12 File Offset: 0x0001EE12
			public static Lease.RenewalDelegate operator +(Lease.RenewalDelegate A_0, Lease.RenewalDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lease.RenewalDelegate>();
			}

			// Token: 0x06005601 RID: 22017 RVA: 0x00020C20 File Offset: 0x0001EE20
			public static Lease.RenewalDelegate operator -(Lease.RenewalDelegate A_0, Lease.RenewalDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Lease.RenewalDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004544 RID: 17732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004545 RID: 17733
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0;

			// Token: 0x04004546 RID: 17734
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0;

			// Token: 0x04004547 RID: 17735
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0;
		}
	}
}
