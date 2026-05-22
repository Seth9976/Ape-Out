using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000471 RID: 1137
	[Serializable]
	public class CaseInsensitiveHashCodeProvider : Object
	{
		// Token: 0x0600450F RID: 17679 RVA: 0x0013DC0C File Offset: 0x0013BE0C
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveHashCodeProvider()
		{
			Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CaseInsensitiveHashCodeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr);
			CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, "m_text");
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673371);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673372);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673373);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673374);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x0013DCA0 File Offset: 0x0013BEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228500, XrefRangeEnd = 228505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveHashCodeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x0013DCDC File Offset: 0x0013BEDC
		[CallerCount(0)]
		public unsafe CaseInsensitiveHashCodeProvider(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x0013DD28 File Offset: 0x0013BF28
		public unsafe static CaseInsensitiveHashCodeProvider Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228505, XrefRangeEnd = 228513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x0013DD5C File Offset: 0x0013BF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228513, XrefRangeEnd = 228537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x0001A53D File Offset: 0x0001873D
		public CaseInsensitiveHashCodeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x0013DDAC File Offset: 0x0013BFAC
		// (set) Token: 0x06004516 RID: 17686 RVA: 0x0001A546 File Offset: 0x00018746
		public unsafe TextInfo m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr_m_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;
	}
}
