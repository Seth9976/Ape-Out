using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AA RID: 426
	public class ManifestResourceInfo : Object
	{
		// Token: 0x06001C16 RID: 7190 RVA: 0x000A2D8C File Offset: 0x000A0F8C
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestResourceInfo()
		{
			Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ManifestResourceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr);
			ManifestResourceInfo.NativeFieldInfoPtr__containingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "_containingAssembly");
			ManifestResourceInfo.NativeFieldInfoPtr__containingFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "_containingFileName");
			ManifestResourceInfo.NativeFieldInfoPtr__resourceLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "_resourceLocation");
			ManifestResourceInfo.NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100668050);
			ManifestResourceInfo.NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100668051);
			ManifestResourceInfo.NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100668052);
			ManifestResourceInfo.NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100668053);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000A2E48 File Offset: 0x000A1048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186110, RefRangeEnd = 186112, XrefRangeStart = 186110, XrefRangeEnd = 186110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containingAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containingFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resourceLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestResourceInfo.NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000A2EB4 File Offset: 0x000A10B4
		public unsafe virtual Assembly ReferencedAssembly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x000A2F00 File Offset: 0x000A1100
		public unsafe virtual string FileName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x000A2F44 File Offset: 0x000A1144
		public unsafe virtual ResourceLocation ResourceLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00009939 File Offset: 0x00007B39
		public ManifestResourceInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000A2F8C File Offset: 0x000A118C
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x00009942 File Offset: 0x00007B42
		public unsafe Assembly _containingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000A2FBC File Offset: 0x000A11BC
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x00009961 File Offset: 0x00007B61
		public unsafe string _containingFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000A2FE4 File Offset: 0x000A11E4
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x00009980 File Offset: 0x00007B80
		public unsafe ResourceLocation _resourceLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__resourceLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__resourceLocation)) = value;
			}
		}

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeFieldInfoPtr__containingAssembly;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeFieldInfoPtr__containingFileName;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeFieldInfoPtr__resourceLocation;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0;
	}
}
