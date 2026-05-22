using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000022 RID: 34
	public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060001CB RID: 459 RVA: 0x0001A2BC File Offset: 0x000184BC
		// Note: this type is marked as 'beforefieldinit'.
		static CharEntityEncoderFallbackBuffer()
		{
			Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CharEntityEncoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr);
			CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, "parent");
			CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, "charEntity");
			CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, "charEntityIndex");
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Internal_Void_CharEntityEncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663488);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663489);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663490);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663491);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663492);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663493);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663494);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_SurrogateCharToUtf32_Private_Int32_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663495);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001A3C8 File Offset: 0x000185C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389723, XrefRangeEnd = 389725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Internal_Void_CharEntityEncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001A414 File Offset: 0x00018614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389725, XrefRangeEnd = 389734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001A478 File Offset: 0x00018678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389734, XrefRangeEnd = 389747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001A4E8 File Offset: 0x000186E8
		[CallerCount(0)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001A530 File Offset: 0x00018730
		[CallerCount(0)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001A578 File Offset: 0x00018778
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001A5C0 File Offset: 0x000187C0
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001A5FC File Offset: 0x000187FC
		[CallerCount(0)]
		public unsafe int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_SurrogateCharToUtf32_Private_Int32_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public CharEntityEncoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001A654 File Offset: 0x00018854
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public unsafe CharEntityEncoderFallback parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharEntityEncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001A684 File Offset: 0x00018884
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D18 File Offset: 0x00000F18
		public unsafe string charEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntity);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntity), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0001A6AC File Offset: 0x000188AC
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002D37 File Offset: 0x00000F37
		public unsafe int charEntityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntityIndex)) = value;
			}
		}

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_charEntity;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_charEntityIndex;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CharEntityEncoderFallback_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_SurrogateCharToUtf32_Private_Int32_Char_Char_0;
	}
}
