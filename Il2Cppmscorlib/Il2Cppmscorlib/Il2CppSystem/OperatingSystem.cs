using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200012C RID: 300
	[Serializable]
	public sealed class OperatingSystem : Object
	{
		// Token: 0x060015CC RID: 5580 RVA: 0x00087824 File Offset: 0x00085A24
		// Note: this type is marked as 'beforefieldinit'.
		static OperatingSystem()
		{
			Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OperatingSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr);
			OperatingSystem.NativeFieldInfoPtr__platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_platform");
			OperatingSystem.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_version");
			OperatingSystem.NativeFieldInfoPtr__servicePack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_servicePack");
			OperatingSystem.NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667060);
			OperatingSystem.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667061);
			OperatingSystem.NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667062);
			OperatingSystem.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667063);
			OperatingSystem.NativeMethodInfoPtr_get_ServicePack_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667064);
			OperatingSystem.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667065);
			OperatingSystem.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667066);
			OperatingSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100667067);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00087930 File Offset: 0x00085B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177221, RefRangeEnd = 177223, XrefRangeStart = 177202, XrefRangeEnd = 177221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatingSystem(PlatformID platform, Version version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0008798C File Offset: 0x00085B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177223, XrefRangeEnd = 177247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatingSystem(SerializationInfo information, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(information);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x000879F0 File Offset: 0x00085BF0
		public unsafe PlatformID Platform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00087A2C File Offset: 0x00085C2C
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00087A6C File Offset: 0x00085C6C
		public unsafe string ServicePack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_ServicePack_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00087AA4 File Offset: 0x00085CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177247, XrefRangeEnd = 177251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00087AE4 File Offset: 0x00085CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177251, XrefRangeEnd = 177282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00087B40 File Offset: 0x00085D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177282, XrefRangeEnd = 177314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000076C7 File Offset: 0x000058C7
		public OperatingSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00087B78 File Offset: 0x00085D78
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x000076D0 File Offset: 0x000058D0
		public unsafe PlatformID _platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__platform)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00087BA0 File Offset: 0x00085DA0
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x000076EB File Offset: 0x000058EB
		public unsafe Version _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x00087BD0 File Offset: 0x00085DD0
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x0000770A File Offset: 0x0000590A
		public unsafe string _servicePack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__servicePack);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__servicePack), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeFieldInfoPtr__platform;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr__servicePack;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePack_Public_get_String_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
