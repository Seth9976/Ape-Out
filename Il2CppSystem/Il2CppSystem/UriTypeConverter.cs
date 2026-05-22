using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem
{
	// Token: 0x02000046 RID: 70
	public class UriTypeConverter : TypeConverter
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x0002056C File Offset: 0x0001E76C
		// Note: this type is marked as 'beforefieldinit'.
		static UriTypeConverter()
		{
			Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriTypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr);
			UriTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr, 100663988);
			UriTypeConverter.NativeMethodInfoPtr_CanConvert_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr, 100663989);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000205C4 File Offset: 0x0001E7C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriTypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriTypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00020600 File Offset: 0x0001E800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369277, XrefRangeEnd = 369288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConvert(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriTypeConverter.NativeMethodInfoPtr_CanConvert_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000035F6 File Offset: 0x000017F6
		public UriTypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Private_Boolean_Type_0;
	}
}
