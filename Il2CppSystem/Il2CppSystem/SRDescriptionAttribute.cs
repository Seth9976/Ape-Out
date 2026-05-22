using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem
{
	// Token: 0x02000045 RID: 69
	public class SRDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x00020448 File Offset: 0x0001E648
		// Note: this type is marked as 'beforefieldinit'.
		static SRDescriptionAttribute()
		{
			Il2CppClassPointerStore<SRDescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "SRDescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRDescriptionAttribute>.NativeClassPtr);
			SRDescriptionAttribute.NativeFieldInfoPtr_isReplaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRDescriptionAttribute>.NativeClassPtr, "isReplaced");
			SRDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRDescriptionAttribute>.NativeClassPtr, 100663986);
			SRDescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRDescriptionAttribute>.NativeClassPtr, 100663987);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000204B4 File Offset: 0x0001E6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369274, XrefRangeEnd = 369277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SRDescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SRDescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00020500 File Offset: 0x0001E700
		public unsafe override string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SRDescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000035D2 File Offset: 0x000017D2
		public SRDescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00020544 File Offset: 0x0001E744
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000035DB File Offset: 0x000017DB
		public unsafe bool isReplaced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRDescriptionAttribute.NativeFieldInfoPtr_isReplaced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRDescriptionAttribute.NativeFieldInfoPtr_isReplaced)) = value;
			}
		}

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_isReplaced;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0;
	}
}
