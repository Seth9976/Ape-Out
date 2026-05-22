using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F6 RID: 758
	public class RC2 : SymmetricAlgorithm
	{
		// Token: 0x06003271 RID: 12913 RVA: 0x000FC3F4 File Offset: 0x000FA5F4
		// Note: this type is marked as 'beforefieldinit'.
		static RC2()
		{
			Il2CppClassPointerStore<RC2>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2>.NativeClassPtr);
			RC2.NativeFieldInfoPtr_EffectiveKeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "EffectiveKeySizeValue");
			RC2.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "s_legalBlockSizes");
			RC2.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "s_legalKeySizes");
			RC2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671254);
			RC2.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671255);
			RC2.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671256);
			RC2.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671257);
			RC2.NativeMethodInfoPtr_Create_Public_Static_RC2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671258);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000FC4C4 File Offset: 0x000FA6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210372, XrefRangeEnd = 210377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x000FC500 File Offset: 0x000FA700
		public unsafe virtual int EffectiveKeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x000FC548 File Offset: 0x000FA748
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x000FC590 File Offset: 0x000FA790
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210377, XrefRangeEnd = 210385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000FC5DC File Offset: 0x000FA7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210385, XrefRangeEnd = 210389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RC2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2.NativeMethodInfoPtr_Create_Public_Static_RC2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RC2>(intPtr3) : null;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00011A96 File Offset: 0x0000FC96
		public RC2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000FC610 File Offset: 0x000FA810
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x00011A9F File Offset: 0x0000FC9F
		public unsafe int EffectiveKeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2.NativeFieldInfoPtr_EffectiveKeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2.NativeFieldInfoPtr_EffectiveKeySizeValue)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000FC638 File Offset: 0x000FA838
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x00011ABA File Offset: 0x0000FCBA
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x000FC660 File Offset: 0x000FA860
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeFieldInfoPtr_EffectiveKeySizeValue;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RC2_0;
	}
}
