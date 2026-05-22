using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B1 RID: 945
	public class LeaseManager : Object
	{
		// Token: 0x06003E4D RID: 15949 RVA: 0x00126400 File Offset: 0x00124600
		// Note: this type is marked as 'beforefieldinit'.
		static LeaseManager()
		{
			Il2CppClassPointerStore<LeaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr);
			LeaseManager.NativeFieldInfoPtr__objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, "_objects");
			LeaseManager.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, "_timer");
			LeaseManager.NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672523);
			LeaseManager.NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672524);
			LeaseManager.NativeMethodInfoPtr_StartManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672525);
			LeaseManager.NativeMethodInfoPtr_StopManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672526);
			LeaseManager.NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672527);
			LeaseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672528);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x001264D0 File Offset: 0x001246D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222018, RefRangeEnd = 222019, XrefRangeStart = 222011, XrefRangeEnd = 222018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPollTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00126510 File Offset: 0x00124710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222023, RefRangeEnd = 222025, XrefRangeStart = 222019, XrefRangeEnd = 222023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackLifetime(ServerIdentity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00126554 File Offset: 0x00124754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222041, RefRangeEnd = 222042, XrefRangeStart = 222025, XrefRangeEnd = 222041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_StartManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00126588 File Offset: 0x00124788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222042, XrefRangeEnd = 222043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_StopManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x001265BC File Offset: 0x001247BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222043, XrefRangeEnd = 222052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManageLeases(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00126600 File Offset: 0x00124800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222052, XrefRangeEnd = 222056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaseManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00017438 File Offset: 0x00015638
		public LeaseManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003E55 RID: 15957 RVA: 0x0012663C File Offset: 0x0012483C
		// (set) Token: 0x06003E56 RID: 15958 RVA: 0x00017441 File Offset: 0x00015641
		public unsafe ArrayList _objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x0012666C File Offset: 0x0012486C
		// (set) Token: 0x06003E58 RID: 15960 RVA: 0x00017460 File Offset: 0x00015660
		public unsafe Timer _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeFieldInfoPtr__objects;

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0;

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeMethodInfoPtr_StartManager_Public_Void_0;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeMethodInfoPtr_StopManager_Public_Void_0;

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
